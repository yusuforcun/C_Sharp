using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace messagebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sdf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" yes", "no", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MessageBox.Show(" yes", "no", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            MessageBox.Show(" yes", "no", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            MessageBox.Show(" yes", "no", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            DialogResult answer = MessageBox.Show(" yes", "no", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes) { MessageBox.Show("yes"); }
            else if (answer == DialogResult.No) { MessageBox.Show("no"); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            sfd.Filter = "Text Dosyası | *.txt";
            // Kaydedilecek dosyanın uzantısı txt olarak belirlenir.
            sfd.Filter = "Text Dosyası | *.txt | Word Dosyası | *.docx";
            // Kaydedilecek dosyanın uzantısı txt veya docx olarak belirlenir
            sfd.Filter = "Text Dosyası | *.txt | Tüm Dosyalar | *.*";
            DialogResult cevap = sfd.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                MessageBox.Show("Dosya kaydetme işlemi başlıyor.");
            } 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            pd.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            ofd.Filter = "Text Dosyaları| *.txt";
            // Uzantısı txt olanları gösterir.
            ofd.Filter = "Text Dosyaları| *.txt | Word Dosyaları | *.docx";
            // Uzantısı txt veya docx olanları gösterir.
            ofd.Filter = "Text Dosyaları | *.txt | Word Dosyaları | *.docx | Tüm Dosyalar | *.*";
            // Uzantısı txt, docx veya tüm dosyaları gösterir
            DialogResult cevap = ofd.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                MessageBox.Show(ofd.FileName);
            }

            label1.Text = ofd.FileName;
            label2.Text = ofd.SafeFileName;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
            
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
