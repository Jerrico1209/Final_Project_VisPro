namespace prototypeapp
{
    partial class MENU
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
            this.BtnDaftar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.BtnSeatting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDaftar
            // 
            this.BtnDaftar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnDaftar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDaftar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnDaftar.Location = new System.Drawing.Point(-1, 334);
            this.BtnDaftar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDaftar.Name = "BtnDaftar";
            this.BtnDaftar.Size = new System.Drawing.Size(203, 114);
            this.BtnDaftar.TabIndex = 0;
            this.BtnDaftar.Text = "DAFTAR MAHASISWA";
            this.BtnDaftar.UseVisualStyleBackColor = false;
            this.BtnDaftar.Click += new System.EventHandler(this.BtnDaftar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(695, 410);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "E X I T";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(-1, 2);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 114);
            this.button3.TabIndex = 2;
            this.button3.Text = "INPUT POIN";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.Location = new System.Drawing.Point(-1, 224);
            this.BtnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(203, 114);
            this.BtnHome.TabIndex = 3;
            this.BtnHome.Text = "HOME";
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnSeatting
            // 
            this.BtnSeatting.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnSeatting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeatting.Location = new System.Drawing.Point(-1, 113);
            this.BtnSeatting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSeatting.Name = "BtnSeatting";
            this.BtnSeatting.Size = new System.Drawing.Size(203, 114);
            this.BtnSeatting.TabIndex = 4;
            this.BtnSeatting.Text = "SEATING IBADAH";
            this.BtnSeatting.UseVisualStyleBackColor = false;
            this.BtnSeatting.Click += new System.EventHandler(this.BtnSeatting_Click);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSeatting);
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnDaftar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MENU";
            this.Text = "MENU";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnDaftar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnSeatting;
    }
}

