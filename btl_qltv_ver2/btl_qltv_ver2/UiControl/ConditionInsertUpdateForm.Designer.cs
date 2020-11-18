namespace btl_qltv_ver2.UiControl
{
    partial class ConditionInsertUpdateForm
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
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.gradeTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.percentTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.updateCustom = new System.Windows.Forms.Button();
            this.insertCustom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(25, 63);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(84, 33);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Grade:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(25, 207);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(153, 33);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Cost Percent:";
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
            this.gradeTextBox.Location = new System.Drawing.Point(31, 114);
            this.gradeTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(444, 57);
            this.gradeTextBox.TabIndex = 2;
            this.gradeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // percentTextBox
            // 
            this.percentTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.percentTextBox.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.percentTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.percentTextBox.HintText = "";
            this.percentTextBox.isPassword = false;
            this.percentTextBox.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.percentTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.percentTextBox.LineMouseHoverColor = System.Drawing.Color.Orange;
            this.percentTextBox.LineThickness = 4;
            this.percentTextBox.Location = new System.Drawing.Point(33, 253);
            this.percentTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.percentTextBox.Name = "percentTextBox";
            this.percentTextBox.Size = new System.Drawing.Size(444, 57);
            this.percentTextBox.TabIndex = 3;
            this.percentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::btl_qltv_ver2.Properties.Resources.cancel;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(330, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 53);
            this.button1.TabIndex = 19;
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
            this.updateCustom.Location = new System.Drawing.Point(163, 412);
            this.updateCustom.Name = "updateCustom";
            this.updateCustom.Size = new System.Drawing.Size(132, 52);
            this.updateCustom.TabIndex = 18;
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
            this.insertCustom.Location = new System.Drawing.Point(12, 412);
            this.insertCustom.Name = "insertCustom";
            this.insertCustom.Size = new System.Drawing.Size(132, 52);
            this.insertCustom.TabIndex = 17;
            this.insertCustom.Text = "Insert";
            this.insertCustom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.insertCustom.UseVisualStyleBackColor = true;
            this.insertCustom.Click += new System.EventHandler(this.insertCustom_Click);
            // 
            // ConditionInsertUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 530);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updateCustom);
            this.Controls.Add(this.insertCustom);
            this.Controls.Add(this.percentTextBox);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ConditionInsertUpdateForm";
            this.Text = "ConditionInsertUpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox gradeTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox percentTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button updateCustom;
        private System.Windows.Forms.Button insertCustom;
    }
}