namespace prototypeapp
{
    partial class Poin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.a = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.TxtNama = new System.Windows.Forms.TextBox();
            this.TxtMidweek = new System.Windows.Forms.TextBox();
            this.TxtNomorKamar = new System.Windows.Forms.TextBox();
            this.f = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.TxtPA = new System.Windows.Forms.TextBox();
            this.TxtSabbath = new System.Windows.Forms.TextBox();
            this.TxtVesper = new System.Windows.Forms.TextBox();
            this.TxtSave = new System.Windows.Forms.Button();
            this.TxtClear = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.Button();
            this.TxtUpdate = new System.Windows.Forms.Button();
            this.TxtDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 245);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 294);
            this.dataGridView1.TabIndex = 0;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(17, 16);
            this.a.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(70, 16);
            this.a.TabIndex = 1;
            this.a.Text = "Username";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(16, 100);
            this.c.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(61, 16);
            this.c.TabIndex = 2;
            this.c.Text = "Midweek";
            this.c.Click += new System.EventHandler(this.label2_Click);
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(16, 58);
            this.b.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(87, 16);
            this.b.TabIndex = 4;
            this.b.Text = "NomorKamar";
            // 
            // TxtNama
            // 
            this.TxtNama.Location = new System.Drawing.Point(121, 6);
            this.TxtNama.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNama.Name = "TxtNama";
            this.TxtNama.Size = new System.Drawing.Size(132, 22);
            this.TxtNama.TabIndex = 5;
            this.TxtNama.TextChanged += new System.EventHandler(this.TxtNama_TextChanged);
            // 
            // TxtMidweek
            // 
            this.TxtMidweek.Location = new System.Drawing.Point(121, 91);
            this.TxtMidweek.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMidweek.Name = "TxtMidweek";
            this.TxtMidweek.Size = new System.Drawing.Size(132, 22);
            this.TxtMidweek.TabIndex = 6;
            // 
            // TxtNomorKamar
            // 
            this.TxtNomorKamar.Location = new System.Drawing.Point(121, 49);
            this.TxtNomorKamar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNomorKamar.Name = "TxtNomorKamar";
            this.TxtNomorKamar.Size = new System.Drawing.Size(132, 22);
            this.TxtNomorKamar.TabIndex = 7;
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Location = new System.Drawing.Point(17, 206);
            this.f.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(25, 16);
            this.f.TabIndex = 8;
            this.f.Text = "PA";
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Location = new System.Drawing.Point(16, 169);
            this.e.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(58, 16);
            this.e.TabIndex = 9;
            this.e.Text = "Sabbath";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(17, 135);
            this.d.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(51, 16);
            this.d.TabIndex = 10;
            this.d.Text = "Vesper";
            // 
            // TxtPA
            // 
            this.TxtPA.Location = new System.Drawing.Point(121, 197);
            this.TxtPA.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPA.Name = "TxtPA";
            this.TxtPA.Size = new System.Drawing.Size(132, 22);
            this.TxtPA.TabIndex = 11;
            // 
            // TxtSabbath
            // 
            this.TxtSabbath.Location = new System.Drawing.Point(121, 160);
            this.TxtSabbath.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSabbath.Name = "TxtSabbath";
            this.TxtSabbath.Size = new System.Drawing.Size(132, 22);
            this.TxtSabbath.TabIndex = 12;
            // 
            // TxtVesper
            // 
            this.TxtVesper.Location = new System.Drawing.Point(121, 123);
            this.TxtVesper.Margin = new System.Windows.Forms.Padding(4);
            this.TxtVesper.Name = "TxtVesper";
            this.TxtVesper.Size = new System.Drawing.Size(132, 22);
            this.TxtVesper.TabIndex = 13;
            // 
            // TxtSave
            // 
            this.TxtSave.Location = new System.Drawing.Point(833, 16);
            this.TxtSave.Name = "TxtSave";
            this.TxtSave.Size = new System.Drawing.Size(86, 44);
            this.TxtSave.TabIndex = 14;
            this.TxtSave.Text = "Save";
            this.TxtSave.UseVisualStyleBackColor = true;
            this.TxtSave.Click += new System.EventHandler(this.TxtSave_Click);
            // 
            // TxtClear
            // 
            this.TxtClear.Location = new System.Drawing.Point(952, 149);
            this.TxtClear.Name = "TxtClear";
            this.TxtClear.Size = new System.Drawing.Size(86, 44);
            this.TxtClear.TabIndex = 15;
            this.TxtClear.Text = "Clear";
            this.TxtClear.UseVisualStyleBackColor = true;
            this.TxtClear.Click += new System.EventHandler(this.TxtClear_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(952, 80);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(86, 44);
            this.TxtSearch.TabIndex = 16;
            this.TxtSearch.Text = "Search";
            this.TxtSearch.UseVisualStyleBackColor = true;
            this.TxtSearch.Click += new System.EventHandler(this.TxtSearch_Click);
            // 
            // TxtUpdate
            // 
            this.TxtUpdate.Location = new System.Drawing.Point(833, 80);
            this.TxtUpdate.Name = "TxtUpdate";
            this.TxtUpdate.Size = new System.Drawing.Size(86, 44);
            this.TxtUpdate.TabIndex = 17;
            this.TxtUpdate.Text = "Update";
            this.TxtUpdate.UseVisualStyleBackColor = true;
            this.TxtUpdate.Click += new System.EventHandler(this.TxtUpdate_Click);
            // 
            // TxtDelete
            // 
            this.TxtDelete.Location = new System.Drawing.Point(952, 16);
            this.TxtDelete.Name = "TxtDelete";
            this.TxtDelete.Size = new System.Drawing.Size(86, 44);
            this.TxtDelete.TabIndex = 18;
            this.TxtDelete.Text = "Delete";
            this.TxtDelete.UseVisualStyleBackColor = true;
            this.TxtDelete.Click += new System.EventHandler(this.TxtDelete_Click);
            // 
            // Poin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.TxtDelete);
            this.Controls.Add(this.TxtUpdate);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.TxtClear);
            this.Controls.Add(this.TxtSave);
            this.Controls.Add(this.TxtVesper);
            this.Controls.Add(this.TxtSabbath);
            this.Controls.Add(this.TxtPA);
            this.Controls.Add(this.d);
            this.Controls.Add(this.e);
            this.Controls.Add(this.f);
            this.Controls.Add(this.TxtNomorKamar);
            this.Controls.Add(this.TxtMidweek);
            this.Controls.Add(this.TxtNama);
            this.Controls.Add(this.b);
            this.Controls.Add(this.c);
            this.Controls.Add(this.a);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Poin";
            this.Text = "t";
            this.Load += new System.EventHandler(this.Poin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.TextBox TxtNama;
        private System.Windows.Forms.TextBox TxtMidweek;
        private System.Windows.Forms.TextBox TxtNomorKamar;
        private System.Windows.Forms.Label f;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.TextBox TxtPA;
        private System.Windows.Forms.TextBox TxtSabbath;
        private System.Windows.Forms.TextBox TxtVesper;
        private System.Windows.Forms.Button TxtSave;
        private System.Windows.Forms.Button TxtClear;
        private System.Windows.Forms.Button TxtSearch;
        private System.Windows.Forms.Button TxtUpdate;
        private System.Windows.Forms.Button TxtDelete;
    }
}