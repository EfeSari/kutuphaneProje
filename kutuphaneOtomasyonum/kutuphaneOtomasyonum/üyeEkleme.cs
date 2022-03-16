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
    public partial class üyeEkleme : Form
    {
        public üyeEkleme()
        {
            InitializeComponent();
        }
        bool durum;
        void tekrarlıKayit()
        {
            SqlCommand komutTekrarlıKayit = new SqlCommand("select * from uye where TCno=@p1", bag.baglan());
            komutTekrarlıKayit.Parameters.AddWithValue("@p1", mskTCno.Text);
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
        private void btnEkle_Click(object sender, EventArgs e)
        {
            tekrarlıKayit();
            if (durum == true)
            {
                  if (txtAd.Text == "" || txtSoyad.Text == "" || mskTCno.Text == "" || mskTelefon.Text == "" || cmbCinsiyet.Text == "" || txtMail.Text == "" || txtOkuduguKitapSayisi.Text == "")
            {
                MessageBox.Show("Tüm alanlara veri girişi yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                SqlCommand komutUyeEkle = new SqlCommand("insert into uye (ad,soyad,TCno,telefon,cinsiyet,mail,kitapsayisi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bag.baglan());
                komutUyeEkle.Parameters.AddWithValue("@p1", txtAd.Text);
                komutUyeEkle.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komutUyeEkle.Parameters.AddWithValue("@p3", mskTCno.Text);
                komutUyeEkle.Parameters.AddWithValue("@p4", mskTelefon.Text);
                komutUyeEkle.Parameters.AddWithValue("@p5", cmbCinsiyet.Text);
                komutUyeEkle.Parameters.AddWithValue("@p6", txtMail.Text);
                komutUyeEkle.Parameters.AddWithValue("@p7", txtOkuduguKitapSayisi.Text);
               
                komutUyeEkle.ExecuteNonQuery();
                bag.baglan().Close();
                MessageBox.Show("Kaydınız başarıyla gerçekleşmiştir " , "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
            }
            else
            {
                MessageBox.Show("Böyle bir kayıt zaten sistemimzide mevcut bilgilerinizi kontrol edin.");
            }


        }
    }
}
