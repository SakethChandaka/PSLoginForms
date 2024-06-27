using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using MaterialSkin;
using MaterialSkin.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PSLoginForms
{
    public partial class Form1 : MaterialForm
    {
        private string connectionString = "Server=localhost\\MSSQLSERVER01;Database=newdb;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.DeepOrange900, Primary.Red100, Accent.Orange400, TextShade.WHITE);

        }
        MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        private async void loginButton_Click(object sender, EventArgs e)
        {
            string username = userName.Text;
            string password = passWord.Text;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password cannot be blank.");
                return; // Return early if validation fails
            }
            else
            {
                await UserLogin(username, password);
            }
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
                                string insertQuery = "INSERT INTO dbo.usertime (username, time) VALUES (@Username, @LoginTime)";
                                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                                {
                                    insertCommand.Parameters.AddWithValue("@Username", username);
                                    insertCommand.Parameters.AddWithValue("@LoginTime", DateTime.Now);
                                    await insertCommand.ExecuteNonQueryAsync();
                                }

                                MessageBox.Show("Login successful!");
                                Form3 form3 = new Form3(username);
                                form3.ShowDialog();
                                
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
        private void signupButton_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialCheckbox1.Checked)
            {
                passWord.PasswordChar = '\0'; // '\0' means display characters as they are (not masked)
            }
            else
            {
                passWord.PasswordChar = '*'; // '*' masks the characters
            }

        }
    }
    
}
