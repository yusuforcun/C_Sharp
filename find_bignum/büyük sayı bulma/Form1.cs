using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace büyük_sayı_bulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);

            if (a > b && a > c)
                MessageBox.Show("a en büyük");

            else if (b > c && b > a)
                MessageBox.Show("b en büyük");
            else if (c > b && c > a)
                MessageBox.Show("c en büyük");
            else
                MessageBox.Show("eşit");

        }
    }
}
