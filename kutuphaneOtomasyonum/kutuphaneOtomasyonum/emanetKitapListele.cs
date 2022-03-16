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
    public partial class emanetKitapListele : Form
    {
        public emanetKitapListele()
        {
            InitializeComponent();
        }
        baglanti bag = new baglanti();
        DataSet daset = new DataSet();
        private void emanetKitapListele_Load(object sender, EventArgs e)
        {
            emanetKitapListeleme();
            cmbFiltrele.SelectedIndex = 0;
        }

        private void emanetKitapListeleme()
        {
            SqlDataAdapter da = new SqlDataAdapter("select *from emanetKitap", bag.baglan());
            da.Fill(daset, "emanetKitap");
            dgwEmanetKitap.DataSource = daset.Tables["emanetKitap"];
            bag.baglan().Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            daset.Tables["emanetKitap"].Clear();
            if (cmbFiltrele.SelectedIndex==0)
            {
                emanetKitapListeleme();
            }
            else if (cmbFiltrele.SelectedIndex==1)
            {
                SqlDataAdapter da = new SqlDataAdapter("select *from emanetKitap where '"+DateTime.Now.ToShortDateString()+"'>iadeTarihi", bag.baglan());
                da.Fill(daset, "emanetKitap");
                dgwEmanetKitap.DataSource = daset.Tables["emanetKitap"];
                bag.baglan().Close();
                /*SqlCommand komutCeza = new SqlCommand("select teslimTarihi,iadeTarihi,DATEDIFF(day,teslimTarihi,iadeTarihi)*0.25 as fark from emanetKitap", bag.baglan());
                komutCeza.ExecuteNonQuery().ToString();
                bag.baglan().Close();*/
            }
            else if (cmbFiltrele.SelectedIndex == 2)
            {
                SqlDataAdapter da2 = new SqlDataAdapter("select *from emanetKitap where '" + DateTime.Now.ToShortDateString() + "'<=iadeTarihi", bag.baglan());
                da2.Fill(daset, "emanetKitap");
                dgwEmanetKitap.DataSource = daset.Tables["emanetKitap"];
                bag.baglan().Close();


              




            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
                    for (int i = 0; i < dgwEmanetKitap.Columns.Count; i++)
                    {
                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[1, i + 1];
                        myRange.Value2 = dgwEmanetKitap.Columns[i].HeaderText;

                    }

                    for (int i = 0; i < dgwEmanetKitap.Columns.Count; i++)
                    {
                        for (int j = 0; j < dgwEmanetKitap.Rows.Count; j++)
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[j + 2, i + 1];
                            myRange.Value2 = dgwEmanetKitap[i, j].Value;
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

