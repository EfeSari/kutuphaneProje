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
    public partial class kitapListele : Form
    {
        public kitapListele()
        {
            InitializeComponent();
        }
        baglanti bag = new baglanti();
        DataSet daset = new DataSet();
        private void kitapListeleme()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from kitap", bag.baglan());
            da.Fill(daset, "kitap");
            dgwKıtap.DataSource = daset.Tables["kitap"];
            bag.baglan().Close();
        }
        private void kitapListele_Load(object sender, EventArgs e)
        {
            kitapListeleme();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult silmeDialog;
            silmeDialog = MessageBox.Show("Bu kaydı silmek istiyor musunuz=", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (silmeDialog == DialogResult.Yes)
            {
                SqlCommand kıtapSıl = new SqlCommand("delete from kitap where barkodNo=@p1", bag.baglan());
                kıtapSıl.Parameters.AddWithValue("@p1", dgwKıtap.CurrentRow.Cells["barkodNo"].Value.ToString());
                kıtapSıl.ExecuteNonQuery();
                bag.baglan().Close();
                MessageBox.Show("Silme işleminiz başarılı", "Bilgi");
                daset.Tables["kitap"].Clear();
                kitapListeleme();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kıtapGuncelle = new SqlCommand("update kitap set  barkodNo=@p0,ad=@p1,yazar=@p2,yayinevi=@p3,sayfaSayisi=@p4,turu=@p5,stokSayisi=@p6,rafNo=@p7,aciklama=@p8 where barkodNo=@p0", bag.baglan());
            kıtapGuncelle.Parameters.AddWithValue("@p0", txtBarkodNo.Text);
            kıtapGuncelle.Parameters.AddWithValue("@p1", txtKitapAdi.Text);
            kıtapGuncelle.Parameters.AddWithValue("@p2", txtYazari.Text);
            kıtapGuncelle.Parameters.AddWithValue("@p3", txtYayinevi.Text);
            kıtapGuncelle.Parameters.AddWithValue("@p4", txtSayfaSayisi.Text);
            kıtapGuncelle.Parameters.AddWithValue("@p5", cmbTuru.Text);
            kıtapGuncelle.Parameters.AddWithValue("@p6", txtStokSayisi.Text);
            kıtapGuncelle.Parameters.AddWithValue("@p7", txtRafNo.Text);
            kıtapGuncelle.Parameters.AddWithValue("@p8", rtbAciklama.Text);

            kıtapGuncelle.ExecuteNonQuery();
            bag.baglan().Close();
            MessageBox.Show("Güncelleme işleminiz başarılı", "Bilgi");
            daset.Tables["kitap"].Clear();
            kitapListeleme();
        }

        private void txtBarkodAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["kitap"].Clear();
            SqlDataAdapter da = new SqlDataAdapter("select * from kitap where barkodNo like '%" + txtBarkodAra.Text + "%'", bag.baglan());
            da.Fill(daset, "kitap");
            dgwKıtap.DataSource = daset.Tables["kitap"];
            bag.baglan().Close();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            
SqlCommand komutKıtapAra = new SqlCommand("select * from kitap where barkodNo like '" + txtBarkodNo.Text + "'", bag.baglan());
            SqlDataReader dr = komutKıtapAra.ExecuteReader();
            while (dr.Read())
            {
                txtKitapAdi.Text = dr["ad"].ToString();
                txtYazari.Text = dr["yazar"].ToString();
                txtYayinevi.Text = dr["yayinevi"].ToString();
                txtSayfaSayisi.Text = dr["sayfaSayisi"].ToString();
                cmbTuru.Text = dr["turu"].ToString();
                txtStokSayisi.Text = dr["stokSayisi"].ToString();
                txtRafNo.Text = dr["rafNo"].ToString();
                rtbAciklama.Text = dr["aciklama"].ToString();


            }
            bag.baglan().Close(); 
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
                    for (int i = 0; i < dgwKıtap.Columns.Count; i++)
                    {
                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[1, i + 1];
                        myRange.Value2 = dgwKıtap.Columns[i].HeaderText;

                    }

                    for (int i = 0; i < dgwKıtap.Columns.Count; i++)
                    {
                        for (int j = 0; j < dgwKıtap.Rows.Count; j++)
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[j + 2, i + 1];
                            myRange.Value2 = dgwKıtap[i, j].Value;
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
