using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace cagri
{
    public partial class bilgiİşlemKontrol : UserControl
    {
        public bilgiİşlemKontrol()
        {
            InitializeComponent();
        }
        int bolumID = 1;
        int cbolmid = 6;

        SqlConnection baglanti = new SqlConnection("Data Source=BTSOFT\\SQLEXPRESS;Initial Catalog=cagri;Integrated Security=True");
        private void bilgiİşlemKontrol_Load(object sender, EventArgs e)
        {
            labelControl8.Enabled = false;
            buttonEdit1.Enabled = false;
            this.kullanici_güncellemeTableAdapter.Fill(this.cagriDataSet57.kullanici_güncelleme, bolumID);
            this.bilgiTableAdapter.Fill(this.cagriDataSet55.bilgi, bolumID);
            this.kullanici_sekmeTableAdapter.Fill(this.cagriDataSet60.kullanici_sekme, cbolmid);
            this.kullanici_bilgiTableAdapter.Fill(this.cagriDataSet61.kullanici_bilgi, Convert.ToInt32(giris.gonderilecekSicilNo));
            this.bilgiTableAdapter.FillBy(this.cagriDataSet55.bilgi, Convert.ToInt32(giris.gonderilecekSicilNo));
            var yetki9 = this.cagriDataSet61.kullanici_bilgi.Where(x => ((x.ozel_id == 9)));
            if (yetki9.Count() == 1)
            {
                labelControl8.Enabled = true;
                buttonEdit1.Enabled = true;
                this.kullanici_güncellemeTableAdapter.Fill(this.cagriDataSet57.kullanici_güncelleme, bolumID);
                this.bilgiTableAdapter.Fill(this.cagriDataSet55.bilgi, bolumID);
                this.kullanici_sekmeTableAdapter.Fill(this.cagriDataSet60.kullanici_sekme, cbolmid);
                this.kullanici_bilgiTableAdapter.Fill(this.cagriDataSet61.kullanici_bilgi, Convert.ToInt32(giris.gonderilecekSicilNo));
            }
            else
            {
                buttonEdit1.Text = giris.gonderilecekSicilNo;
            }

        }
        string onlem, onlem2, onlem3;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (onlem == comboBoxEdit2.Text && onlem2 == memoEdit1.Text && onlem3 == comboBoxEdit1.Text)
            {
                MessageBox.Show("Statü değiştirmediniz.");
            }
            else
            {


                baglanti.Open();
                //SqlCommand komutt = new SqlCommand("update admin_mesaj set admin_guncelleme = '" + memoEdit2.Text.Trim() + "' where cagri_id = " +Convert.ToInt32( textEdit1.Text) + "", baglanti);
                SqlCommand komutt=new SqlCommand("update admin_mesaj set admin_guncelleme=@admin_guncelleme where cagri_id=@cagri_id",baglanti);
                komutt.Parameters.AddWithValue("@admin_guncelleme", memoEdit2.Text);
                komutt.Parameters.AddWithValue("@cagri_id",Convert.ToInt32(textEdit1.Text));
                komutt.ExecuteNonQuery();
                baglanti.Close();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update bilgi set ilgili_sicil = '" +buttonEdit1.Text + "', cagri_aciliyet = '" + comboBoxEdit2.Text + "', cagri_durum = '" + comboBoxEdit1.Text + "', admin_aciklama = '" + memoEdit2.Text.Trim() + "' where ID = " + textEdit1.Text + "", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                baglanti.Open();
                string kaydet = "insert into admin_guncelleme(kullanici_sicil,mesaj,tarih,cagri_id,guncelleyen_sicil,guncelleyen_bolum) values (@kullanici_sicil,@mesaj,@tarih,@cagri_id,@guncelleyen_sicil,@gıncelleyen_bolum)";
                SqlCommand cmd = new SqlCommand(kaydet, baglanti);


                cmd.Parameters.AddWithValue("@kullanici_sicil", textEdit2.Text.Trim());
                string mesaj = " Bilgi İşlem çağrınıza güncelleme yaptı yeni durumunuz " + comboBoxEdit1.Text.Trim() + ", aciliyetiniz " + comboBoxEdit2.Text.Trim() + " olarak değiştirildi.";
                int guncelleyen = Convert.ToInt32(giris.gonderilecekSicilNo);
                cmd.Parameters.AddWithValue("@guncelleyen_sicil", guncelleyen);
                cmd.Parameters.AddWithValue("@mesaj", mesaj);
                cmd.Parameters.AddWithValue("@tarih", Convert.ToDateTime(DateTime.Now));
                cmd.Parameters.AddWithValue("@cagri_id", Convert.ToInt32(textEdit1.Text));
                cmd.Parameters.AddWithValue("@gıncelleyen_bolum", bolumID);

                cmd.ExecuteNonQuery();
                string kaydett = "insert into kullanici_güncelleme(kullanici_sicil,kullanici_güncelleme,tarih,cagri_id) values (@kullanici_sicil,@kullanici_güncelleme,@tarih,@cagri_id)";
                SqlCommand cmdd = new SqlCommand(kaydett, baglanti);
                cmdd.Parameters.AddWithValue("@kullanici_sicil", textEdit2.Text.Trim());
                cmdd.Parameters.AddWithValue("@kullanici_güncelleme", mesaj);
                cmdd.Parameters.AddWithValue("@tarih", Convert.ToDateTime(DateTime.Now.ToString()));
                cmdd.Parameters.AddWithValue("@cagri_id", textEdit1.Text);

                baglanti.Close();
                baglanti.Open();
                cmdd.ExecuteNonQuery();
                baglanti.Close();
                var yetki9 = this.cagriDataSet61.kullanici_bilgi.Where(x => ((x.ozel_id == 9)));
                if (yetki9.Count() == 1)
                {
                    this.bilgiTableAdapter.Fill(this.cagriDataSet55.bilgi, bolumID);
                }
                
                this.bilgiTableAdapter.FillBy(this.cagriDataSet55.bilgi, Convert.ToInt32(giris.gonderilecekSicilNo));
                memoEdit2.Text = "";
                MessageBox.Show("Güncellendi");
                //this.kullanici_güncellemeTableAdapter3.Fill(this.cagriDataSet29.kullanici_güncelleme);
                //this.kullanici_güncellemeTableAdapter3.Fill(this.cagriDataSet29.kullanici_güncelleme);
                //this.bilgiTableAdapter.Fill(this.cagriDataSet9.bil
            }
        }

        private void buttonEdit1_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
        int sayac = 1;
        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            sayac++;
            this.kullanici_sekmeTableAdapter.Fill(this.cagriDataSet60.kullanici_sekme, cbolmid);
            if (sayac % 2 == 0)
            {
                gridControl3.Visible = false;
                labelControl9.Visible = false;
            }
            else
            {
                labelControl9.Visible = true;
                gridControl3.Visible = true;
               
            }
            
        }

        private void labelControl9_Click(object sender, EventArgs e)
        {
            gridControl3.Visible = false;
            labelControl9.Visible = false;
            sayac++;
        }
        string dosyaadi, dosyauzanti; Byte[] donen;
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveFileDialog1.FileName = dosyaadi;
                //   File.WriteAllBytes(saveFileDialog1.FileName + dosyaadi.Trim() + "" + dosyauzanti.Trim() + "", donen);
               // File.WriteAllBytes(saveFileDialog1.FileName + dosyaadi.Trim() + "", donen);
                File.WriteAllBytes(saveFileDialog1.FileName , donen);
                // File.WriteAllBytes(@"C: \Users\bimsoft\Documents\" + dosyaadi + "" + dosyauzanti + "", donen);
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            textEdit1.Text = "";
            textEdit2.Text = "";
            textEdit3.Text = "";
            comboBoxEdit1.Text = "";
            comboBoxEdit2.Text = "";
            this.kullanici_güncellemeTableAdapter.Fill(this.cagriDataSet57.kullanici_güncelleme, bolumID);
            this.bilgiTableAdapter.FillBy(this.cagriDataSet55.bilgi, Convert.ToInt32(giris.gonderilecekSicilNo));
            var yetki9 = this.cagriDataSet61.kullanici_bilgi.Where(x => ((x.ozel_id == 9)));
            if (yetki9.Count() == 1)
            {
                this.bilgiTableAdapter.Fill(this.cagriDataSet55.bilgi, bolumID);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gridView1.IsEditorFocused)
            {

                //  textEdit4.Text = gridView1.GetFocusedRowCellValue("").ToString();
                textEdit1.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                textEdit2.Text = gridView1.GetFocusedRowCellValue("cagri_sahibi").ToString();
                textEdit3.Text = gridView1.GetFocusedRowCellValue("cagri_tarih").ToString();
                //comboBoxEdit1.Text = gridView1.GetFocusedRowCellValue("cagri_durum").ToString();
                comboBoxEdit2.Text = gridView1.GetFocusedRowCellValue("cagri_aciliyet").ToString();
                //textEdit1.Text = gridView1.
                memoEdit1.Text = gridView1.GetFocusedRowCellValue("cagri_aciklama").ToString();
                dosyauzanti = gridView1.GetFocusedRowCellValue("cagri_uzanti").ToString();
                dosyaadi = gridView1.GetFocusedRowCellValue("cagri_adi").ToString();
               
                // this.bilgiTableAdapter15.Fill(this.cagriDataSet41.bilgi);
                // this.bilgiTableAdapter15.FillBy(this.cagriDataSet41.bilgi, textEdit2.Text);
                this.kullanici_güncellemeTableAdapter.FillBy(cagriDataSet57.kullanici_güncelleme, Convert.ToInt32(textEdit1.Text));
                //this.kullanici_güncellemeTableAdapter3.FillBy(cagriDataSet29.kullanici_güncelleme, Convert.ToInt32(textEdit1.Text));
                onlem = comboBoxEdit2.Text = gridView1.GetFocusedRowCellValue("cagri_aciliyet").ToString();
                onlem2 = memoEdit1.Text = gridView1.GetFocusedRowCellValue("cagri_aciklama").ToString(); ;
                onlem3 = comboBoxEdit1.Text = gridView1.GetFocusedRowCellValue("cagri_durum").ToString();
                SqlCommand com = new SqlCommand("Select * from bilgi where ID=" + textEdit1.Text + "", baglanti);
                baglanti.Open();
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    donen = (byte[])dr["cagri_icerik"];
                }
                baglanti.Close();
            }
            if (gridView2.IsEditorFocused)
            {
                textEdit1.Text = gridView2.GetFocusedRowCellValue("cagri_id").ToString();
                this.kullanici_güncellemeTableAdapter.FillBy(cagriDataSet57.kullanici_güncelleme, Convert.ToInt32(textEdit1.Text));
                //      this.kullanici_güncellemeTableAdapter3.FillBy2(cagriDataSet29.kullanici_güncelleme, Convert.ToInt32(textEdit1.Text));
            }
            if (gridView3.IsEditorFocused)
            {
                buttonEdit1.Text = gridView3.GetFocusedRowCellValue("sicil").ToString();
                gridControl3.Visible = false;
            }
        }
    }
}
