using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Project_Asrama
{
    public partial class VDBFrm : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public VDBFrm()
        {
            alamat = "server = localhost; database = db_asrama ;username = root; password = ;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void insertDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertDBFrm dBFrm = new InsertDBFrm();
            dBFrm.Show();
            this.Hide();
        }

        private void updateDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDBFrm updateDBFrm = new UpdateDBFrm();
            updateDBFrm.Show();
            this.Hide();
        }

        private void VDBFrm_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("SELECT * FROM data_mh_asrama");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                dgvMH.DataSource = ds.Tables[0];
                dgvMH.Columns[0].Width = 55;
                dgvMH.Columns[0].HeaderText = "Nomor";
                dgvMH.Columns[1].Width = 120;
                dgvMH.Columns[1].HeaderText = "Nama Mahasiswa";
                dgvMH.Columns[2].Width = 120;
                dgvMH.Columns[2].HeaderText = "NIM Mahasiswa";
                dgvMH.Columns[3].Width = 120;
                dgvMH.Columns[3].HeaderText = "Fakultas Mahasiswa";
                dgvMH.Columns[4].Width = 40;
                dgvMH.Columns[4].HeaderText = "Nomor kamar";
                dgvMH.Columns[5].Width = 55;
                dgvMH.Columns[5].HeaderText = "Absen";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
