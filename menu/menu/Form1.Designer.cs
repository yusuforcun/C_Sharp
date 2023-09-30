namespace menu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtEditor = new System.Windows.Forms.RichTextBox();
            this.kopyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıstırToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kopyaToolStripMenuItem,
            this.yapıstırToolStripMenuItem1,
            this.kesToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 76);
            // 
            // txtEditor
            // 
            this.txtEditor.ContextMenuStrip = this.contextMenuStrip1;
            this.txtEditor.Location = new System.Drawing.Point(24, 76);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(299, 360);
            this.txtEditor.TabIndex = 2;
            this.txtEditor.Text = "";
            this.txtEditor.TextChanged += new System.EventHandler(this.txtEditor_TextChanged);
            // 
            // kopyaToolStripMenuItem
            // 
            this.kopyaToolStripMenuItem.Name = "kopyaToolStripMenuItem";
            this.kopyaToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.kopyaToolStripMenuItem.Text = "kopya";
            this.kopyaToolStripMenuItem.Click += new System.EventHandler(this.kopyaToolStripMenuItem_Click);
            // 
            // yapıstırToolStripMenuItem1
            // 
            this.yapıstırToolStripMenuItem1.Name = "yapıstırToolStripMenuItem1";
            this.yapıstırToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.yapıstırToolStripMenuItem1.Text = "yapıstır";
            this.yapıstırToolStripMenuItem1.Click += new System.EventHandler(this.yapıstırToolStripMenuItem1_Click);
            // 
            // kesToolStripMenuItem1
            // 
            this.kesToolStripMenuItem1.Name = "kesToolStripMenuItem1";
            this.kesToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.kesToolStripMenuItem1.Text = "kes";
            this.kesToolStripMenuItem1.Click += new System.EventHandler(this.kesToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 448);
            this.Controls.Add(this.txtEditor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox txtEditor;
        private System.Windows.Forms.ToolStripMenuItem kopyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıstırToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem1;
    }
}

