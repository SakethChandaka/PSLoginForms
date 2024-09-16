namespace PSLoginForms
{
    partial class LoginPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.userName = new MaterialSkin.Controls.MaterialTextBox2();
            this.passWord = new MaterialSkin.Controls.MaterialTextBox2();
            this.loginButton = new MaterialSkin.Controls.MaterialButton();
            this.signupButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(222, 172);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(72, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Username";
            // 
            // userName
            // 
            this.userName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userName.AnimateReadOnly = false;
            this.userName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.userName.Depth = 0;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userName.HideSelection = true;
            this.userName.LeadingIcon = null;
            this.userName.Location = new System.Drawing.Point(182, 254);
            this.userName.Margin = new System.Windows.Forms.Padding(2);
            this.userName.MaxLength = 32767;
            this.userName.MouseState = MaterialSkin.MouseState.OUT;
            this.userName.Name = "userName";
            this.userName.PasswordChar = '\0';
            this.userName.PrefixSuffixText = null;
            this.userName.ReadOnly = false;
            this.userName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userName.SelectedText = "";
            this.userName.SelectionLength = 0;
            this.userName.SelectionStart = 0;
            this.userName.ShortcutsEnabled = true;
            this.userName.Size = new System.Drawing.Size(201, 48);
            this.userName.TabIndex = 7;
            this.userName.TabStop = false;
            this.userName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userName.TrailingIcon = null;
            this.userName.UseSystemPasswordChar = false;
            // 
            // passWord
            // 
            this.passWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passWord.AnimateReadOnly = false;
            this.passWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passWord.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passWord.Depth = 0;
            this.passWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passWord.HideSelection = true;
            this.passWord.LeadingIcon = null;
            this.passWord.Location = new System.Drawing.Point(182, 382);
            this.passWord.Margin = new System.Windows.Forms.Padding(2);
            this.passWord.MaxLength = 32767;
            this.passWord.MouseState = MaterialSkin.MouseState.OUT;
            this.passWord.Name = "passWord";
            this.passWord.PasswordChar = '*';
            this.passWord.PrefixSuffixText = null;
            this.passWord.ReadOnly = false;
            this.passWord.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passWord.SelectedText = "";
            this.passWord.SelectionLength = 0;
            this.passWord.SelectionStart = 0;
            this.passWord.ShortcutsEnabled = true;
            this.passWord.Size = new System.Drawing.Size(201, 48);
            this.passWord.TabIndex = 8;
            this.passWord.TabStop = false;
            this.passWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passWord.TrailingIcon = null;
            this.passWord.UseSystemPasswordChar = false;
            // 
            // loginButton
            // 
            this.loginButton.AutoSize = false;
            this.loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.loginButton.Depth = 0;
            this.loginButton.HighEmphasis = true;
            this.loginButton.Icon = null;
            this.loginButton.Location = new System.Drawing.Point(201, 461);
            this.loginButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.loginButton.Size = new System.Drawing.Size(127, 50);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "Log in";
            this.loginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.loginButton.UseAccentColor = false;
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // signupButton
            // 
            this.signupButton.AutoSize = false;
            this.signupButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signupButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.signupButton.Depth = 0;
            this.signupButton.HighEmphasis = true;
            this.signupButton.Icon = null;
            this.signupButton.Location = new System.Drawing.Point(279, 530);
            this.signupButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.signupButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.signupButton.Name = "signupButton";
            this.signupButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.signupButton.Size = new System.Drawing.Size(104, 27);
            this.signupButton.TabIndex = 10;
            this.signupButton.Text = "Sign up";
            this.signupButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.signupButton.UseAccentColor = false;
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click_1);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(222, 303);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(71, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(98, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 52);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(136, 535);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(137, 19);
            this.materialLabel3.TabIndex = 13;
            this.materialLabel3.Text = "Create an account?";
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.AutoSize = true;
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(164, 403);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.ReadOnly = false;
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(148, 37);
            this.materialCheckbox1.TabIndex = 14;
            this.materialCheckbox1.Text = "Show password";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            this.materialCheckbox1.CheckedChanged += new System.EventHandler(this.materialCheckbox1_CheckedChanged);
            // 
            // LoginPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(557, 783);
            this.Controls.Add(this.materialCheckbox1);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passWord);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.materialLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginPage";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 2, 2);
            this.Sizable = false;
            this.Text = "PS LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 userName;
        private MaterialSkin.Controls.MaterialTextBox2 passWord;
        private MaterialSkin.Controls.MaterialButton loginButton;
        private MaterialSkin.Controls.MaterialButton signupButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
    }
}

