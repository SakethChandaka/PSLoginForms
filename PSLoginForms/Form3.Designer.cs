namespace PSLoginForms
{
    partial class Form3
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.userClick = new MaterialSkin.Controls.MaterialButton();
            this.usertimeDisplay = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(35, 27);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(765, 568);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.userClick);
            this.tabPage1.Controls.Add(this.usertimeDisplay);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.ForeColor = System.Drawing.Color.Coral;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(757, 542);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Details";
            // 
            // userClick
            // 
            this.userClick.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userClick.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.userClick.Depth = 0;
            this.userClick.HighEmphasis = true;
            this.userClick.Icon = null;
            this.userClick.Location = new System.Drawing.Point(279, 331);
            this.userClick.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.userClick.MouseState = MaterialSkin.MouseState.HOVER;
            this.userClick.Name = "userClick";
            this.userClick.NoAccentTextColor = System.Drawing.Color.Empty;
            this.userClick.Size = new System.Drawing.Size(133, 36);
            this.userClick.TabIndex = 2;
            this.userClick.Text = "Get Login Time";
            this.userClick.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.userClick.UseAccentColor = false;
            this.userClick.UseVisualStyleBackColor = true;
            this.userClick.Click += new System.EventHandler(this.userClick_Click);
            // 
            // usertimeDisplay
            // 
            this.usertimeDisplay.AutoSize = true;
            this.usertimeDisplay.Depth = 0;
            this.usertimeDisplay.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.usertimeDisplay.Location = new System.Drawing.Point(458, 141);
            this.usertimeDisplay.MouseState = MaterialSkin.MouseState.HOVER;
            this.usertimeDisplay.Name = "usertimeDisplay";
            this.usertimeDisplay.Size = new System.Drawing.Size(11, 19);
            this.usertimeDisplay.TabIndex = 1;
            this.usertimeDisplay.Text = "X";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(160, 141);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(131, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "USER LOGIN TIME";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(757, 542);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Help";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 619);
            this.Controls.Add(this.materialTabControl1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "Form3";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "Form3";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel usertimeDisplay;
        private MaterialSkin.Controls.MaterialButton userClick;
    }
}