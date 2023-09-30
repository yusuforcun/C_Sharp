using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tooltip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string sifre;
        public static string isim;

        private void Form1_Load(object sender, EventArgs e)
        {
            /*ToolTip tt = new ToolTip();
            tt.SetToolTip(textBox1, "Please login your name");

            tt.SetToolTip(textBox2, "Please login your surname");

            tt.SetToolTip(textBox3, "Please login your phone");

            tt.SetToolTip(textBox4, "Please login your address");*/
        }

        ErrorProvider errorProvider = new ErrorProvider();
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)) { label5.Text = "You should login"; }
            else if (string.IsNullOrEmpty(textBox2.Text)) { label6.Text = "You should login"; }
            else if (string.IsNullOrEmpty(textBox3.Text)) { label7.Text = "You should login"; }
            else if (string.IsNullOrEmpty(textBox4.Text)) { label8.Text = "You should login"; }
            else if (textBox3.Text != textBox4.Text) { MessageBox.Show("Password must be should same"); }
            
            else { Form3 form = new Form3();sifre = textBox3.Text;isim = textBox1.Text; form.ShowDialog(); }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {

            if (int.TryParse(textBox3.Text, out int sonuc)) { errorProvider.SetError(textBox3, ""); }
            else { e.Cancel = true; errorProvider.SetError(textBox3, "Wrong login"); }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {

            if (int.TryParse(textBox4.Text, out int sonuc)) { errorProvider.SetError(textBox4, ""); }
            else { e.Cancel = true; errorProvider.SetError(textBox4, "Wrong login"); }
        }


        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text==" ") { e.Cancel = true; errorProvider.SetError(textBox1, "space ");  }
            else { errorProvider.SetError(textBox1, ""); }

        }
    }
}
