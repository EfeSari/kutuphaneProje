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
    public partial class kitapEkle : Form
    {
        public kitapEkle()
        {
            InitializeComponent();
        }
        baglanti bag = new baglanti();
          bool durum2;
          void tekrarlıKayit2()
          {
              SqlCommand komutTekrarlıKayit2 = new SqlCommand("select * from kitap where barkodNo=@p1", bag.baglan());
              komutTekrarlıKayit2.Parameters.AddWithValue("@p1", txtBarkodNo.Text);
              SqlDataReader dr2 = komutTekrarlıKayit2.ExecuteReader();
              if (dr2.Read())
              {
                  durum2 = false;
              }
              else
              {
                  durum2 = true;
              }
              bag.baglan().Close();
          }

        
        private void btnEkle_Click(object sender, EventArgs e)
        {
             tekrarlıKayit2();
            if (durum2 == true)
            {
                  if (txtBarkodNo.Text == "" || txtKitapAdi.Text == "" || txtYazari.Text == "" ||txtYayinevi.Text == "" || txtSayfaSayisi.Text == "" || cmbTuru.Text == "" || txtStokSayisi.Text == ""|| txtRafNo.Text == ""|| rtbAciklama.Text == "")
            {
                MessageBox.Show("Tüm alanlara veri girişi yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                SqlCommand komutUyeEkle = new SqlCommand("insert into kitap (barkodNo,ad,yazar,yayinevi,sayfaSayisi,turu,stokSayisi,rafNo,aciklama) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bag.baglan());
                komutUyeEkle.Parameters.AddWithValue("@p1",txtBarkodNo.Text);
                komutUyeEkle.Parameters.AddWithValue("@p2", txtKitapAdi.Text);
                komutUyeEkle.Parameters.AddWithValue("@p3", txtYazari.Text);
                komutUyeEkle.Parameters.AddWithValue("@p4", txtYayinevi.Text);
                komutUyeEkle.Parameters.AddWithValue("@p5", txtSayfaSayisi.Text);
                komutUyeEkle.Parameters.AddWithValue("@p6", cmbTuru.Text);
                komutUyeEkle.Parameters.AddWithValue("@p7", txtStokSayisi.Text);
                komutUyeEkle.Parameters.AddWithValue("@p8", txtRafNo.Text);
                komutUyeEkle.Parameters.AddWithValue("@p9", rtbAciklama.Text);
               
                komutUyeEkle.ExecuteNonQuery();
                bag.baglan().Close();
                MessageBox.Show("Kitap başarıyla eklendi" +txtKitapAdi.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
            }
            else
            {
                MessageBox.Show("Böyle bir kayıt zaten sistemimzide mevcut bilgilerinizi kontrol edin.");
            }


        }

        private void cmbTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rtbAciklama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRafNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStokSayisi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSayfaSayisi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYayinevi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYazari_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKitapAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
