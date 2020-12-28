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
using System.Threading;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.IO;
using System.IO.MemoryMappedFiles;



namespace cagri
{
    public partial class adminkontrol : UserControl
    {
        public adminkontrol()
        {
            InitializeComponent();
        }
        public static string gonderilecekGuncelleme;
        SqlConnection baglanti = new SqlConnection("Data Source=BTSOFT\\SQLEXPRESS;Initial Catalog=cagri;Integrated Security=True");
        private void adminkontrol_Load(object sender, EventArgs e)
        {


            this.bilgiTableAdapter15.Fill(this.cagriDataSet41.bilgi);
            this.bilgiTableAdapter14.Fill(this.cagriDataSet40.bilgi);
            this.kullanici_güncellemeTableAdapter3.Fill(this.cagriDataSet29.kullanici_güncelleme);
            //gridControl4.Visible = false;
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
            this.bilgiTableAdapter16.Fill(this.cagriDataSet44.bilgi);
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutt = new SqlCommand("update admin_mesaj set admin_guncelleme = '"+memoEdit2.Text.Trim()+"' where cagri_id = "+Convert.ToInt32( textEdit1.Text)+"",baglanti);
            komutt.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update bilgi set cagri_aciliyet = '" + comboBoxEdit2.Text + "', cagri_durum = '" + comboBoxEdit1.Text + "', admin_aciklama = '"+memoEdit2.Text.Trim()+"' where ID = " + textEdit1.Text + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            string kaydet = "insert into admin_guncelleme(kullanici_sicil,mesaj,tarih,cagri_id,guncelleyen_sicil) values (@kullanici_sicil,@mesaj,@tarih,@cagri_id,@guncelleyen_sicil)";
            SqlCommand cmd = new SqlCommand(kaydet, baglanti);


            cmd.Parameters.AddWithValue("@kullanici_sicil", textEdit2.Text.Trim());
            string mesaj = " Yönetici çağrınıza güncelleme yaptı yeni durumunuz " + comboBoxEdit1.Text.Trim() + ", aciliyetiniz " + comboBoxEdit2.Text.Trim() + " olarak değiştirildi.";
            int guncelleyen =Convert.ToInt32( giris.gonderilecekSicilNo);
            cmd.Parameters.AddWithValue("@guncelleyen_sicil",guncelleyen);
            cmd.Parameters.AddWithValue("@mesaj", mesaj);
            cmd.Parameters.AddWithValue("@tarih",Convert.ToDateTime( DateTime.Now));
            cmd.Parameters.AddWithValue("@cagri_id", Convert.ToInt32(textEdit1.Text));
            
            cmd.ExecuteNonQuery();
            string kaydett = "insert into kullanici_güncelleme(kullanici_sicil,kullanici_güncelleme,tarih,cagri_id) values (@kullanici_sicil,@kullanici_güncelleme,@tarih,@cagri_id)";
            SqlCommand cmdd = new SqlCommand(kaydett, baglanti);
            cmdd.Parameters.AddWithValue("@kullanici_sicil", textEdit2.Text.Trim());
            cmdd.Parameters.AddWithValue("@kullanici_güncelleme", mesaj);
            cmdd.Parameters.AddWithValue("@tarih",Convert.ToDateTime( DateTime.Now.ToString()));
            cmdd.Parameters.AddWithValue("@cagri_id", textEdit1.Text);

            baglanti.Close();
            baglanti.Open();
            cmdd.ExecuteNonQuery();
            baglanti.Close();
            this.bilgiTableAdapter11.Fill(this.cagriDataSet28.bilgi);
            this.bilgiTableAdapter15.Fill(this.cagriDataSet41.bilgi);
            this.bilgiTableAdapter16.Fill(this.cagriDataSet44.bilgi);
            //this.kullanici_güncellemeTableAdapter3.Fill(this.cagriDataSet29.kullanici_güncelleme);
            //this.kullanici_güncellemeTableAdapter3.Fill(this.cagriDataSet29.kullanici_güncelleme);
            //this.bilgiTableAdapter.Fill(this.cagriDataSet9.bil
        }

