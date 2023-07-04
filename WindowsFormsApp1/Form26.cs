using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form26 : Form
    {
        public Form26()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-6D6HB79C;Initial Catalog=ogrenciisleri;Integrated Security=True");
        private void VerileriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from ogretmenn", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["kullaniciadi"].ToString();
                ekle.SubItems.Add(oku["parola"].ToString());
                ekle.SubItems.Add(oku["mno"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }


        private void button11_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void Form26_Load(object sender, EventArgs e)
        {

        }
        //kullanıcıadına göre arama yapar
        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from ogretmenn where kullaniciadi like '%" + TextBox1.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["kullaniciadi"].ToString();
                ekle.SubItems.Add(oku["parola"].ToString());
                ekle.SubItems.Add(oku["mno"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
    }
}
