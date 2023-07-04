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
    public partial class Form3 : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-6D6HB79C;Initial Catalog=ogrenciisleri;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }
        //sql ile giris yapma
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from ogretmenn where kullaniciadi='" + textBox1.Text + "'and parola='" + TextBox3.Text + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                Form6 frm6 = new Form6();
                frm6.Show();
                textBox1.Clear();
                TextBox3.Clear();
            }
            else
            {
                MessageBox.Show("kullanici adi veya sifre hatalidir.");
                textBox1.Clear();
                TextBox3.Clear();
            }
            baglanti.Close();
           
        }
        //gizle göster kısmı
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
 

            if (checkBox1.CheckState == CheckState.Checked)
            {
                TextBox3.UseSystemPasswordChar = true;
                checkBox1.Text = "Gizle";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                TextBox3.UseSystemPasswordChar = false;
                checkBox1.Text = "Göster";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form19 frm19 = new Form19();
            frm19.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form26 frm26 = new Form26();
            frm26.Show();
        }
    }
}
