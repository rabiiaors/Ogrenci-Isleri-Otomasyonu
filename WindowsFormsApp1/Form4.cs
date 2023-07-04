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
    public partial class Form4 : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-6D6HB79C;Initial Catalog=ogrenciisleri;Integrated Security=True");
        public Form4()
        {
            InitializeComponent();
        }
        // sql ile giris yapma 
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from yonetim where kullaniciadi='" + TextBox3.Text + "'and parola='" + TextBox4.Text + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                Form7 frm7 = new Form7();
                frm7.Show();
                TextBox3.Clear();
                TextBox4.Clear();
            }
            else
            {
                MessageBox.Show("kullanici adi veya sifre hatalidir.");
                TextBox3.Clear();
                TextBox4.Clear();
            }
            baglanti.Close();
         
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
           
        }
        //gizle goster kısmı
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                TextBox4.UseSystemPasswordChar = true;
                checkBox1.Text = "Gizle";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                TextBox4.UseSystemPasswordChar = false;
                checkBox1.Text = "Göster";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
