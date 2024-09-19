using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MaterialSkin.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.ServiceProcess;
using ZstdSharp.Unsafe;

namespace PSLoginForms
{
    public partial class OtpForm : MaterialForm
    {
        public string _username;
        private LoginPage _loginPage;
        public OtpForm(string username, LoginPage loginPage)
        {
            _username = username;
            _loginPage = loginPage;
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.DeepOrange900, Primary.Red100, Accent.Orange400, TextShade.WHITE);
        }


        private void verifyOtp_Click(object sender, EventArgs e)
        {
            string otp = otpbox.Text;

            // Create a client for the WCF service
            AuthenticationService.ServiceClient client2 = new AuthenticationService.ServiceClient();

            // Call the AuthenticateUser method
            var result2 = client2.AuthenticateUserByOtp(_username, otp);

            if (result2 != null && !string.IsNullOrEmpty(result2.Token) && result2.StatusMessage == "Login Success")
            {
                string token = result2.Token;
                // Example: Store the token for future API calls
                // StoreToken(token);
                MessageBox.Show(result2.Message, "Verification Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                _loginPage?.Hide();
                Dashboard DB = new Dashboard(_username);
                DB.Show();
            }
            else if (result2 != null && string.IsNullOrEmpty(result2.Token) && result2.StatusMessage == "Regenrate OTP")
            {
                MessageBox.Show("Wrong otp, Retry Login!");
            }
            else if (result2 != null && string.IsNullOrEmpty(result2.Token) && result2.StatusMessage == "OTP not generated successfully.")
            {
                MessageBox.Show("OTP Not generated! Retry Login.");
                this.Hide();
            }
        }
    }
}
