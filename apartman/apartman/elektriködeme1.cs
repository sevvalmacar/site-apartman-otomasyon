using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apartman
{
    public partial class elektriködeme1 : Form
    {
        public elektriködeme1()
        {
            InitializeComponent();
        }
        private void elektriködeme_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void geribtn_Click(object sender, EventArgs e)
        {
            ödemelergiriş oGirisi = new ödemelergiriş();
            oGirisi.Show();
            this.Hide();
        }

        private void odebtn_Click(object sender, EventArgs e)
        {

            DialogResult yardım;
            yardım = MessageBox.Show("BORCUNUZ ÖDENMİŞTİR", "UYARI", MessageBoxButtons.OKCancel);
            if (yardım != DialogResult.OK)
            {
                Giris.ActiveForm.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
