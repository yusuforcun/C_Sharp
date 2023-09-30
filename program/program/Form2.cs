using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// İF ELSE KULLANARAK SAYILARI BİRBİRİNDEN ÇIKARAN PROGRAM

namespace program
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sonuc;

            if (sayi1>sayi2)
            {
                sonuc  = sayi1 - sayi2;
                label1.Text = Convert.ToString(sonuc);
            }
            else {
                sonuc=sayi2 - sayi1;
                label1.Text = Convert.ToString(sonuc);
            }
        }

    }
}
