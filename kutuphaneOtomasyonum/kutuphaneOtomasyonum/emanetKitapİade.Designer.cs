namespace kutuphaneOtomasyonum
{
    partial class emanetKitapİade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emanetKitapİade));
            this.dgwİadeKitap = new System.Windows.Forms.DataGridView();
            this.btnTeslimAl = new System.Windows.Forms.Button();
            this.txtTCgöreAra = new System.Windows.Forms.TextBox();
            this.txtBarkodGöreAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgwİadeKitap)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwİadeKitap
            // 
            this.dgwİadeKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwİadeKitap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwİadeKitap.Location = new System.Drawing.Point(0, 0);
            this.dgwİadeKitap.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.dgwİadeKitap.Name = "dgwİadeKitap";
            this.dgwİadeKitap.Size = new System.Drawing.Size(866, 469);
            this.dgwİadeKitap.TabIndex = 0;
            // 
            // btnTeslimAl
            // 
            this.btnTeslimAl.Image = ((System.Drawing.Image)(resources.GetObject("btnTeslimAl.Image")));
            this.btnTeslimAl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeslimAl.Location = new System.Drawing.Point(363, 62);
            this.btnTeslimAl.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.btnTeslimAl.Name = "btnTeslimAl";
            this.btnTeslimAl.Size = new System.Drawing.Size(216, 54);
            this.btnTeslimAl.TabIndex = 1;
            this.btnTeslimAl.Text = "Teslim Al";
            this.btnTeslimAl.UseVisualStyleBackColor = true;
            this.btnTeslimAl.Click += new System.EventHandler(this.btnTeslimAl_Click);
            // 
            // txtTCgöreAra
            // 
            this.txtTCgöreAra.Location = new System.Drawing.Point(251, 15);
            this.txtTCgöreAra.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.txtTCgöreAra.Name = "txtTCgöreAra";
            this.txtTCgöreAra.Size = new System.Drawing.Size(128, 25);
            this.txtTCgöreAra.TabIndex = 2;
            this.txtTCgöreAra.TextChanged += new System.EventHandler(this.txtTCgöreAra_TextChanged);
            // 
            // txtBarkodGöreAra
            // 
            this.txtBarkodGöreAra.Location = new System.Drawing.Point(622, 15);
            this.txtBarkodGöreAra.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.txtBarkodGöreAra.Name = "txtBarkodGöreAra";
            this.txtBarkodGöreAra.Size = new System.Drawing.Size(128, 25);
            this.txtBarkodGöreAra.TabIndex = 3;
            this.txtBarkodGöreAra.TextChanged += new System.EventHandler(this.txtBarkodGöreAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(99, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "TC\'ye Göre arama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(435, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Barkod No\'ya Göre arama";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtBarkodGöreAra);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnTeslimAl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTCgöreAra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 122);
            this.panel1.TabIndex = 6;
            // 
            // emanetKitapİade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(866, 469);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgwİadeKitap);
            this.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.MaximizeBox = false;
            this.Name = "emanetKitapİade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "emanetKitapİade";
            this.Load += new System.EventHandler(this.emanetKitapİade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwİadeKitap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwİadeKitap;
        private System.Windows.Forms.Button btnTeslimAl;
        private System.Windows.Forms.TextBox txtTCgöreAra;
        private System.Windows.Forms.TextBox txtBarkodGöreAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}