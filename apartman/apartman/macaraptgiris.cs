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
    public partial class macaraptgiris : Form
    {
        private object form;

        public macaraptgiris()
        {
            InitializeComponent();
        }

        private void macaraptgiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            YoneticiGirisi aGirisi = new YoneticiGirisi();
            aGirisi.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void macaraptgiris_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_4(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            macarGercekKisiler mcrapt = new macarGercekKisiler();
            mcrapt.Show();
            this.Hide();
        }
    }
}
