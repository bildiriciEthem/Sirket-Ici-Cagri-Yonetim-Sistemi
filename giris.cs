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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        SqlDataReader oku;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-LVTU07Q\\SQLEXPRESS;Initial Catalog=cagri;Integrated Security=True");
        public static string gonderilecekSicilNo;
        public static object gonderilecekOzelNo;
        anaForm form = new anaForm();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select *from kullanici_bilgi where kullanici_ad='"+textEdit1.Text+"' and kullanici_sifre='"+textEdit2.Text+"'",baglanti );
            form1userkontrol form1 = new form1userkontrol();
            baglanti.Open();
            oku = komut.ExecuteReader();
            if (oku.Read())
            {

                giris.gonderilecekSicilNo = oku["kullanici_sicil"].ToString();
                giris.gonderilecekOzelNo = oku["ozel_id"];
                
               

                giris giriss = new giris();
                form.Show();
                this.Hide();

            }
            else if (textEdit1.Text=="admin"&&textEdit2.Text=="admin")
            {
              

                admin admin = new admin();
                giris giris = new giris();
                
               admin.Show();
                this.Hide();
                
                
            }
            else
            {
               
                textEdit1.Text = "";
                textEdit2.Text = "";
                MessageBox.Show("Kayıt bulunamadı");
            }
            baglanti.Close();
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            kaydol kaydol = new kaydol();
            kaydol.Show();

        }

        private void giris_Load(object sender, EventArgs e)
        {

        }

        private void giris_KeyDown(object sender, KeyEventArgs e)
        {

           
        }

        private void textEdit2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                simpleButton1.PerformClick();
            }
        }

        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton1.PerformClick();
            }
        }
    }
}
