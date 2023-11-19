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
        bool includeNumbers, includeCapital, includeSymbols;

        public FormGenerator()
        {
            InitializeComponent();
        }

        private string generate_password(bool isIncludeNumbers, bool isIncludeCapital, bool isIncludeSymbols)
        {

            Random res = new Random();

            String str = "abcdefghijklmnopqrstuvwxyz";
            
            // check if user wants to include numbers
            if (isIncludeNumbers == true )
            {
                str += "0123456789";
            }

            // check if user wants to include capital letters
            if (isIncludeCapital == true)
            {
                str += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }

            // check if user wants to include symbols
            if (isIncludeSymbols == true )
            {
                str += "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
            }


            int size = Convert.ToInt32(length.Text);

            string ran = "";

            for (int i = 0; i < size; i++)
            {
                int x = res.Next(str.Length);

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
            generatedPassword.Text = generate_password(includeNumbers, includeCapital, includeSymbols);
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
            RoundedCorner.CreateRoundedCorner(this);
        }

        private void isIncludeNumbers_CheckedChanged(object sender, EventArgs e)
        {
            if (isIncludeNumbers.Checked == true)
            {
                includeNumbers = true;
            }
            else
            {
                includeNumbers = false;
            }
        }

        private void isIncludeSymbols_CheckedChanged(object sender, EventArgs e)
        {
            if (isIncludeSymbols.Checked == true)
            {
                includeSymbols = true;
            }
            else
            {
                includeSymbols = false;
            }
        }

        private void isIncludeCapital_CheckedChanged(object sender, EventArgs e)
        {
            if (isIncludeCapital.Checked == true)
            {
                includeCapital = true;
            }
            else
            {
                includeCapital = false;
            }
        }
    }
}
