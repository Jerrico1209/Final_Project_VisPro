﻿namespace prototypeapp
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
            this.TxtDelete = new System.Windows.Forms.Button();
            this.TxtUpdate = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.Button();
            this.TxtClear = new System.Windows.Forms.Button();
            this.TxtSave = new System.Windows.Forms.Button();
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 245);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 294);
            this.dataGridView1.TabIndex = 7;
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
            // TxtDelete
            // 
            this.TxtDelete.Location = new System.Drawing.Point(965, 15);
            this.TxtDelete.Name = "TxtDelete";
            this.TxtDelete.Size = new System.Drawing.Size(86, 44);
            this.TxtDelete.TabIndex = 24;
            this.TxtDelete.Text = "Delete";
            this.TxtDelete.UseVisualStyleBackColor = true;
            // 
            // TxtUpdate
            // 
            this.TxtUpdate.Location = new System.Drawing.Point(846, 79);
            this.TxtUpdate.Name = "TxtUpdate";
            this.TxtUpdate.Size = new System.Drawing.Size(86, 44);
            this.TxtUpdate.TabIndex = 23;
            this.TxtUpdate.Text = "Update";
            this.TxtUpdate.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(965, 79);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(86, 44);
            this.TxtSearch.TabIndex = 22;
            this.TxtSearch.Text = "Search";
            this.TxtSearch.UseVisualStyleBackColor = true;
            // 
            // TxtClear
            // 
            this.TxtClear.Location = new System.Drawing.Point(965, 148);
            this.TxtClear.Name = "TxtClear";
            this.TxtClear.Size = new System.Drawing.Size(86, 44);
            this.TxtClear.TabIndex = 21;
            this.TxtClear.Text = "Clear";
            this.TxtClear.UseVisualStyleBackColor = true;
            // 
            // TxtSave
            // 
            this.TxtSave.Location = new System.Drawing.Point(846, 15);
            this.TxtSave.Name = "TxtSave";
            this.TxtSave.Size = new System.Drawing.Size(86, 44);
            this.TxtSave.TabIndex = 20;
            this.TxtSave.Text = "Save";
            this.TxtSave.UseVisualStyleBackColor = true;
            // 
            // namamahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.TxtDelete);
            this.Controls.Add(this.TxtUpdate);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.TxtClear);
            this.Controls.Add(this.TxtSave);
            this.Controls.Add(this.a);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtNama);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "namamahasiswa";
            this.Text = "namamahasiswa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Button TxtDelete;
        private System.Windows.Forms.Button TxtUpdate;
        private System.Windows.Forms.Button TxtSearch;
        private System.Windows.Forms.Button TxtClear;
        private System.Windows.Forms.Button TxtSave;
    }
}