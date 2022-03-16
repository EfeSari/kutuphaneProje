namespace kutuphaneOtomasyonum
{
    partial class sıralama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sıralama));
            this.dgwSıralama = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAz = new System.Windows.Forms.Label();
            this.lblCok = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSıralama)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwSıralama
            // 
            this.dgwSıralama.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwSıralama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSıralama.Location = new System.Drawing.Point(-1, 113);
            this.dgwSıralama.Name = "dgwSıralama";
            this.dgwSıralama.Size = new System.Drawing.Size(797, 344);
            this.dgwSıralama.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(223, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "En Çok Kitap Okuyan Üye";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(223, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "En Az Kitap Okuyan Üye";
            // 
            // lblAz
            // 
            this.lblAz.AutoSize = true;
            this.lblAz.Location = new System.Drawing.Point(465, 66);
            this.lblAz.Name = "lblAz";
            this.lblAz.Size = new System.Drawing.Size(0, 18);
            this.lblAz.TabIndex = 3;
            // 
            // lblCok
            // 
            this.lblCok.AutoSize = true;
            this.lblCok.Location = new System.Drawing.Point(465, 21);
            this.lblCok.Name = "lblCok";
            this.lblCok.Size = new System.Drawing.Size(0, 18);
            this.lblCok.TabIndex = 4;
            // 
            // sıralama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(795, 456);
            this.Controls.Add(this.lblCok);
            this.Controls.Add(this.lblAz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwSıralama);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "sıralama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sıralama";
            this.Load += new System.EventHandler(this.sıralama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSıralama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwSıralama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAz;
        private System.Windows.Forms.Label lblCok;
    }
}