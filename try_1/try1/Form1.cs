using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace try1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "giriş yapılmadı";
            button2.Visible = false;
            tabControl1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " ")
            {
                textBox2.Text = "giriş yapılmadı";
            }
            else
            {
                textBox2.Text = "hoşgeldiniz " + textBox1.Text;
            }
            textBox1.Text = " ";
            button2.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox3.Text);
            textBox3.Text = " ";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void topbut1_Click(object sender, EventArgs e)
        {
            int sonuc =0;
            int sayi1 = 0;
            int sayi2 = 0;
            sayi1 = Convert.ToInt32(top1.Text);
            sayi2 = Convert.ToInt32(top2.Text);
            sonuc =sayi1 + sayi2;
            toplab.Text = sonuc.ToString();
            

        }

        private void topbut2_Click(object sender, EventArgs e)
        {
            int sonuc ,sayi1,sayi2;
            sayi1 = Convert.ToInt32(top1.Text);
            sayi2 = Convert.ToInt32(top2.Text);
            sonuc = sayi1 - sayi2;
            toplab.Text = sonuc.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool secim;
            secim = checkBox1.Checked;
            label2.Text = "Lamba " + secim.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x,b;
            x= Convert.ToInt32( textBox4.Text);
            b = x * x;
            x = Convert.ToString(b.ToString(x);
            label3.Text = x.ToString(b);


        }
    }
}
