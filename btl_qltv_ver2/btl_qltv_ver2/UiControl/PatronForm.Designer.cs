﻿namespace btl_qltv_ver2.UiControl
{
    partial class PatronForm
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
            this.patronTable = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.search = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.filterTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.filterButton = new System.Windows.Forms.Button();
            this.filterPatronForm1 = new btl_qltv_ver2.UiControl.filterPatronForm();
            ((System.ComponentModel.ISupportInitialize)(this.patronTable)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // patronTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.patronTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.patronTable.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.patronTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patronTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.patronTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.patronTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patronTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Title,
            this.Column3,
            this.Column4,
            this.Column5});
            this.patronTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patronTable.DoubleBuffered = true;
            this.patronTable.EnableHeadersVisualStyles = false;
            this.patronTable.HeaderBgColor = System.Drawing.Color.Black;
            this.patronTable.HeaderForeColor = System.Drawing.Color.GhostWhite;
            this.patronTable.Location = new System.Drawing.Point(0, 0);
            this.patronTable.Name = "patronTable";
            this.patronTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.patronTable.RowHeadersWidth = 51;
            this.patronTable.RowTemplate.Height = 24;
            this.patronTable.Size = new System.Drawing.Size(1138, 623);
            this.patronTable.TabIndex = 1;
            this.patronTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patronTable_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Detail";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Text = "Detail";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "LibraryCardNumber";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Title
            // 
            this.Title.HeaderText = "Name";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.Width = 125;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Date Of Birth";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "PhoneNumber";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Address";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.7029877F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.15641F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.search, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.update, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.insert, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.delete, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.filterTextBox, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.filterButton, 9, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 578);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1138, 45);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // search
            // 
            this.search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Image = global::btl_qltv_ver2.Properties.Resources.search;
            this.search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search.Location = new System.Drawing.Point(229, 3);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(107, 39);
            this.search.TabIndex = 2;
            this.search.Text = "Search";
            this.search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // update
            // 
            this.update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Image = global::btl_qltv_ver2.Properties.Resources.updateVer1mini;
            this.update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update.Location = new System.Drawing.Point(116, 3);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(107, 39);
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
            this.insert.Size = new System.Drawing.Size(107, 39);
            this.insert.TabIndex = 0;
            this.insert.Text = "Insert";
            this.insert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // delete
            // 
            this.delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Image = global::btl_qltv_ver2.Properties.Resources.delete;
            this.delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete.Location = new System.Drawing.Point(342, 3);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(107, 39);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // filterTextBox
            // 
            this.filterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.filterTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterTextBox.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.filterTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.filterTextBox.HintText = "";
            this.filterTextBox.isPassword = false;
            this.filterTextBox.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.filterTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.filterTextBox.LineMouseHoverColor = System.Drawing.Color.Orange;
            this.filterTextBox.LineThickness = 4;
            this.filterTextBox.Location = new System.Drawing.Point(804, 5);
            this.filterTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(208, 35);
            this.filterTextBox.TabIndex = 7;
            this.filterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.filterTextBox.OnValueChanged += new System.EventHandler(this.filterTextBox_OnValueChanged);
            // 
            // filterButton
            // 
            this.filterButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterButton.Font = new System.Drawing.Font("Microsoft New Tai Lue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterButton.Location = new System.Drawing.Point(1020, 3);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(115, 39);
            this.filterButton.TabIndex = 8;
            this.filterButton.Text = "Filter Option";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // filterPatronForm1
            // 
            this.filterPatronForm1.Location = new System.Drawing.Point(819, 247);
            this.filterPatronForm1.Name = "filterPatronForm1";
            this.filterPatronForm1.Size = new System.Drawing.Size(245, 311);
            this.filterPatronForm1.TabIndex = 3;
            this.filterPatronForm1.Visible = false;
            // 
            // PatronForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.filterPatronForm1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.patronTable);
            this.Name = "PatronForm";
            this.Size = new System.Drawing.Size(1138, 623);
            ((System.ComponentModel.ISupportInitialize)(this.patronTable)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid patronTable;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button delete;
        private Bunifu.Framework.UI.BunifuMaterialTextbox filterTextBox;
        private System.Windows.Forms.Button filterButton;
        private filterPatronForm filterPatronForm1;
    }
}
