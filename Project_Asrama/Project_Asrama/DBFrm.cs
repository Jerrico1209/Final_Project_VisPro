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
    public partial class DBFrm : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public DBFrm()
        {
            alamat = "server = localhost; database = db_asrama ;username = root; password = ;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void btn_Cari_Click(object sender, EventArgs e)
        {
            try 
            {
                koneksi.Open();
                query = string.Format("select * from data_mh_asrama");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow kolom in ds.Tables[0].Rows){
                        txt_nama.Text = kolom["Nama Mahasiswa"].ToString();
                        txt_NIM.Text = kolom["NIM Mahasiswa"].ToString();
                        txt_Fakultas.Text = kolom["Fakultas Mahasiswa"].ToString();
                        txt_No_kamar.Text = kolom["No_kamar"].ToString();
                        txt_absen.Text = kolom["Absen"].ToString();

                        btnUpdate.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                query = string.Format("UPDATE `data_mh_asrama` SET `Nama Mahasiswa`='{0}',`NIM Mahasiswa`='{1}',`Fakultas Mahasiswa`='{2}',`No_Kamar`='{3}',`Absen`='{4}'", txt_nama.Text, txt_NIM.Text, txt_Fakultas.Text, txt_No_kamar.Text, txt_absen.Text);

                ds.Clear();
                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                adapter.Fill(ds);
                koneksi.Close();

                DBFrm_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSafe_Click(object sender, EventArgs e)
        {
            try
            {
                query = string.Format("INSERT INTO `data_mh_asrama`(`Nama Mahasiswa`, `NIM Mahasiswa`, `Fakultas Mahasiswa`, `No_Kamar`, `Absen`) VALUES ('{0}','{1}','{2}','{3}','{4}')", txt_nama.Text, txt_NIM.Text, txt_Fakultas.Text, txt_No_kamar.Text, txt_absen.Text);

                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();

                koneksi.Close();
                if (res == 1)
                {
                    MessageBox.Show("Data Insert Success");
                    DBFrm_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Data insert Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                DBFrm_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HoD hoD = new HoD();
            hoD.Show();
            this.Hide();
        }

        private void DBFrm_Load(object sender, EventArgs e)
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

                dtG_Asrama.DataSource = ds.Tables[0];
                dtG_Asrama.Columns[0].Width = 55;
                dtG_Asrama.Columns[0].HeaderText = "Nomor";
                dtG_Asrama.Columns[1].Width = 120;
                dtG_Asrama.Columns[1].HeaderText = "Nama Mahasiswa";
                dtG_Asrama.Columns[2].Width = 120;
                dtG_Asrama.Columns[2].HeaderText = "NIM Mahasiswa";
                dtG_Asrama.Columns[3].Width = 120;
                dtG_Asrama.Columns[3].HeaderText = "Fakultas Mahasiswa";
                dtG_Asrama.Columns[4].Width = 40;
                dtG_Asrama.Columns[4].HeaderText = "Nomor kamar";
                dtG_Asrama.Columns[5].Width = 55;
                dtG_Asrama.Columns[5].HeaderText = "Absen";
                

                txt_nama.Clear();
                txt_NIM.Clear();
                txt_Fakultas.Clear();
                txt_No_kamar.Clear();
                txt_absen.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
