using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (toplama.Checked == true)
            {
                int sayi=Convert.ToInt32(x.Text);
                
                int sayi2=Convert.ToInt32(y.Text);
                
                textBox1.Text = (sayi+sayi2).ToString();
            }

            else 
            {
                int sayi= Convert.ToInt32(x.Text);
               
                int sayi2=Convert.ToInt32(y.Text);
                textBox1.Text = (sayi - sayi2).ToString();

            }
        }
    }
}

