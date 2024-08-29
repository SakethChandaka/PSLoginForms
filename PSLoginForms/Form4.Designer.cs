namespace PSLoginForms
{
    partial class Form4
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
            this.OAuthUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.OAuthPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.LoginOA = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // OAuthUsername
            // 
            this.OAuthUsername.AnimateReadOnly = false;
            this.OAuthUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OAuthUsername.Depth = 0;
            this.OAuthUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.OAuthUsername.LeadingIcon = null;
            this.OAuthUsername.Location = new System.Drawing.Point(179, 171);
            this.OAuthUsername.MaxLength = 50;
            this.OAuthUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.OAuthUsername.Multiline = false;
            this.OAuthUsername.Name = "OAuthUsername";
            this.OAuthUsername.Size = new System.Drawing.Size(166, 50);
            this.OAuthUsername.TabIndex = 0;
            this.OAuthUsername.Text = "";
            this.OAuthUsername.TrailingIcon = null;
            // 
            // OAuthPassword
            // 
            this.OAuthPassword.AnimateReadOnly = false;
            this.OAuthPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OAuthPassword.Depth = 0;
            this.OAuthPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.OAuthPassword.LeadingIcon = null;
            this.OAuthPassword.Location = new System.Drawing.Point(179, 279);
            this.OAuthPassword.MaxLength = 50;
            this.OAuthPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.OAuthPassword.Multiline = false;
            this.OAuthPassword.Name = "OAuthPassword";
            this.OAuthPassword.Password = true;
            this.OAuthPassword.Size = new System.Drawing.Size(166, 50);
            this.OAuthPassword.TabIndex = 1;
            this.OAuthPassword.Text = "";
            this.OAuthPassword.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(219, 139);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(72, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Username";
            // 
            // LoginOA
            // 
            this.LoginOA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginOA.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.LoginOA.Depth = 0;
            this.LoginOA.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LoginOA.HighEmphasis = true;
            this.LoginOA.Icon = null;
            this.LoginOA.Location = new System.Drawing.Point(202, 356);
            this.LoginOA.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoginOA.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginOA.Name = "LoginOA";
            this.LoginOA.NoAccentTextColor = System.Drawing.Color.Empty;
            this.LoginOA.Size = new System.Drawing.Size(117, 36);
            this.LoginOA.TabIndex = 3;
            this.LoginOA.Text = "OAuth Login";
            this.LoginOA.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.LoginOA.UseAccentColor = false;
            this.LoginOA.UseVisualStyleBackColor = true;
            this.LoginOA.Click += new System.EventHandler(this.LoginOA_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(219, 248);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(71, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Password";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 505);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.LoginOA);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.OAuthPassword);
            this.Controls.Add(this.OAuthUsername);
            this.Name = "Form4";
            this.Text = "PS OAUTH LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox OAuthUsername;
        private MaterialSkin.Controls.MaterialTextBox OAuthPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton LoginOA;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}