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
    public partial class YoneticiGirisi : Form
    {
        public YoneticiGirisi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult yardım;
            yardım = MessageBox.Show("Gülmez Apartmanı Girişi\n tc:11111111111\n" +
                " şifre: hatice\nSaraç Apartmanı Girişi\n tc:22222222222\n " +
                "şifre:zeynep\n Macar Apartmanı Girişi\n tc:33333333333\n " +
                "şifre: şevo", "UYARI" ,MessageBoxButtons.OKCancel);
            if (yardım != DialogResult.OK)
            {
                Giris.ActiveForm.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yoneticisifre cgGirisi = new yoneticisifre();
            cgGirisi.Show();
            this.Hide();

        }

        private void yonbtnm_Click(object sender, EventArgs e)
        {
            if( mcrmtxt.Text == "33333333333" && mcrtxt.Text == "şevo")
            {
                macaraptgiris git = new macaraptgiris();
                git.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("T.C. Kimlik veya Şifre Hatalı", "HATA");
                mcrmtxt.Clear();
                mcrtxt.Text = "";
            }


        }

        private void ıptalm_Click(object sender, EventArgs e)
        {
            mcrmtxt.Clear();
            mcrtxt.Text = "";
        }

        private void yonbtns_Click(object sender, EventArgs e)
        {
          


            if (gulmazmtxt.Text == "11111111111" && gulmeztxt.Text == "hatice")
            {
               gulmezaptgiris git = new gulmezaptgiris();
                git.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("T.C. Kimlik veya Şifre Hatalı", "HATA");
                gulmazmtxt.Clear();
                gulmeztxt.Text = "";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            gulmazmtxt.Clear();
            gulmeztxt.Text = "";

        }

        private void yonbtng_Click(object sender, EventArgs e)
        {

            if (saracmtxt.Text == "22222222222" && saractxt.Text == "zeynep")
            {
                saracaptgiris git = new saracaptgiris();
                git.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("T.C. Kimlik veya Şifre Hatalı", "HATA");
                saracmtxt.Clear();
                saractxt.Text = "";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            saracmtxt.Clear();
            saractxt.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
