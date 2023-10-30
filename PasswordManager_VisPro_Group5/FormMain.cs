using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PasswordManager_VisPro_Group5
{
    public partial class FormMain : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public FormMain()
        {
            alamat = "server=localhost; database=db_password; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void newPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void LoadData()
        {
            try
            {
                koneksi.Open();
                query = string.Format("Select * from tbl_item");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();


                tabel_item.DataSource = ds.Tables[0];
                tabel_item.Columns[0].HeaderText = "Title";
                tabel_item.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                tabel_item.Columns[1].HeaderText = "Username/Email";
                tabel_item.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                tabel_item.Columns[2].HeaderText = "Password";
                tabel_item.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadData();
            // #1

            foreach (Control control in this.Controls)
            {
                // #2
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    // #3
                    client.BackColor = ColorTranslator.FromHtml("#ffffff");
                    // 4#
                    break;
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void insertItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormGenerator formGenerator = new FormGenerator();
            formGenerator.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            New_item new_item = new New_item();
            new_item.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete_item delete_item = new Delete_item();
            delete_item.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void btnCreatePassword_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnCreatePassword_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
