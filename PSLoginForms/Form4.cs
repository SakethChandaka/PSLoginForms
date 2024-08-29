using System;
using System.Diagnostics;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using PSLoginForms.AuthService;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PSLoginForms
{
    public partial class Form4 : MaterialForm
    {
        public Form4()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.DeepOrange900, Primary.Red100, Accent.Orange400, TextShade.WHITE);
        }
        MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        private async void LoginOA_Click(object sender, EventArgs e)
        {
            // Retrieve the username and password from the form
            string username = OAuthUsername.Text;
            string password = OAuthPassword.Text;

            try
            {
                AuthenticationServerClient client = new AuthenticationServerClient();

                // Call the GetAccessToken method on the service
                var response = await client.GetAccessTokenAsync(username, password);

                // Check if the access token was successfully generated
                if (!string.IsNullOrEmpty(response.AccessToken))
                {
                    // Use the access token as needed
                    string accessToken = response.AccessToken;
                    this.Hide(); // Hides the current form
                    MessageBox.Show("Login successful!");
                    Form3 form3 = new Form3(username);
                    form3.ShowDialog();

                }
                else
                {
                    // Display the message returned from the service
                    MessageBox.Show("Error: " + response.Message);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine(ex.Message);
                // Example of logging a message
                Debug.WriteLine(ex.Message);
                Trace.WriteLine(ex.Message);
            }
        }
    }
}
