using MaterialSkin;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Reflection;
using System.Threading.Tasks;

namespace PSLoginForms
{
    public partial class Dashboard : MaterialForm
    {
        private string _username;

        public Dashboard(string username)
        {
            _username = username;
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.DeepOrange900, Primary.Red100, Accent.Orange400, TextShade.WHITE);
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            userNameDisplay.Text = $"Welcome {_username}!";
        }
        private void FetchClick_Click(object sender, EventArgs e)
        {
            FetchUserClick();
        }
        private async void FetchUserClick()
        {
            try
            {
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);  
            }
        }

        private void SaveChangeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
