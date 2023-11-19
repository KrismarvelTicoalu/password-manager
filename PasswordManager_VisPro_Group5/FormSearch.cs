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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace PasswordManager_VisPro_Group5
{
    public partial class FormSearch : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        public FormSearch()
        {
            alamat = "server=localhost; database=db_password; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void FormSearch_Paint(object sender, PaintEventArgs e)
        {
            RoundedCorner.CreateRoundedCorner(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void addItem_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                string query = string.Format("SELECT * FROM tbl_item WHERE Title = '{0}'", txtTitle.Text);
                MySqlCommand perintah = new MySqlCommand(query, koneksi);
                MySqlDataAdapter adapter = new MySqlDataAdapter(perintah);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                koneksi.Close();

                //Dpe MessageBox
                StringBuilder resultMessage = new StringBuilder();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    FormUpdate formUpdate = new FormUpdate(txtTitle.Text);
                    this.Close();
                    formUpdate.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Tidak ditemukan catatan yang cocok.", "Hasil Pencarian");
                }

                // Mengasumsikan LoadData() adalah metode yang menyegarkan data dalam antarmuka pengguna Anda
                // Panggil LoadData() langsung untuk memperbarui data di antarmuka pengguna
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Kesalahan");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
