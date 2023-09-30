using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random_a
{
    public partial class Form1 : Form
    {
        Random random=new Random();
        private int sayı ;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            
        }
        private void button2_Click(object sender, EventArgs e)
        {

            int sayı= random.Next(0,20);
            MessageBox.Show(sayı.ToString());
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) < sayı)
            {
                MessageBox.Show("tex büyüt");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) < sayı)
            {
                MessageBox.Show("tex büyüt");
            }
        }
    }
}
