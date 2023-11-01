using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace prototypeapp
{
    public partial class Poin : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public Poin()
        
            {
                alamat = "server=localhost; database=poin; username=root; password=;";
                koneksi = new MySqlConnection(alamat);

                InitializeComponent();
            }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSave_Click(object sender, EventArgs e)
        {
            try
            {
                query = string.Format("insert into poin (Username, NomorKamar, Midweek, Vesper, Sabbath, PA) VALUES ('{0}','{1}', '{2}','{3}', '{4}', '{5}')", TxtNama.Text, TxtNomorKamar.Text, TxtMidweek.Text, TxtVesper.Text, TxtSabbath.Text, TxtPA.Text);

                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();

                koneksi.Close();
                if (res == 1)
                {
                    MessageBox.Show("Insert data success");
                }
                else
                {
                    MessageBox.Show("Insert data Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void TxtClear_Click(object sender, EventArgs e)
        {
            try
            {
                Poin_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void TxtDelete_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("delete from poin where Username = '{0}'", TxtNama.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void TxtSearch_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("Select * from poin where `Username` = '{0}' or `NomorKamar` ='{1}'", TxtNama.Text, TxtNomorKamar.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow kolom in ds.Tables[0].Rows)
                    {
                        TxtNama.Text = kolom["Username"].ToString();
                        TxtNomorKamar.Text = kolom["NomorKamar"].ToString();
                        TxtMidweek.Text = kolom["Midweek"].ToString();
                        TxtVesper.Text = kolom["Vesper"].ToString();
                        TxtSabbath.Text = kolom["Sabbath"].ToString();
                        TxtPA.Text = kolom["PA"].ToString();

                        TxtUpdate.Enabled = true;
                        TxtDelete.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TxtUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                query = string.Format("UPDATE poin SET Username='{0}', NomorKamar='{1}', Midweek='{2}', Vesper='{3}', Sabbath = '{4}', PA = '{5}'", TxtNama.Text, TxtNomorKamar.Text, TxtMidweek.Text, TxtVesper.Text, TxtSabbath.Text, TxtPA.Text);
                ds.Clear();
                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                adapter.Fill(ds);
                koneksi.Close();

                Poin_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void Poin_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("Select * from poin");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[0].HeaderText = "Username";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[1].HeaderText = "NomorKamar";
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[2].HeaderText = "Midweek";
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[3].HeaderText = "Vesper";
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[4].HeaderText = "Sabbath";
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[5].HeaderText = "PA";

            TxtNama.Clear();
            TxtNomorKamar.Clear();
            TxtMidweek.Clear();
            TxtVesper.Clear();
            TxtSabbath.Clear();
            TxtPA.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

}

        

    }
}
