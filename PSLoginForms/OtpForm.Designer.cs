namespace PSLoginForms
{
    partial class OtpForm
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
            this.otpbox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.verifyOtp = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // otpbox
            // 
            this.otpbox.AnimateReadOnly = false;
            this.otpbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.otpbox.Depth = 0;
            this.otpbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.otpbox.LeadingIcon = null;
            this.otpbox.Location = new System.Drawing.Point(39, 206);
            this.otpbox.MaxLength = 50;
            this.otpbox.MouseState = MaterialSkin.MouseState.OUT;
            this.otpbox.Multiline = false;
            this.otpbox.Name = "otpbox";
            this.otpbox.Size = new System.Drawing.Size(274, 50);
            this.otpbox.TabIndex = 0;
            this.otpbox.Text = "";
            this.otpbox.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(96, 94);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(160, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "OTP Sent to your mail!";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(113, 169);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(119, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Enter OTP Below";
            // 
            // verifyOtp
            // 
            this.verifyOtp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.verifyOtp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.verifyOtp.Depth = 0;
            this.verifyOtp.HighEmphasis = true;
            this.verifyOtp.Icon = null;
            this.verifyOtp.Location = new System.Drawing.Point(142, 265);
            this.verifyOtp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.verifyOtp.MouseState = MaterialSkin.MouseState.HOVER;
            this.verifyOtp.Name = "verifyOtp";
            this.verifyOtp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.verifyOtp.Size = new System.Drawing.Size(70, 36);
            this.verifyOtp.TabIndex = 3;
            this.verifyOtp.Text = "Verify";
            this.verifyOtp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.verifyOtp.UseAccentColor = false;
            this.verifyOtp.UseVisualStyleBackColor = true;
            this.verifyOtp.Click += new System.EventHandler(this.verifyOtp_Click);
            // 
            // OtpForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(355, 341);
            this.Controls.Add(this.verifyOtp);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.otpbox);
            this.Name = "OtpForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Additional Verification Required";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox otpbox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton verifyOtp;
    }
}