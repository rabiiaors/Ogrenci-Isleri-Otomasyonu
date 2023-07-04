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

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection baglanti1 = new SqlConnection("Data Source=LAPTOP-6D6HB79C;Initial Catalog=ogrenciisleri;Integrated Security=True");



        //verileri gösterir
        private void VerileriGoster()
        {
        listView1.Items.Clear();
            baglanti1.Open();
            SqlCommand komut = new SqlCommand("Select *from ogretmenn", baglanti1);
        SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text =oku["isimsoyisim"].ToString();
                ekle.SubItems.Add(oku["tc"].ToString());
                ekle.SubItems.Add(oku["kullaniciadi"].ToString()); 
                ekle.SubItems.Add(oku["parola"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["brans"].ToString());
                ekle.SubItems.Add(oku["mno"].ToString());

                listView1.Items.Add(ekle);
            }
    baglanti1.Close();
        }


        //verileri gösterir

        private void bilgileriGoster()
        {
            listView2.Items.Clear();
            baglanti1.Open();
            SqlCommand komut = new SqlCommand("Select *from ogrencii", baglanti1);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["isimsoyisim"].ToString();
                ekle.SubItems.Add(oku["tc"].ToString());
                ekle.SubItems.Add(oku["kullaniciadi"].ToString());
                ekle.SubItems.Add(oku["parola"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["bolum"].ToString());
                ekle.SubItems.Add(oku["kno"].ToString());

                listView2.Items.Add(ekle);
            }
            baglanti1.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {   
            VerileriGoster();
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
        //listvievden isime göre arama yapma
        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti1.Open();
            SqlCommand komut = new SqlCommand("Select *from ogretmenn where isimsoyisim like '%" + textBox1.Text + "%'", baglanti1);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["isimsoyisim"].ToString();
                ekle.SubItems.Add(oku["tc"].ToString());
                ekle.SubItems.Add(oku["kullaniciadi"].ToString());
                ekle.SubItems.Add(oku["parola"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["brans"].ToString());
                ekle.SubItems.Add(oku["mno"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti1.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bilgileriGoster();
        }
       //ögrenci adına göre arama yapar
        private void button6_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            baglanti1.Open();
            SqlCommand komut = new SqlCommand("Select *from ogrencii where isimsoyisim like '%" + textBox2.Text + "%'", baglanti1);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["isimsoyisim"].ToString();
                ekle.SubItems.Add(oku["tc"].ToString());
                ekle.SubItems.Add(oku["kullaniciadi"].ToString());
                ekle.SubItems.Add(oku["parola"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["bolum"].ToString());
                ekle.SubItems.Add(oku["kno"].ToString());

                listView2.Items.Add(ekle);
            }
            baglanti1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 frm8 = new Form8();
            frm8.ShowDialog();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 frm10 = new Form10();
            frm10.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 frm9 = new Form9();
            frm9.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }
    }
}
