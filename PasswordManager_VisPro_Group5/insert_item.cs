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
        public New_item()
        {
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
                query = string.Format("insert into `tbl_item` (`Title`, `Username/Email`, `Password`) VALUES ('{0}','{1}', '{2}')", txtTitle.Text, txtUsernameEmail.Text, txtPassword.Text);

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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
