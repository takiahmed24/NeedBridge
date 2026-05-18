namespace NeedBridge
{
    partial class VendorHome
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnEarnings = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnMyOrders = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnMyProducts = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dgvRecentOrders = new System.Windows.Forms.DataGridView();
            this.lblRecentOrders = new System.Windows.Forms.Label();
            this.panelStats = new System.Windows.Forms.Panel();
            this.panelStat4 = new System.Windows.Forms.Panel();
            this.lblStat4Value = new System.Windows.Forms.Label();
            this.lblStat4Title = new System.Windows.Forms.Label();
            this.panelStat3 = new System.Windows.Forms.Panel();
            this.lblStat3Value = new System.Windows.Forms.Label();
            this.lblStat3Title = new System.Windows.Forms.Label();
            this.panelStat2 = new System.Windows.Forms.Panel();
            this.lblStat2Value = new System.Windows.Forms.Label();
            this.lblStat2Title = new System.Windows.Forms.Label();
            this.panelStat1 = new System.Windows.Forms.Panel();
            this.lblStat1Value = new System.Windows.Forms.Label();
            this.lblStat1Title = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelSide.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentOrders)).BeginInit();
            this.panelStats.SuspendLayout();
            this.panelStat4.SuspendLayout();
            this.panelStat3.SuspendLayout();
            this.panelStat2.SuspendLayout();
            this.panelStat1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.panelTop.Controls.Add(this.lblBrand);
            this.panelTop.Controls.Add(this.lblWelcome);
            this.panelTop.Controls.Add(this.btnProfile);
            this.panelTop.Controls.Add(this.btnLogout);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1100, 60);
            this.panelTop.TabIndex = 2;
            // 
            // lblBrand
            // 
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(15, 12);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(200, 35);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "NeedBridge";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.lblWelcome.Location = new System.Drawing.Point(225, 18);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(500, 25);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Vendor Dashboard";
            // 
            // btnProfile
            // 
            this.btnProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(90)))));
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(895, 13);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(90, 34);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(995, 13);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(85, 34);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(60)))), ((int)(((byte)(50)))));
            this.panelSide.Controls.Add(this.btnEarnings);
            this.panelSide.Controls.Add(this.btnStock);
            this.panelSide.Controls.Add(this.btnMyOrders);
            this.panelSide.Controls.Add(this.btnAddProduct);
            this.panelSide.Controls.Add(this.btnMyProducts);
            this.panelSide.Controls.Add(this.btnDashboard);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 60);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(180, 620);
            this.panelSide.TabIndex = 1;
            // 
            // btnEarnings
            // 
            this.btnEarnings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(60)))), ((int)(((byte)(50)))));
            this.btnEarnings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEarnings.FlatAppearance.BorderSize = 0;
            this.btnEarnings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(80)))));
            this.btnEarnings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEarnings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEarnings.ForeColor = System.Drawing.Color.White;
            this.btnEarnings.Location = new System.Drawing.Point(0, 260);
            this.btnEarnings.Name = "btnEarnings";
            this.btnEarnings.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnEarnings.Size = new System.Drawing.Size(180, 46);
            this.btnEarnings.TabIndex = 0;
            this.btnEarnings.Text = "  Earnings";
            this.btnEarnings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEarnings.UseVisualStyleBackColor = false;
            this.btnEarnings.Click += new System.EventHandler(this.btnEarnings_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(60)))), ((int)(((byte)(50)))));
            this.btnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(80)))));
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Location = new System.Drawing.Point(0, 210);
            this.btnStock.Name = "btnStock";
            this.btnStock.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnStock.Size = new System.Drawing.Size(180, 46);
            this.btnStock.TabIndex = 1;
            this.btnStock.Text = "  Stock";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnMyOrders
            // 
            this.btnMyOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(60)))), ((int)(((byte)(50)))));
            this.btnMyOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyOrders.FlatAppearance.BorderSize = 0;
            this.btnMyOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(80)))));
            this.btnMyOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyOrders.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMyOrders.ForeColor = System.Drawing.Color.White;
            this.btnMyOrders.Location = new System.Drawing.Point(0, 160);
            this.btnMyOrders.Name = "btnMyOrders";
            this.btnMyOrders.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMyOrders.Size = new System.Drawing.Size(180, 46);
            this.btnMyOrders.TabIndex = 2;
            this.btnMyOrders.Text = "  My Orders";
            this.btnMyOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyOrders.UseVisualStyleBackColor = false;
            this.btnMyOrders.Click += new System.EventHandler(this.btnMyOrders_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(60)))), ((int)(((byte)(50)))));
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(80)))));
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(0, 110);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAddProduct.Size = new System.Drawing.Size(180, 46);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "  Add Product";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnMyProducts
            // 
            this.btnMyProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(60)))), ((int)(((byte)(50)))));
            this.btnMyProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyProducts.FlatAppearance.BorderSize = 0;
            this.btnMyProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(80)))));
            this.btnMyProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyProducts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMyProducts.ForeColor = System.Drawing.Color.White;
            this.btnMyProducts.Location = new System.Drawing.Point(0, 60);
            this.btnMyProducts.Name = "btnMyProducts";
            this.btnMyProducts.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMyProducts.Size = new System.Drawing.Size(180, 46);
            this.btnMyProducts.TabIndex = 4;
            this.btnMyProducts.Text = "  My Products";
            this.btnMyProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyProducts.UseVisualStyleBackColor = false;
            this.btnMyProducts.Click += new System.EventHandler(this.btnMyProducts_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(60)))), ((int)(((byte)(50)))));
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(80)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 10);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(180, 46);
            this.btnDashboard.TabIndex = 5;
            this.btnDashboard.Text = "  Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.panelMain.Controls.Add(this.panelGrid);
            this.panelMain.Controls.Add(this.panelStats);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(180, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(15);
            this.panelMain.Size = new System.Drawing.Size(920, 620);
            this.panelMain.TabIndex = 0;
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.White;
            this.panelGrid.Controls.Add(this.dgvRecentOrders);
            this.panelGrid.Controls.Add(this.lblRecentOrders);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(15, 130);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(890, 475);
            this.panelGrid.TabIndex = 0;
            // 
            // dgvRecentOrders
            // 
            this.dgvRecentOrders.AllowUserToAddRows = false;
            this.dgvRecentOrders.AllowUserToDeleteRows = false;
            this.dgvRecentOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecentOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecentOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecentOrders.ColumnHeadersHeight = 38;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecentOrders.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecentOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecentOrders.Location = new System.Drawing.Point(0, 38);
            this.dgvRecentOrders.Name = "dgvRecentOrders";
            this.dgvRecentOrders.ReadOnly = true;
            this.dgvRecentOrders.RowHeadersWidth = 51;
            this.dgvRecentOrders.RowTemplate.Height = 38;
            this.dgvRecentOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentOrders.Size = new System.Drawing.Size(890, 437);
            this.dgvRecentOrders.TabIndex = 0;
            // 
            // lblRecentOrders
            // 
            this.lblRecentOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRecentOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecentOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.lblRecentOrders.Location = new System.Drawing.Point(0, 0);
            this.lblRecentOrders.Name = "lblRecentOrders";
            this.lblRecentOrders.Padding = new System.Windows.Forms.Padding(8, 6, 0, 0);
            this.lblRecentOrders.Size = new System.Drawing.Size(890, 38);
            this.lblRecentOrders.TabIndex = 1;
            this.lblRecentOrders.Text = "Recent Orders";
            // 
            // panelStats
            // 
            this.panelStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.panelStats.Controls.Add(this.panelStat4);
            this.panelStats.Controls.Add(this.panelStat3);
            this.panelStats.Controls.Add(this.panelStat2);
            this.panelStats.Controls.Add(this.panelStat1);
            this.panelStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStats.Location = new System.Drawing.Point(15, 15);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(890, 115);
            this.panelStats.TabIndex = 1;
            // 
            // panelStat4
            // 
            this.panelStat4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(70)))), ((int)(((byte)(175)))));
            this.panelStat4.Controls.Add(this.lblStat4Value);
            this.panelStat4.Controls.Add(this.lblStat4Title);
            this.panelStat4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStat4.Location = new System.Drawing.Point(630, 0);
            this.panelStat4.Name = "panelStat4";
            this.panelStat4.Padding = new System.Windows.Forms.Padding(14, 8, 8, 8);
            this.panelStat4.Size = new System.Drawing.Size(255, 115);
            this.panelStat4.TabIndex = 0;
            // 
            // lblStat4Value
            // 
            this.lblStat4Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStat4Value.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblStat4Value.ForeColor = System.Drawing.Color.White;
            this.lblStat4Value.Location = new System.Drawing.Point(14, 30);
            this.lblStat4Value.Name = "lblStat4Value";
            this.lblStat4Value.Size = new System.Drawing.Size(233, 77);
            this.lblStat4Value.TabIndex = 0;
            this.lblStat4Value.Text = "0";
            // 
            // lblStat4Title
            // 
            this.lblStat4Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStat4Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStat4Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.lblStat4Title.Location = new System.Drawing.Point(14, 8);
            this.lblStat4Title.Name = "lblStat4Title";
            this.lblStat4Title.Size = new System.Drawing.Size(233, 22);
            this.lblStat4Title.TabIndex = 1;
            this.lblStat4Title.Text = "Low Stock Items";
            // 
            // panelStat3
            // 
            this.panelStat3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.panelStat3.Controls.Add(this.lblStat3Value);
            this.panelStat3.Controls.Add(this.lblStat3Title);
            this.panelStat3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStat3.Location = new System.Drawing.Point(420, 0);
            this.panelStat3.Name = "panelStat3";
            this.panelStat3.Padding = new System.Windows.Forms.Padding(14, 8, 8, 8);
            this.panelStat3.Size = new System.Drawing.Size(210, 115);
            this.panelStat3.TabIndex = 1;
            // 
            // lblStat3Value
            // 
            this.lblStat3Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStat3Value.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblStat3Value.ForeColor = System.Drawing.Color.White;
            this.lblStat3Value.Location = new System.Drawing.Point(14, 30);
            this.lblStat3Value.Name = "lblStat3Value";
            this.lblStat3Value.Size = new System.Drawing.Size(188, 77);
            this.lblStat3Value.TabIndex = 0;
            this.lblStat3Value.Text = "0";
            // 
            // lblStat3Title
            // 
            this.lblStat3Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStat3Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStat3Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.lblStat3Title.Location = new System.Drawing.Point(14, 8);
            this.lblStat3Title.Name = "lblStat3Title";
            this.lblStat3Title.Size = new System.Drawing.Size(188, 22);
            this.lblStat3Title.TabIndex = 1;
            this.lblStat3Title.Text = "Total Earnings (BDT)";
            // 
            // panelStat2
            // 
            this.panelStat2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.panelStat2.Controls.Add(this.lblStat2Value);
            this.panelStat2.Controls.Add(this.lblStat2Title);
            this.panelStat2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStat2.Location = new System.Drawing.Point(210, 0);
            this.panelStat2.Name = "panelStat2";
            this.panelStat2.Padding = new System.Windows.Forms.Padding(14, 8, 8, 8);
            this.panelStat2.Size = new System.Drawing.Size(210, 115);
            this.panelStat2.TabIndex = 2;
            // 
            // lblStat2Value
            // 
            this.lblStat2Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStat2Value.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblStat2Value.ForeColor = System.Drawing.Color.White;
            this.lblStat2Value.Location = new System.Drawing.Point(14, 30);
            this.lblStat2Value.Name = "lblStat2Value";
            this.lblStat2Value.Size = new System.Drawing.Size(188, 77);
            this.lblStat2Value.TabIndex = 0;
            this.lblStat2Value.Text = "0";
            // 
            // lblStat2Title
            // 
            this.lblStat2Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStat2Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStat2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.lblStat2Title.Location = new System.Drawing.Point(14, 8);
            this.lblStat2Title.Name = "lblStat2Title";
            this.lblStat2Title.Size = new System.Drawing.Size(188, 22);
            this.lblStat2Title.TabIndex = 1;
            this.lblStat2Title.Text = "Total Orders";
            // 
            // panelStat1
            // 
            this.panelStat1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.panelStat1.Controls.Add(this.lblStat1Value);
            this.panelStat1.Controls.Add(this.lblStat1Title);
            this.panelStat1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStat1.Location = new System.Drawing.Point(0, 0);
            this.panelStat1.Name = "panelStat1";
            this.panelStat1.Padding = new System.Windows.Forms.Padding(14, 8, 8, 8);
            this.panelStat1.Size = new System.Drawing.Size(210, 115);
            this.panelStat1.TabIndex = 3;
            // 
            // lblStat1Value
            // 
            this.lblStat1Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStat1Value.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblStat1Value.ForeColor = System.Drawing.Color.White;
            this.lblStat1Value.Location = new System.Drawing.Point(14, 30);
            this.lblStat1Value.Name = "lblStat1Value";
            this.lblStat1Value.Size = new System.Drawing.Size(188, 77);
            this.lblStat1Value.TabIndex = 0;
            this.lblStat1Value.Text = "0";
            // 
            // lblStat1Title
            // 
            this.lblStat1Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStat1Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStat1Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.lblStat1Title.Location = new System.Drawing.Point(14, 8);
            this.lblStat1Title.Name = "lblStat1Title";
            this.lblStat1Title.Size = new System.Drawing.Size(188, 22);
            this.lblStat1Title.TabIndex = 1;
            this.lblStat1Title.Text = "Total Products";
            // 
            // VendorHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelTop);
            this.Name = "VendorHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NeedBridge - Vendor Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VendorHome_Load);
            this.panelTop.ResumeLayout(false);
            this.panelSide.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentOrders)).EndInit();
            this.panelStats.ResumeLayout(false);
            this.panelStat4.ResumeLayout(false);
            this.panelStat3.ResumeLayout(false);
            this.panelStat2.ResumeLayout(false);
            this.panelStat1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnMyProducts;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnMyOrders;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnEarnings;
        private System.Windows.Forms.Panel panelStat1;
        private System.Windows.Forms.Panel panelStat2;
        private System.Windows.Forms.Panel panelStat3;
        private System.Windows.Forms.Panel panelStat4;
        private System.Windows.Forms.Label lblStat1Title;
        private System.Windows.Forms.Label lblStat1Value;
        private System.Windows.Forms.Label lblStat2Title;
        private System.Windows.Forms.Label lblStat2Value;
        private System.Windows.Forms.Label lblStat3Title;
        private System.Windows.Forms.Label lblStat3Value;
        private System.Windows.Forms.Label lblStat4Title;
        private System.Windows.Forms.Label lblStat4Value;
        private System.Windows.Forms.Label lblRecentOrders;
        private System.Windows.Forms.DataGridView dgvRecentOrders;
    }
}