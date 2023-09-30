using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switch_case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int boy, kilo;
            boy=Convert.ToInt32(textBox1.Text);
            kilo = Convert.ToInt32(textBox2.Text);
            float VKİ = kilo / boy;
            if (VKİ<18.49)
            {
                System.Console.WriteLine("ideal kilo altı");
            }
            else if  (VKİ<24.99)
             {
                System.Console.WriteLine("İdeal Kilo");
            }
            else if (VKİ<29.99)
            {
                System.Console.WriteLine("İdeal kilo üzeri");
            }
            else
            {
                System.Console.WriteLine("İdeal kilonun çok üzeri");
            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Yellow;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor=SystemColors.Window;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int ses = trackBar1.Value;
            if(ses==0)
            {
                label4.Text = "ses kapalı";
            }
            else if(ses>0&&ses<10)
            {
                label4.Text = "ses seviyesi normal";
            }
            else
            {
                label4.Text = "ses seviyesi yüksek";
            }
        }
    }
}
