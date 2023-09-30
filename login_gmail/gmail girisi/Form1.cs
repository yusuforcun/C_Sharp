using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gmail_girisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e){
            textBox2.MaxLength = 5;
            textBox2.PasswordChar= '*';
        }
        public static class hide
        {
            public static string isim="yusufufus";
            public static string sifre="132";
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("ikiside boş");
            }

            if (textBox1.Text == hide.isim && textBox2.Text == hide.sifre)
            {
                Form1.hide.isim = textBox1.Text; Form1.hide.sifre=textBox2.Text;
                Form2 form2 = new Form2();
                form2.Show();
            }

        }

    }
}
