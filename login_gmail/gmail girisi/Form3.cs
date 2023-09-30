using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gmail_girisi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.hide.isim == textBox1.Text) { Form1.hide.isim = textBox2.Text; MessageBox.Show("basarili");this.Close(); }
            else
            {
                MessageBox.Show("no");
            }
        }
    }
}
