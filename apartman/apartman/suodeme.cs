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
    public partial class suodeme : Form
    {
        public suodeme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ödemelergiriş odemelergrs= new ödemelergiriş();
            odemelergrs.Show();
            this.Hide();
        }

        private void odebtn_Click(object sender, EventArgs e)
        {
            DialogResult yardım;
            yardım = MessageBox.Show("SU BORCUNUZ ÖDENMİŞTİR", "UYARI", MessageBoxButtons.OKCancel);
            if (yardım != DialogResult.OK)
            {
                Giris.ActiveForm.Close();
            }
        }
    }
}
