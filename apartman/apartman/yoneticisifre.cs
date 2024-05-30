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
    public partial class yoneticisifre : Form
    {
        public yoneticisifre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kllancıgrstxt.Text == "simgesitesi" && sifregrstxt.Text == "simge123")
            {
                YoneticiGirisi git = new YoneticiGirisi();
                git.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya Şifre Hatalı", "HATA");
                kllancıgrstxt.Clear();
                kllancıgrstxt.Text = "";
            }


           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Giris gGirisi = new Giris();
            gGirisi.Show();
            this.Hide();
        }
    }
}
