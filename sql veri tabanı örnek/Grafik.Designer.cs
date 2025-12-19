using System.Windows.Forms.DataVisualization.Charting;

namespace sql_veri_tabanı_örnek
{
    partial class Grafik
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
            SuspendLayout();
            // 
            // Grafik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Grafik";
            Text = "Grafik";
            Load += Grafik_Load;
            ResumeLayout(false);

            // Chart nesnesi oluştur
            Chart chart1 = new Chart();

            // Boyutunu belirle
            chart1.Size = new Size(500, 300);
            chart1.Location = new Point(20, 20);

            // Grafik alanı oluştur
            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);

            // Verileri ekle
            Series series = new Series("Veriler");
            
            series.ChartType = SeriesChartType.Column;

            // Verileri grafiğe ekle
            chart1.Series.Add(series);

            // Kontrole formda yer ver
            this.Controls.Add(chart1);
        }

        #endregion
    }
}