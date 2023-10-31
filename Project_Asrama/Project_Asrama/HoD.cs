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
    public partial class HoD : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public HoD()
        {
            alamat = "server = localhost; database = db_login ;username = root; password = ;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void HoD_Load(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void btn_HoD_Click(object sender, EventArgs e)
        {
            try
            {
                query = string.Format("SELECT * FROM `data_login` WHERE user = '{0}'", txtUser.Text);
                ds.Clear();
                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                adapter.Fill(ds);
                koneksi.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow kolom in ds.Tables[0].Rows)
                    {
                        string sandi;
                        sandi = kolom["password"].ToString();
                        if (sandi == txtPass.Text)
                        {
                            DBFrm dBFrm = new DBFrm();
                            dBFrm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Anda salah memasukan password");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Anda salah memasukan Username");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(chB_ShowPass.Checked == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            FrmLogin FrmLogin = new FrmLogin();
            FrmLogin.Show();
            this.Hide();
        }
    }
}
