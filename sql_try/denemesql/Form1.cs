using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace denemesql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn; //sql baglantı
        SqlDataAdapter adapter; // gredwiev veri aktarma
        SqlCommand cmd;  //tüm sql komutlarını yazacağız
        DataSet ds;


        public void createtable()
        {
            conn = new SqlConnection();
            adapter = new SqlDataAdapter("Select * From bilgi", conn);
            conn.Open();
            adapter.Fill(ds, "bilgi");
            dataGridView1.DataSource = ds.Tables["bilgi"];
            conn.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
