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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void newPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGenerator formGenerator = new FormGenerator();
            formGenerator.Show();

            // Create a task that will delay for 10 seconds
            Task.Delay(TimeSpan.FromSeconds(2))
                // Continue with a statement that will print "Hello" to the console
                .ContinueWith(t => passwordList.Rows[0].Cells["Password"].Value = "r3W@47V78M");

            

            
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            passwordList.Rows[0].Cells[0].Value = "";
            passwordList.Rows[0].Cells[1].Value = "";
            passwordList.Rows[0].Cells[2].Value = "";
        }
    }
}
