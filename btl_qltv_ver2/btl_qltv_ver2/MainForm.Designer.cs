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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.typeLabelInfor = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.usernameLabelInfor = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.employeeManagerButton = new System.Windows.Forms.Button();
            this.policiesManagerButton = new System.Windows.Forms.Button();
            this.mediaManagerButton = new System.Windows.Forms.Button();
            this.stockManagerButton = new System.Windows.Forms.Button();
            this.checkOutManagerButton = new System.Windows.Forms.Button();
            this.conditionManagerButton = new System.Windows.Forms.Button();
            this.exchangeManagerButton = new System.Windows.Forms.Button();
            this.authorManagerButton = new System.Windows.Forms.Button();
            this.patronManagerButton = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.home1 = new btl_qltv_ver2.Home();
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
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 1F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
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
            this.tableLayoutPanel1.Controls.Add(this.employeeManagerButton, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.policiesManagerButton, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.mediaManagerButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.stockManagerButton, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkOutManagerButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.conditionManagerButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.exchangeManagerButton, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.authorManagerButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.patronManagerButton, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.home, 0, 0);
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
            this.panel4.Controls.Add(this.home1);
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
            this.panel4.Location = new System.Drawing.Point(0, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1112, 627);
            this.panel4.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.typeLabelInfor);
            this.panel2.Controls.Add(this.usernameLabelInfor);
            this.panel2.Controls.Add(this.panel3);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1112, 62);
            this.panel2.TabIndex = 0;
            // 
            // typeLabelInfor
            // 
            this.typeLabelInfor.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.typeLabelInfor, BunifuAnimatorNS.DecorationType.None);
            this.typeLabelInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabelInfor.Location = new System.Drawing.Point(3, 31);
            this.typeLabelInfor.Name = "typeLabelInfor";
            this.typeLabelInfor.Size = new System.Drawing.Size(49, 18);
            this.typeLabelInfor.TabIndex = 3;
            this.typeLabelInfor.Text = "Type:";
            // 
            // usernameLabelInfor
            // 
            this.usernameLabelInfor.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.usernameLabelInfor, BunifuAnimatorNS.DecorationType.None);
            this.usernameLabelInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabelInfor.Location = new System.Drawing.Point(3, 0);
            this.usernameLabelInfor.Name = "usernameLabelInfor";
            this.usernameLabelInfor.Size = new System.Drawing.Size(90, 18);
            this.usernameLabelInfor.TabIndex = 2;
            this.usernameLabelInfor.Text = "Username:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.logout);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(975, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(137, 62);
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
            // employeeManagerButton
            // 
            this.employeeManagerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeManagerButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bunifuTransition1.SetDecoration(this.employeeManagerButton, BunifuAnimatorNS.DecorationType.None);
            this.employeeManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeManagerButton.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeManagerButton.Image = global::btl_qltv_ver2.Properties.Resources.employee;
            this.employeeManagerButton.Location = new System.Drawing.Point(891, 3);
            this.employeeManagerButton.Name = "employeeManagerButton";
            this.employeeManagerButton.Size = new System.Drawing.Size(105, 94);
            this.employeeManagerButton.TabIndex = 6;
            this.employeeManagerButton.Text = "Employee";
            this.employeeManagerButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.employeeManagerButton.UseVisualStyleBackColor = false;
            this.employeeManagerButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // policiesManagerButton
            // 
            this.policiesManagerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.policiesManagerButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
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
            this.policiesManagerButton.UseVisualStyleBackColor = false;
            this.policiesManagerButton.Click += new System.EventHandler(this.policiesManagerButton_Click);
            // 
            // mediaManagerButton
            // 
            this.mediaManagerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mediaManagerButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
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
            this.mediaManagerButton.UseVisualStyleBackColor = false;
            this.mediaManagerButton.Click += new System.EventHandler(this.mediaManagerButton_Click);
            // 
            // stockManagerButton
            // 
            this.stockManagerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockManagerButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
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
            this.stockManagerButton.UseVisualStyleBackColor = false;
            this.stockManagerButton.Click += new System.EventHandler(this.stockManagerButton_Click);
            // 
            // checkOutManagerButton
            // 
            this.checkOutManagerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkOutManagerButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
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
            this.checkOutManagerButton.UseVisualStyleBackColor = false;
            this.checkOutManagerButton.Click += new System.EventHandler(this.checkOutManagerButton_Click);
            // 
            // conditionManagerButton
            // 
            this.conditionManagerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conditionManagerButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
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
            this.conditionManagerButton.UseVisualStyleBackColor = false;
            this.conditionManagerButton.Click += new System.EventHandler(this.conditionManagerButton_Click);
            // 
            // exchangeManagerButton
            // 
            this.exchangeManagerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exchangeManagerButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
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
            this.exchangeManagerButton.UseVisualStyleBackColor = false;
            this.exchangeManagerButton.Click += new System.EventHandler(this.exchangeManagerButton_Click);
            // 
            // authorManagerButton
            // 
            this.authorManagerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorManagerButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
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
            this.authorManagerButton.UseVisualStyleBackColor = false;
            this.authorManagerButton.Click += new System.EventHandler(this.authorManagerButton_Click);
            // 
            // patronManagerButton
            // 
            this.patronManagerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patronManagerButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bunifuTransition1.SetDecoration(this.patronManagerButton, BunifuAnimatorNS.DecorationType.None);
            this.patronManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patronManagerButton.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patronManagerButton.Image = global::btl_qltv_ver2.Properties.Resources.customermini1;
            this.patronManagerButton.Location = new System.Drawing.Point(669, 3);
            this.patronManagerButton.Name = "patronManagerButton";
            this.patronManagerButton.Size = new System.Drawing.Size(105, 94);
            this.patronManagerButton.TabIndex = 2;
            this.patronManagerButton.Text = "Patron";
            this.patronManagerButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.patronManagerButton.UseVisualStyleBackColor = false;
            this.patronManagerButton.Click += new System.EventHandler(this.patronManagerButton_Click);
            // 
            // home
            // 
            this.home.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.home.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bunifuTransition1.SetDecoration(this.home, BunifuAnimatorNS.DecorationType.None);
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.Image = global::btl_qltv_ver2.Properties.Resources.home;
            this.home.Location = new System.Drawing.Point(3, 3);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(105, 94);
            this.home.TabIndex = 8;
            this.home.Text = "Home";
            this.home.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // home1
            // 
            this.bunifuTransition1.SetDecoration(this.home1, BunifuAnimatorNS.DecorationType.None);
            this.home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(1112, 627);
            this.home1.TabIndex = 9;
            // 
            // checkOutForm1
            // 
            this.bunifuTransition1.SetDecoration(this.checkOutForm1, BunifuAnimatorNS.DecorationType.None);
            this.checkOutForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkOutForm1.Location = new System.Drawing.Point(0, 0);
            this.checkOutForm1.Name = "checkOutForm1";
            this.checkOutForm1.Size = new System.Drawing.Size(1112, 627);
            this.checkOutForm1.TabIndex = 8;
            this.checkOutForm1.Visible = false;
            this.checkOutForm1.Load += new System.EventHandler(this.checkOutForm1_Load);
            // 
            // exchangeForm1
            // 
            this.bunifuTransition1.SetDecoration(this.exchangeForm1, BunifuAnimatorNS.DecorationType.None);
            this.exchangeForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exchangeForm1.Location = new System.Drawing.Point(0, 0);
            this.exchangeForm1.Name = "exchangeForm1";
            this.exchangeForm1.Size = new System.Drawing.Size(1112, 627);
            this.exchangeForm1.TabIndex = 7;
            this.exchangeForm1.Visible = false;
            this.exchangeForm1.Load += new System.EventHandler(this.exchangeForm1_Load);
            // 
            // stockForm1
            // 
            this.bunifuTransition1.SetDecoration(this.stockForm1, BunifuAnimatorNS.DecorationType.None);
            this.stockForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockForm1.Location = new System.Drawing.Point(0, 0);
            this.stockForm1.Name = "stockForm1";
            this.stockForm1.Size = new System.Drawing.Size(1112, 627);
            this.stockForm1.TabIndex = 6;
            this.stockForm1.Visible = false;
            this.stockForm1.Load += new System.EventHandler(this.stockForm1_Load);
            // 
            // policyForm1
            // 
            this.bunifuTransition1.SetDecoration(this.policyForm1, BunifuAnimatorNS.DecorationType.None);
            this.policyForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.policyForm1.Location = new System.Drawing.Point(0, 0);
            this.policyForm1.Name = "policyForm1";
            this.policyForm1.Size = new System.Drawing.Size(1112, 627);
            this.policyForm1.TabIndex = 5;
            this.policyForm1.Visible = false;
            this.policyForm1.Load += new System.EventHandler(this.policyForm1_Load);
            // 
            // conditionForm1
            // 
            this.bunifuTransition1.SetDecoration(this.conditionForm1, BunifuAnimatorNS.DecorationType.None);
            this.conditionForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conditionForm1.Location = new System.Drawing.Point(0, 0);
            this.conditionForm1.Name = "conditionForm1";
            this.conditionForm1.Size = new System.Drawing.Size(1112, 627);
            this.conditionForm1.TabIndex = 4;
            this.conditionForm1.Visible = false;
            this.conditionForm1.Load += new System.EventHandler(this.conditionForm1_Load);
            // 
            // authorForm1
            // 
            this.bunifuTransition1.SetDecoration(this.authorForm1, BunifuAnimatorNS.DecorationType.None);
            this.authorForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorForm1.Location = new System.Drawing.Point(0, 0);
            this.authorForm1.Name = "authorForm1";
            this.authorForm1.Size = new System.Drawing.Size(1112, 627);
            this.authorForm1.TabIndex = 3;
            this.authorForm1.Visible = false;
            this.authorForm1.Load += new System.EventHandler(this.authorForm1_Load);
            // 
            // employeeForm1
            // 
            this.bunifuTransition1.SetDecoration(this.employeeForm1, BunifuAnimatorNS.DecorationType.None);
            this.employeeForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeForm1.Location = new System.Drawing.Point(0, 0);
            this.employeeForm1.Name = "employeeForm1";
            this.employeeForm1.Size = new System.Drawing.Size(1112, 627);
            this.employeeForm1.TabIndex = 2;
            this.employeeForm1.Visible = false;
            this.employeeForm1.Load += new System.EventHandler(this.employeeForm1_Load);
            // 
            // patronForm1
            // 
            this.patronForm1.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.patronForm1, BunifuAnimatorNS.DecorationType.None);
            this.patronForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patronForm1.Location = new System.Drawing.Point(0, 0);
            this.patronForm1.Name = "patronForm1";
            this.patronForm1.Size = new System.Drawing.Size(1112, 627);
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
            this.mediaForm1.Size = new System.Drawing.Size(1112, 627);
            this.mediaForm1.TabIndex = 0;
            this.mediaForm1.Visible = false;
            this.mediaForm1.Load += new System.EventHandler(this.mediaForm1_Load);
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
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Button checkOutManagerButton;
        private System.Windows.Forms.Button mediaManagerButton;
        private System.Windows.Forms.Button patronManagerButton;
        private System.Windows.Forms.Button employeeManagerButton;
        private System.Windows.Forms.Button stockManagerButton;
        private System.Windows.Forms.Button home;
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
        private Bunifu.Framework.UI.BunifuCustomLabel typeLabelInfor;
        private Bunifu.Framework.UI.BunifuCustomLabel usernameLabelInfor;
        private Home home1;
        //private UiControl.MediaForm mediaTable;
    }
}