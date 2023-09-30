using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26._22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Visible = false;
        }
        int sayi;
        int[] sayilar = new int[10];
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int baslangıc = Convert.ToInt32(textBox1.Text);
            int bitis = Convert.ToInt32(textBox2.Text);
            

            int sayac = 0;
            while(sayac < 10)
            {
                sayi = rnd.Next(baslangıc, bitis);
                if (Array.IndexOf(sayilar,sayi) == -1){
                    sayilar[sayac]= sayi;
                    sayac++;
                }
                
            }
            listBox1.Visible = true;
            foreach (int yaz in sayilar)
            {
                listBox1.Items.Add(yaz);
            }



        }

        
    }
}
