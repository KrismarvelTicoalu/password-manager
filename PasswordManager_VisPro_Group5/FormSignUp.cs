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
    public partial class FormSignUp : Form
    {
        private MySqlConnection koneksi;

        Sql sql = new Sql();
        public FormSignUp()
        {
            koneksi = sql.SqlSetup("localhost", "db_password", "root", "");

            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (txtMasterPassword.Text != txtConfirmMasterPassword.Text)
            {
                MessageBox.Show("Please confirm again your master password");
            }
            else
            {
                // Get the current Windows user
                WindowsIdentity windowsIdentity = WindowsIdentity.GetCurrent();
                string currentWindowsUser = windowsIdentity.Name;
                currentWindowsUser = currentWindowsUser.Replace("\\", "\\\\");

                try
                {
                    string encrypted_password = Convert.ToBase64String(Protection.ProtectData(txtMasterPassword.Text));
                    string query = string.Format("insert into `tbl_user` (`Username`, `MasterPassword` , `WindowsIdentity`) VALUES ('{0}','{1}','{2}')", txtNewUsername.Text, encrypted_password, currentWindowsUser);


                    var (adapter, res) = sql.SqlQuery(query);

                    if (res == 1)
                    {
                        MessageBox.Show("Account successfully created");

                        FormLogin formLogin = new FormLogin();
                        formLogin.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Insert data Error");
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    koneksi.Close();
                    MessageBox.Show("You've registered already. Try again if it's actually your first time registering");
                }
            }
        }

        private void FormSignUp_Paint(object sender, PaintEventArgs e)
        {
            RoundedCorner.CreateRoundedCorner(this);
        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPassword.Checked == true)
            {
                txtMasterPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtMasterPassword.UseSystemPasswordChar = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtConfirmMasterPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtConfirmMasterPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtConfirmMasterPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMasterPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
