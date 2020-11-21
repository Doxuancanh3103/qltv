namespace btl_qltv_ver2.UiControl
{
    partial class filterOptionForm
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
            this.filterOption = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lnameCheckBox = new System.Windows.Forms.CheckBox();
            this.mnameCheckBox = new System.Windows.Forms.CheckBox();
            this.fnameCheckBox = new System.Windows.Forms.CheckBox();
            this.filterOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterOption
            // 
            this.filterOption.Controls.Add(this.button1);
            this.filterOption.Controls.Add(this.lnameCheckBox);
            this.filterOption.Controls.Add(this.mnameCheckBox);
            this.filterOption.Controls.Add(this.fnameCheckBox);
            this.filterOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterOption.Location = new System.Drawing.Point(0, 0);
            this.filterOption.Name = "filterOption";
            this.filterOption.Size = new System.Drawing.Size(227, 213);
            this.filterOption.TabIndex = 0;
            this.filterOption.TabStop = false;
            this.filterOption.Text = "filter option";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(143, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lnameCheckBox
            // 
            this.lnameCheckBox.AutoSize = true;
            this.lnameCheckBox.Checked = true;
            this.lnameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lnameCheckBox.Location = new System.Drawing.Point(19, 149);
            this.lnameCheckBox.Name = "lnameCheckBox";
            this.lnameCheckBox.Size = new System.Drawing.Size(98, 21);
            this.lnameCheckBox.TabIndex = 2;
            this.lnameCheckBox.Text = "Last Name";
            this.lnameCheckBox.UseVisualStyleBackColor = true;
            // 
            // mnameCheckBox
            // 
            this.mnameCheckBox.AutoSize = true;
            this.mnameCheckBox.Location = new System.Drawing.Point(19, 96);
            this.mnameCheckBox.Name = "mnameCheckBox";
            this.mnameCheckBox.Size = new System.Drawing.Size(93, 21);
            this.mnameCheckBox.TabIndex = 1;
            this.mnameCheckBox.Text = "Mid Name";
            this.mnameCheckBox.UseVisualStyleBackColor = true;
            // 
            // fnameCheckBox
            // 
            this.fnameCheckBox.AutoSize = true;
            this.fnameCheckBox.Location = new System.Drawing.Point(19, 43);
            this.fnameCheckBox.Name = "fnameCheckBox";
            this.fnameCheckBox.Size = new System.Drawing.Size(98, 21);
            this.fnameCheckBox.TabIndex = 0;
            this.fnameCheckBox.Text = "First Name";
            this.fnameCheckBox.UseVisualStyleBackColor = true;
            // 
            // filterOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filterOption);
            this.Name = "filterOptionForm";
            this.Size = new System.Drawing.Size(227, 213);
            this.filterOption.ResumeLayout(false);
            this.filterOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox filterOption;
        private System.Windows.Forms.CheckBox lnameCheckBox;
        private System.Windows.Forms.CheckBox mnameCheckBox;
        private System.Windows.Forms.CheckBox fnameCheckBox;
        private System.Windows.Forms.Button button1;
    }
}
