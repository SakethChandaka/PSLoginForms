using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace PSLoginForms
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=newdb;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            string username = userName.Text;
            string password = passWord.Text;
            UserLogin(username, password);
        }

        private async Task UserLogin(string username, string password)
        {
            string query = "SELECT password FROM dbo.userinfo WHERE username = @Username";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        // Retrieve hashed password from the database
                        object result = await command.ExecuteScalarAsync();
                        if (result != null)
                        {
                            string hashedPasswordFromDB = result.ToString();

                            // Verify the entered password with the hashed password from the database
                            bool passwordMatch = BCrypt.Net.BCrypt.Verify(password, hashedPasswordFromDB);

                            if (passwordMatch)
                            {
                                MessageBox.Show("Login successful!");
                                // Proceed with your logic after successful login
                            }
                            else
                            {
                                MessageBox.Show("Login failed. Incorrect password.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Login failed. Username not found.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            // Open signup form (Form2) for user registration
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
