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
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }
        SqlConnection baglanti1 = new SqlConnection("Data Source=LAPTOP-6D6HB79C;Initial Catalog=ogrenciisleri;Integrated Security=True");




        //sqlden veri getirir
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
        //ogrenci adına göre arama yapar
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

        private void Form24_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            VerileriGoster();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 frm6 = new Form6();
            frm6.ShowDialog();
        }
    }
}
