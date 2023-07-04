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
    public partial class Form19 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public Form19()
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


        private void Form19_Load(object sender, EventArgs e)
        {
            ogretmennGetir();


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
        //guncelle butonu
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }
    }
}
