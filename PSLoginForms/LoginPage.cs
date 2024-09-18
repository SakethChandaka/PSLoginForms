using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using MaterialSkin;
using MaterialSkin.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.ServiceProcess;

namespace PSLoginForms
{
    public partial class LoginPage : MaterialForm
    {
        private string AuthenticationServiceName = "AuthenticationService";
        public LoginPage()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.DeepOrange900, Primary.Red100, Accent.Orange400, TextShade.WHITE);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            // Start the Authentication Service manually before running the Forms.
            //ManageServiceOnAppLaunch();

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
            try
            {
                // Create a client for the WCF service
                //var client = new AuthenticationService.IService();

                AuthenticationService.ServiceClient client = new AuthenticationService.ServiceClient();   

                // Call the AuthenticateUser method
                var result = client.AuthenticateUserByPassword(username, password);

                // Process the result
                if (result != null && !string.IsNullOrEmpty(result.Token))
                {
                    // Handle successful login
                    MessageBox.Show(result.Message, "Login Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Optionally, you can store the token or proceed with other logic
                    string token = result.Token;
                    // Example: Store the token for future API calls
                    // StoreToken(token);

                    this.Hide();
                    Dashboard DB = new Dashboard(username);
                    DB.Show();
                }
                else if (result != null && string.IsNullOrEmpty(result.Token) && result.StatusMessage == "OTP Required")
                {

                    OtpForm otpform = new OtpForm(username);
                    otpform.Show();

                }
                else
                {
                    // Handle failed login
                    MessageBox.Show(result?.Message ?? "Login failed.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void signupButton_Click_1(object sender, EventArgs e)
        {
            SignupPage Signup = new SignupPage();
            Signup.ShowDialog();
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
