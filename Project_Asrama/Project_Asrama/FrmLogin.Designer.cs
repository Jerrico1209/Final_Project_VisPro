namespace Project_Asrama
{
    partial class FrmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.headOfDorm = new System.Windows.Forms.Button();
            this.student = new System.Windows.Forms.Button();
            this.admin = new System.Windows.Forms.Button();
            this.monitors = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(150, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistem informasi Asrama Unklab";
            // 
            // headOfDorm
            // 
            this.headOfDorm.BackColor = System.Drawing.Color.Purple;
            this.headOfDorm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.headOfDorm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headOfDorm.ForeColor = System.Drawing.Color.White;
            this.headOfDorm.Location = new System.Drawing.Point(287, 438);
            this.headOfDorm.Name = "headOfDorm";
            this.headOfDorm.Size = new System.Drawing.Size(240, 37);
            this.headOfDorm.TabIndex = 2;
            this.headOfDorm.Text = "Head of dormitory";
            this.headOfDorm.UseVisualStyleBackColor = false;
            this.headOfDorm.Click += new System.EventHandler(this.headOfDorm_Click);
            // 
            // student
            // 
            this.student.BackColor = System.Drawing.Color.Purple;
            this.student.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.student.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student.ForeColor = System.Drawing.Color.White;
            this.student.Location = new System.Drawing.Point(287, 481);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(240, 37);
            this.student.TabIndex = 3;
            this.student.Text = "Student";
            this.student.UseVisualStyleBackColor = false;
            // 
            // admin
            // 
            this.admin.BackColor = System.Drawing.Color.Purple;
            this.admin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.ForeColor = System.Drawing.Color.White;
            this.admin.Location = new System.Drawing.Point(287, 524);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(240, 37);
            this.admin.TabIndex = 4;
            this.admin.Text = "Administrator";
            this.admin.UseVisualStyleBackColor = false;
            // 
            // monitors
            // 
            this.monitors.BackColor = System.Drawing.Color.Purple;
            this.monitors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.monitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monitors.ForeColor = System.Drawing.Color.White;
            this.monitors.Location = new System.Drawing.Point(287, 567);
            this.monitors.Name = "monitors";
            this.monitors.Size = new System.Drawing.Size(240, 37);
            this.monitors.TabIndex = 5;
            this.monitors.Text = "Monitors";
            this.monitors.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(287, 610);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(329, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "Login as";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Project_Asrama.Properties.Resources.LOGO_UNIVERSITAS_KLABAT;
            this.pictureBox1.Location = new System.Drawing.Point(263, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 693);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monitors);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.student);
            this.Controls.Add(this.headOfDorm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button headOfDorm;
        private System.Windows.Forms.Button student;
        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.Button monitors;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

