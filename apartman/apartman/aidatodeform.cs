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
    public partial class aidatodeform : Form
    {
        public aidatodeform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ödemelergiriş odemegrs = new ödemelergiriş();
            odemegrs.Show();
            this.Hide();
        }

        private void odebtn_Click(object sender, EventArgs e)
        {
            DialogResult yardım;
            yardım = MessageBox.Show("AİDAT BORCUNUZ ÖDENMİŞTİR", "UYARI", MessageBoxButtons.OKCancel);
            if (yardım != DialogResult.OK)
            {
                Giris.ActiveForm.Close();
            }
        }
    }
}
