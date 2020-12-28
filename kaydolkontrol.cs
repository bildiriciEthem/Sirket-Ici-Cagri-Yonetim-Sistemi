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
using DevExpress.XtraToolbox;
using DevExpress.XtraEditors;

namespace cagri
{
    
    public partial class kaydolkontrol : UserControl
    {
        
        public kaydolkontrol()
        {

            InitializeComponent();
        }
        int sayac = 0;
        public static TextEdit txtisim;
        
        public static TextEdit txtsicil;
        int bolum;
        SqlConnection baglanti = new SqlConnection("Data Source=BTSOFT\\SQLEXPRESS;Initial Catalog=cagri;Integrated Security=True");
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            AAA:
            SqlDataReader oku;
            int sayacc = 0;
           
            //SqlCommand komutt = new SqlCommand("select *from kullanici_bilgi where bolum='" + lookUpEdit1.Text + "'", baglanti);
           // DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("Select bolum_ad from bolum",baglanti);
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kullanici_bilgi where kullanici_ad='" + (textEdit1.Text) + "'", baglanti);
            oku = komut.ExecuteReader();
            
            //if (oku.Read())
            //{

            //    sayacc++;
            //    checkEdit1.Checked = false;
            //    checkEdit2.Checked = false;
            //    checkEdit3.Checked = false;
            //    checkEdit4.Checked = false;
            //    checkEdit5.Checked = false;
            //    //checkBox1.Checked = false;
            //    //checkBox2.Checked = false;
            //    //checkBox3.Checked = false;
            //    MessageBox.Show("Bu kullanıcı adı kullanılıyor");
            //    baglanti.Close();
                


            //}
            baglanti.Close();
            SqlDataReader oku1;
            
            SqlCommand komut1 = new SqlCommand("select *from kullanici_bilgi where kullanici_sicil='" +( textEdit3.Text) + "'", baglanti);
            baglanti.Open();
            oku1 = komut1.ExecuteReader();
            

            if (oku1.Read())
            {
                sayacc++;
               textEdit1.Text = "";
                textEdit2.Text = "";
                textEdit3.Text = "";
                checkEdit1.Checked = false;
                checkEdit2.Checked = false;
                checkEdit3.Checked = false;
                checkEdit4.Checked = false;
                checkEdit5.Checked = false;
                //checkBox1.Checked = false;
                //checkBox2.Checked = false;
                //checkBox3.Checked = false;
                MessageBox.Show("Bu Sicil No kullanılıyor");
                baglanti.Close();
                
            }

