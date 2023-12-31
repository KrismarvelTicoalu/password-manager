﻿using MySql.Data.MySqlClient;
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

        private string Title, Userid;
        public FormUpdate(string title, string userid)
        {
            alamat = "server=localhost; database=db_password; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();

            Title = title;
            Userid = userid;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            string encrypted_password = Convert.ToBase64String(Protection.ProtectData(txtPassword.Text));
            string query = string.Format("UPDATE tbl_item SET `Title` = '{0}', `UsernameOrEmail` = '{1}', `Password` = '{2}', `URL` = '{3}' WHERE `Title` = '{4}' AND `UserID` = '{5}'", txtTitle.Text, txtUsernameEmail.Text, encrypted_password, txtUrl.Text, Title, Userid);
            MySqlCommand perintah = new MySqlCommand(query, koneksi);
            MySqlDataAdapter adapter = new MySqlDataAdapter(perintah);
            DataSet ds = new DataSet();
            int rowsUpdated = adapter.Fill(ds);
            koneksi.Close();

            // check if there is any row updated
            if (rowsUpdated > 0)
            {
                MessageBox.Show("Data is updated");
            }


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

        private void linkLabel1_Paint(object sender, PaintEventArgs e)
        {
            RoundedCorner.CreateRoundedCorner(this);
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnPasteUrl_Click(object sender, EventArgs e)
        {
            txtUrl.Text = Clipboard.GetText();
        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
            koneksi.Open();
            string query = string.Format("SELECT * FROM tbl_item WHERE Title = '{0}' AND `UserID` = '{1}'", Title, Userid);
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
                txtUsernameEmail.Text = row["UsernameOrEmail"].ToString();
                txtPassword.Text = row["Password"].ToString();
                txtUrl.Text = row["URL"].ToString();
            }
        }
    }
}
