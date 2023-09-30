using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int döngü = 0;
            do
            {
                listBox1.Items.Add(döngü);
                döngü++;

            }
            while (döngü <= 10);
            
                
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            int sıfırdan = 0;
            do
            {
                richTextBox1.Text += sıfırdan.ToString();
                richTextBox1.Text += (" \t");
                sıfırdan++;
            }
            while (sıfırdan <= 10);
        }
    }
}
