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
    public partial class anaForm : DevExpress.XtraEditors.XtraForm
    {
        public anaForm()
        {
            InitializeComponent();
        }

        private void anaForm_Load(object sender, EventArgs e)
        {
            int sicil =Convert.ToInt32( giris.gonderilecekSicilNo);
            // TODO: This line of code loads data into the 'cagriDataSet35.kullanici_bilgi' table. You can move, or remove it, as needed.
            this.kullanici_bilgiTableAdapter.Fill(this.cagriDataSet35.kullanici_bilgi);
            this.kullanici_bilgiTableAdapter.FillBy(this.cagriDataSet35.kullanici_bilgi, sicil);

            // TODO: This line of code loads data into the 'cagriDataSet32.Menuler' table. You can move, or remove it, as needed.
            this.menulerTableAdapter2.Fill(this.cagriDataSet32.Menuler);
            // TODO: This line of code loads data into the 'cagriDataSet31.Menuler' table. You can move, or remove it, as needed.

            
        }

        private void treeList1_Click(object sender, EventArgs e)
        {
            admin admin = new admin();
            kaydol kaydol = new kaydol();
            Form1 form1 = new Form1();
            form1userkontrol user1 = new form1userkontrol();
            adminkontrol admin1 = new adminkontrol();
            string menuAdi = treeList1.GetFocusedRowCellValue(colForm).ToString();
            if (menuAdi=="Kullanıcı Paneli")
            {
                admin.Close();
                kaydol.Close();
                admin1.Hide();
                kaydol.Hide();

                form1userkontrol1.BringToFront();
                
            }
            else if (menuAdi=="Admin Paneli")
            {
                kaydol.Close();
                form1.Close();
                kaydol.Hide();
                form1.Hide();
                user1.Hide();

                adminkontrol1.BringToFront();
            }
            else if (menuAdi == "Yetkilendirme")
            {


                kaydolkontrol1.BringToFront();

            }
            else if (menuAdi == "Bilgi İşlem")
            {

                bilgiİşlemKontrol1.BringToFront();
                

            }
            else if (menuAdi == "Satın Alma")
            {

                satinAlma1.BringToFront();
                

            }
            else if (menuAdi == "İK")
            {

                ik1.BringToFront();
               

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void treeList1_CustomRowFilter(object sender, DevExpress.XtraTreeList.CustomRowFilterEventArgs e)
        {
            if (e.Node.GetDisplayText(0) == "Kullanıcı Paneli")
            {
                var yetki = this.cagriDataSet35.kullanici_bilgi.Where(x => ((x.ozel_id == 1 || x.ozel_id == 2 || x.ozel_id == 3)));
                if (yetki.Count() == 0)
                {
                    e.Visible = false;
                    e.Handled = true;
                }
                goto FFF;
            }
            else if (e.Node.GetDisplayText(0) == "Admin Paneli")
            {
                var yetki = this.cagriDataSet35.kullanici_bilgi.Where(x => (x.ozel_id == 4));
                if (yetki.Count() == 0)
                {
                    e.Visible = false;
                    e.Handled = true;
                }
            }
            else if (e.Node.GetDisplayText(0) == "Yetkilendirme")
            {
                var yetki = this.cagriDataSet35.kullanici_bilgi.Where(x => (x.ozel_id == 5));
                if (yetki.Count() == 0)
                {
                    e.Visible = false;
                    e.Handled = true;
                }
            }
            else if (e.Node.GetDisplayText(0) == "Bilgi İşlem")
            {
                var yetki = this.cagriDataSet35.kullanici_bilgi.Where(x => (x.ozel_id == 6));
                if (yetki.Count() == 0)
                {
                    e.Visible = false;
                    e.Handled = true;
                }
            }
            else if (e.Node.GetDisplayText(0) == "Satın Alma")
            {
                var yetki = this.cagriDataSet35.kullanici_bilgi.Where(x => (x.ozel_id == 7));
                if (yetki.Count() == 0)
                {
                    e.Visible = false;
                    e.Handled = true;
                }
            }
            else if (e.Node.GetDisplayText(0) == "İK")
            {
                var yetki = this.cagriDataSet35.kullanici_bilgi.Where(x => (x.ozel_id == 8));
                if (yetki.Count() == 0)
                {
                    e.Visible = false;
                    e.Handled = true;
                }
            }
            FFF:;
        }

        private void xtraUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void satinAlma1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
