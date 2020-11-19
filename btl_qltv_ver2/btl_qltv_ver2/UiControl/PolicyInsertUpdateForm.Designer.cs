namespace btl_qltv_ver2.UiControl
{
    partial class PolicyInsertUpdateForm
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
            this.valueTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.descriptionTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.updateCustom = new System.Windows.Forms.Button();
            this.insertCustom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valueTextBox
            // 
            this.valueTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.valueTextBox.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.valueTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.valueTextBox.HintText = "";
            this.valueTextBox.isPassword = false;
            this.valueTextBox.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.valueTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.valueTextBox.LineMouseHoverColor = System.Drawing.Color.Orange;
            this.valueTextBox.LineThickness = 4;
            this.valueTextBox.Location = new System.Drawing.Point(41, 290);
            this.valueTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(444, 57);
            this.valueTextBox.TabIndex = 23;
            this.valueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.descriptionTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.descriptionTextBox.HintText = "";
            this.descriptionTextBox.isPassword = false;
            this.descriptionTextBox.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.descriptionTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.descriptionTextBox.LineMouseHoverColor = System.Drawing.Color.Orange;
            this.descriptionTextBox.LineThickness = 4;
            this.descriptionTextBox.Location = new System.Drawing.Point(41, 106);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(444, 57);
            this.descriptionTextBox.TabIndex = 22;
            this.descriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(35, 252);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(79, 33);
            this.bunifuCustomLabel2.TabIndex = 21;
            this.bunifuCustomLabel2.Text = "Value:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(35, 68);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(146, 33);
            this.bunifuCustomLabel1.TabIndex = 20;
            this.bunifuCustomLabel1.Text = "Description:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::btl_qltv_ver2.Properties.Resources.cancel;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(406, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 53);
            this.button1.TabIndex = 26;
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
            this.updateCustom.Location = new System.Drawing.Point(187, 427);
            this.updateCustom.Name = "updateCustom";
            this.updateCustom.Size = new System.Drawing.Size(132, 52);
            this.updateCustom.TabIndex = 25;
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
            this.insertCustom.Location = new System.Drawing.Point(12, 427);
            this.insertCustom.Name = "insertCustom";
            this.insertCustom.Size = new System.Drawing.Size(132, 52);
            this.insertCustom.TabIndex = 24;
            this.insertCustom.Text = "Insert";
            this.insertCustom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.insertCustom.UseVisualStyleBackColor = true;
            this.insertCustom.Click += new System.EventHandler(this.insertCustom_Click);
            // 
            // PolicyInsertUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 616);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updateCustom);
            this.Controls.Add(this.insertCustom);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "PolicyInsertUpdateForm";
            this.Text = "PolicyInsertUpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button updateCustom;
        private System.Windows.Forms.Button insertCustom;
        private Bunifu.Framework.UI.BunifuMaterialTextbox valueTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox descriptionTextBox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}