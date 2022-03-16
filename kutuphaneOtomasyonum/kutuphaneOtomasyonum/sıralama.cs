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
    public partial class sıralama : Form
    {
        public sıralama()
        {
            InitializeComponent();
        }
        baglanti bag = new baglanti();
        DataSet daset = new DataSet();
        private void sıralama_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select *from uye order by kitapSayisi desc", bag.baglan());
            da.Fill(daset, "uye");
            dgwSıralama.DataSource = daset.Tables["uye"];
            bag.baglan().Close();
            lblCok.Text = "";
            lblAz.Text = "";
            lblCok.Text = daset.Tables["uye"].Rows[0]["ad"].ToString();
          //  lblCok.Text = daset.Tables["uye"].Rows[0]["soyad"].ToString();
            lblCok.Text+=daset.Tables["uye"].Rows[0]["kitapSayisi"].ToString();

            lblAz.Text = daset.Tables["uye"].Rows[dgwSıralama.Rows.Count-2]["ad"].ToString()+" ";
           // lblAz.Text = daset.Tables["uye"].Rows[dgwSıralama.Rows.Count - 2]["soyad"].ToString() + " ";
            lblAz.Text += daset.Tables["uye"].Rows[dgwSıralama.Rows.Count - 2]["kitapSayisi"].ToString() + " ";
        }
    }
}
