using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text), sayac = 0;
            int x = 2;
            while (x < sayi)
            {
                if (sayi % x == 0)
                {
                    sayac++;
                    break;
                    
                }
            x++;
            }
                if (sayac == 0)
                {
                    label1.Text = ("sayı asaldır");
                }
                else
                {
                    label1.Text = ("sayı asal değildir");
                }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
  
        }
    }
}
