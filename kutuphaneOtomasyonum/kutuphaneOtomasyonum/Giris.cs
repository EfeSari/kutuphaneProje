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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kayitOl frm = new kayitOl();
            frm.Show();
            this.Hide();
        }
        int hak = 3;
        baglanti bag = new baglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "" && txtSifre.Text == "")
            {
                MessageBox.Show("Tüm bilgileri doldurunuz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

                
                SqlCommand komut = new SqlCommand("select * from yetkili where TCno=@p1 and sifre=@p2", bag.baglan());

               
                komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);

               
                SqlDataReader dr = komut.ExecuteReader();

                
                if (dr.Read())
                {
                    yetkiliDetayPaneli frmYetkiliPanel = new yetkiliDetayPaneli();



                    frmYetkiliPanel.TC = txtKullaniciAdi.Text;
                    frmYetkiliPanel.Show();
                    this.Hide();
                }
                else
                {

                    hak--;
                    lblHak.Text = hak.ToString();
                    if (hak == 0)
                    {
                        MessageBox.Show("3 kere yanlış girdiğiniz için buton kilitlendi!", "Bilgi", MessageBoxButtons.OK);
                        btnGirisYap.Enabled = false;
                    }
                }

            }
        }

        private void chkSifre_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSifre.CheckState==CheckState.Checked)
            {
                txtSifre.UseSystemPasswordChar = true;

            }
            else if (chkSifre.CheckState == CheckState.Unchecked)
            {
                txtSifre.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
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
