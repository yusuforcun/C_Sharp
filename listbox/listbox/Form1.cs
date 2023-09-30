using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbox
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            { 
            listBox1.Items.Add(Convert.ToInt32(textBox1.Text));
            textBox1.Text = (" ");
        }
            catch (Exception)
            {
                MessageBox.Show("düzgün bir sayı giriniz");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            for (int i=0;i<listBox1.Items.Count;i++)
            {
                toplam += Convert.ToDouble(listBox1.Items[i]);
            }
            label1.Visible = true;
            label1.Text = ("toplam : "+toplam);

        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.Purple;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Purple;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.Purple;   
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = DefaultBackColor;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = DefaultBackColor;

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = DefaultBackColor;
        }
    }
}
