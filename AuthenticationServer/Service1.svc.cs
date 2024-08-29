using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using System.Data;
using AuthenticationServer;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Tokens;

namespace AuthenticationWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class AuthenticationService : IAuthenticationServer
    {
        private string connectionString = "Server=localhost\\MSSQLSERVER01;Database=newdb;Trusted_Connection=True;";

        public async Task<AccessTokenResponse> GetAccessToken(string username, string password)
        {
            var (accessToken, message) = await IsValidUser(username, password);

            return new AccessTokenResponse
            {
                AccessToken = accessToken,
                Message = message
            };
        }

        private async Task<(string accessToken,string message)> IsValidUser(string username, string password)
        {
            string query = "SELECT password FROM dbo.userinfo WHERE username = @Username";
            string accessToken = null;
            string message = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@Username", SqlDbType.VarChar).Value = username;

                        // Retrieve hashed password from the database
                        object result = await command.ExecuteScalarAsync();
                        if (result != null)
                        {
                            string hashedPasswordFromDB = result.ToString();

                            // Verify the entered password with the hashed password from the database
                            bool passwordMatch = BCrypt.Net.BCrypt.Verify(password, hashedPasswordFromDB);

                            if (passwordMatch)
                            {

                                // Update the latest entry of this user to mark it as expired
                                string updateQuery = "UPDATE dbo.useraccess SET expired = 1 WHERE username = @Username AND expired = 0";
                                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                                {
                                    updateCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = username;
                                    await updateCommand.ExecuteNonQueryAsync();
                                }
                                // Generate the access token
                                DateTime loginTime = DateTime.Now;
                                accessToken = GenerateAccessToken(username, loginTime);

                                // Insert the new access token with expired = 0
                                string insertQuery = "INSERT INTO dbo.useraccess (username, access_token, last_login_time, expired) VALUES (@Username, @AccessToken, @LoginTime, 0)";
                                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                                {
                                    insertCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = username;
                                    insertCommand.Parameters.Add("@AccessToken", SqlDbType.VarChar).Value = accessToken;
                                    insertCommand.Parameters.Add("@LoginTime", SqlDbType.DateTime).Value = loginTime;
                                    await insertCommand.ExecuteNonQueryAsync();
                                }
                            }

                            else
                            {
                                message = "Invalid password.";
                            }
                        }
                        else
                        {
                            message = "Login failed. Username not found.";
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                message = $"Database error: {ex.Message}";
            }
            catch (Exception ex)
            {
                message = $"Error: {ex.Message}";
            }

            return (accessToken, message); // Return the access token or null if login failed
        }

        private string GenerateAccessToken(string username, DateTime loginTime)
        {
            // Define the key for signing the token
            var securityKey = new SymmetricSecurityKey(Convert.FromBase64String("UFNMT0dJTkZPUk1TU0VDVVJJVFlURUFNxO2d8HyBhiI="));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            // Define the token claims
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, username), // Subject
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()), // Unique identifier
                new Claim(JwtRegisteredClaimNames.Iat, ToUnixEpochDate(loginTime).ToString()) // Issued at
            };

            // Set the token expiration to 30 minutes from the login time
            var expires = loginTime.AddMinutes(30);

            // Create the token
            var token = new JwtSecurityToken(
                issuer: "PSCONNECT", // Issuer of the token
                audience: "api://PS-Auth", // Audience of the token
                claims: claims,
                expires: expires, // Use the expiration time calculated from login time
                signingCredentials: credentials);

            // Return the token as a string
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        // Helper method to convert DateTime to Unix epoch time
        private long ToUnixEpochDate(DateTime date)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return (long)(date - epoch).TotalSeconds;
        }
    }
}
