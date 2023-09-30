using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace procces_bar
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
        int deger = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            deger += 5;
            if (deger <= progressBar1.Maximum)
            {
                progressBar1.Value += 5;
            }
            if (deger >= progressBar1.Maximum)
            {
                timer1.Stop();
                deger= 0;
                MessageBox.Show("durdu");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
