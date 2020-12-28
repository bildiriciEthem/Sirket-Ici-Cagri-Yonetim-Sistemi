using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cagri
{
    public partial class kullanici_secme : Form
    {
        public kullanici_secme()
        {
            InitializeComponent();
        }

        private void kullanici_secme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cagriDataSet52.kullanici_sekme' table. You can move, or remove it, as needed.
            this.kullanici_sekmeTableAdapter.Fill(this.cagriDataSet52.kullanici_sekme);

        }
        public static string adAktar;
        public static string sicilAktar;
        public static int gondsay = 0;
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
          
        }
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gridView1.IsEditorFocused)
            {
                
              string a = gridView1.GetFocusedRowCellValue("adi").ToString();
               string b= gridView1.GetFocusedRowCellValue("sicil").ToString();
                
               // kaydolkontrol.txtisim.Text = a;
                kaydolkontrol.txtsicil.Text = b;
                    
                MessageBox.Show(adAktar + "   " + sicilAktar);
                gondsay++;
               
                this.Hide();
            }
        }
    }
}
