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

        private DataSet ds1 = new DataSet();
        private DataSet ds2 = new DataSet();
        private string alamat, query;

        private string Username, Identity;

        public FormMain(string username, string identity)
        {
            alamat = "server=localhost; database=db_password; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();

            txtUsername.Text = username;
            Username = username;
            Identity = identity;
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
            New_item insert_item = new New_item(Identity);

            try
            {
                koneksi.Open();
                query = string.Format("Select `Title`, `Username/Email`, `Password` from tbl_item where `WindowsIdentity` = '{0}'", Identity.Replace("\\", "\\\\"));
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds2.Clear();
                adapter.Fill(ds2);

                // Decrypt the 'encrypted_password' column
                if (ds2.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds2.Tables[0].Rows)
                    {
                        if (row["Password"] is DBNull)
                        {
                            Console.WriteLine("Password is DB null");
                        }
                        else
                        {
                            byte[] encrypted_data = (byte[])row["Password"];
                            if (encrypted_data.Length == 0)
                            {
                                Console.WriteLine("Encrypted data is empty");
                            }
                            else
                            {
                                try
                                {
                                    row["Password"] = Protection.UnprotectData(encrypted_data);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Error decrypting data: " + ex.Message);
                                }
                            }
                        }
                    }

                }

                koneksi.Close();

                

                tabel_item.DataSource = ds2.Tables[0];
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
            New_item new_item = new New_item(Identity);
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

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
