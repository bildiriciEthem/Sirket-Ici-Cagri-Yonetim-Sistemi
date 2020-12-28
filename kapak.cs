using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cagri
{
    public partial class kapak : UserControl
    {
        public kapak()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
        string saat, dakika, saniye;

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (DateTime.Today.Hour < 10)
            {
                saat = "0" + DateTime.Today.Hour.ToString();
            }
            else
            {
                saat = DateTime.Today.Hour.ToString();
            }
            if (DateTime.Today.Minute < 10)
            {
                dakika = "0" + DateTime.Today.Minute;
            }
            else
            {
                dakika = DateTime.Today.Minute.ToString();
            }
            if (DateTime.Today.Second < 10)
            {
                saniye = "0" + DateTime.Today.Second;
            }
            else
            {
                saniye = DateTime.Today.Second.ToString();
            }
            //labelControl1.Text = saat + ":" + dakika + ":" + saniye;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Today.Hour<10)
            {
                saat = "0" + DateTime.Today.Hour;
            }
            else
            {
               saat= DateTime.Today.Hour.ToString();
            }
            if (DateTime.Today.Minute<10)
            {
                dakika = "0" + DateTime.Today.Minute;
            }
            else
            {
                dakika = DateTime.Today.Minute.ToString();
            }
            if (DateTime.Today.Second<10)
            {
                saniye = "0" + DateTime.Today.Second;
            }
            else
            {
                saniye = DateTime.Today.Second.ToString();
            }
            //labelControl1.Text = saat + ":" + dakika + ":" + saniye;
        }
    }
}
