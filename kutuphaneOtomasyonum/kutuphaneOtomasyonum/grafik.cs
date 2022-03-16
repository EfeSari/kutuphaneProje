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
    public partial class grafik : Form
    {
        public grafik()
        {
            InitializeComponent();
        }
        baglanti bag = new baglanti();
        private void grafik_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand ("select ad,soyad,kitapSayisi from uye",bag.baglan());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                grafıkKıtapSayısı.Series["Okunan Kitap Sayısı"].Points.AddXY(dr["ad"].ToString(), dr["kitapSayisi"]);
            }
            bag.baglan().Close();
            grafıkKıtapSayısı.Series["Okunan Kitap Sayısı"].Color = Color.Green;
        }
    }
}
