﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giriş
{
    public partial class Form1 : Form
    {
        public string isim;
        
        public Form1()
        {
            InitializeComponent();
            button1.Visible = (false);
            
            

        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
