using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototypeapp
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Poin poin = new Poin();
            poin.Show();
            this.Hide();
        }

        private void BtnSeatting_Click(object sender, EventArgs e)
        {
            seatting seattingg = new seatting();
            seattingg.Show();   
            this.Hide();    
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {

        }

        private void BtnDaftar_Click(object sender, EventArgs e)
        {
            namamahasiswa namamahasiswaa = new namamahasiswa(); 
            namamahasiswaa.Show();
            this.Hide();
        }
    }
}
