using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.IdentityModel.Tokens.Jwt;
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

        // Secret key for JWT signing (store securely in production)
        private readonly string _jwtSecretKey = "37pIqqN0IZDzp8WrWS4ctJKm0+2NQAs/MEcWNwjD9/PenpxjqJiY9kzoWwj+C0OMs8IA2wdpoORWOJFUXgshyw=="; // replace with your secret key

        public class AuthenticationResponse
        {
            public string Token { get; set; }
            public string Message { get; set; }
        }


        public Service()
        {
            // Initialize MongoDB connection
            _client = new MongoClient("mongodb+srv://chssfw2921:pslogin@testpsloginforms.hrn5g.mongodb.net/?retryWrites=true&w=majority&appName=TestPSLoginForms"); // replace with your connection string
            _database = _client.GetDatabase("AuthenticationData"); // replace with your database name
            _userCredsCollection = _database.GetCollection<BsonDocument>("usercreds");
            _userAccessCollection = _database.GetCollection<BsonDocument>("useraccess"); // New collection for storing access tokens
        }

        public AuthenticationResponse AuthenticateUser(string username, string password)
        {
            // Step 1: Retrieve user data from MongoDB
            var filter = Builders<BsonDocument>.Filter.Eq("username", username);
            var userDocument = _userCredsCollection.Find(filter).FirstOrDefault();

            if (userDocument != null)
            {
                string storedHashedPassword = userDocument["password"].AsString;

                // Step 2: Verify the provided password with the stored hashed password
                if (BCrypt.Net.BCrypt.Verify(password, storedHashedPassword))
                {
                    // Step 3: Generate a JWT token
                    string jwtToken = GenerateJwtToken(username);

                    // Step 4: Store the JWT token and expiry status in the useraccess collection
                    var tokenDocument = new BsonDocument
                    {
                        { "username", username },
                        { "accessToken", jwtToken },
                        { "expiryStatus", 1 }, // 1 means not expired
                        { "loginTime", DateTime.UtcNow }
                    };

                    _userAccessCollection.InsertOne(tokenDocument); // Insert token into useraccess collection

                    return new AuthenticationResponse
                    {
                        Token = jwtToken,
                        Message = "Authentication successful."
                    };
                }
                else
                {
                    return new AuthenticationResponse
                    {
                        Token = null,
                        Message = "Invalid username or password."
                    };
                }
            }
            else
            {
                return new AuthenticationResponse
                {
                    Token = null,
                    Message = "Invalid username or password."
                };
            }
        }

        private string GenerateJwtToken(string username)
        {
            // Step 3a: Define the token's claims (this can include custom claims like roles)
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, username),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim("loginTime", DateTime.UtcNow.ToString())
            };

            // Step 3b: Generate a symmetric security key
            var key = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSecretKey));
            var creds = new Microsoft.IdentityModel.Tokens.SigningCredentials(key, Microsoft.IdentityModel.Tokens.SecurityAlgorithms.HmacSha256);

            // Step 3c: Create the JWT token
            var token = new JwtSecurityToken(
                issuer: "yourappname", // replace with your issuer name
                audience: "yourappname", // replace with your audience name
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1), // token expiry time
                signingCredentials: creds);

            // Step 3d: Return the JWT token as a string
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
