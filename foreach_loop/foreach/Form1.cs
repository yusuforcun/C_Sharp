using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace @foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[3];
        string[] isimlerkopya = new string[3];
        int[] notlar = new int[3];
        int[] notlarkopya = new int[3];
        int index = 0;
     
        private void button1_Click(object sender, EventArgs e)
        {

            isimler[index] = textBox1.Text; notlar[index] = Convert.ToInt32(textBox2.Text);
            index++;
            if (index == 3)
                MessageBox.Show("dizi dolu");
            textBox1.Text = " "; textBox2.Text = " ";

        }

        private void button2_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < 3; i++)
            {
                listBox1.Items.Add(isimler[i] + " " + notlar[i]);
            }
            textBox3.Text = notlar.Max().ToString();
            textBox4.Text = notlar.Min().ToString();
            textBox5.Text = notlar.Average().ToString(); ;
            textBox6.Text = notlar.First().ToString();
            textBox7.Text = notlar.Last().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Array.Copy(isimler, isimlerkopya, 3);
            Array.Copy(notlar, notlarkopya, 3);
            for (int i = 0; i < 3; i++)
            {
                listBox2.Items.Add(isimlerkopya[i] + " " + notlarkopya[i]);
            }
        }






    }
}
