using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

// FOR VE ARRAYS KULLANARAK GİRİLEN SAYILARDAN EN BÜYÜK SAYIYI BULMA 

namespace program
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int[] notlar = new int[5];
        int x = 0;


        private void button1_Click(object sender, EventArgs e)
        {

            notlar[x] = int.Parse(textBox1.Text);
            textBox1.Text = " ";
            x += 1;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int enyuksek = notlar[0];
            for (int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i] > enyuksek)
                {
                    enyuksek = notlar[i];
                }
            }
            textBox2.Text = enyuksek.ToString();
        }
    }
}

