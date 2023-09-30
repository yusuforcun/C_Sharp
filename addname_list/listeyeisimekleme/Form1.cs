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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace listeyeisimekleme
{       
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            list.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.Visible = true;

            for (int i = 0; i < 10; i++)
                list.Items.Add(Convert.ToString(textBox1.Text));
        }




       
        private void button2_Click_1(object sender, EventArgs e)
        {
            int mattrue = Convert.ToInt32(textBox2.Text);
            int matfalse = Convert.ToInt32(textBox3.Text);
            int turtrue = Convert.ToInt32(textBox4.Text);
            int turfalse = Convert.ToInt32(textBox5.Text);

            int allnet = (mattrue + turtrue) - ((matfalse + turfalse) / 4);
            int matnet = mattrue- (matfalse / matfalse);
            int türnet = turtrue - (turfalse / matfalse);

            label6.Text = Convert.ToString(matnet);
            label7.Text = Convert.ToString(türnet);
            label8.Text = Convert.ToString(allnet);
        }






        private void button3_Click(object sender, EventArgs e)
        {
            label11.Visible = true;
            int deger1 = Convert.ToInt32(textBox6.Text);
            int deger2 = Convert.ToInt32(textBox7.Text);
            if (radioButton2.Checked == true)
            {
                label11.Text = (deger1 * deger2).ToString();
            }
            else
            {
                label11.Text = (deger1 + deger2).ToString();

            }


        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int value = trackBar1.Value;
            if (value == 0)
            {
                label12.Text = ("ses yok"); label12.ForeColor = Color.Black;
            }
            if (value > 0 && value <= 10)
            {
                label12.Text = "Normal Ses Seviyesi"; label12.ForeColor = Color.Green;
            }
            if (value > 11)
            { 
            label12.Text = "yüksek ses"; label12.ForeColor = Color.Red;
        }


        }
    }
}
