using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankamatik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int ikiyüz;
        public int yüz;
        public int elli;
        public int yirmi;
        public int on;
        public int beş;
        public int sonuc;
        public int para;
       

        private void button1_Click(object sender, EventArgs e)
        {
            para = Convert.ToInt32(textBox1.Text);

            //if (para % 200 != 0) {
            int ikiyüz = para / 200;
            //if (para % 100 != 0) {
            int yüz = para / 100;
            //if (para % 50 != 0) {
            int elli = para / 50;
            //if (para % 20 != 0) {
            int yirmi = para / 20;
            //if (para % 10 != 0) {
            int on = para / 10;
            //if (para % 5 != 0) { 
            int beş = para / 5;

            listBox1.Items.Add(ikiyüz);
            listBox1.Items.Add(yüz);
            listBox1.Items.Add(elli);
            listBox1.Items.Add(yirmi);
            listBox1.Items.Add(on);
            listBox1.Items.Add(beş);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            para = Convert.ToInt32(textBox1.Text);

            //if (para % 200 != 0) {
            int ikiyüz = para / 200;
            para -= ikiyüz;
            //if (para % 100 != 0) {
            int yüz = para / 100;
            para -= yüz;
            //if (para % 50 != 0) {
            int elli = para / 50;
            para -= elli;
            //if (para % 20 != 0) {
            int yirmi = para / 20;
            para -= yirmi;
            //if (para % 10 != 0) {
            int on = para / 10;
            para -= on;
            //if (para % 5 != 0) { 
            int beş = para / 5;
            para -= beş;

            listBox2.Items.Add(ikiyüz);
            listBox2.Items.Add(yüz);
            listBox2.Items.Add(elli);
            listBox2.Items.Add(yirmi);
            listBox2.Items.Add(on);
            listBox2.Items.Add(beş);
        }

    }
}
