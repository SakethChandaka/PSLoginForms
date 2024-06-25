using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PSLoginForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = Susername.Text;
            string password = Spassword.Text;   
            UserSignup(username, password);
        }




        private async Task UserSignup(string username, string password)
        {

            string connectionString = "Server=TEST_123\\MSSQLSERVER01;Database=newdb;Integrated Security=True;";

            string query = "INSERT INTO dbo.userinfo (username, password) VALUES (@Username, @Password)";

            try
            {
                // Create a new SqlConnection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection asynchronously
                    await connection.OpenAsync();

                    // Create a new SqlCommand
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the SQL query to prevent SQL injection
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        // Execute the query asynchronously
                        int result = await command.ExecuteNonQueryAsync();

                        // Check if the insert operation was successful
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
                // Handle SQL-specific exceptions
                MessageBox.Show($"Database error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle other types of exceptions
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
