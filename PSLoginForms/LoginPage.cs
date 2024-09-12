using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using MaterialSkin;
using MaterialSkin.Controls;
using PSLoginForms.AuthService;
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

            ManageServiceOnAppLaunch();

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
                var client = new AuthenticationClientService.Service1();

                // Call the AuthenticateUser method
                var result = client.AuthenticateUser(username, password);

                // Process the result
                if (result.StartsWith("Login successful"))
                {
                    // Handle successful login
                    MessageBox.Show(result, "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Optionally, you can store the token or proceed with other logic
                }
                else
                {
                    // Handle failed login
                    MessageBox.Show(result, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            SignupPage form2 = new SignupPage();
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

        // Method to start the service on application startup
        public void ManageServiceOnAppLaunch()
        {
            ServiceController sc = new ServiceController(AuthenticationServiceName);

            try
            {
                // Check if the service is running
                if (sc.Status != ServiceControllerStatus.Running)
                {
                    sc.Start();
                    sc.WaitForStatus(ServiceControllerStatus.Running);
                }
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show("Could not start the service: " + e.Message);
            }
        }

        // Method to stop the service when the application closes
        public void StopServiceOnAppClose()
        {
            ServiceController sc = new ServiceController(AuthenticationServiceName);

            try
            {
                // Stop the service
                if (sc.Status == ServiceControllerStatus.Running)
                {
                    sc.Stop();
                    sc.WaitForStatus(ServiceControllerStatus.Stopped);
                }
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show("Could not stop the service: " + e.Message);
            }
        }

        // Ensure the service stops when the form is closed
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            StopServiceOnAppClose();
            base.OnFormClosing(e);
        }
    }
    
}
