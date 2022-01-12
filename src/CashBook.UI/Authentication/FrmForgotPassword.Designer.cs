namespace CashBook.UI.Authentication
{
    partial class FrmForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmForgotPassword));
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.btnCheckUsername = new System.Windows.Forms.Button();
            this.txtSecurityAnswer = new System.Windows.Forms.TextBox();
            this.txtSecurityQuestion = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.BackColor = System.Drawing.SystemColors.Control;
            this.btnGeneratePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneratePassword.Location = new System.Drawing.Point(286, 172);
            this.btnGeneratePassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(131, 34);
            this.btnGeneratePassword.TabIndex = 11;
            this.btnGeneratePassword.Text = "&Generate Password";
            this.btnGeneratePassword.UseVisualStyleBackColor = false;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // btnCheckUsername
            // 
            this.btnCheckUsername.BackColor = System.Drawing.SystemColors.Control;
            this.btnCheckUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckUsername.Location = new System.Drawing.Point(122, 172);
            this.btnCheckUsername.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckUsername.Name = "btnCheckUsername";
            this.btnCheckUsername.Size = new System.Drawing.Size(131, 34);
            this.btnCheckUsername.TabIndex = 10;
            this.btnCheckUsername.Text = "&Check Username";
            this.btnCheckUsername.UseVisualStyleBackColor = false;
            this.btnCheckUsername.Click += new System.EventHandler(this.btnCheckUsername_Click);
            // 
            // txtSecurityAnswer
            // 
            this.txtSecurityAnswer.Location = new System.Drawing.Point(122, 68);
            this.txtSecurityAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.txtSecurityAnswer.Multiline = true;
            this.txtSecurityAnswer.Name = "txtSecurityAnswer";
            this.txtSecurityAnswer.Size = new System.Drawing.Size(295, 100);
            this.txtSecurityAnswer.TabIndex = 8;
            // 
            // txtSecurityQuestion
            // 
            this.txtSecurityQuestion.Enabled = false;
            this.txtSecurityQuestion.Location = new System.Drawing.Point(122, 43);
            this.txtSecurityQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.txtSecurityQuestion.Name = "txtSecurityQuestion";
            this.txtSecurityQuestion.ReadOnly = true;
            this.txtSecurityQuestion.Size = new System.Drawing.Size(295, 20);
            this.txtSecurityQuestion.TabIndex = 9;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(122, 17);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(295, 20);
            this.txtUsername.TabIndex = 4;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(10, 71);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(83, 13);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Security Answer";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(10, 45);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(90, 13);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Security Question";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(10, 20);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(55, 13);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Username";
            // 
            // FrmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(427, 223);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.btnCheckUsername);
            this.Controls.Add(this.txtSecurityAnswer);
            this.Controls.Add(this.txtSecurityQuestion);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmForgotPassword";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swift Accounts - Forgot Password";
            this.Load += new System.EventHandler(this.FrmForgotPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnGeneratePassword;
        internal System.Windows.Forms.Button btnCheckUsername;
        internal System.Windows.Forms.TextBox txtSecurityAnswer;
        internal System.Windows.Forms.TextBox txtSecurityQuestion;
        internal System.Windows.Forms.TextBox txtUsername;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}