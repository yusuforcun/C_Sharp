using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wasdefrg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            label4.Text = "isim = " + textBox1.Text + "  telefon = " + textBox2.Text + "  adres = " + textBox3.Text;
            label9.Text = "çorba = " + numericUpDown1.Value + "  salata= " + numericUpDown2.Value + "  ana yemek= " + numericUpDown3.Value + "  tatlı= " + numericUpDown4.Value;

        }
    }
} 
