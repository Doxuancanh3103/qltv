namespace btl_qltv_ver2.UiControl
{
    partial class AuthorInsertUpdateSearchForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.updateCustom = new System.Windows.Forms.Button();
            this.insertCustom = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lnameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.mnameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.fnameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dobLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.authorIdTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dobTextBox = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.updateCustom);
            this.panel1.Controls.Add(this.insertCustom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 638);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 53);
            this.panel1.TabIndex = 4;
            // 
            // search
            // 
            this.search.Dock = System.Windows.Forms.DockStyle.Left;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Image = global::btl_qltv_ver2.Properties.Resources.search;
            this.search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search.Location = new System.Drawing.Point(423, 0);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(142, 53);
            this.search.TabIndex = 16;
            this.search.Text = "Search";
            this.search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::btl_qltv_ver2.Properties.Resources.cancel;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(284, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 53);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cancel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateCustom
            // 
            this.updateCustom.Dock = System.Windows.Forms.DockStyle.Left;
            this.updateCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateCustom.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCustom.Image = global::btl_qltv_ver2.Properties.Resources.updateVer1;
            this.updateCustom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateCustom.Location = new System.Drawing.Point(142, 0);
            this.updateCustom.Name = "updateCustom";
            this.updateCustom.Size = new System.Drawing.Size(142, 53);
            this.updateCustom.TabIndex = 14;
            this.updateCustom.Text = "Update";
            this.updateCustom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateCustom.UseVisualStyleBackColor = true;
            this.updateCustom.Click += new System.EventHandler(this.updateCustom_Click);
            // 
            // insertCustom
            // 
            this.insertCustom.Dock = System.Windows.Forms.DockStyle.Left;
            this.insertCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertCustom.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertCustom.Image = global::btl_qltv_ver2.Properties.Resources.insert;
            this.insertCustom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insertCustom.Location = new System.Drawing.Point(0, 0);
            this.insertCustom.Name = "insertCustom";
            this.insertCustom.Size = new System.Drawing.Size(142, 53);
            this.insertCustom.TabIndex = 13;
            this.insertCustom.Text = "Insert";
            this.insertCustom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.insertCustom.UseVisualStyleBackColor = true;
            this.insertCustom.Click += new System.EventHandler(this.insertCustom_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lnameTextBox, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.mnameTextBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.fnameTextBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dobLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.bunifuCustomLabel7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.bunifuCustomLabel5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.bunifuCustomLabel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bunifuCustomLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.authorIdTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dobTextBox, 0, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(567, 638);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // lnameTextBox
            // 
            this.lnameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lnameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnameTextBox.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lnameTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.lnameTextBox.HintText = "";
            this.lnameTextBox.isPassword = false;
            this.lnameTextBox.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.lnameTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.lnameTextBox.LineMouseHoverColor = System.Drawing.Color.Orange;
            this.lnameTextBox.LineThickness = 4;
            this.lnameTextBox.Location = new System.Drawing.Point(5, 462);
            this.lnameTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lnameTextBox.Name = "lnameTextBox";
            this.lnameTextBox.Size = new System.Drawing.Size(557, 41);
            this.lnameTextBox.TabIndex = 12;
            this.lnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // mnameTextBox
            // 
            this.mnameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mnameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mnameTextBox.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnameTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.mnameTextBox.HintText = "";
            this.mnameTextBox.isPassword = false;
            this.mnameTextBox.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.mnameTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.mnameTextBox.LineMouseHoverColor = System.Drawing.Color.Orange;
            this.mnameTextBox.LineThickness = 4;
            this.mnameTextBox.Location = new System.Drawing.Point(5, 335);
            this.mnameTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.mnameTextBox.Name = "mnameTextBox";
            this.mnameTextBox.Size = new System.Drawing.Size(557, 41);
            this.mnameTextBox.TabIndex = 11;
            this.mnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // fnameTextBox
            // 
            this.fnameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fnameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fnameTextBox.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fnameTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.fnameTextBox.HintText = "";
            this.fnameTextBox.isPassword = false;
            this.fnameTextBox.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.fnameTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.fnameTextBox.LineMouseHoverColor = System.Drawing.Color.Orange;
            this.fnameTextBox.LineThickness = 4;
            this.fnameTextBox.Location = new System.Drawing.Point(5, 208);
            this.fnameTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.fnameTextBox.Name = "fnameTextBox";
            this.fnameTextBox.Size = new System.Drawing.Size(557, 41);
            this.fnameTextBox.TabIndex = 10;
            this.fnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dobLabel.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLabel.Location = new System.Drawing.Point(3, 508);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(561, 76);
            this.dobLabel.TabIndex = 8;
            this.dobLabel.Text = "Date Of Birth:";
            this.dobLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(3, 381);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(561, 76);
            this.bunifuCustomLabel7.TabIndex = 6;
            this.bunifuCustomLabel7.Text = "Last Name:";
            this.bunifuCustomLabel7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(3, 254);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(561, 76);
            this.bunifuCustomLabel5.TabIndex = 4;
            this.bunifuCustomLabel5.Text = "Mid Name:";
            this.bunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(3, 127);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(561, 76);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "First Name:";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(561, 76);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Author Id:";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // authorIdTextBox
            // 
            this.authorIdTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.authorIdTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorIdTextBox.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorIdTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.authorIdTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.authorIdTextBox.HintText = "";
            this.authorIdTextBox.isPassword = false;
            this.authorIdTextBox.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.authorIdTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.authorIdTextBox.LineMouseHoverColor = System.Drawing.Color.Orange;
            this.authorIdTextBox.LineThickness = 4;
            this.authorIdTextBox.Location = new System.Drawing.Point(5, 81);
            this.authorIdTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.authorIdTextBox.Name = "authorIdTextBox";
            this.authorIdTextBox.Size = new System.Drawing.Size(557, 41);
            this.authorIdTextBox.TabIndex = 9;
            this.authorIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.authorIdTextBox.OnValueChanged += new System.EventHandler(this.authorIdTextBox_OnValueChanged);
            // 
            // dobTextBox
            // 
            this.dobTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dobTextBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobTextBox.Location = new System.Drawing.Point(3, 587);
            this.dobTextBox.Name = "dobTextBox";
            this.dobTextBox.Size = new System.Drawing.Size(561, 22);
            this.dobTextBox.TabIndex = 13;
            // 
            // AuthorInsertUpdateSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 691);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AuthorInsertUpdateSearchForm";
            this.Text = "AuthorInsertUpdateSearchForm";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button updateCustom;
        private System.Windows.Forms.Button insertCustom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lnameTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox mnameTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox fnameTextBox;
        private Bunifu.Framework.UI.BunifuCustomLabel dobLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox authorIdTextBox;
        private System.Windows.Forms.DateTimePicker dobTextBox;
    }
}