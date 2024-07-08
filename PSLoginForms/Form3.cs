using MaterialSkin;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace PSLoginForms
{
    public partial class Form3 : MaterialForm
    {
        private string _username;

        public Form3(string username)
        {
            _username = username;
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.DeepOrange900, Primary.Red100, Accent.Orange400, TextShade.WHITE);
        }

        private void userClick_Click(object sender, EventArgs e)
        {
            DisplayLoginTime();
        }

        private void DisplayLoginTime()
        {
            string connectionString = "Server=localhost\\MSSQLSERVER01;Database=newdb;Trusted_Connection=True;";
            string query = "SELECT time FROM dbo.usertime WHERE username = @Username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", _username);
                command.Parameters.AddWithValue("@Username", _username);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string loginTime = reader.GetString(0); // Assuming 'time' is stored as DateTime
                        usertimeDisplay.Text = $"Last Login Time: {loginTime.ToString()}";
                    }
                    else
                    {
                        usertimeDisplay.Text = "No login time found for this user.";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error retrieving login time: {ex.Message}");
                }
            }
        }
    }
}
