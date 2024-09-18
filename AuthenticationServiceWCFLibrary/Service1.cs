using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Mail;
using System.Net;
using System.Security.Claims;
using System.Text;

namespace AuthenticationServiceWCFLibrary
{
    public class Service : IService
    {
        // MongoDB connection settings
        private readonly IMongoClient _client;
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection<BsonDocument> _userCredsCollection;
        private readonly IMongoCollection<BsonDocument> _userAccessCollection;
        private readonly IMongoCollection<BsonDocument> _userOtpCollection;

        // Secret key for JWT signing (store securely in production)
        private readonly string _jwtSecretKey = "37pIqqN0IZDzp8WrWS4ctJKm0+2NQAs/MEcWNwjD9/PenpxjqJiY9kzoWwj+C0OMs8IA2wdpoORWOJFUXgshyw=="; // replace with your secret key

        public class AuthenticationResponse
        {
            public string Token { get; set; }
            public string Message { get; set; }
            public string StatusMessage { get; set; }
        }


        public Service()
        {
            // Initialize MongoDB connection
            _client = new MongoClient("mongodb+srv://chssfw2921:pslogin@testpsloginforms.hrn5g.mongodb.net/?retryWrites=true&w=majority&appName=TestPSLoginForms"); // replace with your connection string
            _database = _client.GetDatabase("AuthenticationData"); // replace with your database name
            _userCredsCollection = _database.GetCollection<BsonDocument>("usercreds");
            _userAccessCollection = _database.GetCollection<BsonDocument>("useraccess"); // New collection for storing access tokens
            _userOtpCollection = _database.GetCollection<BsonDocument>("userotp");
        }

        public AuthenticationResponse AuthenticateUser(string username, string password)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("username", username);
            var userDocument = _userCredsCollection.Find(filter).FirstOrDefault();

            if (userDocument != null)
            {
                string storedHashedPassword = userDocument["password"].AsString;

                if (BCrypt.Net.BCrypt.Verify(password, storedHashedPassword))
                {
                    // Generate OTP and store in userotp collection
                    string otp = GenerateOtp();
                    DateTime expiryTime = DateTime.UtcNow.AddMinutes(5); // Set OTP expiry to 5 minutes from now

                    var otpDocument = new BsonDocument
                    {
                        { "username", username },
                        { "otp", otp },
                        { "generatedTime", DateTime.UtcNow },
                        { "expiryTime", expiryTime }
                    };

                    _userOtpCollection.InsertOne(otpDocument);

                    // Send OTP to user's email (replace with actual email-sending logic)
                    SendOtpToEmail(username, otp);

                    return new AuthenticationResponse
                    {
                        Token = null,
                        Message = $"Additional Verification is needed, OTP sent to your email. OTP Expiry time: {expiryTime}",
                        StatusMessage = "OTP Required"
                    };
                }
                else
                {
                    return new AuthenticationResponse
                    {
                        Token = null,
                        Message = "Invalid username or password.",
                        StatusMessage = "Invalid Password"
                    };
                }
            }
            else
            {
                return new AuthenticationResponse
                {
                    Token = null,
                    Message = "Invalid username or password.",
                    StatusMessage = "Invalid Username"
                };
            }
        }

        public AuthenticationResponse AuthenticateUserOtp(string username, string otp)
        {
            // Step 1: Retrieve OTP data from MongoDB
            var filter = Builders<BsonDocument>.Filter.Eq("username", username);
            var otpDocument = _userOtpCollection.Find(filter).Sort(Builders<BsonDocument>.Sort.Descending("generatedTime")).FirstOrDefault();

            if (otpDocument != null)
            {
                DateTime expiryTime = otpDocument["expiryTime"].ToUniversalTime();

                // Step 2: Verify the provided OTP and check if it's within the expiry time
                if (otpDocument["otp"].AsString == otp && DateTime.UtcNow <= expiryTime)
                {
                    // OTP is valid, generate JWT token
                    string newJwtToken = GenerateJwtToken(username);

                    // Store the new token in useraccess collection
                    var newTokenDocument = new BsonDocument
                    {
                        { "username", username },
                        { "accessToken", newJwtToken },
                        { "expiryStatus", 0 }, // 0 means not expired
                        { "loginTime", DateTime.UtcNow }
                    };

                    _userAccessCollection.InsertOne(newTokenDocument);

                    return new AuthenticationResponse
                    {
                        Token = newJwtToken,
                        Message = "Authentication successful. New token generated.",
                        StatusMessage = "Login Success"
                    };
                }
                else
                {
                    return new AuthenticationResponse
                    {
                        Token = null,
                        Message = "Invalid or expired OTP.",
                        StatusMessage = "Regenrate OTP"
                    };
                }
            }
            else
            {
                return new AuthenticationResponse
                {
                    Token = null,
                    Message = "No OTP found for this user.",
                    StatusMessage = "OTP not generated successfully."
                };
            }
        }

        private string GenerateOtp()
        {
            // Generate a random 6-digit OTP
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        private void SendOtpToEmail(string username, string otp)
        {
            // Step 1: Set up SMTP client configuration
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("psloginformstestotp@gmail.com", "pslogin0001"), // Use app-specific password for Gmail
                EnableSsl = true
            };

            // Step 2: Create the email message
            var mailMessage = new MailMessage
            {
                From = new MailAddress("psloginformstestotp@gmail.com"), // Replace with your email
                Subject = "OTP for PS LoginForms Authentication",
                Body = $"Your OTP for login is: {otp}. It will expire in 5 minutes.",
                IsBodyHtml = false,
            };

            // Step 3: Add the recipient (username is the email address)
            mailMessage.To.Add(username);

            try
            {
                // Step 4: Send the email
                smtpClient.Send(mailMessage);
                Console.WriteLine($"OTP {otp} successfully sent to {username}");
            }
            catch (Exception ex)
            {
                // Handle any errors
                Console.WriteLine($"Failed to send OTP to {username}: {ex.Message}");
            }
        }

        private string GenerateJwtToken(string username)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, username),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim("loginTime", DateTime.UtcNow.ToString())
            };

            var key = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSecretKey));
            var creds = new Microsoft.IdentityModel.Tokens.SigningCredentials(key, Microsoft.IdentityModel.Tokens.SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "PSLOGINTEST",
                audience: "PSCLIENT",
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
