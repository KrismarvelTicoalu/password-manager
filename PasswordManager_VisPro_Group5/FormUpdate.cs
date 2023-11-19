using MySql.Data.MySqlClient;
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
    public partial class FormUpdate : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        private string Title;
        public FormUpdate(string title)
        {
            alamat = "server=localhost; database=db_password; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();

            Title = title;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            string encrypted_password = Convert.ToBase64String(Protection.ProtectData(txtPassword.Text));
            string query = string.Format("UPDATE tbl_item SET `Title` = '{0}', `Username/Email` = '{1}', `Password` = '{2}' WHERE `Title` = '{3}'", txtTitle.Text, txtUsernameEmail.Text, encrypted_password, Title);
            MySqlCommand perintah = new MySqlCommand(query, koneksi);
            MySqlDataAdapter adapter = new MySqlDataAdapter(perintah);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            koneksi.Close();

            FormMain mainForm = (FormMain)Application.OpenForms["FormMain"];
            if (mainForm != null)
            {
                mainForm.LoadData(); // Call the method to refresh the DataGridView
            }
        }

        private void btnCopyUsername_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtUsernameEmail.Text);
            MessageBox.Show("Username/Email copied");
        }

        private void btnPastePassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = Clipboard.GetText();
        }

        private void btnCopyPassword_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPassword.Text);
            MessageBox.Show("Password copied");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormGenerator generator = new FormGenerator();
            generator.ShowDialog();
        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
            koneksi.Open();
            string query = string.Format("SELECT * FROM tbl_item WHERE Title = '{0}'", Title);
            MySqlCommand perintah = new MySqlCommand(query, koneksi);
            MySqlDataAdapter adapter = new MySqlDataAdapter(perintah);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            koneksi.Close();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string encrypted_data = row["Password"].ToString();
                byte[] encrypted_password = Convert.FromBase64String(encrypted_data);
                row["Password"] = Protection.UnprotectData(encrypted_password);

                txtTitle.Text = row["Title"].ToString();
                txtUsernameEmail.Text = row["Username/Email"].ToString();
                txtPassword.Text = row["Password"].ToString();
            }
        }
    }
}
