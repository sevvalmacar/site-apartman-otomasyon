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
    public partial class KullaniciGirisi : Form
    {
        public KullaniciGirisi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Giris dGirisi = new Giris();
            dGirisi.Show();
            this.Hide();
        }

       
        private void button4_Click(object sender, EventArgs e)
        {

            ödemelergiriş ödemelergiriş = new ödemelergiriş();
            ödemelergiriş.Show();
            this.Hide();

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sifremiunuttum sifre = new sifremiunuttum();
            sifre.Show();
            this.Hide();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

            yenikullanıcıform yenıkllnıcı = new yenikullanıcıform();
            yenıkllnıcı.Show();
            this.Hide();
        }
    }

    }

