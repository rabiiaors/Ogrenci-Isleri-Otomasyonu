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
    public partial class Form2 : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-6D6HB79C;Initial Catalog=ogrenciisleri;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }
        //sql ile giris yapma
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from ogrencii where kullaniciadi='" + TextBox1.Text + "'and parola='" + TextBox2.Text + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {     this.Hide();
                Form5 frm5 = new Form5();
                frm5.Show();
                TextBox1.Clear();
                TextBox2.Clear();
            }
            else
            {
                MessageBox.Show("kullanici adi veya sifre hatalidir.");
                TextBox1.Clear();
                TextBox2.Clear();
            }
            baglanti.Close();
           

        }


        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                TextBox2.UseSystemPasswordChar = true;
                checkBox1.Text = "Gizle";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                TextBox2.UseSystemPasswordChar = false;
                checkBox1.Text = "Göster";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
      


    private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form23 frm23 = new Form23();
            frm23.Show();
        }
    }
}
