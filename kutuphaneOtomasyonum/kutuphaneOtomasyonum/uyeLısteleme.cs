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
using Excel = Microsoft.Office.Interop.Excel;

namespace kutuphaneOtomasyonum
{
    public partial class uyeLısteleme : Form
    {
        public uyeLısteleme()
        {
            InitializeComponent();
        }

        private void dgwUye_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mskTCno.Text = dgwUye.CurrentRow.Cells["TCno"].Value.ToString();
        }

        private void mskTCara_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        baglanti bag = new baglanti();
        DataSet daset = new DataSet();
        private void mskTCara_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["uye"].Clear();
           SqlDataAdapter da = new SqlDataAdapter("select * from uye where TCno like '%" + mskTCara.Text + "%'", bag.baglan());
           da.Fill(daset, "uye");
           dgwUye.DataSource = daset.Tables["uye"];
            bag.baglan().Close();
        }

        private void uyeListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from uye", bag.baglan());
            da.Fill(daset, "uye");
            dgwUye.DataSource = daset.Tables["uye"];
            bag.baglan().Close();
        }
        private void uyeLısteleme_Load(object sender, EventArgs e)
        {
            uyeListele();
        }

        private void mskTCno_TextChanged(object sender, EventArgs e)
        {
            SqlCommand komutUyeAra = new SqlCommand("select * from uye where TCno like '" + mskTCno.Text + "'", bag.baglan());
            SqlDataReader dr = komutUyeAra.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr["ad"].ToString();
                txtSoyad.Text = dr["soyad"].ToString();
                // mskTCno.Text = dr["TCno"].ToString();
                mskTelefon.Text = dr["telefon"].ToString();
                cmbCinsiyet.Text = dr["cinsiyet"].ToString();
                txtMail.Text = dr["mail"].ToString();
                txtOkuduguKitapSayisi.Text = dr["kitapSayisi"].ToString();


            }
            bag.baglan().Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult silmeDialog;
            silmeDialog = MessageBox.Show("Bu kaydı silmek istiyor musunuz=","Bilgi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (silmeDialog==DialogResult.Yes)
            {
                SqlCommand uyeSil = new SqlCommand("delete from uye where TCno=@p1", bag.baglan());
                uyeSil.Parameters.AddWithValue("@p1", dgwUye.CurrentRow.Cells["TCno"].Value.ToString());
                uyeSil.ExecuteNonQuery();
                bag.baglan().Close();
                MessageBox.Show("Silme işleminiz başarılı", "Bilgi");
                daset.Tables["uye"].Clear();
                uyeListele();
            }
            
            
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
               SqlCommand uyeGuncelle = new SqlCommand("update uye set  TCno=@p0,ad=@p1,soyad=@p2,telefon=@p3,cinsiyet=@p4,mail=@p5,kitapSayisi=@p6 where TCno=@p0", bag.baglan());
                uyeGuncelle.Parameters.AddWithValue("@p0", mskTCno.Text);
                uyeGuncelle.Parameters.AddWithValue("@p1", txtAd.Text);
                uyeGuncelle.Parameters.AddWithValue("@p2", txtSoyad.Text);
                uyeGuncelle.Parameters.AddWithValue("@p3", mskTelefon.Text);
                uyeGuncelle.Parameters.AddWithValue("@p4", cmbCinsiyet.Text);
                uyeGuncelle.Parameters.AddWithValue("@p5", txtMail.Text);
                uyeGuncelle.Parameters.AddWithValue("@p6", txtOkuduguKitapSayisi.Text);
              
                 uyeGuncelle.ExecuteNonQuery();
                 bag.baglan().Close();
                 MessageBox.Show("Güncelleme işleminiz başarılı", "Bilgi");
                daset.Tables["uye"].Clear();
                uyeListele();
        }

        private void btnExcelAktar_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Aktarma işlemi fazla veri olduğundan uzun sürebilir onaylıyor musunuz?", "Aktarma İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
                    uyg.Visible = true;
                    Microsoft.Office.Interop.Excel.Workbook kitap = uyg.Workbooks.Add(System.Reflection.Missing.Value);
                    Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                    for (int i = 0; i < dgwUye.Columns.Count; i++)
                    {
                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[1, i + 1];
                        myRange.Value2 = dgwUye.Columns[i].HeaderText;

                    }

                    for (int i = 0; i < dgwUye.Columns.Count; i++)
                    {
                        for (int j = 0; j < dgwUye.Rows.Count; j++)
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[j + 2, i + 1];
                            myRange.Value2 = dgwUye[i, j].Value;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("İŞLEM İPTAL EDİLDİ.", "İşlem Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("İŞLEM TAMAMLANMADAN EXCEL PENCERESİNİ KAPATTINIZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
