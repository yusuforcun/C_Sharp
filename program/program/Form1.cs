using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "çıkarma") {
                Form2 Form = new Form2();
                Form.Show();
            }
            else if(textBox1.Text =="büyük sayı bulma") {
                Form3 Form = new Form3();
                Form.Show();
            }else if (textBox1.Text == "diziler") {
                Form4 Form = new Form4();
                Form.Show();
            }
            else
            {
                MessageBox.Show("Lütfen doğru kelimeleri giriniz (çıkarma, büyük sayı bulma,diziler)");
            }
        }
    }
}
