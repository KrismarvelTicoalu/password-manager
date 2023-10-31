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
    public partial class Delete_item : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public Delete_item()
        {
            alamat = "server=localhost; database=db_password; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_item_Paint(object sender, PaintEventArgs e)
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

        private void Delete_item_Load(object sender, EventArgs e)
        {

        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("delete from tbl_item where Title = '{0}'", txtTitle.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                MessageBox.Show("Delete data Success");
                FormMain mainForm = (FormMain)Application.OpenForms["FormMain"];
                mainForm.LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
