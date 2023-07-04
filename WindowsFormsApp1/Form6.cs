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
    public partial class Form6 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection baglanti1 = new SqlConnection("Data Source=LAPTOP-6D6HB79C;Initial Catalog=ogrenciisleri;Integrated Security=True");
        void nottGetir()
        {
            baglanti = new SqlConnection("server=.;Initial Catalog=ogrenciisleri;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM nott", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        void derssGetir()
        {
            baglanti = new SqlConnection("server=.;Initial Catalog=ogrenciisleri;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM derss", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
            baglanti.Close();
        }
        //sqlden ogrenci verilerini listvieve getir
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form25 frm25 = new Form25();
            frm25.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form24 frm24 = new Form24();
            frm24.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 frm9 = new Form9();
            frm9.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bilgileriGoster();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            derssGetir();
            nottGetir();

        }
        //listvievde ogrenci adi ile arama butonu
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


        // ekle buttonu
        private void button8_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO nott(ogrenciadi,notu) VALUES (@ogrenciadi,@notu)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ogrenciadi", textBox1.Text);
            komut.Parameters.AddWithValue("@notu", textBox3.Text);
           
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            nottGetir();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO derss(ogrenciadi,odevi) VALUES (@ogrenciadi,@odevi)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ogrenciadi", textBox5.Text);
            komut.Parameters.AddWithValue("@odevi", textBox6.Text);
          
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            derssGetir();
        }


        //sil buttonu
        private void button5_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM nott WHERE mno=@mno";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@mno", Convert.ToInt32(textBox4.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            nottGetir();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM derss WHERE kno=@kno";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kno", Convert.ToInt32(textBox7.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            derssGetir();
        }
        //güncelle buttonu
        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE nott SET ogrenciadi=@ogrenciadi, notu=@notu WHERE mno=@mno";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ogrenciadi", textBox1.Text);
            komut.Parameters.AddWithValue("@notu", textBox3.Text);
            komut.Parameters.AddWithValue("@mno", Convert.ToInt32(textBox4.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            nottGetir();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE derss SET ogrenciadi=@ogrenciadi, odevi=@odevi WHERE kno=@kno";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ogrenciadi", textBox5.Text);
            komut.Parameters.AddWithValue("@odevi", textBox6.Text);
            komut.Parameters.AddWithValue("@kno", Convert.ToInt32(textBox7.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            derssGetir();
        }
        //datagrind viev içi 
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
           
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox5.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox6.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox7.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }
    }
}
