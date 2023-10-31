using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

                try
                {
                    query = string.Format("insert into `tbl_user` (`Username/Email`, `Password`) VALUES ('{0}','{1}')", txtNewUsername.Text, txtMasterPassword.Text);

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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void FormSignUp_Paint(object sender, PaintEventArgs e)
        {

            // Create a rounded rectangle
            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            int radius = 20; // Adjust this value to control the roundness

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.Left, rect.Top, radius * 2, radius * 2, 180, 90);
            path.AddLine(rect.Left + radius, rect.Top, rect.Right - radius, rect.Top);
            path.AddArc(rect.Right - radius * 2, rect.Top, radius * 2, radius * 2, 270, 90);
            path.AddLine(rect.Right, rect.Top + radius, rect.Right, rect.Bottom - radius);
            path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddLine(rect.Right - radius, rect.Bottom, rect.Left + radius, rect.Bottom);
            path.AddArc(rect.Left, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
