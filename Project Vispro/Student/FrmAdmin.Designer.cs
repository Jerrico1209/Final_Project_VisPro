
namespace Student
{
    partial class FrmAdmin
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
            this.BtnInsertMahasiswa = new System.Windows.Forms.Button();
            this.BtnInsertKepas = new System.Windows.Forms.Button();
            this.BtnInsertMonitor = new System.Windows.Forms.Button();
            this.BtnSetelan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnInsertMahasiswa
            // 
            this.BtnInsertMahasiswa.Location = new System.Drawing.Point(26, 25);
            this.BtnInsertMahasiswa.Name = "BtnInsertMahasiswa";
            this.BtnInsertMahasiswa.Size = new System.Drawing.Size(304, 175);
            this.BtnInsertMahasiswa.TabIndex = 0;
            this.BtnInsertMahasiswa.Text = "Insert Nama Mahasiswa";
            this.BtnInsertMahasiswa.UseVisualStyleBackColor = true;
            this.BtnInsertMahasiswa.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnInsertKepas
            // 
            this.BtnInsertKepas.Location = new System.Drawing.Point(437, 25);
            this.BtnInsertKepas.Name = "BtnInsertKepas";
            this.BtnInsertKepas.Size = new System.Drawing.Size(322, 175);
            this.BtnInsertKepas.TabIndex = 1;
            this.BtnInsertKepas.Text = "Insert Nama Kepas";
            this.BtnInsertKepas.UseVisualStyleBackColor = true;
            this.BtnInsertKepas.Click += new System.EventHandler(this.BtnInsertKepas_Click);
            // 
            // BtnInsertMonitor
            // 
            this.BtnInsertMonitor.Location = new System.Drawing.Point(26, 253);
            this.BtnInsertMonitor.Name = "BtnInsertMonitor";
            this.BtnInsertMonitor.Size = new System.Drawing.Size(304, 172);
            this.BtnInsertMonitor.TabIndex = 2;
            this.BtnInsertMonitor.Text = "Insert Nama Monitor";
            this.BtnInsertMonitor.UseVisualStyleBackColor = true;
            this.BtnInsertMonitor.Click += new System.EventHandler(this.BtnInsertMonitor_Click);
            // 
            // BtnSetelan
            // 
            this.BtnSetelan.Location = new System.Drawing.Point(437, 253);
            this.BtnSetelan.Name = "BtnSetelan";
            this.BtnSetelan.Size = new System.Drawing.Size(322, 172);
            this.BtnSetelan.TabIndex = 3;
            this.BtnSetelan.Text = "Setelan";
            this.BtnSetelan.UseVisualStyleBackColor = true;
            this.BtnSetelan.Click += new System.EventHandler(this.BtnSetelan_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 684);
            this.Controls.Add(this.BtnSetelan);
            this.Controls.Add(this.BtnInsertMonitor);
            this.Controls.Add(this.BtnInsertKepas);
            this.Controls.Add(this.BtnInsertMahasiswa);
            this.Name = "FrmAdmin";
            this.Text = "Form8";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnInsertMahasiswa;
        private System.Windows.Forms.Button BtnInsertKepas;
        private System.Windows.Forms.Button BtnInsertMonitor;
        private System.Windows.Forms.Button BtnSetelan;
    }
}