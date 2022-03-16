namespace kutuphaneOtomasyonum
{
    partial class emanetKitapListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emanetKitapListele));
            this.dgwEmanetKitap = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFiltrele = new System.Windows.Forms.ComboBox();
            this.btnExcelAktar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmanetKitap)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwEmanetKitap
            // 
            this.dgwEmanetKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEmanetKitap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwEmanetKitap.Location = new System.Drawing.Point(0, 0);
            this.dgwEmanetKitap.Name = "dgwEmanetKitap";
            this.dgwEmanetKitap.Size = new System.Drawing.Size(826, 498);
            this.dgwEmanetKitap.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtrele";
            // 
            // cmbFiltrele
            // 
            this.cmbFiltrele.FormattingEnabled = true;
            this.cmbFiltrele.Items.AddRange(new object[] {
            "Tüm Kitaplar",
            "Süresi dolan Kitaplar",
            "Süresi dolmayan Kitaplar"});
            this.cmbFiltrele.Location = new System.Drawing.Point(121, 25);
            this.cmbFiltrele.Name = "cmbFiltrele";
            this.cmbFiltrele.Size = new System.Drawing.Size(492, 25);
            this.cmbFiltrele.TabIndex = 2;
            this.cmbFiltrele.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnExcelAktar
            // 
            this.btnExcelAktar.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExcelAktar.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelAktar.Image")));
            this.btnExcelAktar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcelAktar.Location = new System.Drawing.Point(629, 13);
            this.btnExcelAktar.Name = "btnExcelAktar";
            this.btnExcelAktar.Size = new System.Drawing.Size(194, 41);
            this.btnExcelAktar.TabIndex = 90;
            this.btnExcelAktar.Text = "Excel\'e aktar";
            this.btnExcelAktar.UseCompatibleTextRendering = true;
            this.btnExcelAktar.UseVisualStyleBackColor = true;
            this.btnExcelAktar.Click += new System.EventHandler(this.btnExcelAktar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExcelAktar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbFiltrele);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 73);
            this.panel1.TabIndex = 91;
            // 
            // emanetKitapListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(826, 498);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgwEmanetKitap);
            this.Font = new System.Drawing.Font("Corbel", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "emanetKitapListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "emanetKitapListele";
            this.Load += new System.EventHandler(this.emanetKitapListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmanetKitap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwEmanetKitap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFiltrele;
        private System.Windows.Forms.Button btnExcelAktar;
        private System.Windows.Forms.Panel panel1;
    }
}