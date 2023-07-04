using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 frm11 = new Form11();
            frm11.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 frm12 = new Form12();
            frm12.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 frm13 = new Form13();
            frm13.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form17 frm17 = new Form17();
            frm17.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form14 frm14 = new Form14();
            frm14.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form15 frm15 = new Form15();
            frm15.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form16 frm16 = new Form16();
            frm16.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form18 frm18 = new Form18();
            frm18.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
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
