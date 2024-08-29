using MaterialSkin;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Reflection;
using System.Threading.Tasks;

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
        private void Form3_Load(object sender, EventArgs e)
        {
            userNameDisplay.Text = $"Welcome {_username}!";
        }
        private void FetchClick_Click(object sender, EventArgs e)
        {
            FetchUserImages();
        }
        private async void FetchUserImages()
        {
            try
            {
                ImageDummy.Text = "This is your new Image!";
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);  
            }
        }
    }
}
