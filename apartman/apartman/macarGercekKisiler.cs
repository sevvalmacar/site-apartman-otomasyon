using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace apartman
{
    public partial class macarGercekKisiler : Form
    {
        public macarGercekKisiler()
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
                dtgrview.DataSource = ds.Tables[0];
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
                dataGridViewapt.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }
        private void macarGercekKisiler_Load(object sender, EventArgs e)
        {
            ViewGridData();
            ViewGridDataapt();
            // TODO: This line of code loads data into the 'dbSiteDataSet.Kisiler' table. You can move, or remove it, as needed.
            //this.kisilerTableAdapter.Fill(this.dbSiteDataSet.Kisiler);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

     
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            macaraptgiris mmgirisi = new macaraptgiris();
            mmgirisi.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ViewGridData();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("Update Kisiler set Name='" + adsoyad.Text + "', Password='" + telefon.Text + "'where Username='" + oturapt.Text + "'", con);
                cmd1.ExecuteNonQuery();
                con.Close();
                ViewGridData();
                MessageBox.Show("KULLANICI BAŞARILI DÜZENLENDİ");
            }
            catch
            {

            }
        }
    }
}
