using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraToolbox;
using System.Data.SqlClient;
using System.IO;
using System.Net.Mail;

namespace cagri
{
    public partial class form1userkontrol : UserControl
    {
        int ekSayac,ekkontrol, ekkontrol2, ekkontrol3, ekkontrol4;
        public form1userkontrol()
        {
            InitializeComponent();
        }
        public static byte[] bos;

        public static byte[] stbyt;
        public static byte[] stbyt2;
        public static byte[] stbyt3;
        public static byte[] stbyt4;
        public bool ByteArrayToFile(string fileName, byte[] byteArray)
        {
            try
            {
                using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(byteArray, 0, byteArray.Length);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in process: {0}", ex);
                return false;
            }
        }
        int sonID = 0;
        string sonıd;
        int eksyc = 0;
        private void form1userkontrol_Load(object sender, EventArgs e)
        {
            labelControl9.Visible = false;
            labelControl10.Visible = false;
            labelControl11.Visible = false;
            labelControl12.Visible = false;
            simpleButton4.Enabled = false;
            dateEdit1.Text = (Convert.ToDateTime(DateTime.Today)).ToString();
            this.bilgiTableAdapter7.Fill(this.cagriDataSet58.bilgi);
            textEdit2.Text = giris.gonderilecekSicilNo;
            this.bilgiTableAdapter6.Fill(this.cagriDataSet51.bilgi, textEdit2.Text);
            this.gridView6.FocusedRowHandle = 0;
        //    sonıd = gridView6.GetFocusedRowCellValue("ID").ToString();
          //  textEdit1.Text =(Convert.ToInt32( sonıd )+ 1).ToString();
           

            

            // gridView6.FocusedColumn = colID1;

            //sonID = gridView6.GetRowCellValue(0, gridView6.Columns[0]);





            
            SqlDataReader oku;
            SqlCommand komut = new SqlCommand("select *from kullanici_bilgi where kullanici_ad='" + textEdit1.Text + "'", baglanti);
            baglanti.Open();
            oku = komut.ExecuteReader();
            //dateEdit1.Properties.Mask.Culture = new System.Globalization.CultureInfo("en-US");
            //dateEdit1.Properties.Mask.EditMask = "MMM-dd-yyyy";
            //dateEdit1.Properties.Mask.UseMaskAsDisplayFormat = true;
            //dateEdit1.Properties.CharacterCasing = CharacterCasing.Upper;
            textEdit2.Text = giris.gonderilecekSicilNo;
            this.admin_guncellemeTableAdapter1.Fill(this.cagriDataSet22.admin_guncelleme, textEdit2.Text);
            this.bilgiTableAdapter6.Fill(this.cagriDataSet51.bilgi, textEdit2.Text);
            // this.bilgiTableAdapter5.FillBy(this.cagriDataSet25.bilgi, textEdit2.Text);
            this.admin_guncellemeTableAdapter.FillBy(this.cagriDataSet13.admin_guncelleme, (textEdit2.Text));
            this.kullanici_bilgiTableAdapter1.FillBy(this.cagriDataSet39.kullanici_bilgi,Convert.ToInt32( textEdit2.Text));

            this.admin_guncellemeTableAdapter4.Fill(this.cagriDataSet43.admin_guncelleme);
            this.admin_guncellemeTableAdapter2.FillBy1(this.cagriDataSet37.admin_guncelleme, textEdit2.Text);
            this.admin_guncellemeTableAdapter5.Fill(this.cagriDataSet45.admin_guncelleme, textEdit2.Text);

            var yetki = this.cagriDataSet39.kullanici_bilgi.Where(x => ((x.ozel_id == 1)));
            if (yetki.Count() == 0)
            {
                simpleButton1.Enabled = false;
            }
            var yetki2 = this.cagriDataSet39.kullanici_bilgi.Where(x => ((x.ozel_id == 2)));
            if (yetki2.Count() == 0)
            {
                simpleButton4.Enabled = false;
            }

            var yetki3 = this.cagriDataSet39.kullanici_bilgi.Where(x => ((x.ozel_id == 3)));
            if (yetki3.Count() == 0)
            {
                simpleButton5.Enabled = false;
            }
            baglanti.Close();
           
        }
        string SonKayitID ="";
        public static string kullanicigıncelleme;
        SqlConnection baglanti = new SqlConnection("Data Source=BTSOFT\\SQLEXPRESS;Initial Catalog=cagri;Integrated Security=True");
        int bolumID = 0;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            //int sonn = Convert.ToInt32(sonID) + 1;
            
