
namespace FinalProject
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.registKamarButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.PanelDesktopPanel = new System.Windows.Forms.Panel();
            this.pemilihanKamarButton = new System.Windows.Forms.Button();
            this.informasiPoinButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelMenu.SuspendLayout();
            this.PanelTitle.SuspendLayout();
            this.PanelDesktopPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PanelMenu.Controls.Add(this.ExitButton);
            this.PanelMenu.Controls.Add(this.informasiPoinButton);
            this.PanelMenu.Controls.Add(this.pemilihanKamarButton);
            this.PanelMenu.Controls.Add(this.registKamarButton);
            this.PanelMenu.Controls.Add(this.profileButton);
            this.PanelMenu.Controls.Add(this.homeButton);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(185, 450);
            this.PanelMenu.TabIndex = 0;
            // 
            // registKamarButton
            // 
            this.registKamarButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.registKamarButton.FlatAppearance.BorderSize = 0;
            this.registKamarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registKamarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registKamarButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.registKamarButton.Image = ((System.Drawing.Image)(resources.GetObject("registKamarButton.Image")));
            this.registKamarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registKamarButton.Location = new System.Drawing.Point(0, 182);
            this.registKamarButton.Name = "registKamarButton";
            this.registKamarButton.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.registKamarButton.Size = new System.Drawing.Size(185, 62);
            this.registKamarButton.TabIndex = 3;
            this.registKamarButton.Text = "Registrasi Kamar";
            this.registKamarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.registKamarButton.UseVisualStyleBackColor = true;
            this.registKamarButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // profileButton
            // 
            this.profileButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.profileButton.FlatAppearance.BorderSize = 0;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.profileButton.Image = ((System.Drawing.Image)(resources.GetObject("profileButton.Image")));
            this.profileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileButton.Location = new System.Drawing.Point(0, 120);
            this.profileButton.Name = "profileButton";
            this.profileButton.Padding = new System.Windows.Forms.Padding(0, 0, 55, 0);
            this.profileButton.Size = new System.Drawing.Size(185, 62);
            this.profileButton.TabIndex = 2;
            this.profileButton.Text = "Profile";
            this.profileButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // homeButton
            // 
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(0, 58);
            this.homeButton.Name = "homeButton";
            this.homeButton.Padding = new System.Windows.Forms.Padding(0, 0, 55, 0);
            this.homeButton.Size = new System.Drawing.Size(185, 62);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "Home";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.RegistKamarButton_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(185, 58);
            this.PanelLogo.TabIndex = 0;
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelTitle.Controls.Add(this.lblTitle);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(185, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(642, 58);
            this.PanelTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(294, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(64, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Home";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // PanelDesktopPanel
            // 
            this.PanelDesktopPanel.Controls.Add(this.panel1);
            this.PanelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDesktopPanel.Location = new System.Drawing.Point(185, 58);
            this.PanelDesktopPanel.Name = "PanelDesktopPanel";
            this.PanelDesktopPanel.Size = new System.Drawing.Size(642, 392);
            this.PanelDesktopPanel.TabIndex = 2;
            // 
            // pemilihanKamarButton
            // 
            this.pemilihanKamarButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pemilihanKamarButton.FlatAppearance.BorderSize = 0;
            this.pemilihanKamarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pemilihanKamarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pemilihanKamarButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.pemilihanKamarButton.Image = ((System.Drawing.Image)(resources.GetObject("pemilihanKamarButton.Image")));
            this.pemilihanKamarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pemilihanKamarButton.Location = new System.Drawing.Point(0, 244);
            this.pemilihanKamarButton.Name = "pemilihanKamarButton";
            this.pemilihanKamarButton.Padding = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.pemilihanKamarButton.Size = new System.Drawing.Size(185, 62);
            this.pemilihanKamarButton.TabIndex = 4;
            this.pemilihanKamarButton.Text = "Pemilihan Kamar";
            this.pemilihanKamarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pemilihanKamarButton.UseVisualStyleBackColor = true;
            this.pemilihanKamarButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // informasiPoinButton
            // 
            this.informasiPoinButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.informasiPoinButton.FlatAppearance.BorderSize = 0;
            this.informasiPoinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.informasiPoinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informasiPoinButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.informasiPoinButton.Image = ((System.Drawing.Image)(resources.GetObject("informasiPoinButton.Image")));
            this.informasiPoinButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.informasiPoinButton.Location = new System.Drawing.Point(0, 306);
            this.informasiPoinButton.Name = "informasiPoinButton";
            this.informasiPoinButton.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.informasiPoinButton.Size = new System.Drawing.Size(185, 62);
            this.informasiPoinButton.TabIndex = 5;
            this.informasiPoinButton.Text = "Informasi Poin";
            this.informasiPoinButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.informasiPoinButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location = new System.Drawing.Point(0, 368);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Padding = new System.Windows.Forms.Padding(0, 0, 62, 0);
            this.ExitButton.Size = new System.Drawing.Size(185, 62);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hope you always enjoy staying in our beloved Dormitory..";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(414, 138);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.PanelDesktopPanel);
            this.Controls.Add(this.PanelTitle);
            this.Controls.Add(this.PanelMenu);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.PanelDesktopPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Button registKamarButton;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel PanelDesktopPanel;
        private System.Windows.Forms.Button pemilihanKamarButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button informasiPoinButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}