            else
            {
                baglanti.Close();

                if (checkEdit1.Checked == true)
                {
                    int ozel = 1;
                    baglanti.Open();
                    string kaydet = "insert into kullanici_bilgi(kullanici_ad,kullanici_sifre,kullanici_sicil,ozel_id) values (@kullanici_adi,@kullanici_sifre,@kullanici_sicil,@ozel_id)";
                    SqlCommand cmd = new SqlCommand(kaydet, baglanti);

                    cmd.Parameters.AddWithValue("@kullanici_adi", textEdit1.Text.Trim());
                    cmd.Parameters.AddWithValue("@kullanici_sifre", textEdit2.Text.Trim());
                    cmd.Parameters.AddWithValue("@kullanici_sicil", textEdit3.Text.Trim());
                    cmd.Parameters.AddWithValue("@ozel_id", ozel);


                    baglanti.Close();
                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    sayac++;

                }
                if (checkEdit2.Checked == true)
                {
                    int ozel = 2;
                    baglanti.Open();
                    string kaydet = "insert into kullanici_bilgi(kullanici_ad,kullanici_sifre,kullanici_sicil,ozel_id) values (@kullanici_adi,@kullanici_sifre,@kullanici_sicil,@ozel_id)";
                    SqlCommand cmd = new SqlCommand(kaydet, baglanti);

                    cmd.Parameters.AddWithValue("@kullanici_adi", textEdit1.Text.Trim());
                    cmd.Parameters.AddWithValue("@kullanici_sifre", textEdit2.Text.Trim());
                    cmd.Parameters.AddWithValue("@kullanici_sicil", textEdit3.Text.Trim());
                    cmd.Parameters.AddWithValue("@ozel_id", ozel);


                    baglanti.Close();
                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    sayac++;

                }
                if (checkEdit3.Checked == true)
                {
                    int ozel = 3;
                    baglanti.Open();
                    string kaydet = "insert into kullanici_bilgi(kullanici_ad,kullanici_sifre,kullanici_sicil,ozel_id) values (@kullanici_adi,@kullanici_sifre,@kullanici_sicil,@ozel_id)";
                    SqlCommand cmd = new SqlCommand(kaydet, baglanti);

                    cmd.Parameters.AddWithValue("@kullanici_adi", textEdit1.Text.Trim());
                    cmd.Parameters.AddWithValue("@kullanici_sifre", textEdit2.Text.Trim());
                    cmd.Parameters.AddWithValue("@kullanici_sicil", textEdit3.Text.Trim());
                    cmd.Parameters.AddWithValue("@ozel_id", ozel);


                    baglanti.Close();
                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    sayac++;

                }
                if (checkEdit4.Checked == true)
                {
                    int ozel = 4;
                    baglanti.Open();
                    string kaydet = "insert into kullanici_bilgi(kullanici_ad,kullanici_sifre,kullanici_sicil,ozel_id) values (@kullanici_adi,@kullanici_sifre,@kullanici_sicil,@ozel_id)";
                    SqlCommand cmd = new SqlCommand(kaydet, baglanti);

                    cmd.Parameters.AddWithValue("@kullanici_adi", textEdit1.Text.Trim());
                    cmd.Parameters.AddWithValue("@kullanici_sifre", textEdit2.Text.Trim());
                    cmd.Parameters.AddWithValue("@kullanici_sicil", textEdit3.Text.Trim());
                    cmd.Parameters.AddWithValue("@ozel_id", ozel);


                    baglanti.Close();
                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    baglanti.Close();

                    sayac++;
                }
                if (checkEdit5.Checked == true)
                {
                    int ozel = 5;
                    baglanti.Open();
                    string kaydet = "insert into kullanici_bilgi(kullanici_ad,kullanici_sifre,kullanici_sicil,ozel_id) values (@kullanici_adi,@kullanici_sifre,@kullanici_sicil,@ozel_id)";
                    SqlCommand cmd = new SqlCommand(kaydet, baglanti);

                    cmd.Parameters.AddWithValue("@kullanici_adi", textEdit1.Text.Trim());
                    cmd.Parameters.AddWithValue("@kullanici_sifre", textEdit2.Text.Trim());
                    cmd.Parameters.AddWithValue("@kullanici_sicil", textEdit3.Text.Trim());
                    cmd.Parameters.AddWithValue("@ozel_id", ozel);


                    baglanti.Close();
                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    sayac++;

                }
                if (checkEdit6.Checked == true)
                {
                    int ozel = 9;
                    baglanti.Open();
                    string kaydet = "insert into kullanici_bilgi(kullanici_ad,kullanici_sifre,kullanici_sicil,ozel_id) values (@kullanici_adi,@kullanici_sifre,@kullanici_sicil,@ozel_id)";
                    SqlCommand cmd = new SqlCommand(kaydet, baglanti);

                    cmd.Parameters.AddWithValue("@kullanici_adi", textEdit1.Text.Trim());
                    cmd.Parameters.AddWithValue("@kullanici_sifre", textEdit2.Text.Trim());
                    cmd.Parameters.AddWithValue("@kullanici_sicil", textEdit3.Text.Trim());
                    cmd.Parameters.AddWithValue("@ozel_id", ozel);


                    baglanti.Close();
                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    sayac++;

                }
                if (lookUpEdit1.Text== "Bilgi İşlem    ")
                {
                    int ozel = 6;
                     bolum = 6;
                    baglanti.Open();
                    string kaydet = "insert into kullanici_bilgi(kullanici_ad,kullanici_sifre,kullanici_sicil,ozel_id) values (@kullanici_adi,@kullanici_sifre,@kullanici_sicil,@ozel_id)";
                    SqlCommand cmd = new SqlCommand(kaydet, baglanti);

                    cmd.Parameters.AddWithValue("@kullanici_adi", textEdit1.Text.Trim());
                    cmd.Parameters.AddWithValue("@kullanici_sifre", textEdit2.Text.Trim());
                    cmd.Parameters.AddWithValue("@kullanici_sicil", textEdit3.Text.Trim());
                    cmd.Parameters.AddWithValue("@ozel_id", ozel);


                    baglanti.Close();
                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    sayac++;
                }
                if (lookUpEdit1.Text== "Satın Alma     ")
                {
                    int ozel = 7;
                     bolum = 7;
                    baglanti.Open();
                    string kaydet = "insert into kullanici_bilgi(kullanici_ad,kullanici_sifre,kullanici_sicil,ozel_id) values (@kullanici_adi,@kullanici_sifre,@kullanici_sicil,@ozel_id)";
                    SqlCommand cmd = new SqlCommand(kaydet, baglanti);

                    cmd.Parameters.AddWithValue("@kullanici_adi", textEdit1.Text.Trim());
                    cmd.Parameters.AddWithValue("@kullanici_sifre", textEdit2.Text.Trim());
                    cmd.Parameters.AddWithValue("@kullanici_sicil", textEdit3.Text.Trim());
                    cmd.Parameters.AddWithValue("@ozel_id", ozel);


                    baglanti.Close();
                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    sayac++;
                }
                if (lookUpEdit1.Text== "İK             ")
                {
                    int ozel = 8;
                     bolum = 8;
                    baglanti.Open();
                    string kaydet = "insert into kullanici_bilgi(kullanici_ad,kullanici_sifre,kullanici_sicil,ozel_id) values (@kullanici_adi,@kullanici_sifre,@kullanici_sicil,@ozel_id)";
                    SqlCommand cmd = new SqlCommand(kaydet, baglanti);

                    cmd.Parameters.AddWithValue("@kullanici_adi", textEdit1.Text.Trim());
                    cmd.Parameters.AddWithValue("@kullanici_sifre", textEdit2.Text.Trim());
                    cmd.Parameters.AddWithValue("@kullanici_sicil", textEdit3.Text.Trim());
                    cmd.Parameters.AddWithValue("@ozel_id", ozel);


                    baglanti.Close();
                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    sayac++;
                }
                if (lookUpEdit1.Text==" " && checkEdit1.Checked==false&& checkEdit2.Checked == false && checkEdit3.Checked == false && checkEdit4.Checked == false && checkEdit5.Checked == false)
                {
                    sayacc++;
                    MessageBox.Show("Yetki seçmediniz");
                }
                if (sayac >0)
                {
                    baglanti.Open();
                    string kayıt = "insert into kullanici_sekme(adi,sicil,bolum_id) values (@adi,@sicil,@bolum_id)";
                    SqlCommand c = new SqlCommand(kayıt, baglanti);
                    c.Parameters.AddWithValue("@adi", textEdit1.Text.Trim());
                    c.Parameters.AddWithValue("@sicil", textEdit3.Text.Trim());
                    c.Parameters.AddWithValue("@bolum_id", bolum);
                    baglanti.Close();
                    baglanti.Open();
                    c.ExecuteNonQuery();
                    baglanti.Close();

                }
                if (sayacc==0)
                {
                    //MessageBox.Show(ozel.ToString());
                 textEdit1.Text = "";
                    textEdit2.Text = "";
                    textEdit3.Text = "";
                    checkEdit1.Checked = false;
                    checkEdit2.Checked = false;
                    checkEdit3.Checked = false;
                    checkEdit4.Checked = false;
                    checkEdit5.Checked = false;
                    checkEdit6.Checked = false;
                    MessageBox.Show("Kayıt Başarılı");


                }

                this.kullanici_sekmeTableAdapter2.Fill(cagriDataSet53.kullanici_sekme);

            }
            this.kullanici_sekmeTableAdapter2.Fill(cagriDataSet53.kullanici_sekme);
        }

