using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
        Sql sql = new Sql();

        private MySqlConnection koneksi;

        private string Username, Userid;

        public FormMain(string username, string userid)
        {
            koneksi = sql.SqlSetup("localhost", "db_password", "root", "");

            InitializeComponent();

            txtUsername.Text = username;
            Username = username;
            Userid = userid;    
            
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
            New_item insert_item = new New_item(Userid);

            try
            {
                string query = string.Format("Select `Title`, `UsernameOrEmail`, `Password`, `URL` from tbl_item where `UserID` = '{0}'", Userid);

                var (adapter, res) = sql.SqlQuery(query);

                DataSet ds = sql.SqlDatabase(adapter);

                // Decrypt the 'encrypted_password' column
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        if (row["Password"] is DBNull)
                        {
                            Console.WriteLine("Password is DB null");
                        }
                        else
                        {
                            string encrypted_data = row["Password"].ToString();
                            byte[] encrypted_password = Convert.FromBase64String(encrypted_data);

                            if (encrypted_data.Length == 0)
                            {
                                Console.WriteLine("Encrypted data is empty");
                            }
                            else
                            {
                                try
                                {
                                    
                                    row["Password"] = Protection.UnprotectData(encrypted_password);
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

                

                tabel_item.DataSource = ds.Tables[0];
                tabel_item.Columns[0].HeaderText = "Title";
                tabel_item.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                tabel_item.Columns[1].HeaderText = "Username/Email";
                tabel_item.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                tabel_item.Columns[2].HeaderText = "Password";
                tabel_item.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                tabel_item.Columns[3].HeaderText = "URL";
                tabel_item.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


                foreach (DataGridViewRow row in tabel_item.Rows)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    linkCell.Value = row.Cells["URL"].Value;
                    row.Cells["URL"] = linkCell;
                }



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
            // Check if the clicked cell is a DataGridViewLinkCell
            if (tabel_item[e.ColumnIndex, e.RowIndex] is DataGridViewLinkCell)
            {
                // Get the URL from the cell value
                string url = tabel_item[e.ColumnIndex, e.RowIndex].Value.ToString();

                // Open the URL in the default browser
                System.Diagnostics.Process.Start(url);
            }
            else if(tabel_item[e.ColumnIndex, e.RowIndex] is DataGridViewTextBoxCell)
            {
                string text = tabel_item[e.ColumnIndex, e.RowIndex].Value.ToString();

                Clipboard.SetText(text);
                MessageBox.Show("Copied");
            }
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
            formGenerator.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            New_item new_item = new New_item(Userid);
            new_item.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete_item delete_item = new Delete_item(Userid);
            delete_item.ShowDialog();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FormSearch form_search = new FormSearch(Userid);
            form_search.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

    }
}
