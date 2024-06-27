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

namespace PSLoginForms
{
    public partial class Form2 : MaterialForm
    {
        public Form2()
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
            string connectionString = "Server=localhost\\MSSQLSERVER01;Database=newdb;Trusted_Connection=True;";

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password); // Hash the password

            string query = "INSERT INTO dbo.userinfo (username, password) VALUES (@Username, @hashedPassword)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@hashedPassword", hashedPassword);

                        int result = await command.ExecuteNonQueryAsync();

                        if (result > 0)
                        {
                            MessageBox.Show("Sign-up successful!");
                            this.Close(); // Close the sign-up form
                        }
                        else
                        {
                            MessageBox.Show("Sign-up failed. Please try again.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Handle specific SQL exceptions (optional)
                MessageBox.Show($"Database error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle other general exceptions
                MessageBox.Show($"Error: {ex.Message}");
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
