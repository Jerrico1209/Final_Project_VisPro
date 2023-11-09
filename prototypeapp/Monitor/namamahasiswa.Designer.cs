namespace prototypeapp
{
    partial class namamahasiswa
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
            this.TxtNama = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.a = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.TxtSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNIM = new System.Windows.Forms.TextBox();
            this.TxtNomorKamar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNama
            // 
            this.TxtNama.Location = new System.Drawing.Point(136, 17);
            this.TxtNama.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNama.Name = "TxtNama";
            this.TxtNama.Size = new System.Drawing.Size(166, 22);
            this.TxtNama.TabIndex = 6;
            this.TxtNama.TextChanged += new System.EventHandler(this.TxtNama_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 245);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 281);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(41, 23);
            this.a.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(70, 16);
            this.a.TabIndex = 8;
            this.a.Text = "Username";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(965, 15);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(86, 44);
            this.BtnDelete.TabIndex = 24;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(846, 79);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(86, 44);
            this.BtnUpdate.TabIndex = 23;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(965, 79);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(86, 44);
            this.TxtSearch.TabIndex = 22;
            this.TxtSearch.Text = "Search";
            this.TxtSearch.UseVisualStyleBackColor = true;
            this.TxtSearch.Click += new System.EventHandler(this.TxtSearch_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(965, 148);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(86, 44);
            this.BtnClear.TabIndex = 21;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // TxtSave
            // 
            this.TxtSave.Location = new System.Drawing.Point(846, 15);
            this.TxtSave.Name = "TxtSave";
            this.TxtSave.Size = new System.Drawing.Size(86, 44);
            this.TxtSave.TabIndex = 20;
            this.TxtSave.Text = "Save";
            this.TxtSave.UseVisualStyleBackColor = true;
            this.TxtSave.Click += new System.EventHandler(this.TxtSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "NIM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "NomorKamar";
            // 
            // TxtNIM
            // 
            this.TxtNIM.Location = new System.Drawing.Point(136, 87);
            this.TxtNIM.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNIM.Name = "TxtNIM";
            this.TxtNIM.Size = new System.Drawing.Size(166, 22);
            this.TxtNIM.TabIndex = 27;
            // 
            // TxtNomorKamar
            // 
            this.TxtNomorKamar.Location = new System.Drawing.Point(136, 52);
            this.TxtNomorKamar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNomorKamar.Name = "TxtNomorKamar";
            this.TxtNomorKamar.Size = new System.Drawing.Size(166, 22);
            this.TxtNomorKamar.TabIndex = 28;
            // 
            // namamahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.TxtNomorKamar);
            this.Controls.Add(this.TxtNIM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.TxtSave);
            this.Controls.Add(this.a);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtNama);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "namamahasiswa";
            this.Text = "namamahasiswa";
            this.Load += new System.EventHandler(this.namamahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button TxtSearch;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button TxtSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNIM;
        private System.Windows.Forms.TextBox TxtNomorKamar;
    }
}