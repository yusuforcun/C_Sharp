using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dizin_olusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double dizi = Convert.ToUInt32(5);
        public void ekle()
        {
            Random sayi = new Random();
            for (int i =0;i<dizi; i++)
            {
                sayi.Next();
                label1.Text.Append(sayi);
                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            ekle();

        }
    }
}