            if (comboBoxEdit3.Text== "Bilgi İşlem")
            {
                bolumID = 1;
            }
            if (comboBoxEdit3.Text == "Satın Alma")
            {
                bolumID = 2;
            }
            if (comboBoxEdit3.Text == "İK")
            {
                bolumID = 3;
            }

            

            if (dateEdit1.DateTime < DateTime.Today)
            {
                MessageBox.Show("Yanlış tarih girişi");
                MessageBox.Show("Yanlış tarih girişi");
                comboBoxEdit2.Text = "";
                memoEdit1.Text = "";
                dateEdit1.Text = "";
            }
            else if (comboBoxEdit2.Text==""||comboBoxEdit3.Text=="")
            {
                MessageBox.Show("Alanları boş geçmeyin");
            }
            else
            {


                baglanti.Close();
                //string fileName = textEdit6.Text;
                //BinaryWriter bwStream = new BinaryWriter(new FileStream(fileName, FileMode.Create));
                baglanti.Open();
                string kaydet = "insert into bilgi(cagri_sahibi,cagri_aciliyet,cagri_tarih,cagri_durum,cagri_aciklama,tarih,siralama_tarih,admin_aciklama,bolum_id,bolum_ad,ilgili_sicil,cagri_icerik,cagri_adi) values (@cagri_sahibi,@cagri_aciliyet,@cagri_tarih,@cagri_durum,@cagri_aciklama,@tarih,@siralama_tarih,@admin_aciklama,@bolum_id,@bolum_ad,@ilgili_sicil,@cagri_icerik,@cagri_adi)";
                SqlCommand cmd = new SqlCommand(kaydet, baglanti);


                // cmd.Parameters.AddWithValue("@cagri_no",Convert.ToInt32( textEdit1.Text.Trim()));
                // cmd.Parameters.AddWithValue("@cagri_no", idver());
                cmd.Parameters.AddWithValue("@cagri_sahibi", textEdit2.Text.Trim());
                cmd.Parameters.AddWithValue("@cagri_aciliyet", comboBoxEdit2.Text.Trim());
                cmd.Parameters.AddWithValue("@cagri_tarih", (dateEdit1.DateTime));
                cmd.Parameters.AddWithValue("@cagri_durum", comboBoxEdit1.Text.Trim());
                cmd.Parameters.AddWithValue("@cagri_aciklama", memoEdit1.Text.Trim());
                cmd.Parameters.AddWithValue("@tarih", DateTime.Now);
                cmd.Parameters.AddWithValue("@siralama_tarih", (dateEdit1.DateTime));
                cmd.Parameters.AddWithValue("@admin_aciklama", "");
                cmd.Parameters.AddWithValue("@bolum_id", bolumID);
                cmd.Parameters.AddWithValue("@bolum_ad", comboBoxEdit3.Text.Trim());
                cmd.Parameters.AddWithValue("@ilgili_sicil", 0);
                cmd.Parameters.AddWithValue("@cagri_icerik",stbyt);
                cmd.Parameters.AddWithValue("@cagri_adi",ad);
                baglanti.Close();
                kapatıcı.Visible = true;




                //if (ekSayac>0)
                //{
                //    cmd.Parameters.AddWithValue("@cagri_icerik", stbyt);
                //}
                //else
                //{
                //    cmd.Parameters.AddWithValue("@cagri_icerik", "");
                //}

                // cmd.Parameters.AddWithValue("@cagri_id")
                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                //baglanti.Open();
                //string kaydettt = "insert into admin_mesaj (admin_guncelleme,cagri_id) values (@admin_guncelleme,@cagri_id)";
                //SqlCommand cm = new SqlCommand(kaydettt, baglanti);
                //cm.Parameters.AddWithValue("@admin_guncelleme", "");
                //cm.Parameters.AddWithValue("@cagri_id",Convert.ToInt32( textEdit1.Text));
                //cm.ExecuteNonQuery();
                //baglanti.Close();
                baglanti.Open();
                sonID = Convert.ToInt32(sonıd) + 1;
                string gonderilecekGuncelleme = "" + textEdit2.Text.Trim() + " sicil numaralı kullanıcı " + DateTime.Now + " tarihinde " + comboBoxEdit2.Text + " olarak hata bildirdi.\n";
                admin.gonderilecekGuncelleme = gonderilecekGuncelleme;
                string kaydett = "insert into kullanici_güncelleme(kullanici_güncelleme,tarih,kullanici_sicil,siralama_tarih,bolum_id,cagri_id) values (@kullanici_güncelleme,@tarih,@kullanici_sicil,@siralama_tarih,@bolum_id,@cagri_id)";
                SqlCommand cmdd = new SqlCommand(kaydett, baglanti);
                cmdd.Parameters.AddWithValue("@kullanici_güncelleme", gonderilecekGuncelleme);
                cmdd.Parameters.AddWithValue("@tarih", DateTime.Now);
                cmdd.Parameters.AddWithValue("@siralama_tarih", (dateEdit1.DateTime));
                cmdd.Parameters.AddWithValue("@kullanici_sicil", textEdit2.Text.Trim());
                cmdd.Parameters.AddWithValue("@bolum_id", bolumID);
                cmdd.Parameters.AddWithValue("@cagri_id", sonID);
                //cmd.Parameters.AddWithValue("@cagri_icerik",(textEdit6.Text));

                cmdd.ExecuteNonQuery();
                baglanti.Close();

            //    if (ekkontrol == 1)
            //        {
            //        //    string sql = "UPDATE bilgi SET cagri_icerik=@cagri_icerik, cagri_adi=@cagri_adi where ID= '" +sonID+"'";

            //        //    SqlCommand ekle = new SqlCommand(sql, baglanti);
            //        //    ekle.Parameters.AddWithValue("@cagri_icerik", stbyt);
            //        //    ekle.Parameters.AddWithValue("@cagri_adi", ad);
            //        //    ekle.Parameters.AddWithValue("@ID", sonID);

            //        //    baglanti.Open();
            //        //    ekle.ExecuteNonQuery();
            //        //    baglanti.Close();
            //        baglanti.Open();
            //    SqlCommand komut = new SqlCommand("update bilgi set cagri_icerik = '" + stbyt + "', cagri_adi = '" + ad + "' where ID = " + sonID + "", baglanti);
            //    komut.ExecuteNonQuery();
            //    baglanti.Close();
            //    cmd.Parameters.AddWithValue("@cagri_icerik", stbyt);

            //    cmd.Parameters.AddWithValue("@cagri_adi", ad);
            //}
                //if (ekkontrol2 == 1)
                //{
                //    baglanti.Open();
                //    SqlCommand komut = new SqlCommand("update bilgi set cagri_icerik2 = '" + stbyt2 + "', cagri_adi2 = '" + ad2 + "' where ID = " + textEdit1.Text + "", baglanti);
                //    komut.ExecuteNonQuery();
                //    baglanti.Close();
                //    //cmd.Parameters.AddWithValue("@cagri_icerik2", stbyt2);

                //    //cmd.Parameters.AddWithValue("@cagri_adi2", ad2);
                //}
                //if (ekkontrol3 == 1)
                //{
                //    baglanti.Open();
                //    SqlCommand komut = new SqlCommand("update bilgi set cagri_icerik3 = '" + stbyt3 + "', cagri_adi3 = '" + ad3 + "' where ID = " + textEdit1.Text + "", baglanti);
                //    komut.ExecuteNonQuery();
                //    baglanti.Close();
                //    //cmd.Parameters.AddWithValue("@cagri_icerik3", stbyt3);

                //    //cmd.Parameters.AddWithValue("@cagri_adi3", ad3);
                //}
                //if (ekkontrol4 == 1)
                //{
                //    baglanti.Open();
                //    SqlCommand komut = new SqlCommand("update bilgi set cagri_icerik4 = '" + stbyt4 + "', cagri_adi4 = '" + ad4 + "' where ID = " + textEdit1.Text + "", baglanti);
                //    komut.ExecuteNonQuery();
                //    baglanti.Close();
                //    //cmd.Parameters.AddWithValue("@cagri_icerik4", stbyt4);

                //    //cmd.Parameters.AddWithValue("@cagri_adi4", ad4);
                //}
                this.bilgiTableAdapter6.Fill(this.cagriDataSet51.bilgi, textEdit2.Text);
                //this.bilgiTableAdapter5.FillBy(this.cagriDataSet25.bilgi, textEdit2.Text);
                MailMessage mail = new MailMessage("bildirici.ethem@gmail.com", "enginareto@gmail.com", "Çağrı", "" + sonID + " ID'li çağrı");
                //mail.Attachments.Add(new Attachment(textEdit6.Text));
                //SmtpClient client = new SmtpClient("smtp.gmail.com");
                //client.Port = 25;
                //client.Credentials = new System.Net.NetworkCredential("enginareto@gmail.com", "f3475ed4");
                //client.EnableSsl = true;
                //client.Send(mail);
                MessageBox.Show("Gönderildi");
                comboBoxEdit2.Text = "";
                memoEdit1.Text = "";
                dateEdit1.Text = "";
                comboBoxEdit3.Text = "";
                
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            
            if (comboBoxEdit3.Text == "Bilgi İşlem")
            {
                bolumID = 1;
            }
            if (comboBoxEdit3.Text == "Satın Alma")
            {
                bolumID = 2;
            }
            if (comboBoxEdit3.Text == "İK")
            {
                bolumID = 3;
            }
            if (dateEdit1.DateTime < DateTime.Today)
            {
                MessageBox.Show("Yanlış tarih girişi");
                comboBoxEdit2.Text = "";
                memoEdit1.Text = "";
                dateEdit1.Text = "";
                comboBoxEdit3.Text = "";

            }
            else
            {
                baglanti.Open();

               // SqlCommand komut = new SqlCommand("update bilgi set cagri_aciliyet = @cagri_aciliyet, cagri_durum = @cagri_durum , cagri_tarih = @cagri_tarih , cagri_aciklama = @cagri_aciklama where ID = " +(textEdit1.Text) + "", baglanti);
                SqlCommand komut = new SqlCommand("update bilgi set cagri_aciliyet = '" + comboBoxEdit2.Text + "', cagri_durum = '" + comboBoxEdit1.Text + "' , cagri_aciklama = '" + memoEdit1.Text.Trim() + "' , bolum_id = '"+bolumID+ "', bolum_ad = '" + comboBoxEdit3.Text.Trim() + "',cagri_icerik = '"+sonıd+ "',cagri_adi = '" + ad + "' where ID = " + textEdit1.Text + "", baglanti);
               // SqlCommand komut = new SqlCommand("update bilgi set cagri_aciliyet = '" + comboBoxEdit2.Text + "', cagri_durum = '" + comboBoxEdit1.Text + "' where ID = " + textEdit1.Text + "", baglanti);
                //komut.parameters.addwithvalue("@cagri_aciliyet", comboboxedit2.text);
                //komut.parameters.addwithvalue("@cagri_tarih", dateedit1.datetime);
                //komut.parameters.addwithvalue("@cagri_durum", comboboxedit1.text);
                //komut.parameters.addwithvalue("@cagri_aciklama", memoedit1.text);

                baglanti.Close();
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                string kaydet = "insert into kullanici_güncelleme(kullanici_güncelleme,tarih,kullanici_sicil,siralama_tarih,bolum_id,cagri_id) values (@kullanici_güncelleme,@tarih,@kullanici_sicil,@siralama_tarih,@bolum_id,@cagri_id)";

                SqlCommand cmd = new SqlCommand(kaydet, baglanti);
                string kullaniciguncellemee = "" + textEdit2.Text.Trim() + " sicil numaralı kullanıcı" + DateTime.Now + " tarihinde " + textEdit1.Text.Trim() + " ID'li çağrısının aciliyetini " + comboBoxEdit2.Text.Trim() + " olarak güncelledi. Açıklama " + memoEdit1.Text.Trim();

                cmd.Parameters.AddWithValue("@kullanici_güncelleme", kullaniciguncellemee);
                cmd.Parameters.AddWithValue("@tarih", DateTime.Now);
                cmd.Parameters.AddWithValue("@kullanici_sicil", textEdit2.Text.Trim());
                cmd.Parameters.AddWithValue("@siralama_tarih", dateEdit1.DateTime);
                cmd.Parameters.AddWithValue("@bolum_id", bolumID);
                cmd.Parameters.AddWithValue("@cagri_id", textEdit1.Text);
                baglanti.Close();
                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                this.bilgiTableAdapter6.Fill(this.cagriDataSet51.bilgi, textEdit2.Text);
                MessageBox.Show("Güncellendi");
                
                //this.bilgiTableAdapter5.FillBy(this.cagriDataSet25.bilgi, textEdit2.Text);
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from bilgi where ID =(" + textEdit1.Text.Trim() + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            kapatıcı.Visible = true;
            string kaydet = "insert into kullanici_güncelleme(kullanici_güncelleme,tarih,kullanici_sicil,bolum_id) values (@kullanicisilme,@tarih,@kullanici_sicil,@bolum_id)";
            SqlCommand cmd = new SqlCommand(kaydet, baglanti);
            string kullanicisilme = "" + textEdit2.Text.Trim() + " sicil numaralı kullanıcı " + textEdit1.Text.ToString() + " ID'li çağrısını " + DateTime.Now + " tarihinde sildi.";
            cmd.Parameters.AddWithValue("@kullanici_sicil", textEdit2.Text.Trim());
            cmd.Parameters.AddWithValue("@kullanicisilme", kullanicisilme);
            cmd.Parameters.AddWithValue("@tarih", DateTime.Now);
            cmd.Parameters.AddWithValue("@bolum_id", bolumID);
            cmd.Parameters.AddWithValue("@cagri_id", textEdit1.Text);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            
            comboBoxEdit2.Text = "";
            memoEdit1.Text = "";
            dateEdit1.Text = "";
            comboBoxEdit3.Text = "";
            this.bilgiTableAdapter6.Fill(this.cagriDataSet51.bilgi, textEdit2.Text);
            //this.bilgiTableAdapter4.FillBy(this.cagriDataSet11.bilgi, textEdit2.Text);
            MessageBox.Show("Silindi");
        }
        private void gridControl1_Click_1(object sender, EventArgs e)
        {
            textEdit1.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            textEdit2.Text = gridView1.GetFocusedRowCellValue("cagri_sahibi").ToString();
            dateEdit1.Text = gridView1.GetFocusedRowCellValue("cagri_tarih").ToString();
            //comboBoxEdit1.Text = gridView1.GetFocusedRowCellValue("cagri_durum").ToString();
            comboBoxEdit2.Text = gridView1.GetFocusedRowCellValue("cagri_aciliyet").ToString();
            memoEdit1.Text = gridView1.GetFocusedRowCellValue("cagri_aciklama").ToString();
            

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            textEdit1.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            textEdit2.Text = gridView1.GetFocusedRowCellValue("cagri_sahibi").ToString();
            dateEdit1.Text = gridView1.GetFocusedRowCellValue("cagri_tarih").ToString();
            //comboBoxEdit1.Text = gridView1.GetFocusedRowCellValue("cagri_durum").ToString();
            comboBoxEdit2.Text = gridView1.GetFocusedRowCellValue("cagri_aciliyet").ToString();
            memoEdit1.Text = gridView1.GetFocusedRowCellValue("cagri_aciklama").ToString();
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            this.admin_guncellemeTableAdapter1.Fill(this.cagriDataSet22.admin_guncelleme, textEdit2.Text);
            kapatıcı.Visible = true;
            this.bilgiTableAdapter6.Fill(this.cagriDataSet51.bilgi, textEdit2.Text);
            //this.bilgiTableAdapter5.FillBy(this.cagriDataSet25.bilgi, textEdit2.Text);
            this.admin_guncellemeTableAdapter.FillBy(this.cagriDataSet13.admin_guncelleme, (textEdit2.Text));
            this.kullanici_bilgiTableAdapter1.FillBy(this.cagriDataSet39.kullanici_bilgi, Convert.ToInt32(textEdit2.Text));
            this.admin_guncellemeTableAdapter2.FillBy1(this.cagriDataSet37.admin_guncelleme, textEdit2.Text);
            this.admin_guncellemeTableAdapter5.Fill(this.cagriDataSet45.admin_guncelleme,textEdit2.Text);
            //this.gridView6.FocusedRowHandle = 0;
            //sonıd = gridView6.GetFocusedRowCellValue("ID").ToString();
            //comboBoxEdit2.Text = "";
            //memoEdit1.Text = "";
            //dateEdit1.Text = "";
            //comboBoxEdit3.Text = "";
            simpleButton4.Enabled = false;
            labelControl9.Visible = false;
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            

            if (gridView1.IsEditorFocused)
            {
                kapatıcı.Visible = false;
                textEdit1.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                textEdit2.Text = gridView1.GetFocusedRowCellValue("cagri_sahibi").ToString();
                dateEdit1.Text = gridView1.GetFocusedRowCellValue("cagri_tarih").ToString();
                //comboBoxEdit1.Text = gridView1.GetFocusedRowCellValue("cagri_durum").ToString();
                comboBoxEdit2.Text = gridView1.GetFocusedRowCellValue("cagri_aciliyet").ToString();
                //textEdit1.Text = gridView1.
                memoEdit1.Text = gridView1.GetFocusedRowCellValue("cagri_aciklama").ToString();
                memoEdit2.Text = gridView1.GetFocusedRowCellValue("admin_aciklama").ToString();
                comboBoxEdit3.Text = gridView1.GetFocusedRowCellValue("bolum_ad").ToString();
              //  labelControl9.Text= gridView1.GetFocusedRowCellValue("cagri_adi").ToString();
                // labelControl9.Text= gridView1.GetFocusedRowCellValue("cagri_adi").ToString();
                this.admin_guncellemeTableAdapter5.FillBy(this.cagriDataSet45.admin_guncelleme,Convert.ToInt32( textEdit1.Text));
                memoEdit1.Text = memoEdit1.Text.Trim();
                simpleButton4.Enabled = true;
                //this.admin_guncellemeTableAdapter4.FillBy(this.cagriDataSet43.admin_guncelleme, Convert.ToInt32(textEdit1.Text));
                // this.bilgiTableAdapter15.Fill(this.cagriDataSet41.bilgi);
                //this.bilgiTableAdapter15.FillBy(this.cagriDataSet41.bilgi, textEdit2.Text);

               // labelControl9.Visible = true;
                
            }
            if (gridView6.IsEditorFocused)
            {
                this.ActiveControl = this.gridControl6;

                this.gridView6.FocusedRowHandle = 0;
                sonıd = gridView6.GetFocusedRowCellValue("ID").ToString();
            }
        }
        string extn,extn2,extn3,extn4;

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            byte[] byt;
            openFileDialog1.ShowDialog();
            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                ekkontrol4 = 1;
                ekSayac++;
                string path = openFileDialog1.FileName;
                System.IO.FileInfo ff = new System.IO.FileInfo(openFileDialog1.FileName);
                extn4 = ff.Extension;
                ad4 = ff.Name;
                byt = File.ReadAllBytes(path);
                stbyt4 = byt;
                string picPath = openFileDialog1.FileName.ToString();
                textEdit6.Text = picPath;
                eksyc++;
                labelControl12.Text = ad4;
                MessageBox.Show("Ek seçildi");
            }
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            byte[] byt;
            openFileDialog1.ShowDialog();
            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                ekkontrol3 = 1;
                ekSayac++;
                string path = openFileDialog1.FileName;
                System.IO.FileInfo ff = new System.IO.FileInfo(openFileDialog1.FileName);
                extn3 = ff.Extension;
                ad3 = ff.Name;
                byt = File.ReadAllBytes(path);
                stbyt3 = byt;
                string picPath = openFileDialog1.FileName.ToString();
                textEdit6.Text = picPath;
                eksyc++;
                labelControl11.Text = ad3;
                MessageBox.Show("Ek seçildi");
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            byte[] byt;
            openFileDialog1.ShowDialog();
            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                ekkontrol2 = 1;
                ekSayac++;
                string path = openFileDialog1.FileName;
                System.IO.FileInfo ff = new System.IO.FileInfo(openFileDialog1.FileName);
                extn2 = ff.Extension;
                ad2 = ff.Name;
                byt = File.ReadAllBytes(path);
                stbyt2 = byt;
                string picPath = openFileDialog1.FileName.ToString();
                textEdit6.Text = picPath;
                eksyc++;
                labelControl10.Text = ad2;
                MessageBox.Show("Ek seçildi");
            }
        }

        string ad,ad2,ad3,ad4;
        private void simpleButton3_Click(object sender, EventArgs e)
        {

            byte[] byt;
            openFileDialog1.ShowDialog();
            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                ekkontrol = 1;
                ekSayac++;
                string path = openFileDialog1.FileName;
                System.IO.FileInfo ff = new System.IO.FileInfo(openFileDialog1.FileName);
                extn = ff.Extension;
                ad = ff.Name;
                byt = File.ReadAllBytes(path);
                stbyt = byt;
                string picPath = openFileDialog1.FileName.ToString();
                textEdit6.Text = picPath;
                eksyc++;
                labelControl9.Text = ad;
                MessageBox.Show("Ek seçildi");
                labelControl9.Visible = true;
            }
            //OpenFileDialog dlg = new OpenFileDialog();
            //if (dlg.ShowDialog() == DialogResult.OK)
            //{
            //    string picPath = dlg.FileName.ToString();
            //    textEdit6.Text = picPath;
            //}


        }

        private void gridControl3_Click(object sender, EventArgs e)
        {

        }

        private void gridControl5_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog()==DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                textEdit6.Text = picPath;
            }
        }
    }

}

