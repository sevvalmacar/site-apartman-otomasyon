using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace apartman
{
    public partial class yenikullanıcıform : Form
    {
        public yenikullanıcıform()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LRO829J\SQLEXPRESS01;Initial Catalog=DbSite;Integrated Security=True");
        void ViewGridData()
        {
            try
            {
                con.Open();
                string query = "select * from Kisiler";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                dtrgrv.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            KullaniciGirisi kullanıcıgrs = new KullaniciGirisi();
            kullanıcıgrs.Show();
            this.Hide();
        }

        private void dtrgrv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void yenikullanıcıform_Load(object sender, EventArgs e)
        {
            ViewGridData();
        }
    }
}
