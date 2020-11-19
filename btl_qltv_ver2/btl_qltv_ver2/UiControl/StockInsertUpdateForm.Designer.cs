namespace btl_qltv_ver2.UiControl
{
    partial class StockInsertUpdateForm
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
            this.gradeTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.isbnTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.updateCustom = new System.Windows.Forms.Button();
            this.insertCustom = new System.Windows.Forms.Button();
            this.orderCostTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.amountTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gradeTextBox.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gradeTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.gradeTextBox.HintText = "";
            this.gradeTextBox.isPassword = false;
            this.gradeTextBox.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.gradeTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.gradeTextBox.LineMouseHoverColor = System.Drawing.Color.Orange;
            this.gradeTextBox.LineThickness = 4;
            this.gradeTextBox.Location = new System.Drawing.Point(32, 221);
            this.gradeTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(444, 57);
            this.gradeTextBox.TabIndex = 30;
            this.gradeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.isbnTextBox.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.isbnTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.isbnTextBox.HintText = "";
            this.isbnTextBox.isPassword = false;
            this.isbnTextBox.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.isbnTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.isbnTextBox.LineMouseHoverColor = System.Drawing.Color.Orange;
            this.isbnTextBox.LineThickness = 4;
            this.isbnTextBox.Location = new System.Drawing.Point(32, 77);
            this.isbnTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(444, 57);
            this.isbnTextBox.TabIndex = 29;
            this.isbnTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(26, 170);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(84, 33);
            this.bunifuCustomLabel2.TabIndex = 28;
            this.bunifuCustomLabel2.Text = "Grade:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(26, 39);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(73, 33);
            this.bunifuCustomLabel1.TabIndex = 27;
            this.bunifuCustomLabel1.Text = "ISBN:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::btl_qltv_ver2.Properties.Resources.cancel;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(363, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 53);
            this.button1.TabIndex = 33;
            this.button1.Text = "Cancel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateCustom
            // 
            this.updateCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateCustom.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCustom.Image = global::btl_qltv_ver2.Properties.Resources.updateVer1;
            this.updateCustom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateCustom.Location = new System.Drawing.Point(170, 583);
            this.updateCustom.Name = "updateCustom";
            this.updateCustom.Size = new System.Drawing.Size(132, 52);
            this.updateCustom.TabIndex = 32;
            this.updateCustom.Text = "Update";
            this.updateCustom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateCustom.UseVisualStyleBackColor = true;
            this.updateCustom.Click += new System.EventHandler(this.updateCustom_Click);
            // 
            // insertCustom
            // 
            this.insertCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertCustom.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertCustom.Image = global::btl_qltv_ver2.Properties.Resources.insert;
            this.insertCustom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insertCustom.Location = new System.Drawing.Point(12, 582);
            this.insertCustom.Name = "insertCustom";
            this.insertCustom.Size = new System.Drawing.Size(132, 52);
            this.insertCustom.TabIndex = 31;
            this.insertCustom.Text = "Insert";
            this.insertCustom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.insertCustom.UseVisualStyleBackColor = true;
            this.insertCustom.Click += new System.EventHandler(this.insertCustom_Click);
            // 
            // orderCostTextBox
            // 
            this.orderCostTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.orderCostTextBox.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderCostTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.orderCostTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.orderCostTextBox.HintText = "";
            this.orderCostTextBox.isPassword = false;
            this.orderCostTextBox.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.orderCostTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.orderCostTextBox.LineMouseHoverColor = System.Drawing.Color.Orange;
            this.orderCostTextBox.LineThickness = 4;
            this.orderCostTextBox.Location = new System.Drawing.Point(32, 467);
            this.orderCostTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.orderCostTextBox.Name = "orderCostTextBox";
            this.orderCostTextBox.Size = new System.Drawing.Size(444, 57);
            this.orderCostTextBox.TabIndex = 37;
            this.orderCostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amountTextBox.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.amountTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.amountTextBox.HintText = "";
            this.amountTextBox.isPassword = false;
            this.amountTextBox.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.amountTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.amountTextBox.LineMouseHoverColor = System.Drawing.Color.Orange;
            this.amountTextBox.LineThickness = 4;
            this.amountTextBox.Location = new System.Drawing.Point(32, 333);
            this.amountTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(444, 57);
            this.amountTextBox.TabIndex = 36;
            this.amountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(26, 429);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(134, 33);
            this.bunifuCustomLabel3.TabIndex = 35;
            this.bunifuCustomLabel3.Text = "Order Cost:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(26, 295);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(109, 33);
            this.bunifuCustomLabel4.TabIndex = 34;
            this.bunifuCustomLabel4.Text = "Amount:";
            // 
            // StockInsertUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 666);
            this.Controls.Add(this.orderCostTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updateCustom);
            this.Controls.Add(this.insertCustom);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(this.isbnTextBox);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "StockInsertUpdateForm";
            this.Text = "StockInsertUpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button updateCustom;
        private System.Windows.Forms.Button insertCustom;
        private Bunifu.Framework.UI.BunifuMaterialTextbox gradeTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox isbnTextBox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox orderCostTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox amountTextBox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
    }
}