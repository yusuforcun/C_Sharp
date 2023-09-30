using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dowhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dong = 1;
            while(dong<10)
            {
                dong++;
                if (listBox1.Text.Contains("zümra"))

               {    
                    MessageBox.Show("bulundu");
                    break;
                }

                else
                { 
                    MessageBox.Show("yok");
                    break;
                }   
            }
            
                    
                    
                    }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
