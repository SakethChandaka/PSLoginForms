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
                                // Insert login record into user_login_history table
                                string insertQuery = "INSERT INTO user_login_history (username, login_time) VALUES (@Username, @LoginTime)";
                                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                                {
                                    insertCommand.Parameters.AddWithValue("@Username", username);
                                    insertCommand.Parameters.AddWithValue("@LoginTime", DateTime.Now);
                                    await insertCommand.ExecuteNonQueryAsync();
                                }

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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passWord.PasswordChar = '\0'; // '\0' means display characters as they are (not masked)
            }
            else
            {
                passWord.PasswordChar = '♡'; // '*' masks the characters
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
