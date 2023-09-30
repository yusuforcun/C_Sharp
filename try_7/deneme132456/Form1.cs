using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme132456
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
        int sonuc;
        int su;
        int ekmek;
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            su = 12;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            su = 15;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            su = 80;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ekmek = 15;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ekmek = 10;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ekmek = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sonuc = ekmek + su;
            label1.Text = sonuc.ToString();
                
        }
    }
}
