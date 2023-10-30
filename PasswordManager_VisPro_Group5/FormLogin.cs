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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtUsernameOrEmail.Text == "")
            {
                if (txtPassword.Text == "")
                {
                    FormMain formMain = new FormMain();
                    formMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong password");
                }
            }
            else if (txtPassword.Text == "")
            {
                if (txtUsernameOrEmail.Text == "")
                {
                    FormMain formMain = new FormMain();
                    formMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong username or email");
                }
            }
            else
            {
                MessageBox.Show("Wrong username/email and password");
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
    }
}
