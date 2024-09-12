using System;
using System.ServiceModel;
using MongoDB.Bson;
using MongoDB.Driver;
using BCrypt.Net;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace AuthenticationClientService
{
    public class Service1 : IService1
    {
        private readonly IMongoCollection<BsonDocument> userCollection;
        private readonly IMongoCollection<BsonDocument> accessCollection;

        public Service1()
        {
            var client = new MongoClient("mongodb+srv://chssfw:pslogin@cluster0.mmzyp.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0");
            var database = client.GetDatabase("AuthenticationData");
            userCollection = database.GetCollection<BsonDocument>("usercreds");
            accessCollection = database.GetCollection<BsonDocument>("useraccess");
        }

        public string AuthenticateUser(string username, string password)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("username", username);
            var user = userCollection.Find(filter).FirstOrDefault();

            if (user == null || !BCrypt.Net.BCrypt.Verify(password, user["password"].ToString()))
            {
                return "Invalid credentials";
            }

            var token = GenerateAccessToken(username);
            UpdateUserAccess(username);
            return $"Login successful. Access Token: {token}";
        }

        private string GenerateAccessToken(string username)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("hEI8oCnBdjUrnP3UX8B5DCAUkmdLeZNIH/aHdNRoyaU=");

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, username)
                }),
                Expires = DateTime.UtcNow.AddMinutes(30),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        private void UpdateUserAccess(string username)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("username", username);
            var update = Builders<BsonDocument>.Update.Set("expired", 1);
            accessCollection.UpdateMany(filter, update);

            var newAccess = new BsonDocument
            {
                { "username", username },
                { "lastLoginTime", DateTime.UtcNow },
                { "expired", 0 }
            };
            accessCollection.InsertOne(newAccess);
        }
    }
}
