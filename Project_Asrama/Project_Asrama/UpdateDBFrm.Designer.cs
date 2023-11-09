namespace Project_Asrama
{
    partial class UpdateDBFrm
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_absen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_No_kamar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Fakultas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NIM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtG_Asrama)).BeginInit();
            this.SuspendLayout();
            // 
            // dtG_Asrama
            // 
            this.dtG_Asrama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtG_Asrama.Location = new System.Drawing.Point(3, 254);
            this.dtG_Asrama.Name = "dtG_Asrama";
            this.dtG_Asrama.RowHeadersWidth = 51;
            this.dtG_Asrama.RowTemplate.Height = 24;
            this.dtG_Asrama.Size = new System.Drawing.Size(743, 366);
            this.dtG_Asrama.TabIndex = 0;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(603, 29);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(144, 69);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_absen
            // 
            this.txt_absen.Location = new System.Drawing.Point(193, 193);
            this.txt_absen.Multiline = true;
            this.txt_absen.Name = "txt_absen";
            this.txt_absen.Size = new System.Drawing.Size(200, 25);
            this.txt_absen.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Absensi:";
            // 
            // txt_No_kamar
            // 
            this.txt_No_kamar.Location = new System.Drawing.Point(193, 155);
            this.txt_No_kamar.Multiline = true;
            this.txt_No_kamar.Name = "txt_No_kamar";
            this.txt_No_kamar.Size = new System.Drawing.Size(200, 25);
            this.txt_No_kamar.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nomor Kamar:";
            // 
            // txt_Fakultas
            // 
            this.txt_Fakultas.Location = new System.Drawing.Point(193, 117);
            this.txt_Fakultas.Multiline = true;
            this.txt_Fakultas.Name = "txt_Fakultas";
            this.txt_Fakultas.Size = new System.Drawing.Size(200, 25);
            this.txt_Fakultas.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Fakultas:";
            // 
            // txt_NIM
            // 
            this.txt_NIM.Location = new System.Drawing.Point(193, 76);
            this.txt_NIM.Multiline = true;
            this.txt_NIM.Name = "txt_NIM";
            this.txt_NIM.Size = new System.Drawing.Size(200, 25);
            this.txt_NIM.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "NIM Mahasiswa:";
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(193, 37);
            this.txt_nama.Multiline = true;
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(200, 25);
            this.txt_nama.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nama Mahasiswa:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(445, 29);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 69);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(445, 113);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(144, 69);
            this.btn_Clear.TabIndex = 22;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(603, 113);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(144, 69);
            this.btn_Back.TabIndex = 23;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // UpdateDBFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(750, 624);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btnUpdate);
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
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dtG_Asrama);
            this.Name = "UpdateDBFrm";
            this.Text = "UpdateDBFrm";
            this.Load += new System.EventHandler(this.UpdateDBFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtG_Asrama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtG_Asrama;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_absen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_No_kamar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Fakultas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NIM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Back;
    }
}