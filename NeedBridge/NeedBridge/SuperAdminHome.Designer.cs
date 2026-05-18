namespace NeedBridge
{
    partial class SuperAdminHome
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnManageAdmins = new System.Windows.Forms.Button();
            this.btnManageVendors = new System.Windows.Forms.Button();
            this.btnManageCustomers = new System.Windows.Forms.Button();
            this.btnPlatformReport = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelStats = new System.Windows.Forms.Panel();
            this.panelS1 = new System.Windows.Forms.Panel();
            this.lblS1Title = new System.Windows.Forms.Label();
            this.lblS1Value = new System.Windows.Forms.Label();
            this.panelS2 = new System.Windows.Forms.Panel();
            this.lblS2Title = new System.Windows.Forms.Label();
            this.lblS2Value = new System.Windows.Forms.Label();
            this.panelS3 = new System.Windows.Forms.Panel();
            this.lblS3Title = new System.Windows.Forms.Label();
            this.lblS3Value = new System.Windows.Forms.Label();
            this.panelS4 = new System.Windows.Forms.Panel();
            this.lblS4Title = new System.Windows.Forms.Label();
            this.lblS4Value = new System.Windows.Forms.Label();
            this.panelS5 = new System.Windows.Forms.Panel();
            this.lblS5Title = new System.Windows.Forms.Label();
            this.lblS5Value = new System.Windows.Forms.Label();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.panelSide.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.panelS1.SuspendLayout();
            this.panelS2.SuspendLayout();
            this.panelS3.SuspendLayout();
            this.panelS4.SuspendLayout();
            this.panelS5.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(20, 20, 30);
            this.panelTop.Controls.Add(this.lblBrand);
            this.panelTop.Controls.Add(this.lblWelcome);
            this.panelTop.Controls.Add(this.btnLogout);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Size = new System.Drawing.Size(1100, 60);

            this.lblBrand.AutoSize = false;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(255, 215, 0);
            this.lblBrand.Location = new System.Drawing.Point(15, 12);
            this.lblBrand.Size = new System.Drawing.Size(220, 35);
            this.lblBrand.Text = "NeedBridge";

            this.lblWelcome.AutoSize = false;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.lblWelcome.Location = new System.Drawing.Point(245, 18);
            this.lblWelcome.Size = new System.Drawing.Size(500, 25);
            this.lblWelcome.Text = "Super Admin Control Panel";
            this.lblWelcome.Name = "lblWelcome";

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
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(30, 30, 45);
            this.panelSide.Controls.Add(this.btnPlatformReport);
            this.panelSide.Controls.Add(this.btnManageCustomers);
            this.panelSide.Controls.Add(this.btnManageVendors);
            this.panelSide.Controls.Add(this.btnManageAdmins);
            this.panelSide.Controls.Add(this.btnDashboard);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Size = new System.Drawing.Size(190, 620);

            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(30, 30, 45);
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 50, 70);
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

            this.btnManageAdmins.BackColor = System.Drawing.Color.FromArgb(30, 30, 45);
            this.btnManageAdmins.FlatAppearance.BorderSize = 0;
            this.btnManageAdmins.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.btnManageAdmins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageAdmins.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnManageAdmins.ForeColor = System.Drawing.Color.FromArgb(255, 215, 0);
            this.btnManageAdmins.Location = new System.Drawing.Point(0, 58);
            this.btnManageAdmins.Size = new System.Drawing.Size(190, 44);
            this.btnManageAdmins.Text = "  Manage Admins";
            this.btnManageAdmins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageAdmins.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageAdmins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageAdmins.Click += new System.EventHandler(this.btnManageAdmins_Click);

            this.btnManageVendors.BackColor = System.Drawing.Color.FromArgb(30, 30, 45);
            this.btnManageVendors.FlatAppearance.BorderSize = 0;
            this.btnManageVendors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.btnManageVendors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageVendors.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnManageVendors.ForeColor = System.Drawing.Color.White;
            this.btnManageVendors.Location = new System.Drawing.Point(0, 106);
            this.btnManageVendors.Size = new System.Drawing.Size(190, 44);
            this.btnManageVendors.Text = "  Manage Vendors";
            this.btnManageVendors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageVendors.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageVendors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageVendors.Click += new System.EventHandler(this.btnManageVendors_Click);

            this.btnManageCustomers.BackColor = System.Drawing.Color.FromArgb(30, 30, 45);
            this.btnManageCustomers.FlatAppearance.BorderSize = 0;
            this.btnManageCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.btnManageCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCustomers.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnManageCustomers.ForeColor = System.Drawing.Color.White;
            this.btnManageCustomers.Location = new System.Drawing.Point(0, 154);
            this.btnManageCustomers.Size = new System.Drawing.Size(190, 44);
            this.btnManageCustomers.Text = "  Manage Customers";
            this.btnManageCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageCustomers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageCustomers.Click += new System.EventHandler(this.btnManageCustomers_Click);

            this.btnPlatformReport.BackColor = System.Drawing.Color.FromArgb(30, 30, 45);
            this.btnPlatformReport.FlatAppearance.BorderSize = 0;
            this.btnPlatformReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.btnPlatformReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlatformReport.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnPlatformReport.ForeColor = System.Drawing.Color.White;
            this.btnPlatformReport.Location = new System.Drawing.Point(0, 202);
            this.btnPlatformReport.Size = new System.Drawing.Size(190, 44);
            this.btnPlatformReport.Text = "  Platform Report";
            this.btnPlatformReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlatformReport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPlatformReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlatformReport.Click += new System.EventHandler(this.btnPlatformReport_Click);

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
            this.panelStats.Controls.Add(this.panelS5);
            this.panelStats.Controls.Add(this.panelS4);
            this.panelStats.Controls.Add(this.panelS3);
            this.panelStats.Controls.Add(this.panelS2);
            this.panelStats.Controls.Add(this.panelS1);

            // S1 - Admins
            this.panelS1.BackColor = System.Drawing.Color.FromArgb(20, 20, 30);
            this.panelS1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelS1.Width = 160;
            this.panelS1.Padding = new System.Windows.Forms.Padding(12, 8, 8, 8);
            this.panelS1.Controls.Add(this.lblS1Value);
            this.panelS1.Controls.Add(this.lblS1Title);
            this.lblS1Title.AutoSize = false;
            this.lblS1Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblS1Title.ForeColor = System.Drawing.Color.FromArgb(255, 215, 0);
            this.lblS1Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblS1Title.Height = 22;
            this.lblS1Title.Text = "Admins";
            this.lblS1Value.AutoSize = false;
            this.lblS1Value.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblS1Value.ForeColor = System.Drawing.Color.White;
            this.lblS1Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblS1Value.Text = "0";
            this.lblS1Value.Name = "lblS1Value";

            // S2 - Vendors
            this.panelS2.BackColor = System.Drawing.Color.FromArgb(8, 80, 65);
            this.panelS2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelS2.Width = 160;
            this.panelS2.Padding = new System.Windows.Forms.Padding(12, 8, 8, 8);
            this.panelS2.Controls.Add(this.lblS2Value);
            this.panelS2.Controls.Add(this.lblS2Title);
            this.lblS2Title.AutoSize = false;
            this.lblS2Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblS2Title.ForeColor = System.Drawing.Color.FromArgb(180, 255, 220);
            this.lblS2Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblS2Title.Height = 22;
            this.lblS2Title.Text = "Vendors";
            this.lblS2Value.AutoSize = false;
            this.lblS2Value.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblS2Value.ForeColor = System.Drawing.Color.White;
            this.lblS2Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblS2Value.Text = "0";
            this.lblS2Value.Name = "lblS2Value";

            // S3 - Customers
            this.panelS3.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.panelS3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelS3.Width = 160;
            this.panelS3.Padding = new System.Windows.Forms.Padding(12, 8, 8, 8);
            this.panelS3.Controls.Add(this.lblS3Value);
            this.panelS3.Controls.Add(this.lblS3Title);
            this.lblS3Title.AutoSize = false;
            this.lblS3Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblS3Title.ForeColor = System.Drawing.Color.FromArgb(180, 220, 255);
            this.lblS3Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblS3Title.Height = 22;
            this.lblS3Title.Text = "Customers";
            this.lblS3Value.AutoSize = false;
            this.lblS3Value.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblS3Value.ForeColor = System.Drawing.Color.White;
            this.lblS3Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblS3Value.Text = "0";
            this.lblS3Value.Name = "lblS3Value";

            // S4 - Orders
            this.panelS4.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.panelS4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelS4.Width = 160;
            this.panelS4.Padding = new System.Windows.Forms.Padding(12, 8, 8, 8);
            this.panelS4.Controls.Add(this.lblS4Value);
            this.panelS4.Controls.Add(this.lblS4Title);
            this.lblS4Title.AutoSize = false;
            this.lblS4Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblS4Title.ForeColor = System.Drawing.Color.FromArgb(255, 210, 200);
            this.lblS4Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblS4Title.Height = 22;
            this.lblS4Title.Text = "Total Orders";
            this.lblS4Value.AutoSize = false;
            this.lblS4Value.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblS4Value.ForeColor = System.Drawing.Color.White;
            this.lblS4Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblS4Value.Text = "0";
            this.lblS4Value.Name = "lblS4Value";

            // S5 - Revenue
            this.panelS5.BackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            this.panelS5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelS5.Width = 160;
            this.panelS5.Padding = new System.Windows.Forms.Padding(12, 8, 8, 8);
            this.panelS5.Controls.Add(this.lblS5Value);
            this.panelS5.Controls.Add(this.lblS5Title);
            this.lblS5Title.AutoSize = false;
            this.lblS5Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblS5Title.ForeColor = System.Drawing.Color.FromArgb(255, 240, 200);
            this.lblS5Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblS5Title.Height = 22;
            this.lblS5Title.Text = "Total Revenue (BDT)";
            this.lblS5Value.AutoSize = false;
            this.lblS5Value.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblS5Value.ForeColor = System.Drawing.Color.White;
            this.lblS5Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblS5Value.Text = "৳0";
            this.lblS5Value.Name = "lblS5Value";

            // panelGrid
            this.panelGrid.BackColor = System.Drawing.Color.White;
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Controls.Add(this.dgvUsers);
            this.panelGrid.Controls.Add(this.lblGridTitle);

            this.lblGridTitle.AutoSize = false;
            this.lblGridTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGridTitle.Height = 38;
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(20, 20, 30);
            this.lblGridTitle.Padding = new System.Windows.Forms.Padding(8, 6, 0, 0);
            this.lblGridTitle.Text = "All Users — Platform Overview";
            this.lblGridTitle.Name = "lblGridTitle";

            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.ColumnHeadersHeight = 38;
            this.dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(20, 20, 30);
            this.dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(255, 215, 0);
            this.dgvUsers.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvUsers.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvUsers.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 240, 150);
            this.dgvUsers.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvUsers.RowTemplate.Height = 38;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // SuperAdminHome Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelTop);
            this.Name = "SuperAdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NeedBridge - Super Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SuperAdminHome_Load);
            this.panelTop.ResumeLayout(false);
            this.panelSide.ResumeLayout(false);
            this.panelStats.ResumeLayout(false);
            this.panelS1.ResumeLayout(false);
            this.panelS2.ResumeLayout(false);
            this.panelS3.ResumeLayout(false);
            this.panelS4.ResumeLayout(false);
            this.panelS5.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnManageAdmins;
        private System.Windows.Forms.Button btnManageVendors;
        private System.Windows.Forms.Button btnManageCustomers;
        private System.Windows.Forms.Button btnPlatformReport;
        private System.Windows.Forms.Panel panelS1;
        private System.Windows.Forms.Label lblS1Title;
        private System.Windows.Forms.Label lblS1Value;
        private System.Windows.Forms.Panel panelS2;
        private System.Windows.Forms.Label lblS2Title;
        private System.Windows.Forms.Label lblS2Value;
        private System.Windows.Forms.Panel panelS3;
        private System.Windows.Forms.Label lblS3Title;
        private System.Windows.Forms.Label lblS3Value;
        private System.Windows.Forms.Panel panelS4;
        private System.Windows.Forms.Label lblS4Title;
        private System.Windows.Forms.Label lblS4Value;
        private System.Windows.Forms.Panel panelS5;
        private System.Windows.Forms.Label lblS5Title;
        private System.Windows.Forms.Label lblS5Value;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.DataGridView dgvUsers;
    }
}