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

namespace PSLoginForms
{
    public partial class Form1 : Form
    {
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
            string connectionString = "Server=TEST_123\\MSSQLSERVER01;Database=newdb;Integrated Security=True;";

            string query = "SELECT COUNT(1) FROM dbo.userinfo WHERE username = @Username AND password = @Password";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int userCount = (int)await command.ExecuteScalarAsync();

                        if (userCount > 0)
                        {
                            MessageBox.Show("Login successful!");
                        }
                        else
                        {
                            MessageBox.Show("Login failed. Please check your username and password.");
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
    }
}
