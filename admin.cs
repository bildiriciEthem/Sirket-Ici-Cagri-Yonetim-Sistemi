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

namespace cagri
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            foreach (var scrn in Screen.AllScreens)
            {
                if (scrn.Bounds.Contains(this.Location))
                {
                    this.Location = new Point(scrn.Bounds.Right - this.Width, scrn.Bounds.Top + 23);
                    return;
                }
            }
        }
        public static string gonderilecekGuncelleme;
        SqlConnection baglanti = new SqlConnection("Data Source=BTSOFT\\SQLEXPRESS;Initial Catalog=cagri;Integrated Security=True");
        private void admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cagriDataSet29.kullanici_güncelleme' table. You can move, or remove it, as needed.
            this.kullanici_güncellemeTableAdapter3.Fill(this.cagriDataSet29.kullanici_güncelleme);
            gridControl4.Visible = false;
            // TODO: This line of code loads data into the 'cagriDataSet28.bilgi' table. You can move, or remove it, as needed.
            this.bilgiTableAdapter11.Fill(this.cagriDataSet28.bilgi);
            // TODO: This line of code loads data into the 'cagriDataSet27.bilgi' table. You can move, or remove it, as needed.
            this.bilgiTableAdapter10.Fill(this.cagriDataSet27.bilgi);

            // TODO: This line of code loads data into the 'cagriDataSet26.bilgi' table. You can move, or remove it, as needed.
            this.bilgiTableAdapter9.Fill(this.cagriDataSet26.bilgi);
            //this.bilgiTableAdapter.Fill(this.cagriDataSet9.bilgi);
            // TODO: This line of code loads data into the 'cagriDataSet24.bilgi' table. You can move, or remove it, as needed.
            //this.bilgiTableAdapter8.Fill(this.cagriDataSet24.bilgi);
            // TODO: This line of code loads data into the 'cagriDataSet23.kullanici_güncelleme' table. You can move, or remove it, as needed.
            //this.kullanici_güncellemeTableAdapter2.Fill(this.cagriDataSet23.kullanici_güncelleme);
            // TODO: This line of code loads data into the 'cagriDataSet21.bilgi' table. You can move, or remove it, as needed.
            // this.bilgiTableAdapter7.Fill(this.cagriDataSet21.bilgi);
            // TODO: This line of code loads data into the 'cagriDataSet20.kullanici_güncelleme' table. You can move, or remove it, as needed.
            this.kullanici_güncellemeTableAdapter1.Fill(this.cagriDataSet20.kullanici_güncelleme);
            // TODO: This line of code loads data into the 'cagriDataSet19.kullanici_güncelleme' table. You can move, or remove it, as needed.
            this.kullanici_güncellemeTableAdapter.Fill(this.cagriDataSet19.kullanici_güncelleme);
            // TODO: This line of code loads data into the 'cagriDataSet18.bilgi' table. You can move, or remove it, as needed.
            //this.bilgiTableAdapter6.Fill(this.cagriDataSet18.bilgi);
            //// TODO: This line of code loads data into the 'cagriDataSet17.bilgi' table. You can move, or remove it, as needed.
            //this.bilgiTableAdapter5.Fill(this.cagriDataSet17.bilgi);
            //// TODO: This line of code loads data into the 'cagriDataSet16.bilgi' table. You can move, or remove it, as needed.
            //this.bilgiTableAdapter4.Fill(this.cagriDataSet16.bilgi);
            //// TODO: This line of code loads data into the 'cagriDataSet15.bilgi' table. You can move, or remove it, as needed.
            //this.bilgiTableAdapter3.Fill(this.cagriDataSet15.bilgi);
            //// TODO: This line of code loads data into the 'cagriDataSet14.bilgi' table. You can move, or remove it, as needed.
            //this.bilgiTableAdapter2.Fill(this.cagriDataSet14.bilgi);
            //// TODO: This line of code loads data into the 'cagriDataSet12.bilgi' table. You can move, or remove it, as needed.
            //this.bilgiTableAdapter1.Fill(this.cagriDataSet12.bilgi);
            //// TODO: This line of code loads data into the 'cagriDataSet9.bilgi' table. You can move, or remove it, as needed.
            //this.bilgiTableAdapter.Fill(this.cagriDataSet9.bilgi);


        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            textEdit1.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            textEdit2.Text = gridView1.GetFocusedRowCellValue("cagri_sahibi").ToString();
            textEdit3.Text = gridView1.GetFocusedRowCellValue("cagri_tarih").ToString();
            comboBoxEdit1.Text = gridView1.GetFocusedRowCellValue("cagri_durum").ToString();
            comboBoxEdit2.Text = gridView1.GetFocusedRowCellValue("cagri_aciliyet").ToString();
            memoEdit1.Text = gridView1.GetFocusedRowCellValue("cagri_aciklama").ToString();
            textEdit4.Text = gridView1.GetFocusedRowCellValue("cagri_sahibi").ToString();

        }

        private void Durum(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update bilgi set cagri_aciliyet = '" + comboBoxEdit2.Text + "', cagri_durum = '" + comboBoxEdit1.Text + "' where ID = " + textEdit1.Text + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            string kaydet = "insert into admin_guncelleme(kullanici_sicil,mesaj,tarih) values (@kullanici_sicil,@mesaj,@tarih)";
            SqlCommand cmd = new SqlCommand(kaydet, baglanti);


            cmd.Parameters.AddWithValue("@kullanici_sicil", textEdit2.Text.Trim());
            string mesaj = " Yönetici " + DateTime.Now + " tarihinde güncelleme yaptı yeni durumunuz " + comboBoxEdit1.Text + ", aciliyetiniz " + comboBoxEdit2.Text + " olarak değiştirildi.";
            cmd.Parameters.AddWithValue("@mesaj", mesaj);
            cmd.Parameters.AddWithValue("@tarih", DateTime.Now);
            string kaydett = "insert into kullanici_güncelleme(kullanici_sicil,kullanici_güncelleme,tarih,cagri_id) values (@kullanici_sicil,@kullanici_güncelleme,@tarih,@cagri_id)";
            SqlCommand cmdd = new SqlCommand(kaydett, baglanti);
            cmdd.Parameters.AddWithValue("@kullanici_sicil", textEdit2.Text.Trim());
            cmdd.Parameters.AddWithValue("@kullanici_güncelleme", mesaj);
            cmdd.Parameters.AddWithValue("@tarih", DateTime.Now);
            cmdd.Parameters.AddWithValue("@cagri_id", textEdit1.Text);
            baglanti.Close();
            baglanti.Open();
            cmdd.ExecuteNonQuery();
            baglanti.Close();
            this.kullanici_güncellemeTableAdapter3.Fill(this.cagriDataSet29.kullanici_güncelleme);
            //this.bilgiTableAdapter.Fill(this.cagriDataSet9.bilgi);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //this.kullanici_güncellemeTableAdapter2.Fill(this.cagriDataSet23.kullanici_güncelleme);
            this.kullanici_güncellemeTableAdapter2.FillBy(this.cagriDataSet23.kullanici_güncelleme, textEdit4.Text);
            //gridControl2.Visible = true;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            this.bilgiTableAdapter11.FillBy(this.cagriDataSet28.bilgi, textEdit4.Text);
            //gridControl1.Visible = false;
            //gridControl4.Visible = true;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
           //

        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {
            textEdit1.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            textEdit2.Text = gridView1.GetFocusedRowCellValue("cagri_sahibi").ToString();
            textEdit3.Text = gridView1.GetFocusedRowCellValue("cagri_tarih").ToString();
            comboBoxEdit1.Text = gridView1.GetFocusedRowCellValue("cagri_durum").ToString();
            comboBoxEdit2.Text = gridView1.GetFocusedRowCellValue("cagri_aciliyet").ToString();
            memoEdit1.Text = gridView1.GetFocusedRowCellValue("cagri_aciklama").ToString();
            textEdit4.Text = gridView1.GetFocusedRowCellValue("cagri_sahibi").ToString();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            this.bilgiTableAdapter11.FillBy1(this.cagriDataSet28.bilgi, dateEdit1.Text);
            gridControl1.Visible = false;
            gridControl4.Visible = true;
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            this.kullanici_güncellemeTableAdapter2.FillBy1(this.cagriDataSet23.kullanici_güncelleme, dateEdit1.Text);
            gridControl2.Visible = true;
        }
    }
}
