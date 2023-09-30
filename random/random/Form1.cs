using System;
using System.Windows.Forms;

namespace random
{
    public partial class Form1 : Form
    {
        private int number;
        private int random;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            Random random = new Random();
            random.Next(0, 20);
            int number = Convert.ToInt32(textBox1.Text);
            int tryy = 0;
            if (tryy != 5)
            {
                if (number == Convert.ToInt32(random))
                {
                    label1.Visible = true;
                    tryy++;
                    label1.Text = (tryy + "denemede bildiniz \n sayı:" + number);
                }
                if (number > Convert.ToInt32(random))
                {
                    label1.Visible = true;
                    tryy++;
                    label1.Text = (tryy + "denemeniz. \n sayıyı küçültün");
                }
                if (number < Convert.ToInt32(random))
                {
                    label1.Visible = true;
                    tryy++;
                    label1.Text = (tryy + "denemeniz. \n sayıyı büyültün");
                }
                label1.Visible = true;
                label1.Text = (tryy + "denemeniz.  sınıra ulaştınız \n sayı=" + number);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
