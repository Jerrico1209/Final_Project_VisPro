﻿namespace Project_Asrama
{
    partial class InsertDBFrm
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
            this.dtG_Asrama = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.txt_NIM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Fakultas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_No_kamar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_absen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Cari = new System.Windows.Forms.Button();
            this.btnSafe = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtG_Asrama)).BeginInit();
            this.SuspendLayout();
            // 
            // dtG_Asrama
            // 
            this.dtG_Asrama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtG_Asrama.Location = new System.Drawing.Point(4, 254);
            this.dtG_Asrama.Name = "dtG_Asrama";
            this.dtG_Asrama.RowHeadersWidth = 51;
            this.dtG_Asrama.RowTemplate.Height = 24;
            this.dtG_Asrama.Size = new System.Drawing.Size(743, 366);
            this.dtG_Asrama.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Mahasiswa:";
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(193, 37);
            this.txt_nama.Multiline = true;
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(200, 25);
            this.txt_nama.TabIndex = 2;
            // 
            // txt_NIM
            // 
            this.txt_NIM.Location = new System.Drawing.Point(193, 75);
            this.txt_NIM.Multiline = true;
            this.txt_NIM.Name = "txt_NIM";
            this.txt_NIM.Size = new System.Drawing.Size(200, 25);
            this.txt_NIM.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "NIM Mahasiswa:";
            // 
            // txt_Fakultas
            // 
            this.txt_Fakultas.Location = new System.Drawing.Point(193, 117);
            this.txt_Fakultas.Multiline = true;
            this.txt_Fakultas.Name = "txt_Fakultas";
            this.txt_Fakultas.Size = new System.Drawing.Size(200, 25);
            this.txt_Fakultas.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fakultas:";
            // 
            // txt_No_kamar
            // 
            this.txt_No_kamar.Location = new System.Drawing.Point(193, 155);
            this.txt_No_kamar.Multiline = true;
            this.txt_No_kamar.Name = "txt_No_kamar";
            this.txt_No_kamar.Size = new System.Drawing.Size(200, 25);
            this.txt_No_kamar.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nomor Kamar:";
            // 
            // txt_absen
            // 
            this.txt_absen.Location = new System.Drawing.Point(193, 193);
            this.txt_absen.Multiline = true;
            this.txt_absen.Name = "txt_absen";
            this.txt_absen.Size = new System.Drawing.Size(200, 25);
            this.txt_absen.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Absensi:";
            // 
            // btn_Cari
            // 
            this.btn_Cari.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cari.Location = new System.Drawing.Point(603, 29);
            this.btn_Cari.Name = "btn_Cari";
            this.btn_Cari.Size = new System.Drawing.Size(144, 69);
            this.btn_Cari.TabIndex = 11;
            this.btn_Cari.Text = "Search";
            this.btn_Cari.UseVisualStyleBackColor = true;
            this.btn_Cari.Click += new System.EventHandler(this.btn_Cari_Click);
            // 
            // btnSafe
            // 
            this.btnSafe.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSafe.Location = new System.Drawing.Point(445, 29);
            this.btnSafe.Name = "btnSafe";
            this.btnSafe.Size = new System.Drawing.Size(144, 69);
            this.btnSafe.TabIndex = 13;
            this.btnSafe.Text = "Insert Data";
            this.btnSafe.UseVisualStyleBackColor = true;
            this.btnSafe.Click += new System.EventHandler(this.btnSafe_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(603, 113);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 69);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(445, 113);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 69);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // InsertDBFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(750, 624);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSafe);
            this.Controls.Add(this.btn_Cari);
            this.Controls.Add(this.txt_absen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_No_kamar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Fakultas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_NIM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtG_Asrama);
            this.Name = "InsertDBFrm";
            this.Text = "DBFrm";
            this.Load += new System.EventHandler(this.DBFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtG_Asrama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtG_Asrama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.TextBox txt_NIM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Fakultas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_No_kamar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_absen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Cari;
        private System.Windows.Forms.Button btnSafe;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
    }
}