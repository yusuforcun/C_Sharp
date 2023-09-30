
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MyApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
          Process.Start("python.exe", "C:\\Users\\orcun\\OneDrive\\Masaüstü\\CODE\\asistan\\assistant\\main.py");
            
        }
    }
}
