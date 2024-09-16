using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using MaterialSkin;
using MaterialSkin.Controls;
using MongoDB.Bson;
using MongoDB.Driver;

namespace PSLoginForms
{
    public partial class SignupPage : MaterialForm
    {
        public SignupPage()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.DeepOrange900, Primary.Red100, Accent.Orange400, TextShade.WHITE);

        }


        private async void signUp_Click(object sender, EventArgs e)
        {
            string username = Susername.Text;
            string password = Spassword.Text;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password cannot be blank.");
                return; // Return early if validation fails
            }
            else
            {
                await UserSignup(username, password);
            }
        }


        private async Task UserSignup(string username, string password)
        {
            await CreateUser(username, password);
        }


        private async Task CreateUser(string username, string password)
        {
            try
            {
                // MongoDB connection string
                string connectionString = "mongodb+srv://chssfw2921:pslogin@testpsloginforms.hrn5g.mongodb.net/?retryWrites=true&w=majority&appName=TestPSLoginForms";

                // Create a MongoClient object
                var client = new MongoClient(connectionString);

                // Get a reference to the database
                var database = client.GetDatabase("AuthenticationData");

                // Get a reference to the usercreds collection
                var collection = database.GetCollection<BsonDocument>("usercreds");

                // Check if the username already exists
                var filter = Builders<BsonDocument>.Filter.Eq("username", username);
                var existingUser = await collection.Find(filter).FirstOrDefaultAsync();

                if (existingUser != null)
                {
                    MessageBox.Show("Username already exists. Please login.", "User Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method early
                }

                // Hash the password using bcrypt
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                // Create a new user document
                var newUser = new BsonDocument
                {
                    { "username", username },
                    { "password", hashedPassword }
                };

                // Insert the new user document into the collection
                await collection.InsertOneAsync(newUser);
                MessageBox.Show("User created successfully! You can login now.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch (Exception ex)
            {
                // Handle or log the exception as needed
                Console.WriteLine($"Error creating user: {ex.Message}");
            }
        }
        
        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialCheckbox1.Checked)
            {
                Spassword.PasswordChar = '\0';
            }
            else
            {
                Spassword.PasswordChar = '*';
            }

        }
    }
}
