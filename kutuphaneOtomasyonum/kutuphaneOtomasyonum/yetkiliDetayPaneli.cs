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
    public partial class yetkiliDetayPaneli : Form
    {
        public yetkiliDetayPaneli()
        {
            InitializeComponent();
        }
        public string TC;
        baglanti bag = new baglanti();
        private void yetkiliDetayPaneli_Load(object sender, EventArgs e)
        {
            lblTC.Text = TC;
            SqlCommand komut = new SqlCommand("select ad,soyad from yetkili where TCno=@p1", bag.baglan());
            komut.Parameters.AddWithValue("@p1", TC);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bag.baglan().Close();
        }

        private void btnÜyeEkle_Click(object sender, EventArgs e)
        {
            üyeEkleme frmUyeEkle = new üyeEkleme();
            frmUyeEkle.Show();
            
        }

        private void btnÜyeListele_Click(object sender, EventArgs e)
        {
            uyeLısteleme frmUyeListele = new uyeLısteleme();
            frmUyeListele.Show();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            kitapEkle frmKitapEkle = new kitapEkle();
            frmKitapEkle.Show();
        }

        private void btnKitapListele_Click(object sender, EventArgs e)
        {
            kitapListele frmKitapListe = new kitapListele();
            frmKitapListe.Show();
        }

        private void btnEmanetKitapVer_Click(object sender, EventArgs e)
        {
            EmanetKitapVerme frmEmanetKitap = new EmanetKitapVerme();
            frmEmanetKitap.Show();
        }

        private void btnEmanetKitapListele_Click(object sender, EventArgs e)
        {
            emanetKitapListele frmEmanetKitapListele = new emanetKitapListele();
            frmEmanetKitapListele.Show();

        }

        private void btnEmanetKitapİade_Click(object sender, EventArgs e)
        {
            emanetKitapİade frmEmanetKitapİade = new emanetKitapİade();
            frmEmanetKitapİade.Show();
        }

        private void btnSıralama_Click(object sender, EventArgs e)
        {
            sıralama frmSıralama = new sıralama();
            frmSıralama.Show();
        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            grafik frmGrafik = new grafik();
            frmGrafik.Show();
        }
    }
}
