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
    public partial class ödemelergiriş : Form
    {
        public ödemelergiriş()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ödemelergiriş_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            elektriködeme1 elektirikfrm = new elektriködeme1();
            elektirikfrm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KullaniciGirisi odemelerg = new KullaniciGirisi();
            odemelerg.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            suodeme sufrm = new suodeme();
            sufrm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            aidatodeform aıdatodefrm = new aidatodeform();
            aıdatodefrm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            asansorodemefrm asansorodefrm = new asansorodemefrm();
            asansorodefrm.Show();
            this.Hide();
        }
    }
}
