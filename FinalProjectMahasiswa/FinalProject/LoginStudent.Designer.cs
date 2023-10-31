
namespace FinalProject
{
    partial class LoginStudent
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
            this.EmailStudent = new System.Windows.Forms.Label();
            this.PasswordStudent = new System.Windows.Forms.Label();
            this.TxtBxEmailStudent = new System.Windows.Forms.TextBox();
            this.TxtBxPassStudent = new System.Windows.Forms.TextBox();
            this.ChckBxPassword = new System.Windows.Forms.CheckBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.BckToMenuButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentLabel = new System.Windows.Forms.Label();
            this.ForgotPassLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // EmailStudent
            // 
            this.EmailStudent.AutoSize = true;
            this.EmailStudent.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailStudent.Location = new System.Drawing.Point(58, 108);
            this.EmailStudent.Name = "EmailStudent";
            this.EmailStudent.Size = new System.Drawing.Size(34, 13);
            this.EmailStudent.TabIndex = 0;
            this.EmailStudent.Text = "Email";
            this.EmailStudent.Click += new System.EventHandler(this.EmailStudent_Click);
            // 
            // PasswordStudent
            // 
            this.PasswordStudent.AutoSize = true;
            this.PasswordStudent.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordStudent.Location = new System.Drawing.Point(58, 135);
            this.PasswordStudent.Name = "PasswordStudent";
            this.PasswordStudent.Size = new System.Drawing.Size(56, 13);
            this.PasswordStudent.TabIndex = 1;
            this.PasswordStudent.Text = "Password";
            // 
            // TxtBxEmailStudent
            // 
            this.TxtBxEmailStudent.Location = new System.Drawing.Point(189, 108);
            this.TxtBxEmailStudent.Name = "TxtBxEmailStudent";
            this.TxtBxEmailStudent.Size = new System.Drawing.Size(156, 20);
            this.TxtBxEmailStudent.TabIndex = 2;
            // 
            // TxtBxPassStudent
            // 
            this.TxtBxPassStudent.Location = new System.Drawing.Point(189, 135);
            this.TxtBxPassStudent.Name = "TxtBxPassStudent";
            this.TxtBxPassStudent.Size = new System.Drawing.Size(156, 20);
            this.TxtBxPassStudent.TabIndex = 3;
            // 
            // ChckBxPassword
            // 
            this.ChckBxPassword.AutoSize = true;
            this.ChckBxPassword.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChckBxPassword.Location = new System.Drawing.Point(189, 161);
            this.ChckBxPassword.Name = "ChckBxPassword";
            this.ChckBxPassword.Size = new System.Drawing.Size(106, 17);
            this.ChckBxPassword.TabIndex = 4;
            this.ChckBxPassword.Text = "Show Password";
            this.ChckBxPassword.UseVisualStyleBackColor = true;
            this.ChckBxPassword.CheckedChanged += new System.EventHandler(this.ChckBxPassword_CheckedChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(216, 215);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // BckToMenuButton
            // 
            this.BckToMenuButton.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BckToMenuButton.Location = new System.Drawing.Point(104, 215);
            this.BckToMenuButton.Name = "BckToMenuButton";
            this.BckToMenuButton.Size = new System.Drawing.Size(84, 23);
            this.BckToMenuButton.TabIndex = 6;
            this.BckToMenuButton.Text = "Back to Menu";
            this.BckToMenuButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sistem Informasi Asrama";
            // 
            // StudentLabel
            // 
            this.StudentLabel.AutoSize = true;
            this.StudentLabel.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLabel.Location = new System.Drawing.Point(167, 58);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(58, 18);
            this.StudentLabel.TabIndex = 8;
            this.StudentLabel.Text = "Student";
            // 
            // ForgotPassLink
            // 
            this.ForgotPassLink.AutoSize = true;
            this.ForgotPassLink.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPassLink.Location = new System.Drawing.Point(187, 181);
            this.ForgotPassLink.Name = "ForgotPassLink";
            this.ForgotPassLink.Size = new System.Drawing.Size(87, 13);
            this.ForgotPassLink.TabIndex = 9;
            this.ForgotPassLink.TabStop = true;
            this.ForgotPassLink.Text = "Forgot Password";
            this.ForgotPassLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgotPassLink_LinkClicked);
            // 
            // LoginStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 273);
            this.Controls.Add(this.ForgotPassLink);
            this.Controls.Add(this.StudentLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BckToMenuButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.ChckBxPassword);
            this.Controls.Add(this.TxtBxPassStudent);
            this.Controls.Add(this.TxtBxEmailStudent);
            this.Controls.Add(this.PasswordStudent);
            this.Controls.Add(this.EmailStudent);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LoginStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login as Students";
            this.Load += new System.EventHandler(this.LoginStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmailStudent;
        private System.Windows.Forms.Label PasswordStudent;
        private System.Windows.Forms.TextBox TxtBxEmailStudent;
        private System.Windows.Forms.TextBox TxtBxPassStudent;
        private System.Windows.Forms.CheckBox ChckBxPassword;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button BckToMenuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.LinkLabel ForgotPassLink;
    }
}

