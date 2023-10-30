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
            FormGenerator formGenerator = new FormGenerator();
            formGenerator.Show();
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
                tabel_item.Columns[0].Width = 200;
                tabel_item.Columns[0].HeaderText = "Title";
                tabel_item.Columns[1].Width = 200;
                tabel_item.Columns[1].HeaderText = "Username/Email";
                tabel_item.Columns[2].Width = 200;
                tabel_item.Columns[2].HeaderText = "Password";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void insertItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_item new_item = new New_item();
            new_item.Show();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
