namespace NeedBridge
{
    partial class AdminHome
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnManageVendors = new System.Windows.Forms.Button();
            this.btnManageCustomers = new System.Windows.Forms.Button();
            this.btnManageReviews = new System.Windows.Forms.Button();
            this.btnDisputes = new System.Windows.Forms.Button();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.btnDiscounts = new System.Windows.Forms.Button();
            this.btnStockView = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelStats = new System.Windows.Forms.Panel();
            this.panelStat1 = new System.Windows.Forms.Panel();
            this.lblStat1Title = new System.Windows.Forms.Label();
            this.lblStat1Value = new System.Windows.Forms.Label();
            this.panelStat2 = new System.Windows.Forms.Panel();
            this.lblStat2Title = new System.Windows.Forms.Label();
            this.lblStat2Value = new System.Windows.Forms.Label();
            this.panelStat3 = new System.Windows.Forms.Panel();
            this.lblStat3Title = new System.Windows.Forms.Label();
            this.lblStat3Value = new System.Windows.Forms.Label();
            this.panelStat4 = new System.Windows.Forms.Panel();
            this.lblStat4Title = new System.Windows.Forms.Label();
            this.lblStat4Value = new System.Windows.Forms.Label();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.lblRecentTitle = new System.Windows.Forms.Label();
            this.dgvRecent = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.panelSide.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.panelStat1.SuspendLayout();
            this.panelStat2.SuspendLayout();
            this.panelStat3.SuspendLayout();
            this.panelStat4.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).BeginInit();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.panelTop.Controls.Add(this.lblBrand);
            this.panelTop.Controls.Add(this.lblWelcome);
            this.panelTop.Controls.Add(this.btnProfile);
            this.panelTop.Controls.Add(this.btnLogout);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Size = new System.Drawing.Size(1100, 60);

            this.lblBrand.AutoSize = false;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(15, 12);
            this.lblBrand.Size = new System.Drawing.Size(200, 35);
            this.lblBrand.Text = "NeedBridge";

            this.lblWelcome.AutoSize = false;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(189, 195, 199);
            this.lblWelcome.Location = new System.Drawing.Point(225, 18);
            this.lblWelcome.Size = new System.Drawing.Size(500, 25);
            this.lblWelcome.Text = "Admin Dashboard";
            this.lblWelcome.Name = "lblWelcome";

            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(895, 13);
            this.btnProfile.Size = new System.Drawing.Size(90, 34);
            this.btnProfile.Text = "Profile";
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);

            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(995, 13);
            this.btnLogout.Size = new System.Drawing.Size(85, 34);
            this.btnLogout.Text = "Logout";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // panelSide
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.panelSide.Controls.Add(this.btnStockView);
            this.panelSide.Controls.Add(this.btnDiscounts);
            this.panelSide.Controls.Add(this.btnSalesReport);
            this.panelSide.Controls.Add(this.btnDisputes);
            this.panelSide.Controls.Add(this.btnManageReviews);
            this.panelSide.Controls.Add(this.btnManageCustomers);
            this.panelSide.Controls.Add(this.btnManageVendors);
            this.panelSide.Controls.Add(this.btnDashboard);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Size = new System.Drawing.Size(190, 620);

            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 10);
            this.btnDashboard.Size = new System.Drawing.Size(190, 44);
            this.btnDashboard.Text = "  Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);

            this.btnManageVendors.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnManageVendors.FlatAppearance.BorderSize = 0;
            this.btnManageVendors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btnManageVendors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageVendors.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnManageVendors.ForeColor = System.Drawing.Color.White;
            this.btnManageVendors.Location = new System.Drawing.Point(0, 58);
            this.btnManageVendors.Size = new System.Drawing.Size(190, 44);
            this.btnManageVendors.Text = "  Manage Vendors";
            this.btnManageVendors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageVendors.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageVendors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageVendors.Click += new System.EventHandler(this.btnManageVendors_Click);

            this.btnManageCustomers.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnManageCustomers.FlatAppearance.BorderSize = 0;
            this.btnManageCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btnManageCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCustomers.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnManageCustomers.ForeColor = System.Drawing.Color.White;
            this.btnManageCustomers.Location = new System.Drawing.Point(0, 106);
            this.btnManageCustomers.Size = new System.Drawing.Size(190, 44);
            this.btnManageCustomers.Text = "  Manage Customers";
            this.btnManageCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageCustomers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageCustomers.Click += new System.EventHandler(this.btnManageCustomers_Click);

            this.btnManageReviews.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnManageReviews.FlatAppearance.BorderSize = 0;
            this.btnManageReviews.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btnManageReviews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageReviews.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnManageReviews.ForeColor = System.Drawing.Color.White;
            this.btnManageReviews.Location = new System.Drawing.Point(0, 154);
            this.btnManageReviews.Size = new System.Drawing.Size(190, 44);
            this.btnManageReviews.Text = "  Manage Reviews";
            this.btnManageReviews.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageReviews.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageReviews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageReviews.Click += new System.EventHandler(this.btnManageReviews_Click);

            this.btnDisputes.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnDisputes.FlatAppearance.BorderSize = 0;
            this.btnDisputes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btnDisputes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisputes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDisputes.ForeColor = System.Drawing.Color.White;
            this.btnDisputes.Location = new System.Drawing.Point(0, 202);
            this.btnDisputes.Size = new System.Drawing.Size(190, 44);
            this.btnDisputes.Text = "  Disputes";
            this.btnDisputes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisputes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDisputes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisputes.Click += new System.EventHandler(this.btnDisputes_Click);

            this.btnSalesReport.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnSalesReport.FlatAppearance.BorderSize = 0;
            this.btnSalesReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btnSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesReport.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnSalesReport.ForeColor = System.Drawing.Color.White;
            this.btnSalesReport.Location = new System.Drawing.Point(0, 250);
            this.btnSalesReport.Size = new System.Drawing.Size(190, 44);
            this.btnSalesReport.Text = "  Sales Report";
            this.btnSalesReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesReport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalesReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);

            this.btnDiscounts.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnDiscounts.FlatAppearance.BorderSize = 0;
            this.btnDiscounts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btnDiscounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscounts.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDiscounts.ForeColor = System.Drawing.Color.White;
            this.btnDiscounts.Location = new System.Drawing.Point(0, 298);
            this.btnDiscounts.Size = new System.Drawing.Size(190, 44);
            this.btnDiscounts.Text = "  Discounts";
            this.btnDiscounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscounts.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDiscounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiscounts.Click += new System.EventHandler(this.btnDiscounts_Click);

            this.btnStockView.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnStockView.FlatAppearance.BorderSize = 0;
            this.btnStockView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btnStockView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockView.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnStockView.ForeColor = System.Drawing.Color.White;
            this.btnStockView.Location = new System.Drawing.Point(0, 346);
            this.btnStockView.Size = new System.Drawing.Size(190, 44);
            this.btnStockView.Text = "  Stock Overview";
            this.btnStockView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockView.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStockView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStockView.Click += new System.EventHandler(this.btnStockView_Click);

            // panelMain
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(245, 248, 250);
            this.panelMain.Controls.Add(this.panelGrid);
            this.panelMain.Controls.Add(this.panelStats);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Padding = new System.Windows.Forms.Padding(15);

            // panelStats
            this.panelStats.BackColor = System.Drawing.Color.FromArgb(245, 248, 250);
            this.panelStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStats.Height = 115;
            this.panelStats.Controls.Add(this.panelStat4);
            this.panelStats.Controls.Add(this.panelStat3);
            this.panelStats.Controls.Add(this.panelStat2);
            this.panelStats.Controls.Add(this.panelStat1);

            this.panelStat1.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.panelStat1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStat1.Width = 210;
            this.panelStat1.Padding = new System.Windows.Forms.Padding(14, 8, 8, 8);
            this.panelStat1.Controls.Add(this.lblStat1Value);
            this.panelStat1.Controls.Add(this.lblStat1Title);
            this.lblStat1Title.AutoSize = false;
            this.lblStat1Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStat1Title.ForeColor = System.Drawing.Color.FromArgb(210, 235, 255);
            this.lblStat1Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStat1Title.Height = 22;
            this.lblStat1Title.Text = "Total Vendors";
            this.lblStat1Value.AutoSize = false;
            this.lblStat1Value.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblStat1Value.ForeColor = System.Drawing.Color.White;
            this.lblStat1Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStat1Value.Text = "0";
            this.lblStat1Value.Name = "lblStat1Value";

            this.panelStat2.BackColor = System.Drawing.Color.FromArgb(22, 160, 133);
            this.panelStat2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStat2.Width = 210;
            this.panelStat2.Padding = new System.Windows.Forms.Padding(14, 8, 8, 8);
            this.panelStat2.Controls.Add(this.lblStat2Value);
            this.panelStat2.Controls.Add(this.lblStat2Title);
            this.lblStat2Title.AutoSize = false;
            this.lblStat2Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStat2Title.ForeColor = System.Drawing.Color.FromArgb(210, 235, 255);
            this.lblStat2Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStat2Title.Height = 22;
            this.lblStat2Title.Text = "Total Customers";
            this.lblStat2Value.AutoSize = false;
            this.lblStat2Value.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblStat2Value.ForeColor = System.Drawing.Color.White;
            this.lblStat2Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStat2Value.Text = "0";
            this.lblStat2Value.Name = "lblStat2Value";

            this.panelStat3.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.panelStat3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStat3.Width = 210;
            this.panelStat3.Padding = new System.Windows.Forms.Padding(14, 8, 8, 8);
            this.panelStat3.Controls.Add(this.lblStat3Value);
            this.panelStat3.Controls.Add(this.lblStat3Title);
            this.lblStat3Title.AutoSize = false;
            this.lblStat3Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStat3Title.ForeColor = System.Drawing.Color.FromArgb(210, 235, 255);
            this.lblStat3Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStat3Title.Height = 22;
            this.lblStat3Title.Text = "Total Orders";
            this.lblStat3Value.AutoSize = false;
            this.lblStat3Value.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblStat3Value.ForeColor = System.Drawing.Color.White;
            this.lblStat3Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStat3Value.Text = "0";
            this.lblStat3Value.Name = "lblStat3Value";

            this.panelStat4.BackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            this.panelStat4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStat4.Width = 210;
            this.panelStat4.Padding = new System.Windows.Forms.Padding(14, 8, 8, 8);
            this.panelStat4.Controls.Add(this.lblStat4Value);
            this.panelStat4.Controls.Add(this.lblStat4Title);
            this.lblStat4Title.AutoSize = false;
            this.lblStat4Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStat4Title.ForeColor = System.Drawing.Color.FromArgb(210, 235, 255);
            this.lblStat4Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStat4Title.Height = 22;
            this.lblStat4Title.Text = "Total Revenue (BDT)";
            this.lblStat4Value.AutoSize = false;
            this.lblStat4Value.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblStat4Value.ForeColor = System.Drawing.Color.White;
            this.lblStat4Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStat4Value.Text = "0";
            this.lblStat4Value.Name = "lblStat4Value";

            // panelGrid
            this.panelGrid.BackColor = System.Drawing.Color.White;
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Controls.Add(this.dgvRecent);
            this.panelGrid.Controls.Add(this.lblRecentTitle);
            this.lblRecentTitle.AutoSize = false;
            this.lblRecentTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRecentTitle.Height = 38;
            this.lblRecentTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecentTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblRecentTitle.Padding = new System.Windows.Forms.Padding(8, 6, 0, 0);
            this.lblRecentTitle.Text = "Recent Orders (Platform-wide)";

            this.dgvRecent.AllowUserToAddRows = false;
            this.dgvRecent.AllowUserToDeleteRows = false;
            this.dgvRecent.ReadOnly = true;
            this.dgvRecent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecent.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecent.ColumnHeadersHeight = 38;
            this.dgvRecent.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.dgvRecent.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRecent.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvRecent.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvRecent.RowTemplate.Height = 38;
            this.dgvRecent.Name = "dgvRecent";
            this.dgvRecent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // AdminHome Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelTop);
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NeedBridge - Admin Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.panelTop.ResumeLayout(false);
            this.panelSide.ResumeLayout(false);
            this.panelStats.ResumeLayout(false);
            this.panelStat1.ResumeLayout(false);
            this.panelStat2.ResumeLayout(false);
            this.panelStat3.ResumeLayout(false);
            this.panelStat4.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).EndInit();
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
        private System.Windows.Forms.Button btnManageVendors;
        private System.Windows.Forms.Button btnManageCustomers;
        private System.Windows.Forms.Button btnManageReviews;
        private System.Windows.Forms.Button btnDisputes;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.Button btnDiscounts;
        private System.Windows.Forms.Button btnStockView;
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
        private System.Windows.Forms.Label lblRecentTitle;
        private System.Windows.Forms.DataGridView dgvRecent;
    }
}