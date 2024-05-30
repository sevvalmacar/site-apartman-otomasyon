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
    public partial class gulmezaptgiris : Form
    {
        public gulmezaptgiris()
        {
            InitializeComponent();
        }

        private void gulmezaptgiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YoneticiGirisi yoneticiGirisi = new YoneticiGirisi();
            yoneticiGirisi.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gulmezoda gGirisi = new gulmezoda();
            gGirisi.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
