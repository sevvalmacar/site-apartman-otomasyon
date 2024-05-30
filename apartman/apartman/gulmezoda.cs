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
    public partial class gulmezoda : Form
    {
        public gulmezoda()
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
                dtgrdv.DataSource = ds.Tables[0];
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
                ///dataGridViewapt.DataSource = ds.Tables[0];
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
            gulmezaptgiris yoneticiGirisi = new gulmezaptgiris();
            yoneticiGirisi.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gulmezoda_Load(object sender, EventArgs e)
        {
            ViewGridData();
            ViewGridDataapt();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            gulmezaptgiris gmgirisi = new gulmezaptgiris();
            gmgirisi.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd1 = new SqlCommand("insert into Kisiler values ('" + ID.Text + "','" + adsoyad.Text + "','" + telefon.Text + "','" + oturapt.Text+ "')", con);
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
            ViewGridData();
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ViewGridData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("Update Kisiler set AdSoyad='" + adsoyad.Text + "', Telefon='" + telefon.Text + "', OturduguApartman='" + oturapt.Text + "'where Id='" + ID.Text + "'", con);
                cmd1.ExecuteNonQuery();
                con.Close();
                ViewGridData();
                MessageBox.Show("KULLANICI BAŞARILI DÜZENLENDİ");
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string myquery = "delete from Kisiler where Id='" + ID.Text + "';";
            SqlCommand cmd = new SqlCommand(myquery, con);
            cmd.ExecuteNonQuery();
            con.Close();
            ViewGridData();

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtgrdv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
