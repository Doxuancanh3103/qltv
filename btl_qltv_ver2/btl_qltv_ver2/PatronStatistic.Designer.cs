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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.patronStatictisTable = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.damageLabel = new System.Windows.Forms.Label();
            this.borrowedLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pieDamage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.patronStatictisTable)).BeginInit();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieDamage)).BeginInit();
            this.SuspendLayout();
            // 
            // patronStatictisTable
            // 
            chartArea3.Name = "ChartArea1";
            this.patronStatictisTable.ChartAreas.Add(chartArea3);
            this.patronStatictisTable.Dock = System.Windows.Forms.DockStyle.Top;
            legend3.Name = "Legend1";
            this.patronStatictisTable.Legends.Add(legend3);
            this.patronStatictisTable.Location = new System.Drawing.Point(0, 0);
            this.patronStatictisTable.Name = "patronStatictisTable";
            this.patronStatictisTable.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.ChartArea = "ChartArea1";
            series3.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series3.Legend = "Legend1";
            series3.Name = "Borrowed";
            series3.YValuesPerPoint = 20;
            this.patronStatictisTable.Series.Add(series3);
            this.patronStatictisTable.Size = new System.Drawing.Size(1205, 316);
            this.patronStatictisTable.TabIndex = 0;
            this.patronStatictisTable.Text = "chart1";
            this.patronStatictisTable.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            title2.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "borrowedTitle";
            title2.Text = "Number Borrowed";
            this.patronStatictisTable.Titles.Add(title2);
            this.patronStatictisTable.Click += new System.EventHandler(this.patronStatictisTable_Click);
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.pieDamage);
            this.panelDetail.Controls.Add(this.damageLabel);
            this.panelDetail.Controls.Add(this.borrowedLabel);
            this.panelDetail.Controls.Add(this.addressLabel);
            this.panelDetail.Controls.Add(this.phoneNumberLabel);
            this.panelDetail.Controls.Add(this.dobLabel);
            this.panelDetail.Controls.Add(this.nameLabel);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetail.Location = new System.Drawing.Point(0, 316);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(1205, 440);
            this.panelDetail.TabIndex = 1;
            this.panelDetail.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // damageLabel
            // 
            this.damageLabel.AutoSize = true;
            this.damageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damageLabel.Location = new System.Drawing.Point(31, 277);
            this.damageLabel.Name = "damageLabel";
            this.damageLabel.Size = new System.Drawing.Size(182, 18);
            this.damageLabel.TabIndex = 5;
            this.damageLabel.Text = "Media number is failed:";
            // 
            // borrowedLabel
            // 
            this.borrowedLabel.AutoSize = true;
            this.borrowedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowedLabel.Location = new System.Drawing.Point(31, 225);
            this.borrowedLabel.Name = "borrowedLabel";
            this.borrowedLabel.Size = new System.Drawing.Size(177, 18);
            this.borrowedLabel.TabIndex = 4;
            this.borrowedLabel.Text = "Total media borrowed:";
            this.borrowedLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(31, 173);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(74, 18);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Address:";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(31, 126);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(125, 18);
            this.phoneNumberLabel.TabIndex = 2;
            this.phoneNumberLabel.Text = "Phone Number:";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLabel.Location = new System.Drawing.Point(31, 80);
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
            // pieDamage
            // 
            chartArea4.Name = "ChartArea1";
            this.pieDamage.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.pieDamage.Legends.Add(legend4);
            this.pieDamage.Location = new System.Drawing.Point(959, 219);
            this.pieDamage.Name = "pieDamage";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "pie";
            this.pieDamage.Series.Add(series4);
            this.pieDamage.Size = new System.Drawing.Size(246, 218);
            this.pieDamage.TabIndex = 6;
            this.pieDamage.Text = "chart1";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart patronStatictisTable;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Label damageLabel;
        private System.Windows.Forms.Label borrowedLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieDamage;
    }
}