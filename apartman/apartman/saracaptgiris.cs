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
    public partial class saracaptgiris : Form
    {
        public saracaptgiris()
        {
            InitializeComponent();
        }

        private void saracaptgiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YoneticiGirisi yGirisi = new YoneticiGirisi();
            yGirisi.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            saracoda sGirisi = new saracoda();
            sGirisi.Show();
            this.Hide();
        }

        private void saracaptgiris_Load(object sender, EventArgs e)
        {

        }
    }
}
