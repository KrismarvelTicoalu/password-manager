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
    public partial class FormGenerator : Form
    {
        public FormGenerator()
        {
            InitializeComponent();
        }

        private string generate_password()
        {
            Random res = new Random();

            String str = "abcdefghijklmnopqrstuvwxyz0123456789";
            int size = Convert.ToInt32(length.Text);

            string ran = "";

            for (int i = 0; i < size; i++)
            {
                int x = res.Next(36);

                ran = ran + str[x];
            }

            return ran;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormGenerator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            generatedPassword.Text = generate_password();
            copyPassword.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(generatedPassword.Text);
            MessageBox.Show("Password copied");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormGenerator_Paint(object sender, PaintEventArgs e)
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
    }
}
