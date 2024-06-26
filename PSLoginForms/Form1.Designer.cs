namespace PSLoginForms
{
    partial class Form1
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
            this.loginButton = new System.Windows.Forms.Button();
            this.signupButton = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.TextBox();
            this.passWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(216, 209);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(136, 34);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click_1);
            // 
            // signupButton
            // 
            this.signupButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupButton.Location = new System.Drawing.Point(241, 247);
            this.signupButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(81, 32);
            this.signupButton.TabIndex = 1;
            this.signupButton.Text = "Sign Up";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(169, 109);
            this.userName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(236, 20);
            this.userName.TabIndex = 2;
            // 
            // passWord
            // 
            this.passWord.Location = new System.Drawing.Point(169, 165);
            this.passWord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passWord.Name = "passWord";
            this.passWord.PasswordChar = '♡';
            this.passWord.Size = new System.Drawing.Size(237, 20);
            this.passWord.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "LOGIN";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(169, 187);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passWord);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.loginButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox passWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

