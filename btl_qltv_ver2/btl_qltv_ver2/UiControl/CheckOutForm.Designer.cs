﻿namespace btl_qltv_ver2.UiControl
{
    partial class CheckOutForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.checkOutTable = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.detail = new System.Windows.Forms.DataGridViewLinkColumn();
            this.librarycardnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentcondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordercost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.statistic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.checkOutTable)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkOutTable
            // 
            this.checkOutTable.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkOutTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.checkOutTable.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.checkOutTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkOutTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.checkOutTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.checkOutTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkOutTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detail,
            this.librarycardnumber,
            this.Column2,
            this.Column3,
            this.checker,
            this.Amount,
            this.currentcondition,
            this.ordercost});
            this.checkOutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkOutTable.DoubleBuffered = true;
            this.checkOutTable.EnableHeadersVisualStyles = false;
            this.checkOutTable.HeaderBgColor = System.Drawing.Color.Black;
            this.checkOutTable.HeaderForeColor = System.Drawing.Color.GhostWhite;
            this.checkOutTable.Location = new System.Drawing.Point(0, 0);
            this.checkOutTable.Name = "checkOutTable";
            this.checkOutTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.checkOutTable.RowHeadersWidth = 51;
            this.checkOutTable.RowTemplate.Height = 24;
            this.checkOutTable.Size = new System.Drawing.Size(1123, 550);
            this.checkOutTable.TabIndex = 13;
            this.checkOutTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.checkOutTable_CellContentClick);
            // 
            // detail
            // 
            this.detail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detail.HeaderText = "Detail";
            this.detail.MinimumWidth = 6;
            this.detail.Name = "detail";
            this.detail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.detail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // librarycardnumber
            // 
            this.librarycardnumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.librarycardnumber.HeaderText = "LibraryCardNumber";
            this.librarycardnumber.MinimumWidth = 6;
            this.librarycardnumber.Name = "librarycardnumber";
            this.librarycardnumber.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "ISBN";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Grade";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // checker
            // 
            this.checker.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.checker.HeaderText = "Checker";
            this.checker.MinimumWidth = 6;
            this.checker.Name = "checker";
            this.checker.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Amount.HeaderText = "Check Out Date";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            // 
            // currentcondition
            // 
            this.currentcondition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.currentcondition.HeaderText = "Current Condition";
            this.currentcondition.MinimumWidth = 6;
            this.currentcondition.Name = "currentcondition";
            this.currentcondition.ReadOnly = true;
            // 
            // ordercost
            // 
            this.ordercost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ordercost.HeaderText = "Fee";
            this.ordercost.MinimumWidth = 6;
            this.ordercost.Name = "ordercost";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.123775F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.08994F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.delete, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.update, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.insert, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.statistic, 9, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 550);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1123, 69);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // delete
            // 
            this.delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Image = global::btl_qltv_ver2.Properties.Resources.delete;
            this.delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete.Location = new System.Drawing.Point(227, 3);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(106, 63);
            this.delete.TabIndex = 4;
            this.delete.Text = "Delete";
            this.delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // update
            // 
            this.update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Image = global::btl_qltv_ver2.Properties.Resources.updateVer1mini;
            this.update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update.Location = new System.Drawing.Point(115, 3);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(106, 63);
            this.update.TabIndex = 1;
            this.update.Text = "Update";
            this.update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.Image = global::btl_qltv_ver2.Properties.Resources.insertmini;
            this.insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insert.Location = new System.Drawing.Point(3, 3);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(106, 63);
            this.insert.TabIndex = 0;
            this.insert.Text = "Insert";
            this.insert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // statistic
            // 
            this.statistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statistic.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistic.Image = global::btl_qltv_ver2.Properties.Resources.analytics;
            this.statistic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statistic.Location = new System.Drawing.Point(978, 3);
            this.statistic.Name = "statistic";
            this.statistic.Size = new System.Drawing.Size(142, 63);
            this.statistic.TabIndex = 6;
            this.statistic.Text = "Statistic";
            this.statistic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.statistic.UseVisualStyleBackColor = true;
            this.statistic.Click += new System.EventHandler(this.statistic_Click);
            // 
            // CheckOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkOutTable);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CheckOutForm";
            this.Size = new System.Drawing.Size(1123, 619);
            ((System.ComponentModel.ISupportInitialize)(this.checkOutTable)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid checkOutTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.DataGridViewLinkColumn detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn librarycardnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn checker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentcondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordercost;
        private System.Windows.Forms.Button statistic;
    }
}
