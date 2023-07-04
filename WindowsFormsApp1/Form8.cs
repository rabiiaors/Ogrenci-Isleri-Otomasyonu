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
    public partial class Form8 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public Form8()
        {
            InitializeComponent();
        }
        void ogretmennGetir()
        {
            baglanti = new SqlConnection("server=.;Initial Catalog=ogrenciisleri;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM ogretmenn", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        void ogrenciiGetir()
        {
            baglanti = new SqlConnection("server=.;Initial Catalog=ogrenciisleri;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM ogrencii", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
            baglanti.Close();
        }



        //ekle butonu
        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO ogretmenn(tc,isimsoyisim,kullaniciadi,parola,telefon,brans) VALUES (@tc,@isimsoyisim,@kullaniciadi,@parola,@telefon,@brans)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@tc", textBox1.Text);
            komut.Parameters.AddWithValue("@isimsoyisim", textBox2.Text);
            komut.Parameters.AddWithValue("@kullaniciadi", textBox3.Text);
            komut.Parameters.AddWithValue("@parola", textBox4.Text);
            komut.Parameters.AddWithValue("@telefon", textBox5.Text);
            komut.Parameters.AddWithValue("@brans", textBox6.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ogretmennGetir();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            ogretmennGetir();
            ogrenciiGetir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox8.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox9.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox10.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBox11.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            textBox12.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textBox13.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            textBox14.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
        }
        //ekleme butonu
        private void button4_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO ogrencii(tc,isimsoyisim,kullaniciadi,parola,telefon,bolum) VALUES (@tc,@isimsoyisim,@kullaniciadi,@parola,@telefon,@bolum)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@tc", textBox8.Text);
            komut.Parameters.AddWithValue("@isimsoyisim", textBox9.Text);
            komut.Parameters.AddWithValue("@kullaniciadi", textBox10.Text);
            komut.Parameters.AddWithValue("@parola", textBox11.Text);
            komut.Parameters.AddWithValue("@telefon", textBox12.Text);
            komut.Parameters.AddWithValue("@bolum", textBox13.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ogrenciiGetir();
        }
        //sil butonu
        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM ogretmenn WHERE mno=@mno";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@mno", Convert.ToInt32(textBox7.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ogretmennGetir();
        }
        //sil butonu
        private void button5_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM ogrencii WHERE kno=@kno";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kno", Convert.ToInt32(textBox14.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ogrenciiGetir();
        }
        //gıncelleme butonu
        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE ogretmenn SET tc=@tc,isimsoyisim=@isimsoyisim,kullaniciadi=@kullaniciadi,parola=@parola,telefon=@telefon,brans=@brans WHERE mno=@mno";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@tc", textBox1.Text);
            komut.Parameters.AddWithValue("@isimsoyisim", textBox2.Text);
            komut.Parameters.AddWithValue("@kullaniciadi", textBox3.Text);
            komut.Parameters.AddWithValue("@parola", textBox4.Text);
            komut.Parameters.AddWithValue("@telefon", textBox5.Text);
            komut.Parameters.AddWithValue("@brans", textBox6.Text);
            komut.Parameters.AddWithValue("@mno", Convert.ToInt32(textBox7.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ogretmennGetir();
        }
        //guncelleme butonu
        private void button6_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE ogrencii SET tc=@tc,isimsoyisim=@isimsoyisim,kullaniciadi=@kullaniciadi,parola=@parola,telefon=@telefon,bolum=@bolum WHERE kno=@kno";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@tc", textBox8.Text);
            komut.Parameters.AddWithValue("@isimsoyisim", textBox9.Text);
            komut.Parameters.AddWithValue("@kullaniciadi", textBox10.Text);
            komut.Parameters.AddWithValue("@parola", textBox11.Text);
            komut.Parameters.AddWithValue("@telefon", textBox12.Text);
            komut.Parameters.AddWithValue("@bolum", textBox13.Text);
            komut.Parameters.AddWithValue("@kno", Convert.ToInt32(textBox14.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ogrenciiGetir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 frm7 = new Form7();
            frm7.ShowDialog();
        }
    }
}
