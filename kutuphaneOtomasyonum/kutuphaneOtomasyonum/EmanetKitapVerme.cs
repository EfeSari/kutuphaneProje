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
    public partial class EmanetKitapVerme : Form
    {
        public EmanetKitapVerme()
        {
            InitializeComponent();
        }
        baglanti bag = new baglanti();
        DataSet dasetSepet = new DataSet();
        private void sepetiListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from sepet", bag.baglan());
            da.Fill(dasetSepet, "sepet");
            dataGridView1.DataSource = dasetSepet.Tables["sepet"];
            bag.baglan().Close();

        }

        private void kitapSayisi()
        {
            SqlCommand komutKitapSayisi = new SqlCommand("select sum(kitapSayisi) from sepet", bag.baglan());
            lblKitapSayisi.Text = komutKitapSayisi.ExecuteScalar().ToString();
            bag.baglan().Close();
        }
         private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into sepet (barkodNo,ad,yazar,yayinevi,sayfaSayisi,kitapSayisi,teslimTarihi,iadeTarihi) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bag.baglan());
            komut.Parameters.AddWithValue("@p1",  txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@p2",  txtKitapAdi.Text);
            komut.Parameters.AddWithValue("@p3",  txtYazari.Text);
            komut.Parameters.AddWithValue("@p4",  txtYayinevi.Text);
            komut.Parameters.AddWithValue("@p5",  txtSayfaSayisi.Text);
            komut.Parameters.AddWithValue("@p6",  txtKitapSayisi.Text);
            komut.Parameters.AddWithValue("@p7", dtpTeslim.Text);
            komut.Parameters.AddWithValue("@p8",  dtpİade.Text);
            komut.ExecuteNonQuery();
            bag.baglan().Close();
            MessageBox.Show("Kitaplar sepete eklendi ","Ekleme işlemi");
             dasetSepet.Tables["sepet"].Clear();
             sepetiListele();
             lblKitapSayisi.Text = "";
             kitapSayisi();
            foreach (Control item in grpKıtap.Controls)
            {
                if (item is TextBox)
                {
                    if (item!=txtKitapSayisi)
                    {
                        item.Text = "";
                    }
                }
            }


        }

         private void EmanetKitapVerme_Load(object sender, EventArgs e)
         {
             sepetiListele();
             kitapSayisi();
         }

         private void textBox1_TextChanged(object sender, EventArgs e)
         {
             SqlCommand komutTcara = new SqlCommand("select * from uye where TCno like'"+txtTcara.Text+"'", bag.baglan());
             SqlDataReader dr = komutTcara.ExecuteReader();
             while (dr.Read())
             {
                 txtAd.Text = dr["ad"].ToString();
                 txtSoyad.Text = dr["soyad"].ToString();
                 txtTelefon.Text = dr["telefon"].ToString();
             }
             bag.baglan().Close();
            
             SqlCommand komut = new SqlCommand("select sum(kitapSayisi) from emanetKitap where TCno='"+txtTcara.Text+"'", bag.baglan());
             lblKayitliKitap.Text = komut.ExecuteScalar().ToString();
             bag.baglan().Close();
             if (txtTcara.Text=="")
             {
                 foreach (Control item in grpUye.Controls)
                 {
                     if (item is TextBox)
                     {
                         item.Text = "";
                     }
                 }
                 lblKayitliKitap.Text = "";
             }
         }

         private void txtBarkodNo_TextChanged(object sender, EventArgs e)
         {
             SqlCommand komutBarkodAra = new SqlCommand("select * from kitap where barkodNo like '" + txtBarkodNo.Text + "'", bag.baglan());
             SqlDataReader drBarkod = komutBarkodAra.ExecuteReader();
             while (drBarkod.Read())
             {
                 txtKitapAdi.Text = drBarkod["ad"].ToString();
                 txtYazari.Text = drBarkod["yazar"].ToString();
                 txtYayinevi.Text = drBarkod["yayinevi"].ToString();
                 txtSayfaSayisi.Text = drBarkod["sayfaSayisi"].ToString();

             }
             bag.baglan().Close();
             if (txtBarkodNo.Text=="")
             {
                 foreach (Control item in grpKıtap.Controls)
                 {
                     if (item is TextBox)
                     {
                         if (item != txtKitapSayisi)
                         {
                             item.Text = "";
                         }
                     }
             }
             
             }
         }

         private void btnSil_Click(object sender, EventArgs e)
         {
             SqlCommand komutSil = new SqlCommand ("delete from sepet where barkodNo='"+dataGridView1.CurrentRow.Cells["barkodNo"].Value.ToString()+"'",bag.baglan());
             komutSil.ExecuteNonQuery();
             bag.baglan();
             MessageBox.Show("Silme işlemi başarışlı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
             dasetSepet.Tables["sepet"].Clear();
             sepetiListele();
             lblKitapSayisi.Text = "";
             kitapSayisi();
         }

         private void btnTeslimEt_Click(object sender, EventArgs e)
         {
             if (lblKitapSayisi.Text!="")
             {
                 if (lblKayitliKitap.Text=="" && int.Parse (lblKitapSayisi.Text)<=3 || lblKayitliKitap.Text!="" && int.Parse(lblKayitliKitap.Text)+int.Parse(lblKitapSayisi.Text)<=3 )
                 {
                     if (txtTcara.Text!="" && txtAd.Text !="" && txtSoyad.Text !="" && txtTelefon.Text!="" )
                     {
                         for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                         {
                             SqlCommand komut = new SqlCommand("insert into emanetKitap(TCno,ad,soyad,telefon,barkodNo,kitapAd,yazar,yayinevi,sayfaSayisi,kitapSayisi,teslimTarihi,iadeTarihi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12) ", bag.baglan());
                             komut.Parameters.AddWithValue("@p1", txtTcara.Text);
                             komut.Parameters.AddWithValue("@p2", txtAd.Text);
                             komut.Parameters.AddWithValue("@p3",  txtSoyad.Text);
                             komut.Parameters.AddWithValue("@p4", txtTelefon.Text);
                             komut.Parameters.AddWithValue("@p5", dataGridView1.Rows[i].Cells["barkodNo"].Value.ToString());
                             komut.Parameters.AddWithValue("@p6", dataGridView1.Rows[i].Cells["ad"].Value.ToString());
                             komut.Parameters.AddWithValue("@p7", dataGridView1.Rows[i].Cells["yazar"].Value.ToString());
                             komut.Parameters.AddWithValue("@p8", dataGridView1.Rows[i].Cells["yayinevi"].Value.ToString());
                             komut.Parameters.AddWithValue("@p9", dataGridView1.Rows[i].Cells["sayfaSayisi"].Value.ToString());
                             komut.Parameters.AddWithValue("@p10", int.Parse(dataGridView1.Rows[i].Cells["kitapSayisi"].Value.ToString()));
                             komut.Parameters.AddWithValue("@p11", dataGridView1.Rows[i].Cells["teslimTarihi"].Value.ToString());
                             komut.Parameters.AddWithValue("@p12", dataGridView1.Rows[i].Cells["iadeTarihi"].Value.ToString());
                             komut.ExecuteNonQuery();

                             SqlCommand komut2 = new SqlCommand("update uye set kitapSayisi=kitapSayisi+'"+int.Parse(dataGridView1.Rows[i].Cells["kitapSayisi"].Value.ToString())+"'where TCno='"+txtTcara.Text+"'",bag.baglan());
                             komut2.ExecuteNonQuery();
                             SqlCommand komut3 = new SqlCommand("update kitap set stokSayisi=stokSayisi-'" + int.Parse(dataGridView1.Rows[i].Cells["kitapSayisi"].Value.ToString()) + "'where barkodNo='" + dataGridView1.Rows[i].Cells["barkodNo"].Value.ToString() + "'", bag.baglan());
                             komut3.ExecuteNonQuery();
                             bag.baglan().Close();

                         }
                         SqlCommand komut4 = new SqlCommand("delete from sepet", bag.baglan());
                         komut4.ExecuteNonQuery();
                         bag.baglan().Close();
                         MessageBox.Show("Kitaplar emanet edildi","Bilgi");
                         dasetSepet.Tables["sepet"].Clear();
                         sepetiListele();
                         txtTcara.Text = "";
                         lblKitapSayisi.Text = "";
                         kitapSayisi();
                         lblKayitliKitap.Text = "";
                     }
                     else
                     {
                         MessageBox.Show("İlk olarak üye ismini seçmeniz gerekli","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                     }

                    
                 
                 }

                 else
                 {
                     MessageBox.Show("Emanet kitap sayısı 3'den fazla olamaz!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);   
                 }

                 
             }

             else
             {
                 MessageBox.Show("Önce sepete kitap eklenmelidir","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
             }





           
         }
    }
}
