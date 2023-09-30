using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   
        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Copy();
        }

        private void yapıstırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Paste();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Cut();
        }

        private void txtEditor_TextChanged(object sender, EventArgs e)
        {

        }

        private void değilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kopyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Copy();
        }

        private void yapıstırToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtEditor.Paste();
        }

        private void kesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtEditor.Cut();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
