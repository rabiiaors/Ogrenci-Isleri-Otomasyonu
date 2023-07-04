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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        SqlConnection baglanti1 = new SqlConnection("Data Source=LAPTOP-6D6HB79C;Initial Catalog=ogrenciisleri;Integrated Security=True");



        //sqlden veri getiren fonksiyon
        private void VerileriGoster()
        {
            listView1.Items.Clear();
            baglanti1.Open();
            SqlCommand komut = new SqlCommand("Select *from derss", baglanti1);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ogrenciadi"].ToString();
                ekle.SubItems.Add(oku["odevi"].ToString());
                ekle.SubItems.Add(oku["kno"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti1.Close();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ogrenciisleriDataSet2.ders' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dersTableAdapter.Fill(this.ogrenciisleriDataSet2.ders);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            VerileriGoster();
        }
        //ogrenciadına göre arama yapar
        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti1.Open();
            SqlCommand komut = new SqlCommand("Select *from derss where ogrenciadi like '%" + textBox1.Text + "%'", baglanti1);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ogrenciadi"].ToString();
                ekle.SubItems.Add(oku["odevi"].ToString());
                ekle.SubItems.Add(oku["kno"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti1.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm5 = new Form5();
            frm5.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
