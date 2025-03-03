﻿namespace PSLoginForms
{
    partial class SignupPage
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
            this.signUp = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.Spassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // Susername
            // 
            this.Susername.AnimateReadOnly = false;
            this.Susername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Susername.Depth = 0;
            this.Susername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Susername.LeadingIcon = null;
            this.Susername.Location = new System.Drawing.Point(105, 140);
            this.Susername.MaxLength = 50;
            this.Susername.MouseState = MaterialSkin.MouseState.OUT;
            this.Susername.Multiline = false;
            this.Susername.Name = "Susername";
            this.Susername.Size = new System.Drawing.Size(165, 50);
            this.Susername.TabIndex = 5;
            this.Susername.Text = "";
            this.Susername.TrailingIcon = null;
            // 
            // signUp
            // 
            this.signUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signUp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.signUp.Depth = 0;
            this.signUp.HighEmphasis = true;
            this.signUp.Icon = null;
            this.signUp.Location = new System.Drawing.Point(146, 344);
            this.signUp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.signUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.signUp.Name = "signUp";
            this.signUp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.signUp.Size = new System.Drawing.Size(74, 36);
            this.signUp.TabIndex = 7;
            this.signUp.Text = "SignUp";
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
            this.materialLabel1.Location = new System.Drawing.Point(132, 118);
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
            this.materialLabel2.Location = new System.Drawing.Point(133, 208);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(111, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Enter Password";
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.AutoSize = true;
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(105, 292);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.ReadOnly = false;
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(148, 37);
            this.materialCheckbox1.TabIndex = 10;
            this.materialCheckbox1.Text = "Show password";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            this.materialCheckbox1.CheckedChanged += new System.EventHandler(this.materialCheckbox1_CheckedChanged);
            // 
            // Spassword
            // 
            this.Spassword.AnimateReadOnly = false;
            this.Spassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Spassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Spassword.Depth = 0;
            this.Spassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Spassword.HideSelection = true;
            this.Spassword.LeadingIcon = null;
            this.Spassword.Location = new System.Drawing.Point(105, 241);
            this.Spassword.MaxLength = 32767;
            this.Spassword.MouseState = MaterialSkin.MouseState.OUT;
            this.Spassword.Name = "Spassword";
            this.Spassword.PasswordChar = '*';
            this.Spassword.PrefixSuffixText = null;
            this.Spassword.ReadOnly = false;
            this.Spassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Spassword.SelectedText = "";
            this.Spassword.SelectionLength = 0;
            this.Spassword.SelectionStart = 0;
            this.Spassword.ShortcutsEnabled = true;
            this.Spassword.Size = new System.Drawing.Size(165, 48);
            this.Spassword.TabIndex = 11;
            this.Spassword.TabStop = false;
            this.Spassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Spassword.TrailingIcon = null;
            this.Spassword.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel3.Location = new System.Drawing.Point(146, 37);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(74, 25);
            this.materialLabel3.TabIndex = 12;
            this.materialLabel3.Text = "SIGN UP";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignupPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(369, 489);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.Spassword);
            this.Controls.Add(this.materialCheckbox1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.Susername);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignupPage";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 2, 2);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox Susername;
        private MaterialSkin.Controls.MaterialButton signUp;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialTextBox2 Spassword;
        public MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}