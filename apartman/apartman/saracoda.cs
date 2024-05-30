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
    public partial class saracoda : Form
    {
        public saracoda()
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
        void ViewGridDataapt()
        {
            try
            {
                con.Open();
                string query = "select * from Apartmanlar";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                //dataGridViewapt.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saracaptgiris yoneticiGirisi = new saracaptgiris();
            yoneticiGirisi.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        public void dairedurumu()
        {
            int sayi = 101;
            foreach (Control btn in Controls)
            {
                if (btn is Button)
                {
                    if (btn.Name != "button19" && btn.Name == "button18")
                    {
                        btn.BackColor = Color.White;
                        btn.Text = "daire-" + sayi.ToString();
                        sayi++;

                    }

                }
            }
        }
        private void saracoda_Load(object sender, EventArgs e)
        {
          dairedurumu();
            ViewGridData();
            ViewGridDataapt();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            saracaptgiris smgirisi = new saracaptgiris();
            smgirisi.Show();
            this.Hide();
        }

        private void kisilerBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd1 = new SqlCommand("insert into Kisiler values ('" + ID.Text + "','" + adsoyad.Text + "','" + telefon.Text + "','" + oturapt.Text + "')", con);
                cmd1.ExecuteNonQuery();
                con.Close();
                ViewGridData();
                MessageBox.Show("KULLANICI BAŞARILI EKLENDİ");

            }
            catch
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
