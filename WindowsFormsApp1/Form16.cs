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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm5 = new Form5();
            frm5.ShowDialog();
        }
    }
}
