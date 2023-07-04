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
using System.Net.Mail;

namespace WindowsFormsApp1
{
    public partial class Form23 : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-6D6HB79C;Initial Catalog=ogrenciisleri;Integrated Security=True");
        public Form23()
        {
            InitializeComponent();
        }
        private void VerileriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from ogrencii", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["kullaniciadi"].ToString();
                ekle.SubItems.Add(oku["parola"].ToString());
                ekle.SubItems.Add(oku["kno"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }



        private void Form23_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2= new Form2();
            frm2.ShowDialog();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
           
    
          
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        //kullaniciadına göre sifre gösterme arama butonu
        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from ogrencii where kullaniciadi like '%" + TextBox1.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["kullaniciadi"].ToString();
                ekle.SubItems.Add(oku["parola"].ToString());
                ekle.SubItems.Add(oku["kno"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
    }
}
