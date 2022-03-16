namespace kutuphaneOtomasyonum
{
    partial class kitapListele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitapListele));
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cmbTuru = new System.Windows.Forms.ComboBox();
            this.rtbAciklama = new System.Windows.Forms.RichTextBox();
            this.txtRafNo = new System.Windows.Forms.TextBox();
            this.txtStokSayisi = new System.Windows.Forms.TextBox();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.txtYayinevi = new System.Windows.Forms.TextBox();
            this.txtYazari = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwKıtap = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBarkodAra = new System.Windows.Forms.TextBox();
            this.btnExcelAktar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKıtap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.Location = new System.Drawing.Point(26, 449);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(287, 58);
            this.btnGuncelle.TabIndex = 37;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cmbTuru
            // 
            this.cmbTuru.FormattingEnabled = true;
            this.cmbTuru.Items.AddRange(new object[] {
            "Roman\t",
            "Hikaye",
            "Araştırma",
            "Tarih",
            "Deneme"});
            this.cmbTuru.Location = new System.Drawing.Point(158, 243);
            this.cmbTuru.Name = "cmbTuru";
            this.cmbTuru.Size = new System.Drawing.Size(155, 26);
            this.cmbTuru.TabIndex = 36;
            // 
            // rtbAciklama
            // 
            this.rtbAciklama.Location = new System.Drawing.Point(158, 391);
            this.rtbAciklama.Name = "rtbAciklama";
            this.rtbAciklama.Size = new System.Drawing.Size(155, 42);
            this.rtbAciklama.TabIndex = 35;
            this.rtbAciklama.Text = "";
            // 
            // txtRafNo
            // 
            this.txtRafNo.Location = new System.Drawing.Point(158, 343);
            this.txtRafNo.Name = "txtRafNo";
            this.txtRafNo.Size = new System.Drawing.Size(155, 26);
            this.txtRafNo.TabIndex = 34;
            // 
            // txtStokSayisi
            // 
            this.txtStokSayisi.Location = new System.Drawing.Point(158, 297);
            this.txtStokSayisi.Name = "txtStokSayisi";
            this.txtStokSayisi.Size = new System.Drawing.Size(155, 26);
            this.txtStokSayisi.TabIndex = 33;
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Location = new System.Drawing.Point(158, 190);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(155, 26);
            this.txtSayfaSayisi.TabIndex = 32;
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.Location = new System.Drawing.Point(158, 142);
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(155, 26);
            this.txtYayinevi.TabIndex = 31;
            // 
            // txtYazari
            // 
            this.txtYazari.Location = new System.Drawing.Point(158, 90);
            this.txtYazari.Name = "txtYazari";
            this.txtYazari.Size = new System.Drawing.Size(155, 26);
            this.txtYazari.TabIndex = 30;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(158, 50);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(155, 26);
            this.txtKitapAdi.TabIndex = 29;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(158, 12);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(155, 26);
            this.txtBarkodNo.TabIndex = 28;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(18, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 18);
            this.label9.TabIndex = 27;
            this.label9.Text = "Açıklama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(23, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 18);
            this.label8.TabIndex = 26;
            this.label8.Text = "Raf no";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(18, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Stok sayisi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(23, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Türü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(23, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Sayfa Sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(23, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Yayınevi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(23, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Yazarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(23, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Kitap Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "K.Barkod No";
            // 
            // dgwKıtap
            // 
            this.dgwKıtap.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgwKıtap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKıtap.Location = new System.Drawing.Point(334, 58);
            this.dgwKıtap.Name = "dgwKıtap";
            this.dgwKıtap.Size = new System.Drawing.Size(534, 506);
            this.dgwKıtap.TabIndex = 38;
            // 
            // btnSil
            // 
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.Location = new System.Drawing.Point(26, 513);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(287, 51);
            this.btnSil.TabIndex = 62;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(331, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 18);
            this.label10.TabIndex = 63;
            this.label10.Text = "K.Barkod No\'ya Göre Ara";
            // 
            // txtBarkodAra
            // 
            this.txtBarkodAra.Location = new System.Drawing.Point(505, 14);
            this.txtBarkodAra.Name = "txtBarkodAra";
            this.txtBarkodAra.Size = new System.Drawing.Size(155, 26);
            this.txtBarkodAra.TabIndex = 64;
            this.txtBarkodAra.TextChanged += new System.EventHandler(this.txtBarkodAra_TextChanged);
            // 
            // btnExcelAktar
            // 
            this.btnExcelAktar.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelAktar.Image")));
            this.btnExcelAktar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcelAktar.Location = new System.Drawing.Point(681, 9);
            this.btnExcelAktar.Name = "btnExcelAktar";
            this.btnExcelAktar.Size = new System.Drawing.Size(187, 41);
            this.btnExcelAktar.TabIndex = 89;
            this.btnExcelAktar.Text = "Excel\'e aktar";
            this.btnExcelAktar.UseCompatibleTextRendering = true;
            this.btnExcelAktar.UseVisualStyleBackColor = true;
            this.btnExcelAktar.Click += new System.EventHandler(this.btnExcelAktar_Click);
            // 
            // kitapListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(880, 576);
            this.Controls.Add(this.btnExcelAktar);
            this.Controls.Add(this.txtBarkodAra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgwKıtap);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.cmbTuru);
            this.Controls.Add(this.rtbAciklama);
            this.Controls.Add(this.txtRafNo);
            this.Controls.Add(this.txtStokSayisi);
            this.Controls.Add(this.txtSayfaSayisi);
            this.Controls.Add(this.txtYayinevi);
            this.Controls.Add(this.txtYazari);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "kitapListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kitapListele";
            this.Load += new System.EventHandler(this.kitapListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKıtap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox cmbTuru;
        private System.Windows.Forms.RichTextBox rtbAciklama;
        private System.Windows.Forms.TextBox txtRafNo;
        private System.Windows.Forms.TextBox txtStokSayisi;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.TextBox txtYayinevi;
        private System.Windows.Forms.TextBox txtYazari;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwKıtap;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBarkodAra;
        private System.Windows.Forms.Button btnExcelAktar;
    }
}