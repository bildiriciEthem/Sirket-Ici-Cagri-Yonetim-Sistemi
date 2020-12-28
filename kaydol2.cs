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
    public partial class kaydol2 : Form
    {
        public kaydol2()
        {
            InitializeComponent();
            //InitializeComponent();
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
        SqlConnection baglanti = new SqlConnection("Data Source=BTSOFT\\SQLEXPRESS;Initial Catalog=cagri;Integrated Security=True");
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            SqlDataReader oku;
            SqlCommand komut = new SqlCommand("select *from kullanici_bilgi where kullanici_ad='" + textEdit1.Text + "'", baglanti);
            baglanti.Open();
            oku = komut.ExecuteReader();

            //if (oku.Read() || textEdit1.Text == "admin")
            //{

            //    textEdit1.Text = "";
            //    textEdit2.Text = "";
            //    textEdit3.Text = "";
            //    //checkBox1.Checked = false;
            //    //checkBox2.Checked = false;
            //    //checkBox3.Checked = false;
            //    MessageBox.Show("Bu kullanıcı adı kullanılıyor");
            //    baglanti.Close();

            //}
            //else
            //{


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
            }
            //MessageBox.Show(ozel.ToString());

            MessageBox.Show("Kayıt Başarılı");
            // }



        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkEdit3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(checkEdit1.CheckState.ToString() + "    TEST ");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkEdit6.Checked)
            {
                MessageBox.Show("true");
            }
            else
            {
                MessageBox.Show("false");
            }
        }

        private void checkEdit6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
