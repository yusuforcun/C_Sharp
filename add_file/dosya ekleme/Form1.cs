using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dosya_ekleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void fotoEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Resim Dosyaları | *.jpg ;*| Tüm Dosyalar | *.*";
                // Uzantısı txt, docx veya tüm dosyaları gösterir
                DialogResult cevap = ofd.ShowDialog();
                if (cevap == DialogResult.OK)
                {
                   pictureBox1.Image= new Bitmap(ofd.FileName);
                }
                
            
        }
    }
}
