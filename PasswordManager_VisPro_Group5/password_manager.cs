using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager_VisPro_Group5
{
    public partial class password_manager : Form
    {
        public password_manager()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            CrystalReport1 cr1 = new CrystalReport1();

            cr1.SetParameterValue("Nama user windows", textBox1.Text);
            crystalReportViewer1.ReportSource = cr1;
            crystalReportViewer1.Refresh();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
