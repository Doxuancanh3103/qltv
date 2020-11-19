namespace btl_qltv_ver2
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.patronManagerButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.policiesManagerButton = new System.Windows.Forms.Button();
            this.mediaManagerButton = new System.Windows.Forms.Button();
            this.mediaAuthorManagerButton = new System.Windows.Forms.Button();
            this.stockManagerButton = new System.Windows.Forms.Button();
            this.checkOutManagerButton = new System.Windows.Forms.Button();
            this.conditionManagerButton = new System.Windows.Forms.Button();
            this.exchangeManagerButton = new System.Windows.Forms.Button();
            this.authorManagerButton = new System.Windows.Forms.Button();
            this.checkOutForm1 = new btl_qltv_ver2.UiControl.CheckOutForm();
            this.exchangeForm1 = new btl_qltv_ver2.UiControl.ExchangeForm();
            this.stockForm1 = new btl_qltv_ver2.UiControl.StockForm();
            this.policyForm1 = new btl_qltv_ver2.UiControl.PolicyForm();
            this.conditionForm1 = new btl_qltv_ver2.UiControl.ConditionForm();
            this.authorForm1 = new btl_qltv_ver2.UiControl.AuthorForm();
            this.employeeForm1 = new btl_qltv_ver2.UiControl.EmployeeForm();
            this.patronForm1 = new btl_qltv_ver2.UiControl.PatronForm();
            this.mediaForm1 = new btl_qltv_ver2.UiControl.MediaForm();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.button3, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.policiesManagerButton, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.mediaManagerButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.mediaAuthorManagerButton, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.stockManagerButton, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkOutManagerButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.conditionManagerButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.exchangeManagerButton, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.authorManagerButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.patronManagerButton, 0, 0);
            this.bunifuTransition1.SetDecoration(this.tableLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 689);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1112, 100);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 689);
            this.panel1.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.checkOutForm1);
            this.panel4.Controls.Add(this.exchangeForm1);
            this.panel4.Controls.Add(this.stockForm1);
            this.panel4.Controls.Add(this.policyForm1);
            this.panel4.Controls.Add(this.conditionForm1);
            this.panel4.Controls.Add(this.authorForm1);
            this.panel4.Controls.Add(this.employeeForm1);
            this.panel4.Controls.Add(this.patronForm1);
            this.panel4.Controls.Add(this.mediaForm1);
            this.bunifuTransition1.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1112, 648);
            this.panel4.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1112, 41);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.logout);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(975, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(137, 41);
            this.panel3.TabIndex = 1;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuTransition1.SetDecoration(this.logout, BunifuAnimatorNS.DecorationType.None);
            this.logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Image = global::btl_qltv_ver2.Properties.Resources.logoutmini2;
            this.logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.Location = new System.Drawing.Point(0, 0);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(137, 40);
            this.logout.TabIndex = 0;
            this.logout.Text = "Logout";
            this.logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // patronManagerButton
            // 
            this.patronManagerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.patronManagerButton, BunifuAnimatorNS.DecorationType.None);
            this.patronManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patronManagerButton.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patronManagerButton.Image = global::btl_qltv_ver2.Properties.Resources.customermini1;
            this.patronManagerButton.Location = new System.Drawing.Point(3, 3);
            this.patronManagerButton.Name = "patronManagerButton";
            this.patronManagerButton.Size = new System.Drawing.Size(105, 94);
            this.patronManagerButton.TabIndex = 2;
            this.patronManagerButton.Text = "Patron";
            this.patronManagerButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.patronManagerButton.UseVisualStyleBackColor = true;
            this.patronManagerButton.Click += new System.EventHandler(this.patronManagerButton_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.button3, BunifuAnimatorNS.DecorationType.None);
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::btl_qltv_ver2.Properties.Resources.employee;
            this.button3.Location = new System.Drawing.Point(891, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 94);
            this.button3.TabIndex = 6;
            this.button3.Text = "Employee";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // policiesManagerButton
            // 
            this.policiesManagerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.policiesManagerButton, BunifuAnimatorNS.DecorationType.None);
            this.policiesManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.policiesManagerButton.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.policiesManagerButton.Image = global::btl_qltv_ver2.Properties.Resources.policy;
            this.policiesManagerButton.Location = new System.Drawing.Point(1002, 3);
            this.policiesManagerButton.Name = "policiesManagerButton";
            this.policiesManagerButton.Size = new System.Drawing.Size(107, 94);
            this.policiesManagerButton.TabIndex = 5;
            this.policiesManagerButton.Text = "Policies";
            this.policiesManagerButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.policiesManagerButton.UseVisualStyleBackColor = true;
            this.policiesManagerButton.Click += new System.EventHandler(this.policiesManagerButton_Click);
            // 
            // mediaManagerButton
            // 
            this.mediaManagerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.mediaManagerButton, BunifuAnimatorNS.DecorationType.None);
            this.mediaManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediaManagerButton.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaManagerButton.Image = global::btl_qltv_ver2.Properties.Resources.mediamini;
            this.mediaManagerButton.Location = new System.Drawing.Point(114, 3);
            this.mediaManagerButton.Name = "mediaManagerButton";
            this.mediaManagerButton.Size = new System.Drawing.Size(105, 94);
            this.mediaManagerButton.TabIndex = 3;
            this.mediaManagerButton.Text = "Media";
            this.mediaManagerButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mediaManagerButton.UseVisualStyleBackColor = true;
            this.mediaManagerButton.Click += new System.EventHandler(this.mediaManagerButton_Click);
            // 
            // mediaAuthorManagerButton
            // 
            this.mediaAuthorManagerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.mediaAuthorManagerButton, BunifuAnimatorNS.DecorationType.None);
            this.mediaAuthorManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediaAuthorManagerButton.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaAuthorManagerButton.Image = global::btl_qltv_ver2.Properties.Resources.media_author;
            this.mediaAuthorManagerButton.Location = new System.Drawing.Point(669, 3);
            this.mediaAuthorManagerButton.Name = "mediaAuthorManagerButton";
            this.mediaAuthorManagerButton.Size = new System.Drawing.Size(105, 94);
            this.mediaAuthorManagerButton.TabIndex = 8;
            this.mediaAuthorManagerButton.Text = "M.Author";
            this.mediaAuthorManagerButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mediaAuthorManagerButton.UseVisualStyleBackColor = true;
            // 
            // stockManagerButton
            // 
            this.stockManagerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.stockManagerButton, BunifuAnimatorNS.DecorationType.None);
            this.stockManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockManagerButton.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockManagerButton.Image = global::btl_qltv_ver2.Properties.Resources.stock;
            this.stockManagerButton.Location = new System.Drawing.Point(780, 3);
            this.stockManagerButton.Name = "stockManagerButton";
            this.stockManagerButton.Size = new System.Drawing.Size(105, 94);
            this.stockManagerButton.TabIndex = 7;
            this.stockManagerButton.Text = "Stock";
            this.stockManagerButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stockManagerButton.UseVisualStyleBackColor = true;
            this.stockManagerButton.Click += new System.EventHandler(this.stockManagerButton_Click);
            // 
            // checkOutManagerButton
            // 
            this.checkOutManagerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.checkOutManagerButton, BunifuAnimatorNS.DecorationType.None);
            this.checkOutManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkOutManagerButton.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutManagerButton.Image = global::btl_qltv_ver2.Properties.Resources.check_out;
            this.checkOutManagerButton.Location = new System.Drawing.Point(225, 3);
            this.checkOutManagerButton.Name = "checkOutManagerButton";
            this.checkOutManagerButton.Size = new System.Drawing.Size(105, 94);
            this.checkOutManagerButton.TabIndex = 4;
            this.checkOutManagerButton.Text = "Check Out";
            this.checkOutManagerButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkOutManagerButton.UseVisualStyleBackColor = true;
            this.checkOutManagerButton.Click += new System.EventHandler(this.checkOutManagerButton_Click);
            // 
            // conditionManagerButton
            // 
            this.conditionManagerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.conditionManagerButton, BunifuAnimatorNS.DecorationType.None);
            this.conditionManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conditionManagerButton.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionManagerButton.Image = global::btl_qltv_ver2.Properties.Resources.condition;
            this.conditionManagerButton.Location = new System.Drawing.Point(336, 3);
            this.conditionManagerButton.Name = "conditionManagerButton";
            this.conditionManagerButton.Size = new System.Drawing.Size(105, 94);
            this.conditionManagerButton.TabIndex = 11;
            this.conditionManagerButton.Text = "Condition";
            this.conditionManagerButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.conditionManagerButton.UseVisualStyleBackColor = true;
            this.conditionManagerButton.Click += new System.EventHandler(this.conditionManagerButton_Click);
            // 
            // exchangeManagerButton
            // 
            this.exchangeManagerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.exchangeManagerButton, BunifuAnimatorNS.DecorationType.None);
            this.exchangeManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exchangeManagerButton.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exchangeManagerButton.Image = global::btl_qltv_ver2.Properties.Resources.exchange;
            this.exchangeManagerButton.Location = new System.Drawing.Point(558, 3);
            this.exchangeManagerButton.Name = "exchangeManagerButton";
            this.exchangeManagerButton.Size = new System.Drawing.Size(105, 94);
            this.exchangeManagerButton.TabIndex = 9;
            this.exchangeManagerButton.Text = "Exchange";
            this.exchangeManagerButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exchangeManagerButton.UseVisualStyleBackColor = true;
            this.exchangeManagerButton.Click += new System.EventHandler(this.exchangeManagerButton_Click);
            // 
            // authorManagerButton
            // 
            this.authorManagerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.authorManagerButton, BunifuAnimatorNS.DecorationType.None);
            this.authorManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authorManagerButton.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorManagerButton.Image = global::btl_qltv_ver2.Properties.Resources.author;
            this.authorManagerButton.Location = new System.Drawing.Point(447, 3);
            this.authorManagerButton.Name = "authorManagerButton";
            this.authorManagerButton.Size = new System.Drawing.Size(105, 94);
            this.authorManagerButton.TabIndex = 10;
            this.authorManagerButton.Text = "Author";
            this.authorManagerButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.authorManagerButton.UseVisualStyleBackColor = true;
            this.authorManagerButton.Click += new System.EventHandler(this.authorManagerButton_Click);
            // 
            // checkOutForm1
            // 
            this.bunifuTransition1.SetDecoration(this.checkOutForm1, BunifuAnimatorNS.DecorationType.None);
            this.checkOutForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkOutForm1.Location = new System.Drawing.Point(0, 0);
            this.checkOutForm1.Name = "checkOutForm1";
            this.checkOutForm1.Size = new System.Drawing.Size(1112, 648);
            this.checkOutForm1.TabIndex = 8;
            this.checkOutForm1.Visible = false;
            // 
            // exchangeForm1
            // 
            this.bunifuTransition1.SetDecoration(this.exchangeForm1, BunifuAnimatorNS.DecorationType.None);
            this.exchangeForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exchangeForm1.Location = new System.Drawing.Point(0, 0);
            this.exchangeForm1.Name = "exchangeForm1";
            this.exchangeForm1.Size = new System.Drawing.Size(1112, 648);
            this.exchangeForm1.TabIndex = 7;
            this.exchangeForm1.Visible = false;
            // 
            // stockForm1
            // 
            this.bunifuTransition1.SetDecoration(this.stockForm1, BunifuAnimatorNS.DecorationType.None);
            this.stockForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockForm1.Location = new System.Drawing.Point(0, 0);
            this.stockForm1.Name = "stockForm1";
            this.stockForm1.Size = new System.Drawing.Size(1112, 648);
            this.stockForm1.TabIndex = 6;
            this.stockForm1.Visible = false;
            // 
            // policyForm1
            // 
            this.bunifuTransition1.SetDecoration(this.policyForm1, BunifuAnimatorNS.DecorationType.None);
            this.policyForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.policyForm1.Location = new System.Drawing.Point(0, 0);
            this.policyForm1.Name = "policyForm1";
            this.policyForm1.Size = new System.Drawing.Size(1112, 648);
            this.policyForm1.TabIndex = 5;
            this.policyForm1.Visible = false;
            // 
            // conditionForm1
            // 
            this.bunifuTransition1.SetDecoration(this.conditionForm1, BunifuAnimatorNS.DecorationType.None);
            this.conditionForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conditionForm1.Location = new System.Drawing.Point(0, 0);
            this.conditionForm1.Name = "conditionForm1";
            this.conditionForm1.Size = new System.Drawing.Size(1112, 648);
            this.conditionForm1.TabIndex = 4;
            this.conditionForm1.Visible = false;
            // 
            // authorForm1
            // 
            this.bunifuTransition1.SetDecoration(this.authorForm1, BunifuAnimatorNS.DecorationType.None);
            this.authorForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorForm1.Location = new System.Drawing.Point(0, 0);
            this.authorForm1.Name = "authorForm1";
            this.authorForm1.Size = new System.Drawing.Size(1112, 648);
            this.authorForm1.TabIndex = 3;
            this.authorForm1.Visible = false;
            // 
            // employeeForm1
            // 
            this.bunifuTransition1.SetDecoration(this.employeeForm1, BunifuAnimatorNS.DecorationType.None);
            this.employeeForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeForm1.Location = new System.Drawing.Point(0, 0);
            this.employeeForm1.Name = "employeeForm1";
            this.employeeForm1.Size = new System.Drawing.Size(1112, 648);
            this.employeeForm1.TabIndex = 2;
            this.employeeForm1.Visible = false;
            // 
            // patronForm1
            // 
            this.patronForm1.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.patronForm1, BunifuAnimatorNS.DecorationType.None);
            this.patronForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patronForm1.Location = new System.Drawing.Point(0, 0);
            this.patronForm1.Name = "patronForm1";
            this.patronForm1.Size = new System.Drawing.Size(1112, 648);
            this.patronForm1.TabIndex = 1;
            this.patronForm1.Visible = false;
            this.patronForm1.Load += new System.EventHandler(this.patronForm1_Load);
            // 
            // mediaForm1
            // 
            this.mediaForm1.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.mediaForm1, BunifuAnimatorNS.DecorationType.None);
            this.mediaForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaForm1.Location = new System.Drawing.Point(0, 0);
            this.mediaForm1.Name = "mediaForm1";
            this.mediaForm1.Size = new System.Drawing.Size(1112, 648);
            this.mediaForm1.TabIndex = 0;
            this.mediaForm1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 789);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Button checkOutManagerButton;
        private System.Windows.Forms.Button mediaManagerButton;
        private System.Windows.Forms.Button patronManagerButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button stockManagerButton;
        private System.Windows.Forms.Button mediaAuthorManagerButton;
        private System.Windows.Forms.Button exchangeManagerButton;
        private System.Windows.Forms.Button authorManagerButton;
        private System.Windows.Forms.Button conditionManagerButton;
        private System.Windows.Forms.Button policiesManagerButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Panel panel4;
        private UiControl.MediaForm mediaForm1;
        private UiControl.PatronForm patronForm1;
        private UiControl.EmployeeForm employeeForm1;
        private UiControl.AuthorForm authorForm1;
        private UiControl.ConditionForm conditionForm1;
        private UiControl.PolicyForm policyForm1;
        private UiControl.StockForm stockForm1;
        private UiControl.ExchangeForm exchangeForm1;
        private UiControl.CheckOutForm checkOutForm1;
        //private UiControl.MediaForm mediaTable;
    }
}