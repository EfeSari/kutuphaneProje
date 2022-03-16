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

namespace kutuphaneOtomasyonum
{
    public partial class kayitOl : Form
    {
        public kayitOl()
        {
            InitializeComponent();
        }
       
        bool durum;
        void tekrarlıKayit()
        {
              SqlCommand komutTekrarlıKayit = new SqlCommand("select * from yetkili where TCno=@p1",bag.baglan());
              komutTekrarlıKayit.Parameters.AddWithValue("@p1",mskTCno.Text);
              SqlDataReader dr = komutTekrarlıKayit.ExecuteReader();
              if (dr.Read())
              {
                  durum = false;
              }
            else
	        {
                   durum = true;
	        }
              bag.baglan().Close();

        }

         baglanti bag = new baglanti();
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            tekrarlıKayit();
            if (durum == true)
            {
                if (txtAd.Text == "" || txtSoyad.Text == "" || mskTCno.Text == "" || mskTelefon.Text == "" || txtSifre.Text == "" || cmbCinsiyet.Text == "")
                {
                    MessageBox.Show("Tüm alanlara veri girişi yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand komut = new SqlCommand("insert into yetkili (ad,soyad,TCno,telefon,sifre,cinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", bag.baglan());
                    komut.Parameters.AddWithValue("@p1", txtAd.Text);
                    komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                    komut.Parameters.AddWithValue("@p3", mskTCno.Text);
                    komut.Parameters.AddWithValue("@p4", mskTelefon.Text);
                    komut.Parameters.AddWithValue("@p5", txtSifre.Text);
                    komut.Parameters.AddWithValue("@p6", cmbCinsiyet.Text);


                    komut.ExecuteNonQuery();
                    bag.baglan().Close();
                    MessageBox.Show("Kaydınız başarıyla gerçekleşmiştir şifreniz :" + txtSifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Böyle bir kayıt zaten sistemimzide mevcut bilgilerinizi kontrol edin.");
            }
             
           
        }

        private void btnGeriDön_Click(object sender, EventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Giris frmAnaGiris = new Giris();
            frmAnaGiris.Show();
        }
    }
}
