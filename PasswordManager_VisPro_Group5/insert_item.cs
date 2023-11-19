using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class New_item : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        private string id;
        public New_item(string identity)
        {
            id = identity;
            alamat = "server=localhost; database=db_password; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void new_item_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                id = id.Replace("\\", "\\\\");
                string encrypted_password = Convert.ToBase64String(Protection.ProtectData(txtPassword.Text));

                query = string.Format("insert into `tbl_item` (`Title`, `Username/Email`, `Password`, `URL`, `WindowsIdentity`) VALUES ('{0}','{1}', '{2}', '{3}', '{4}')", txtTitle.Text, txtUsernameEmail.Text, encrypted_password, txtUrl.Text, id);

                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();

                koneksi.Close();
                if (res == 1)
                {
                    MessageBox.Show("Insert data success");

                    FormMain mainForm = (FormMain)Application.OpenForms["FormMain"];
                    if (mainForm != null)
                    {
                        mainForm.LoadData(); // Call the method to refresh the DataGridView
                    }

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void New_item_Paint(object sender, PaintEventArgs e)
        {
            RoundedCorner.CreateRoundedCorner(this);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            txtPassword.Text = Clipboard.GetText();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormGenerator generator = new FormGenerator();
            generator.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUrl.Text = Clipboard.GetText();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
