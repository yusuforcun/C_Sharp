using System.Diagnostics;

namespace metin_edütörü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Değişiklikleri Kaydetmek İstiyormusunuz ? ","Not Defteri",MessageBoxButtons.YesNoCancel);
        }

        private void yeniPencereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 For = new Form1();
            For.Show();

        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
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
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
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

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
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

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            pd.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("metin edütörü");
            foreach (Process process in processes)
            {
                process.Kill();
            }
        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Paste();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Clear();
        }
    }
}