        private void kaydolkontrol_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Text = " ";
            this.kullanici_sekmeTableAdapter2.Fill(cagriDataSet53.kullanici_sekme);
            //DataRowView satir = lookUpEdit1.Properties.GetDataSourceRowByKeyValue(lookUpEdit1.EditValue) as DataRowView;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID,bolum_ad from bolum", baglanti);

            baglanti.Open();
            da.Fill(dt);
            lookUpEdit1.Properties.DataSource = dt;
            baglanti.Close();
            
        }
        public static string isimm;
        
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
           
            string silmeSorgusu = "DELETE from kullanici_bilgi where kullanici_ad=@kullanici_ad";
            
            //musterino parametresine bağlı olarak müşteri kaydını silen sql sorgusu
            SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglanti);
            silKomutu.Parameters.AddWithValue("@kullanici_ad", textEdit1.Text);
            silKomutu.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            string silmeSorgusu2 = "DELETE from kullanici_sekme where sicil=@sicil";
            SqlCommand silKomutu2 = new SqlCommand(silmeSorgusu2, baglanti);
            silKomutu2.Parameters.AddWithValue("@sicil", textEdit3.Text);
            silKomutu2.ExecuteNonQuery();
            baglanti.Close();
            simpleButton1.PerformClick();


        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            //DataRowView satir = textEdit1.Properties.GetDataSourceRowByKeyValue(textEdit1.EditValue) as DataRowView;
            //textEdit3.Text = satir[1].ToString();

        }

        private void textEdit1_Leave(object sender, EventArgs e)
        {
            //textEdit1.Text = isimm;
        }
       

        private void textEdit1_Properties_KeyDown(object sender, KeyEventArgs e)
        {
            //string isim = textEdit1.Text;
            //isimm = isim;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gridView1.IsEditorFocused)
            {
                checkEdit6.Checked = false;
                sayac++;
                textEdit1.Text = gridView1.GetFocusedRowCellValue("adi").ToString();
                textEdit3.Text = gridView1.GetFocusedRowCellValue("sicil").ToString();
                gridControl1.Visible = false;
                this.kullanici_bilgiTableAdapter2.Fill(this.cagriDataSet59.kullanici_bilgi, Convert.ToInt32(textEdit3.Text));
                var yetki = this.cagriDataSet59.kullanici_bilgi.Where(x => ((x.ozel_id == 1)));
                if (yetki.Count() == 1)
                {
                    checkEdit1.Checked = true;
                }
                var yetki1 = this.cagriDataSet59.kullanici_bilgi.Where(x => ((x.ozel_id == 2)));
                if (yetki1.Count() == 1)
                {
                    checkEdit2.Checked = true;
                }
                var yetki2 = this.cagriDataSet59.kullanici_bilgi.Where(x => ((x.ozel_id == 3)));
                if (yetki2.Count() == 1)
                {
                    checkEdit3.Checked = true;
                }
                var yetki3 = this.cagriDataSet59.kullanici_bilgi.Where(x => ((x.ozel_id == 4)));
                if (yetki3.Count() == 1)
                {
                    checkEdit4.Checked = true;
                }
                var yetki4 = this.cagriDataSet59.kullanici_bilgi.Where(x => ((x.ozel_id == 5)));
                if (yetki4.Count() == 1)
                {
                    checkEdit5.Checked = true;
                }
                var yetki8 = this.cagriDataSet59.kullanici_bilgi.Where(x => ((x.ozel_id == 9)));
                if (yetki8.Count() == 1)
                {
                    checkEdit6.Checked = true;
                }
                var yetki5 = this.cagriDataSet59.kullanici_bilgi.Where(x => ((x.ozel_id == 6)));
                var yetki6 = this.cagriDataSet59.kullanici_bilgi.Where(x => ((x.ozel_id == 7)));
                var yetki7 = this.cagriDataSet59.kullanici_bilgi.Where(x => ((x.ozel_id == 8)));
                if (yetki5.Count() == 1)
                {
                    lookUpEdit1.Text = "Bilgi İşlem";
                }
                
                else if (yetki6.Count() == 1)
                {
                    lookUpEdit1.Text = "Satın Alma";
                }
                
               else if (yetki7.Count() == 1)
                {
                    lookUpEdit1.Text = "İK";
                }
                gridControl1.Visible = false;
                labelControl4.Visible = false;
            }
        }

        private void textEdit1_DoubleClick(object sender, EventArgs e)
        {
          
        }
        int btnsyc = 2;
        private void textEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
            if (sayac%2==0)
            {
                gridControl1.Visible = true;
                labelControl4.Visible = true;
            }
            else
            {
                gridControl1.Visible = false;
                labelControl4.Visible = false;
            }
            sayac++;

        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            //DataRowView satir = lookUpEdit1.Properties.GetDataSourceRowByKeyValue(lookUpEdit1.EditValue) as DataRowView;
            
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {
            gridControl1.Visible = false;
            labelControl4.Visible = false;
        }

        private void lookUpEdit1_Click(object sender, EventArgs e)
        {
           // DataRowView satir = lookUpEdit1.Properties.GetDataSourceRowByKeyValue(lookUpEdit1.EditValue) as DataRowView;
        }

        private void lookUpEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //DataRowView satir = lookUpEdit1.Properties.GetDataSourceRowByKeyValue(lookUpEdit1.EditValue) as DataRowView;
        }
    }
}
