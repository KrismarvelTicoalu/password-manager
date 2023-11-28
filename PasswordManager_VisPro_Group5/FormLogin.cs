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

        private string userid;
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

                query = string.Format("select * from tbl_user where `Username` = '{0}'", txtUsernameOrEmail.Text, txtPassword.Text);
                ds.Clear();
                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                adapter.Fill(ds);
                
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow kolom in ds.Tables[0].Rows)
                    {
                        string sandi, namaPengguna, identitasWindows;
                        namaPengguna = kolom["Username"].ToString();

                        //decrypt the master password
                        if (kolom["MasterPassword"] is DBNull)
                        {
                            Console.WriteLine("Password is DB null");
                        }
                        else
                        {
                            string encrypted_data = kolom["MasterPassword"].ToString();
                            byte[] encrypted_password = Convert.FromBase64String(encrypted_data);

                            if (encrypted_data.Length == 0)
                            {
                                Console.WriteLine("Encrypted data is empty");
                            }
                            else
                            {
                                try
                                {

                                    kolom["MasterPassword"] = Protection.UnprotectData(encrypted_password);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Error decrypting data: " + ex.Message);
                                }
                            }
                        }
                        sandi = kolom["MasterPassword"].ToString();

                        identitasWindows = kolom["WindowsIdentity"].ToString();

                        koneksi.Close();

                        if (sandi == txtPassword.Text)
                        {
                            if (identitasWindows == currentWindowsUser)
                            {
                                userid = kolom["UserID"].ToString();
                                FormMain formMain = new FormMain(namaPengguna, userid);
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
                    koneksi.Close();
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
