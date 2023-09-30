using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace _7._02_Sınırlama_Prograsmı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    Double temp = Convert.ToDouble(queryObj["CurrentTemperature"].ToString());
                    temp = (temp - 273) / 10.0; ;
                    double Celsius = (temp - 32.0) * 5.0 / 9.0;
                    label2.Text = Celsius.ToString() + " C";
                }
            }
            catch (Exception ex)
            {
                label2.Text = ex.Message;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
