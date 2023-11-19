using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace PasswordManager_VisPro_Group5
{
    public partial class FormLogin : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public FormLogin()
        {
            alamat = "server=localhost; database=db_password; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                WindowsIdentity windowsIdentity = WindowsIdentity.GetCurrent();
                string currentWindowsUser = windowsIdentity.Name;

                query = string.Format("select * from tbl_user where `Username` = '{0}' and `MasterPassword` = '{1}'", txtUsernameOrEmail.Text, txtPassword.Text);
                ds.Clear();
                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                adapter.Fill(ds);
                koneksi.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow kolom in ds.Tables[0].Rows)
                    {
                        string sandi, namaPengguna, identitasWindows;
                        namaPengguna = kolom["Username"].ToString();
                        sandi = kolom["MasterPassword"].ToString();
                        identitasWindows = kolom["WindowsIdentity"].ToString();
                        identitasWindows = identitasWindows.Replace("\\\\", "\\");
                        if (sandi == txtPassword.Text && namaPengguna == txtUsernameOrEmail.Text)
                        {
                            if (identitasWindows == currentWindowsUser)
                            {
                                FormMain formMain = new FormMain(namaPengguna, identitasWindows);
                                formMain.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Please log in to your windows account first");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Anda salah input password");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Username not found, please sign up first");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
   
        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSignUp formSignUp = new FormSignUp();
            formSignUp.Show();
            this.Hide();
        }

        private void FormLogin_Paint(object sender, PaintEventArgs e)
        {
            RoundedCorner.CreateRoundedCorner(this);
        }
    }
}
