using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class RegistKamar : Form
    {
        public RegistKamar()
        {
            InitializeComponent();
        }

        private void RegistKamar_Load(object sender, EventArgs e)
        {

        }

        private void fsdfsdfToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentForm paymentForm = new PaymentForm();
            //paymentForm.MdiParent = this;
            paymentForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
