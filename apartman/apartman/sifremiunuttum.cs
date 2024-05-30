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
    public partial class sifremiunuttum : Form
    {
        public sifremiunuttum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciGirisi kkGirisi = new KullaniciGirisi();
            kkGirisi.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult yardım;
            yardım = MessageBox.Show("Şifre yenileme linkiniz e-posta hesabınıza gönderilmiştir.", "DİKKAT", MessageBoxButtons.OKCancel);
            if (yardım != DialogResult.OK)
                
            {
                Giris.ActiveForm.Close();
            }
        }
    }
}
