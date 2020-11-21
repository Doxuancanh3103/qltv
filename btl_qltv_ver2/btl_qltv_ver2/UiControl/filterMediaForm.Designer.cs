namespace btl_qltv_ver2.UiControl
{
    partial class filterMediaForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.type = new System.Windows.Forms.RadioButton();
            this.title = new System.Windows.Forms.RadioButton();
            this.publisher = new System.Windows.Forms.RadioButton();
            this.subject = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.subject);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.type);
            this.groupBox1.Controls.Add(this.title);
            this.groupBox1.Controls.Add(this.publisher);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 334);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "filter option";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(30, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(30, 165);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(61, 21);
            this.type.TabIndex = 3;
            this.type.TabStop = true;
            this.type.Text = "Type";
            this.type.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(30, 52);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(56, 21);
            this.title.TabIndex = 2;
            this.title.TabStop = true;
            this.title.Text = "Title";
            this.title.UseVisualStyleBackColor = true;
            // 
            // publisher
            // 
            this.publisher.AutoSize = true;
            this.publisher.Location = new System.Drawing.Point(30, 107);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(88, 21);
            this.publisher.TabIndex = 1;
            this.publisher.TabStop = true;
            this.publisher.Text = "Publisher";
            this.publisher.UseVisualStyleBackColor = true;
            // 
            // subject
            // 
            this.subject.AutoSize = true;
            this.subject.Location = new System.Drawing.Point(30, 222);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(76, 21);
            this.subject.TabIndex = 5;
            this.subject.TabStop = true;
            this.subject.Text = "Subject";
            this.subject.UseVisualStyleBackColor = true;
            // 
            // filterMediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "filterMediaForm";
            this.Size = new System.Drawing.Size(282, 334);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton subject;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton type;
        private System.Windows.Forms.RadioButton title;
        private System.Windows.Forms.RadioButton publisher;
    }
}
