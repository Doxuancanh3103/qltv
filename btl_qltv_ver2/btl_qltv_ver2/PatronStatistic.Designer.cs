namespace btl_qltv_ver2
{
    partial class PatronStatistic
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.patronStatictisTable = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.pieDamage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pieTotal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.patronStatictisTable)).BeginInit();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // patronStatictisTable
            // 
            chartArea1.Name = "ChartArea1";
            this.patronStatictisTable.ChartAreas.Add(chartArea1);
            this.patronStatictisTable.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.patronStatictisTable.Legends.Add(legend1);
            this.patronStatictisTable.Location = new System.Drawing.Point(0, 0);
            this.patronStatictisTable.Name = "patronStatictisTable";
            this.patronStatictisTable.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series1.Legend = "Legend1";
            series1.Name = "Borrowed";
            series1.YValuesPerPoint = 20;
            this.patronStatictisTable.Series.Add(series1);
            this.patronStatictisTable.Size = new System.Drawing.Size(1205, 284);
            this.patronStatictisTable.TabIndex = 0;
            this.patronStatictisTable.Text = "chart1";
            this.patronStatictisTable.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            title1.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "borrowedTitle";
            title1.Text = "Number Borrowed";
            this.patronStatictisTable.Titles.Add(title1);
            this.patronStatictisTable.Click += new System.EventHandler(this.patronStatictisTable_Click);
            // 
            // panelDetail
            // 
            this.panelDetail.BackColor = System.Drawing.Color.White;
            this.panelDetail.Controls.Add(this.pieTotal);
            this.panelDetail.Controls.Add(this.pieDamage);
            this.panelDetail.Controls.Add(this.addressLabel);
            this.panelDetail.Controls.Add(this.phoneNumberLabel);
            this.panelDetail.Controls.Add(this.dobLabel);
            this.panelDetail.Controls.Add(this.nameLabel);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetail.Location = new System.Drawing.Point(0, 284);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(1205, 472);
            this.panelDetail.TabIndex = 1;
            this.panelDetail.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pieDamage
            // 
            chartArea3.Name = "ChartArea1";
            this.pieDamage.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.pieDamage.Legends.Add(legend3);
            this.pieDamage.Location = new System.Drawing.Point(959, 219);
            this.pieDamage.Name = "pieDamage";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "pie";
            this.pieDamage.Series.Add(series3);
            this.pieDamage.Size = new System.Drawing.Size(246, 218);
            this.pieDamage.TabIndex = 6;
            this.pieDamage.Text = "chart1";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(31, 262);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(74, 18);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Address:";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(31, 192);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(125, 18);
            this.phoneNumberLabel.TabIndex = 2;
            this.phoneNumberLabel.Text = "Phone Number:";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLabel.Location = new System.Drawing.Point(31, 120);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(111, 18);
            this.dobLabel.TabIndex = 1;
            this.dobLabel.Text = "Date Of Birth:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(31, 39);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(62, 18);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name: ";
            // 
            // pieTotal
            // 
            chartArea2.Name = "ChartArea1";
            this.pieTotal.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.pieTotal.Legends.Add(legend2);
            this.pieTotal.Location = new System.Drawing.Point(638, 219);
            this.pieTotal.Name = "pieTotal";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "pie1";
            this.pieTotal.Series.Add(series2);
            this.pieTotal.Size = new System.Drawing.Size(246, 221);
            this.pieTotal.TabIndex = 7;
            this.pieTotal.Text = "chart1";
            // 
            // PatronStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 756);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.patronStatictisTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "PatronStatistic";
            this.Text = "PatronStatistic";
            this.Load += new System.EventHandler(this.PatronStatistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patronStatictisTable)).EndInit();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieTotal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart patronStatictisTable;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieDamage;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieTotal;
    }
}