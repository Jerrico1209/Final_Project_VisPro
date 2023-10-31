using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMH form9 = new FrmMH();
            form9.Show();
            this.Hide();
        }

        private void BtnInsertKepas_Click(object sender, EventArgs e)
        {
            FrmKepas kepas = new FrmKepas();
            kepas.Show();
            this.Hide();
            
        }

        private void BtnInsertMonitor_Click(object sender, EventArgs e)
        {
            FrmMonitor monitor = new FrmMonitor();
            monitor.Show();
            this.Hide();
        }

        private void BtnSetelan_Click(object sender, EventArgs e)
        {
            FrmSetting setting = new FrmSetting();
            setting.Show();
            this.Hide();
        }
    }
}
