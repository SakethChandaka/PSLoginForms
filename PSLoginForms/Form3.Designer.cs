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
            this.imageDisplay = new MaterialSkin.Controls.MaterialCard();
            this.FetchClick = new MaterialSkin.Controls.MaterialButton();
            this.userNameDisplay = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ImageDummy = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.imageDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(47, 33);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1020, 699);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.imageDisplay);
            this.tabPage1.Controls.Add(this.FetchClick);
            this.tabPage1.Controls.Add(this.userNameDisplay);
            this.tabPage1.ForeColor = System.Drawing.Color.Coral;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1012, 670);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Details";
            // 
            // imageDisplay
            // 
            this.imageDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.imageDisplay.Controls.Add(this.ImageDummy);
            this.imageDisplay.Depth = 0;
            this.imageDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.imageDisplay.Location = new System.Drawing.Point(264, 154);
            this.imageDisplay.Margin = new System.Windows.Forms.Padding(14);
            this.imageDisplay.MouseState = MaterialSkin.MouseState.HOVER;
            this.imageDisplay.Name = "imageDisplay";
            this.imageDisplay.Padding = new System.Windows.Forms.Padding(14);
            this.imageDisplay.Size = new System.Drawing.Size(525, 254);
            this.imageDisplay.TabIndex = 3;
            // 
            // FetchClick
            // 
            this.FetchClick.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FetchClick.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.FetchClick.Depth = 0;
            this.FetchClick.HighEmphasis = true;
            this.FetchClick.Icon = null;
            this.FetchClick.Location = new System.Drawing.Point(450, 516);
            this.FetchClick.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.FetchClick.MouseState = MaterialSkin.MouseState.HOVER;
            this.FetchClick.Name = "FetchClick";
            this.FetchClick.NoAccentTextColor = System.Drawing.Color.Empty;
            this.FetchClick.Size = new System.Drawing.Size(166, 36);
            this.FetchClick.TabIndex = 2;
            this.FetchClick.Text = "Fetch Your Images";
            this.FetchClick.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.FetchClick.UseAccentColor = false;
            this.FetchClick.UseVisualStyleBackColor = true;
            this.FetchClick.Click += new System.EventHandler(this.FetchClick_Click);
            // 
            // userNameDisplay
            // 
            this.userNameDisplay.AutoSize = true;
            this.userNameDisplay.Depth = 0;
            this.userNameDisplay.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userNameDisplay.Location = new System.Drawing.Point(885, 23);
            this.userNameDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameDisplay.MouseState = MaterialSkin.MouseState.HOVER;
            this.userNameDisplay.Name = "userNameDisplay";
            this.userNameDisplay.Size = new System.Drawing.Size(74, 19);
            this.userNameDisplay.TabIndex = 1;
            this.userNameDisplay.Text = "UserName";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1012, 670);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Help";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ImageDummy
            // 
            this.ImageDummy.AutoSize = true;
            this.ImageDummy.Depth = 0;
            this.ImageDummy.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ImageDummy.Location = new System.Drawing.Point(152, 111);
            this.ImageDummy.MouseState = MaterialSkin.MouseState.HOVER;
            this.ImageDummy.Name = "ImageDummy";
            this.ImageDummy.Size = new System.Drawing.Size(217, 19);
            this.ImageDummy.TabIndex = 0;
            this.ImageDummy.Text = "Click Fetch to get your images.";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 762);
            this.Controls.Add(this.materialTabControl1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Padding = new System.Windows.Forms.Padding(4, 30, 4, 4);
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.imageDisplay.ResumeLayout(false);
            this.imageDisplay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialLabel userNameDisplay;
        private MaterialSkin.Controls.MaterialButton FetchClick;
        private MaterialSkin.Controls.MaterialCard imageDisplay;
        private MaterialSkin.Controls.MaterialLabel ImageDummy;
    }
}