        private void gridControl4_Click(object sender, EventArgs e)
        {
            textEdit1.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            textEdit2.Text = gridView1.GetFocusedRowCellValue("cagri_sahibi").ToString();
            textEdit3.Text = gridView1.GetFocusedRowCellValue("cagri_tarih").ToString();
            comboBoxEdit1.Text = gridView1.GetFocusedRowCellValue("cagri_durum").ToString();
            comboBoxEdit2.Text = gridView1.GetFocusedRowCellValue("cagri_aciliyet").ToString();
            memoEdit1.Text = gridView1.GetFocusedRowCellValue("cagri_aciklama").ToString();
            //textEdit4.Text = gridView1.GetFocusedRowCellValue("cagri_sahibi").ToString();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            textEdit1.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            textEdit2.Text = gridView1.GetFocusedRowCellValue("cagri_sahibi").ToString();
            textEdit3.Text = gridView1.GetFocusedRowCellValue("cagri_tarih").ToString();
            comboBoxEdit1.Text = gridView1.GetFocusedRowCellValue("cagri_durum").ToString();
            comboBoxEdit2.Text = gridView1.GetFocusedRowCellValue("cagri_aciliyet").ToString();
            memoEdit1.Text = gridView1.GetFocusedRowCellValue("cagri_aciklama").ToString();
            // textEdit4.Text = gridView1.GetFocusedRowCellValue("cagri_sahibi").ToString();
            this.kullanici_güncellemeTableAdapter3.Fill(this.cagriDataSet29.kullanici_güncelleme);
            //gridControl4.Visible = false;
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
        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {
            textEdit1.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            textEdit2.Text = gridView1.GetFocusedRowCellValue("cagri_sahibi").ToString();
            textEdit3.Text = gridView1.GetFocusedRowCellValue("cagri_tarih").ToString();
            comboBoxEdit1.Text = gridView1.GetFocusedRowCellValue("cagri_durum").ToString();
            comboBoxEdit2.Text = gridView1.GetFocusedRowCellValue("cagri_aciliyet").ToString();
            memoEdit1.Text = gridView1.GetFocusedRowCellValue("cagri_aciklama").ToString();
            //textEdit4.Text = gridView1.GetFocusedRowCellValue("cagri_sahibi").ToString();
            this.kullanici_güncellemeTableAdapter3.Fill(this.cagriDataSet29.kullanici_güncelleme);
        }

        private void bilgiBindingSource11_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            textEdit1.Text = "";
            textEdit2.Text = "";
            textEdit3.Text = "";
            comboBoxEdit1.Text = "";
            comboBoxEdit2.Text = "";
            this.bilgiTableAdapter16.Fill(this.cagriDataSet44.bilgi);

            //this.bilgiTableAdapter14.Fill(this.cagriDataSet40.bilgi);
            //this.bilgiTableAdapter11.Fill(this.cagriDataSet28.bilgi);
            this.kullanici_güncellemeTableAdapter3.Fill(this.cagriDataSet29.kullanici_güncelleme);
        }

        private void textEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click_2(object sender, EventArgs e)
        {


        }

        private void gridControl1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
        }

        private void gridView1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_GotFocus(object sender, EventArgs e)
        {


        }

        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {

            //if (e.Button==MouseButtons.Left)
            //{
            //    //if (e.KeyCode == Keys.Enter)
            //    {
            //        textEdit1.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            //        textEdit2.Text = gridView1.GetFocusedRowCellValue("cagri_sahibi").ToString();
            //        textEdit3.Text = gridView1.GetFocusedRowCellValue("cagri_tarih").ToString();
            //        comboBoxEdit1.Text = gridView1.GetFocusedRowCellValue("cagri_durum").ToString();
            //        comboBoxEdit2.Text = gridView1.GetFocusedRowCellValue("cagri_aciliyet").ToString();
            //        //textEdit1.Text = gridView1.
            //        //memoEdit1.Text = gridView1.GetFocusedRowCellValue("cagri_aciklama").ToString();
            //        // this.bilgiTableAdapter15.Fill(this.cagriDataSet41.bilgi);
            //        this.bilgiTableAdapter15.FillBy(this.cagriDataSet41.bilgi, textEdit2.Text);
            //    }
            //}



        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        private void gridView1_GridMenuItemClick(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuItemClickEventArgs e)
        {

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

        }

        private void gridView1_BeforeLeaveRow(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {

        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {

        }

        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void adminkontrol_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {

        }

        private void toolTipController1_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e)
        {

        }

        private void gridControl1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void gridControl1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void gridControl1_MouseHover(object sender, EventArgs e)
        {

        }
        Byte[] donen;
        string dosyauzanti;
        string dosyaadi;
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
                 dosyauzanti= gridView1.GetFocusedRowCellValue("cagri_uzanti").ToString();
                 dosyaadi= gridView1.GetFocusedRowCellValue("cagri_adi").ToString(); 
                SqlCommand com = new SqlCommand("Select * from bilgi where ID="+textEdit1.Text +"", baglanti);
                baglanti.Open();
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    donen = (byte[])dr["cagri_icerik"];
                }
                baglanti.Close();
                //if (donen.Length > 0)
                //{

                //    System.IO.File.WriteAllBytes(@"C:\Users\bimsoft\Documents\Visual Studio 2017\Templates", donen);

                //}
                //var item = "cagri_icerik";
                //var sfd = new SaveFileDialog
                //{
                //    Title = "Kaydet",
                //    FileName = item.DosyaAdı
                //};
                //if (sfd.ShowDialog() == DialogResult.Ok)
                //{
                //    File.WriteAllBytes(item.Bytelar, sfd.FileName);
                //}
               
                
               
                // this.bilgiTableAdapter15.Fill(this.cagriDataSet41.bilgi);
                // this.bilgiTableAdapter15.FillBy(this.cagriDataSet41.bilgi, textEdit2.Text);
                this.kullanici_güncellemeTableAdapter3.FillBy(cagriDataSet29.kullanici_güncelleme, Convert.ToInt32(textEdit1.Text));
            }
            if (gridView2.IsEditorFocused)
            {
                textEdit1.Text = gridView2.GetFocusedRowCellValue("cagri_id").ToString();
                this.kullanici_güncellemeTableAdapter3.FillBy2(cagriDataSet29.kullanici_güncelleme,Convert.ToInt32( textEdit1.Text));
            }

        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
             //   File.WriteAllBytes(saveFileDialog1.FileName + dosyaadi.Trim() + "" + dosyauzanti.Trim() + "", donen);
                File.WriteAllBytes(saveFileDialog1.FileName + dosyaadi.Trim() +  "", donen);
                // File.WriteAllBytes(@"C: \Users\bimsoft\Documents\" + dosyaadi + "" + dosyauzanti + "", donen);
            }
        }
    }
}
