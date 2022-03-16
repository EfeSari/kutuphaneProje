namespace kutuphaneOtomasyonum
{
    partial class uyeLısteleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uyeLısteleme));
            this.dgwUye = new System.Windows.Forms.DataGridView();
            this.mskTCara = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOkuduguKitapSayisi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskTCno = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExcelAktar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUye)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwUye
            // 
            this.dgwUye.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwUye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUye.Location = new System.Drawing.Point(292, 58);
            this.dgwUye.Name = "dgwUye";
            this.dgwUye.Size = new System.Drawing.Size(610, 461);
            this.dgwUye.TabIndex = 57;
            this.dgwUye.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUye_CellDoubleClick);
            // 
            // mskTCara
            // 
            this.mskTCara.Location = new System.Drawing.Point(445, 17);
            this.mskTCara.Mask = "00000000000";
            this.mskTCara.Name = "mskTCara";
            this.mskTCara.Size = new System.Drawing.Size(166, 26);
            this.mskTCara.TabIndex = 58;
            this.mskTCara.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTCara_MaskInputRejected);
            this.mskTCara.TextChanged += new System.EventHandler(this.mskTCara_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(350, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 59;
            this.label3.Text = "TC ara";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGüncelle.Image")));
            this.btnGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGüncelle.Location = new System.Drawing.Point(17, 418);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(239, 50);
            this.btnGüncelle.TabIndex = 60;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseCompatibleTextRendering = true;
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.Location = new System.Drawing.Point(17, 474);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(239, 52);
            this.btnSil.TabIndex = 61;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(134, 298);
            this.txtMail.Margin = new System.Windows.Forms.Padding(5);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(122, 26);
            this.txtMail.TabIndex = 87;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(11, 357);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 18);
            this.label8.TabIndex = 86;
            this.label8.Text = "O.Kitap Sayısı";
            // 
            // txtOkuduguKitapSayisi
            // 
            this.txtOkuduguKitapSayisi.Location = new System.Drawing.Point(134, 354);
            this.txtOkuduguKitapSayisi.Margin = new System.Windows.Forms.Padding(5);
            this.txtOkuduguKitapSayisi.Name = "txtOkuduguKitapSayisi";
            this.txtOkuduguKitapSayisi.Size = new System.Drawing.Size(122, 26);
            this.txtOkuduguKitapSayisi.TabIndex = 85;
            this.txtOkuduguKitapSayisi.Text = "0";
            this.txtOkuduguKitapSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(14, 311);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 84;
            this.label1.Text = "Email";
            // 
            // mskTCno
            // 
            this.mskTCno.Location = new System.Drawing.Point(134, 30);
            this.mskTCno.Mask = "00000000000";
            this.mskTCno.Name = "mskTCno";
            this.mskTCno.Size = new System.Drawing.Size(122, 26);
            this.mskTCno.TabIndex = 76;
            this.mskTCno.TextChanged += new System.EventHandler(this.mskTCno_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(14, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 77;
            this.label2.Text = "Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(14, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 79;
            this.label4.Text = "Soyad";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(134, 247);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(122, 26);
            this.cmbCinsiyet.TabIndex = 80;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(134, 82);
            this.txtAd.Margin = new System.Windows.Forms.Padding(5);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(122, 26);
            this.txtAd.TabIndex = 74;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(134, 137);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(122, 26);
            this.txtSoyad.TabIndex = 75;
            // 
            // mskTelefon
            // 
            this.mskTelefon.Location = new System.Drawing.Point(134, 196);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(122, 26);
            this.mskTelefon.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(11, 252);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 81;
            this.label5.Text = "Cinsiyet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(14, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 83;
            this.label7.Text = "TC No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(14, 201);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 82;
            this.label6.Text = "Telefon";
            // 
            // btnExcelAktar
            // 
            this.btnExcelAktar.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelAktar.Image")));
            this.btnExcelAktar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcelAktar.Location = new System.Drawing.Point(716, 13);
            this.btnExcelAktar.Name = "btnExcelAktar";
            this.btnExcelAktar.Size = new System.Drawing.Size(180, 30);
            this.btnExcelAktar.TabIndex = 88;
            this.btnExcelAktar.Text = "Excel\'e aktar";
            this.btnExcelAktar.UseCompatibleTextRendering = true;
            this.btnExcelAktar.UseVisualStyleBackColor = true;
            this.btnExcelAktar.Click += new System.EventHandler(this.btnExcelAktar_Click);
            // 
            // uyeLısteleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(908, 531);
            this.Controls.Add(this.btnExcelAktar);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtOkuduguKitapSayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskTCno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.mskTelefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.mskTCara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgwUye);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "uyeLısteleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uyeLısteleme";
            this.Load += new System.EventHandler(this.uyeLısteleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUye;
        private System.Windows.Forms.MaskedTextBox mskTCara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOkuduguKitapSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskTCno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExcelAktar;
    }
}