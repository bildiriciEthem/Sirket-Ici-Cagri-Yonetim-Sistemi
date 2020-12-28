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
using System.IO;
using System.Management;




namespace cagri
{
    public partial class Form1 : Form
    {
        public static object idver()
        {
            string cpuInfo = string.Empty;
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                if (cpuInfo == "")
                {
                    //Get only the first CPU's ID
                    cpuInfo = mo.Properties["processorID"].Value.ToString();
                    break;
                }
            }
            return cpuInfo;
        }

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            foreach (var scrn in Screen.AllScreens)
            {
                if (scrn.Bounds.Contains(this.Location))
                {
                    this.Location = new Point(scrn.Bounds.Right - this.Width, scrn.Bounds.Top+23);
                    return;
                }
            }

        }
        public static string kullanicigıncelleme;
        SqlConnection baglanti = new SqlConnection("Data Source=BTSOFT\\SQLEXPRESS;Initial Catalog=cagri;Integrated Security=True");
        private void txtTalepNo_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void txtProje_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void txtKalem_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        public void verilerigoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from bilgi", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ID"].ToString();
                ekle.SubItems.Add(oku["cagri_sahibi"].ToString());
                ekle.SubItems.Add(oku["cagri_aciliyet"].ToString());
                ekle.SubItems.Add(oku["cagri_tarih"].ToString());
                ekle.SubItems.Add(oku["cagri_durum"].ToString());
                ekle.SubItems.Add(oku["cagri_aciklama"].ToString());
                ekle.SubItems.Add(oku["cagri_güncelleme"].ToString());
                ekle.SubItems.Add(oku["cagri_icerik"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateEdit1.Properties.Mask.Culture = new System.Globalization.CultureInfo("en-US");
            dateEdit1.Properties.Mask.EditMask = "MMM-dd-yyyy";
            dateEdit1.Properties.Mask.UseMaskAsDisplayFormat = true;
            dateEdit1.Properties.CharacterCasing = CharacterCasing.Upper;
            // TODO: This line of code loads data into the 'cagriDataSet25.bilgi' table. You can move, or remove it, as needed.
            //this.bilgiTableAdapter5.Fill(this.cagriDataSet25.bilgi);
            //this.bilgiTableAdapter5.FillBy(this.cagriDataSet25.bilgi, textEdit2.Text);
            textEdit2.Text = giris.gonderilecekSicilNo;
            // TODO: This line of code loads data into the 'cagriDataSet22.admin_guncelleme' table. You can move, or remove it, as needed.
            this.admin_guncellemeTableAdapter1.Fill(this.cagriDataSet22.admin_guncelleme, textEdit2.Text);
            // TODO: This line of code loads data into the 'cagriDataSet13.admin_guncelleme' table. You can move, or remove it, as needed.
            //this.admin_guncellemeTableAdapter.Fill(this.cagriDataSet13.admin_guncelleme);


            // TODO: This line of code loads data into the 'cagriDataSet11.bilgi' table. You can move, or remove it, as needed.
            //  this.bilgiTableAdapter4.Fill(this.cagriDataSet11.bilgi);
            ////this.bilgiTableAdapter4.FillBy(this.cagriDataSet11.bilgi, textEdit2.Text);
            // TODO: This line of code loads data into the 'cagriDataSet10.bilgi' table. You can move, or remove it, as needed.
           //// this.bilgiTableAdapter3.Fill(this.cagriDataSet10.bilgi);

            if (Convert.ToInt32(giris.gonderilecekOzelNo) == 7 * 11)
            {
                simpleButton1.Enabled = false;
            }
            if (Convert.ToInt32(giris.gonderilecekOzelNo) == 5 * 11)
            {
                simpleButton4.Enabled = false;
            }
            if (Convert.ToInt32(giris.gonderilecekOzelNo) == 11)
            {
                simpleButton1.Enabled = false;
                simpleButton4.Enabled = false;

            }
            if (Convert.ToInt32(giris.gonderilecekOzelNo) == 5 * 7)
            {
                simpleButton5.Enabled = false;
            }
            if (Convert.ToInt32(giris.gonderilecekOzelNo) == 1)
            {
                simpleButton4.Enabled = false;
                simpleButton5.Enabled = false;
                simpleButton1.Enabled = false;
            }
            if (Convert.ToInt32(giris.gonderilecekOzelNo) == 5)
            {
                simpleButton4.Enabled = false;
                simpleButton5.Enabled = false;
            }
            if (Convert.ToInt32(giris.gonderilecekOzelNo) == 7)
            {
                simpleButton5.Enabled = false;
                simpleButton1.Enabled = false;
            }

            // TODO: This line of code loads data into the 'cagriDataSet8.bilgi' table. You can move, or remove it, as needed.
            ////this.bilgiTableAdapter2.Fill(this.cagriDataSet8.bilgi);
            verilerigoster();
            int cagriNo;


            this.bilgiTableAdapter5.FillBy(this.cagriDataSet25.bilgi, textEdit2.Text);

            // dateEdit1.Text = (DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year);
            // TODO: This line of code loads data into the 'cagriDataSet4.bilgi' table. You can move, or remove it, as needed.
            // this.bilgiTableAdapter.Fill(this.cagriDataSet4.bilgi);
            this.admin_guncellemeTableAdapter.FillBy(this.cagriDataSet13.admin_guncelleme, (textEdit2.Text));
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        public string generateID()
        {
            return Guid.NewGuid().ToString("N");
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            //string fileName = textEdit6.Text;
            //BinaryWriter bwStream = new BinaryWriter(new FileStream(fileName, FileMode.Create));
            baglanti.Open();
            string kaydet = "insert into bilgi(cagri_sahibi,cagri_aciliyet,cagri_tarih,cagri_durum,cagri_aciklama,tarih,siralama_tarih) values (@cagri_sahibi,@cagri_aciliyet,@cagri_tarih,@cagri_durum,@cagri_aciklama,@tarih,@siralama_tarih)";
            SqlCommand cmd = new SqlCommand(kaydet, baglanti);
            
            
            // cmd.Parameters.AddWithValue("@cagri_no",Convert.ToInt32( textEdit1.Text.Trim()));
            // cmd.Parameters.AddWithValue("@cagri_no", idver());
            cmd.Parameters.AddWithValue("@cagri_sahibi", textEdit2.Text.Trim());
            cmd.Parameters.AddWithValue("@cagri_aciliyet", comboBoxEdit2.Text.Trim());
            cmd.Parameters.AddWithValue("@cagri_tarih",(dateEdit1.Text));
            cmd.Parameters.AddWithValue("@cagri_durum", comboBoxEdit1.Text.Trim());
            cmd.Parameters.AddWithValue("@cagri_aciklama", memoEdit1.Text.Trim());
            cmd.Parameters.AddWithValue("@tarih", DateTime.Now);
            cmd.Parameters.AddWithValue("@siralama_tarih", (dateEdit1.Text));
            cmd.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            string gonderilecekGuncelleme = "" + textEdit2.Text.Trim() + " sicil numaralı kullanıcı " + DateTime.Now + " tarihinde " + comboBoxEdit2.Text + " olarak hata bildirdi.\n";
            admin.gonderilecekGuncelleme = gonderilecekGuncelleme;
            string kaydett = "insert into kullanici_güncelleme(kullanici_güncelleme,tarih,kullanici_sicil,siralama_tarih) values (@kullanici_güncelleme,@tarih,@kullanici_sicil,@siralama_tarih)";
            SqlCommand cmdd = new SqlCommand(kaydett, baglanti);
            cmdd.Parameters.AddWithValue("@kullanici_güncelleme", gonderilecekGuncelleme);
            cmdd.Parameters.AddWithValue("@tarih", DateTime.Now);
            cmdd.Parameters.AddWithValue("@siralama_tarih",(dateEdit1.Text));
            cmdd.Parameters.AddWithValue("@kullanici_sicil", textEdit2.Text.Trim());
            //cmd.Parameters.AddWithValue("@cagri_icerik",(textEdit6.Text));

            cmdd.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();


            this.bilgiTableAdapter5.FillBy(this.cagriDataSet25.bilgi, textEdit2.Text);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            xtraOpenFileDialog1.ShowDialog();
            textEdit6.Text = xtraOpenFileDialog1.FileName;


        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update bilgi set cagri_aciliyet = '" + comboBoxEdit2.Text + "', cagri_durum = '" + comboBoxEdit1.Text + "', cagri_aciklama = '" + memoEdit1.Text + "' where ID = " + textEdit1.Text + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            string kaydet = "insert into kullanici_güncelleme(kullanici_güncelleme,tarih,kullanici_sicil,siralama_tarih) values (@kullanici_güncelleme,@tarih,@kullanici_sicil,@siralama_tarih)";
            SqlCommand cmd = new SqlCommand(kaydet, baglanti);
            string kullaniciguncellemee = "" + textEdit2.Text.Trim() + " sicil numaralı kullanıcı" + DateTime.Now + " tarihinde " + textEdit1.Text.Trim() + " ID'li çağrısının aciliyetini " + comboBoxEdit2.Text.Trim() + " olarak güncelledi. Açıklama " + memoEdit1.Text.Trim();

            cmd.Parameters.AddWithValue("@kullanici_güncelleme", kullaniciguncellemee);
            cmd.Parameters.AddWithValue("@tarih", DateTime.Now);
            cmd.Parameters.AddWithValue("@kullanici_sicil", textEdit2.Text.Trim());
            cmd.Parameters.AddWithValue("@siralama_tarih", dateEdit1.Text.Trim());
            baglanti.Close();
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            this.bilgiTableAdapter5.FillBy(this.cagriDataSet25.bilgi, textEdit2.Text);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            textEdit1.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            textEdit2.Text = gridView1.GetFocusedRowCellValue("cagri_sahibi").ToString();
            //textEdit3.Text = gridView1.GetFocusedRowCellValue("cagri_tarih").ToString();
            comboBoxEdit1.Text = gridView1.GetFocusedRowCellValue("cagri_durum").ToString();
            comboBoxEdit2.Text = gridView1.GetFocusedRowCellValue("cagri_aciliyet").ToString();
            memoEdit1.Text = gridView1.GetFocusedRowCellValue("cagri_aciklama").ToString();

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from bilgi where ID =(" + textEdit1.Text.Trim() + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            string kaydet = "insert into kullanici_güncelleme(kullanici_güncelleme,tarih,kullanici_sicil) values (@kullanicisilme,@tarih,@kullanici_sicil)";
            SqlCommand cmd = new SqlCommand(kaydet, baglanti);
            string kullanicisilme = "" + textEdit2.Text.Trim() + " sicil numaralı kullanıcı " + textEdit1.Text.ToString() + " ID'li çağrısını " + DateTime.Now + " tarihinde sildi.";
            cmd.Parameters.AddWithValue("@kullanici_sicil", textEdit2.Text.Trim());
            cmd.Parameters.AddWithValue("@kullanicisilme", kullanicisilme);
            cmd.Parameters.AddWithValue("@tarih",DateTime.Now);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            this.bilgiTableAdapter4.FillBy(this.cagriDataSet11.bilgi, textEdit2.Text);
        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {
            textEdit1.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            textEdit2.Text = gridView1.GetFocusedRowCellValue("cagri_sahibi").ToString();
            //textEdit3.Text = gridView1.GetFocusedRowCellValue("cagri_tarih").ToString();
            //comboBoxEdit1.Text = gridView1.GetFocusedRowCellValue("cagri_durum").ToString();
            comboBoxEdit2.Text = gridView1.GetFocusedRowCellValue("cagri_aciliyet").ToString();
            memoEdit1.Text = gridView1.GetFocusedRowCellValue("cagri_aciklama").ToString();
        }
    }
}
