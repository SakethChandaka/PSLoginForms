namespace PSLoginForms
{
    partial class Dashboard
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
            this.SaveChangeButton = new MaterialSkin.Controls.MaterialButton();
            this.FetchClick = new MaterialSkin.Controls.MaterialButton();
            this.userNameDisplay = new MaterialSkin.Controls.MaterialLabel();
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
            this.tabPage1.Controls.Add(this.SaveChangeButton);
            this.tabPage1.Controls.Add(this.FetchClick);
            this.tabPage1.Controls.Add(this.userNameDisplay);
            this.tabPage1.ForeColor = System.Drawing.Color.Coral;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(757, 542);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Details";
            // 
            // SaveChangeButton
            // 
            this.SaveChangeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveChangeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SaveChangeButton.Depth = 0;
            this.SaveChangeButton.HighEmphasis = true;
            this.SaveChangeButton.Icon = null;
            this.SaveChangeButton.Location = new System.Drawing.Point(302, 448);
            this.SaveChangeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveChangeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveChangeButton.Name = "SaveChangeButton";
            this.SaveChangeButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SaveChangeButton.Size = new System.Drawing.Size(129, 36);
            this.SaveChangeButton.TabIndex = 3;
            this.SaveChangeButton.Text = "Save Changes";
            this.SaveChangeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SaveChangeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SaveChangeButton.UseAccentColor = false;
            this.SaveChangeButton.UseMnemonic = false;
            this.SaveChangeButton.UseVisualStyleBackColor = true;
            this.SaveChangeButton.Click += new System.EventHandler(this.SaveChangeButton_Click);
            // 
            // FetchClick
            // 
            this.FetchClick.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FetchClick.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.FetchClick.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.FetchClick.Depth = 0;
            this.FetchClick.HighEmphasis = true;
            this.FetchClick.Icon = null;
            this.FetchClick.Location = new System.Drawing.Point(325, 50);
            this.FetchClick.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.FetchClick.MouseState = MaterialSkin.MouseState.HOVER;
            this.FetchClick.Name = "FetchClick";
            this.FetchClick.NoAccentTextColor = System.Drawing.Color.Empty;
            this.FetchClick.Size = new System.Drawing.Size(67, 36);
            this.FetchClick.TabIndex = 2;
            this.FetchClick.Text = "Fetch";
            this.FetchClick.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.FetchClick.UseAccentColor = false;
            this.FetchClick.UseMnemonic = false;
            this.FetchClick.UseVisualStyleBackColor = true;
            this.FetchClick.Click += new System.EventHandler(this.FetchClick_Click);
            // 
            // userNameDisplay
            // 
            this.userNameDisplay.AutoSize = true;
            this.userNameDisplay.Depth = 0;
            this.userNameDisplay.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userNameDisplay.Location = new System.Drawing.Point(322, 25);
            this.userNameDisplay.MouseState = MaterialSkin.MouseState.HOVER;
            this.userNameDisplay.Name = "userNameDisplay";
            this.userNameDisplay.Size = new System.Drawing.Size(74, 19);
            this.userNameDisplay.TabIndex = 1;
            this.userNameDisplay.Text = "UserName";
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
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 619);
            this.Controls.Add(this.materialTabControl1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialLabel userNameDisplay;
        private MaterialSkin.Controls.MaterialButton FetchClick;
        private MaterialSkin.Controls.MaterialButton SaveChangeButton;
    }
}