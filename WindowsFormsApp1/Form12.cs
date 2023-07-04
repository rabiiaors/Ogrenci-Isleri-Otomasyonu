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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        SqlConnection baglanti1 = new SqlConnection("Data Source=LAPTOP-6D6HB79C;Initial Catalog=ogrenciisleri;Integrated Security=True");



        //sqlden verileri getirir
        private void VerileriGoster()
        {
            listView1.Items.Clear();
            baglanti1.Open();
            SqlCommand komut = new SqlCommand("Select *from nott where ogrenciadi like '%" + textBox1.Text + "%'", baglanti1);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ogrenciadi"].ToString();
                ekle.SubItems.Add(oku["notu"].ToString());
                ekle.SubItems.Add(oku["mno"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti1.Close();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ogrenciisleriDataSet3.not' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.notTableAdapter.Fill(this.ogrenciisleriDataSet3.not);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            VerileriGoster();
        }
        //isme göre arama yapar
        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti1.Open();
            SqlCommand komut = new SqlCommand("Select *from nott where ogrenciadi like '%" + textBox1.Text + "%'", baglanti1);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ogrenciadi"].ToString();
                ekle.SubItems.Add(oku["notu"].ToString());
                ekle.SubItems.Add(oku["mno"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti1.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm5 = new Form5();
            frm5.ShowDialog();
        }
    }
}
