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
    public partial class emanetKitapİade : Form
    {
        public emanetKitapİade()
        {
            InitializeComponent();
        }
        baglanti bag = new baglanti();
        DataSet daset = new DataSet();
        private void emanetKitapListeleme()
        {
            SqlDataAdapter da = new SqlDataAdapter("select *from emanetKitap", bag.baglan());
            da.Fill(daset, "emanetKitap");
            dgwİadeKitap.DataSource = daset.Tables["emanetKitap"];
        }
        private void emanetKitapİade_Load(object sender, EventArgs e)
        {
            emanetKitapListeleme();
        }

        private void txtTCgöreAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["emanetKitap"].Clear();
            SqlDataAdapter da = new SqlDataAdapter("select *from emanetKitap where TCno like '%"+txtTCgöreAra.Text+"%'",bag.baglan ());
            da.Fill(daset, "emanetKitap");
            bag.baglan().Close();
            if (txtTCgöreAra.Text=="")
            {
                daset.Tables["emanetKitap"].Clear();
                emanetKitapListeleme();
            }
        }

        private void txtBarkodGöreAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["emanetKitap"].Clear();
            SqlDataAdapter da = new SqlDataAdapter("select *from emanetKitap where barkodNo like '%" + txtBarkodGöreAra.Text + "%'", bag.baglan());
            da.Fill(daset, "emanetKitap");
            bag.baglan().Close();
            if (txtBarkodGöreAra.Text == "")
            {
                daset.Tables["emanetKitap"].Clear();
                emanetKitapListeleme();
            }
        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            SqlCommand komutTeslimAl = new SqlCommand("delete from emanetKitap where TCno=@p1 and barkodNo=@p2", bag.baglan());
            komutTeslimAl.Parameters.AddWithValue("@p1", dgwİadeKitap.CurrentRow.Cells["TCno"].Value.ToString());
            komutTeslimAl.Parameters.AddWithValue("@p2", dgwİadeKitap.CurrentRow.Cells["barkodNo"].Value.ToString());
            komutTeslimAl.ExecuteNonQuery();

            SqlCommand komutArttır = new SqlCommand("update kitap set stokSayisi=stokSayisi+'"+dgwİadeKitap.CurrentRow.Cells["kitapSayisi"].Value.ToString()+"'where barkodNo=@p1", bag.baglan());
            komutArttır.Parameters.AddWithValue("@p1", dgwİadeKitap.CurrentRow.Cells["barkodNo"].Value.ToString());
            komutArttır.ExecuteNonQuery();
            MessageBox.Show("Kitap başarıyla iade alınmıştır!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            daset.Tables["emanetKitap"].Clear();
            emanetKitapListeleme();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Programdan Çıkmak İstediğinizden Emin Misiniz?", "Çıkış Mesajı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (x == DialogResult.Yes)
            {
                Environment.Exit(0);

            }
            else if (x == DialogResult.No)
            {
                MessageBox.Show("Çıkış yapılmadı", "Bilgi Kutusu");

            }
        }

    }
}
