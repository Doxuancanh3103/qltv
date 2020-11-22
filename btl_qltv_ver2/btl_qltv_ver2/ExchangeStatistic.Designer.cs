namespace btl_qltv_ver2
{
    partial class ExchangeStatistic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.exchangeStatisticTable = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeStatisticTable)).BeginInit();
            this.SuspendLayout();
            // 
            // exchangeStatisticTable
            // 
            chartArea1.Name = "ChartArea1";
            this.exchangeStatisticTable.ChartAreas.Add(chartArea1);
            this.exchangeStatisticTable.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.exchangeStatisticTable.Legends.Add(legend1);
            this.exchangeStatisticTable.Location = new System.Drawing.Point(0, 0);
            this.exchangeStatisticTable.Name = "exchangeStatisticTable";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "amount";
            this.exchangeStatisticTable.Series.Add(series1);
            this.exchangeStatisticTable.Size = new System.Drawing.Size(1306, 557);
            this.exchangeStatisticTable.TabIndex = 0;
            this.exchangeStatisticTable.Text = "chart1";
            this.exchangeStatisticTable.Click += new System.EventHandler(this.exchangeStatisticTable_Click);
            // 
            // ExchangeStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 767);
            this.Controls.Add(this.exchangeStatisticTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ExchangeStatistic";
            this.Text = "ExchageStatistic";
            this.Load += new System.EventHandler(this.ExchangeStatistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exchangeStatisticTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart exchangeStatisticTable;
    }
}