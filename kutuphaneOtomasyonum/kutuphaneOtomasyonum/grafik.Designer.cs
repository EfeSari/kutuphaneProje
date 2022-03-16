namespace kutuphaneOtomasyonum
{
    partial class grafik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grafıkKıtapSayısı = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.grafıkKıtapSayısı)).BeginInit();
            this.SuspendLayout();
            // 
            // grafıkKıtapSayısı
            // 
            chartArea2.Name = "ChartArea1";
            this.grafıkKıtapSayısı.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.grafıkKıtapSayısı.Legends.Add(legend2);
            this.grafıkKıtapSayısı.Location = new System.Drawing.Point(-2, 1);
            this.grafıkKıtapSayısı.Name = "grafıkKıtapSayısı";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Okunan Kitap Sayısı";
            this.grafıkKıtapSayısı.Series.Add(series2);
            this.grafıkKıtapSayısı.Size = new System.Drawing.Size(828, 531);
            this.grafıkKıtapSayısı.TabIndex = 0;
            this.grafıkKıtapSayısı.Text = "chart1";
            // 
            // grafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(823, 534);
            this.Controls.Add(this.grafıkKıtapSayısı);
            this.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "grafik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "grafik";
            this.Load += new System.EventHandler(this.grafik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafıkKıtapSayısı)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafıkKıtapSayısı;
    }
}