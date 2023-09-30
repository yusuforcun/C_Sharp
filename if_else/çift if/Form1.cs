using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace çift_if
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

        private void button1_Click(object sender, EventArgs e)
        {
            int tr = Convert.ToInt32(textBox1.Text);
            int eng = Convert.ToInt32(textBox2.Text);
            int mat = Convert.ToInt32(textBox3.Text);
            int fiz = Convert.ToInt32(textBox4.Text);

            int ort =(tr+eng+ mat+fiz) / 4;

            if (ort<50)
            {
                label2.Text = "sınıfta kaldı";
                label3.Text = "ortalama :" + ort;
            }
            else
            {
                if (ort> 70)
                {
                    label2.Text = "ORTALAMA ÜSTÜNDE TEŞEKKÜR ALDI";
                    label3.Text = "ortalama :" + ort;
                }
                else
                {
                    label2.Text = "ORTALAMA ÜSTÜNDE TAKDİR ALDI";
                    label3.Text = "ortalama :" + ort;
                }
            }
        }
    }
}
