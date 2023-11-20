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
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public FormSignUp()
        {
            alamat = "server=localhost; database=db_password; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
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
                currentWindowsUser = currentWindowsUser.Replace("AVEL\\", "");

                try
                {
                    string encrypted_password = Convert.ToBase64String(Protection.ProtectData(txtMasterPassword.Text));
                    query = string.Format("insert into `tbl_user` (`Username`, `MasterPassword` , `WindowsIdentity`) VALUES ('{0}','{1}','{2}')", txtNewUsername.Text, encrypted_password, currentWindowsUser);

                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();

                    koneksi.Close();
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
                    MessageBox.Show("Your username already registered");
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
    }
}
