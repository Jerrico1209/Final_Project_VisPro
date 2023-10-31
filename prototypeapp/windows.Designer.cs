namespace prototypeapp
{
    partial class windows
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.TxtSabbath = new System.Windows.Forms.TextBox();
            this.TxtVesper = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 239);
            this.dataGridView1.TabIndex = 0;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(13, 13);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(35, 13);
            this.a.TabIndex = 1;
            this.a.Text = "Nama";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(12, 81);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(50, 13);
            this.c.TabIndex = 2;
            this.c.Text = "Midweek";
            this.c.Click += new System.EventHandler(this.label2_Click);
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(12, 47);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(68, 13);
            this.b.TabIndex = 4;
            this.b.Text = "NomorKamar";
            // 
            // TxtNama
            // 
            this.TxtNama.Location = new System.Drawing.Point(91, 5);
            this.TxtNama.Name = "TxtNama";
            this.TxtNama.Size = new System.Drawing.Size(100, 20);
            this.TxtNama.TabIndex = 5;
            // 
            // TxtMidweek
            // 
            this.TxtMidweek.Location = new System.Drawing.Point(91, 74);
            this.TxtMidweek.Name = "TxtMidweek";
            this.TxtMidweek.Size = new System.Drawing.Size(100, 20);
            this.TxtMidweek.TabIndex = 6;
            // 
            // TxtNomorKamar
            // 
            this.TxtNomorKamar.Location = new System.Drawing.Point(91, 40);
            this.TxtNomorKamar.Name = "TxtNomorKamar";
            this.TxtNomorKamar.Size = new System.Drawing.Size(100, 20);
            this.TxtNomorKamar.TabIndex = 7;
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Location = new System.Drawing.Point(13, 167);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(21, 13);
            this.f.TabIndex = 8;
            this.f.Text = "PA";
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Location = new System.Drawing.Point(12, 137);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(47, 13);
            this.e.TabIndex = 9;
            this.e.Text = "Sabbath";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(13, 110);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(40, 13);
            this.d.TabIndex = 10;
            this.d.Text = "Vesper";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(91, 160);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 11;
            // 
            // TxtSabbath
            // 
            this.TxtSabbath.Location = new System.Drawing.Point(91, 130);
            this.TxtSabbath.Name = "TxtSabbath";
            this.TxtSabbath.Size = new System.Drawing.Size(100, 20);
            this.TxtSabbath.TabIndex = 12;
            // 
            // TxtVesper
            // 
            this.TxtVesper.Location = new System.Drawing.Point(91, 100);
            this.TxtVesper.Name = "TxtVesper";
            this.TxtVesper.Size = new System.Drawing.Size(100, 20);
            this.TxtVesper.TabIndex = 13;
            // 
            // windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtVesper);
            this.Controls.Add(this.TxtSabbath);
            this.Controls.Add(this.textBox4);
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
            this.Name = "windows";
            this.Text = "t";
            this.Load += new System.EventHandler(this.windows_Load);
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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox TxtSabbath;
        private System.Windows.Forms.TextBox TxtVesper;
    }
}