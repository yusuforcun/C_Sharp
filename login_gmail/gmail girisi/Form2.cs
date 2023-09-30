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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==Form1.hide.isim && textBox2.Text == Form1.hide.sifre) { MessageBox.Show("basarili"); } 
            else { MessageBox.Show("yanlis"); }
        }



        private void kapatToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formdanÇıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sifreDegistirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.ShowDialog();
        }

        private void kullanıcıDegistirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form3 form = new Form3();
            form.ShowDialog();
        }
    }
}
