﻿using System;
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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            KullaniciGirisi kGirisi = new KullaniciGirisi();
            kGirisi.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            yoneticisifre yyGirisi = new yoneticisifre();
            yyGirisi.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
