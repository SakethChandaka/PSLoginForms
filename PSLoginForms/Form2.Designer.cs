namespace PSLoginForms
{
    partial class Form2
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
            this.Susername = new MaterialSkin.Controls.MaterialTextBox();
            this.Spassword = new MaterialSkin.Controls.MaterialTextBox();
            this.signUp = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // Susername
            // 
            this.Susername.AnimateReadOnly = false;
            this.Susername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Susername.Depth = 0;
            this.Susername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Susername.LeadingIcon = null;
            this.Susername.Location = new System.Drawing.Point(162, 140);
            this.Susername.MaxLength = 50;
            this.Susername.MouseState = MaterialSkin.MouseState.OUT;
            this.Susername.Multiline = false;
            this.Susername.Name = "Susername";
            this.Susername.Size = new System.Drawing.Size(165, 50);
            this.Susername.TabIndex = 5;
            this.Susername.Text = "";
            this.Susername.TrailingIcon = null;
            // 
            // Spassword
            // 
            this.Spassword.AnimateReadOnly = false;
            this.Spassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Spassword.Depth = 0;
            this.Spassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Spassword.LeadingIcon = null;
            this.Spassword.Location = new System.Drawing.Point(162, 227);
            this.Spassword.MaxLength = 50;
            this.Spassword.MouseState = MaterialSkin.MouseState.OUT;
            this.Spassword.Multiline = false;
            this.Spassword.Name = "Spassword";
            this.Spassword.Size = new System.Drawing.Size(165, 50);
            this.Spassword.TabIndex = 6;
            this.Spassword.Text = "";
            this.Spassword.TrailingIcon = null;
            // 
            // signUp
            // 
            this.signUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signUp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.signUp.Depth = 0;
            this.signUp.HighEmphasis = true;
            this.signUp.Icon = null;
            this.signUp.Location = new System.Drawing.Point(169, 348);
            this.signUp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.signUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.signUp.Name = "signUp";
            this.signUp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.signUp.Size = new System.Drawing.Size(158, 36);
            this.signUp.TabIndex = 7;
            this.signUp.Text = "materialButton1";
            this.signUp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.signUp.UseAccentColor = false;
            this.signUp.UseVisualStyleBackColor = true;
            this.signUp.Click += new System.EventHandler(this.signUp_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(187, 140);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(112, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Enter Username";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(188, 235);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(111, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Enter Password";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(488, 489);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.Spassword);
            this.Controls.Add(this.Susername);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox Susername;
        private MaterialSkin.Controls.MaterialTextBox Spassword;
        private MaterialSkin.Controls.MaterialButton signUp;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}