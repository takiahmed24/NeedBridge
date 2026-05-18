namespace NeedBridge
{
    partial class SalesReport
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.cmbPeriod = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.panelS1.SuspendLayout();
            this.panelS2.SuspendLayout();
            this.panelS3.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblSubtitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Size = new System.Drawing.Size(900, 65);

            this.lblTitle.AutoSize = false;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 8);
            this.lblTitle.Size = new System.Drawing.Size(600, 32);
            this.lblTitle.Text = "Sales Report";

            this.lblSubtitle.AutoSize = false;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(189, 195, 199);
            this.lblSubtitle.Location = new System.Drawing.Point(20, 42);
            this.lblSubtitle.Size = new System.Drawing.Size(600, 20);
            this.lblSubtitle.Text = "Platform-wide sales analytics";

            // panelFilter
            this.panelFilter.BackColor = System.Drawing.Color.FromArgb(240, 245, 255);
            this.panelFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFilter.Controls.Add(this.lblPeriod);
            this.panelFilter.Controls.Add(this.cmbPeriod);
            this.panelFilter.Controls.Add(this.btnLoad);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Size = new System.Drawing.Size(900, 55);

            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPeriod.Location = new System.Drawing.Point(15, 17);
            this.lblPeriod.Text = "Report Period:";

            this.cmbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPeriod.Location = new System.Drawing.Point(125, 13);
            this.cmbPeriod.Size = new System.Drawing.Size(180, 28);
            this.cmbPeriod.Name = "cmbPeriod";
            this.cmbPeriod.Items.AddRange(new object[] { "Today", "This Week", "This Month", "Last Month", "All Time" });
            this.cmbPeriod.SelectedIndex = 2;

            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(320, 12);
            this.btnLoad.Size = new System.Drawing.Size(110, 30);
            this.btnLoad.Text = "Load Report";
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            // panelStats
            this.panelStats.BackColor = System.Drawing.Color.FromArgb(245, 248, 250);
            this.panelStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStats.Height = 110;
            this.panelStats.Controls.Add(this.panelS3);
            this.panelStats.Controls.Add(this.panelS2);
            this.panelStats.Controls.Add(this.panelS1);

            this.panelS1.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.panelS1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelS1.Width = 240;
            this.panelS1.Padding = new System.Windows.Forms.Padding(14, 8, 8, 8);
            this.panelS1.Controls.Add(this.lblS1Value);
            this.panelS1.Controls.Add(this.lblS1Title);
            this.lblS1Title.AutoSize = false;
            this.lblS1Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblS1Title.ForeColor = System.Drawing.Color.FromArgb(210, 235, 255);
            this.lblS1Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblS1Title.Height = 22;
            this.lblS1Title.Text = "Total Orders";
            this.lblS1Value.AutoSize = false;
            this.lblS1Value.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblS1Value.ForeColor = System.Drawing.Color.White;
            this.lblS1Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblS1Value.Text = "0";
            this.lblS1Value.Name = "lblS1Value";

            this.panelS2.BackColor = System.Drawing.Color.FromArgb(22, 160, 133);
            this.panelS2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelS2.Width = 240;
            this.panelS2.Padding = new System.Windows.Forms.Padding(14, 8, 8, 8);
            this.panelS2.Controls.Add(this.lblS2Value);
            this.panelS2.Controls.Add(this.lblS2Title);
            this.lblS2Title.AutoSize = false;
            this.lblS2Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblS2Title.ForeColor = System.Drawing.Color.FromArgb(210, 235, 255);
            this.lblS2Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblS2Title.Height = 22;
            this.lblS2Title.Text = "Total Revenue (BDT)";
            this.lblS2Value.AutoSize = false;
            this.lblS2Value.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblS2Value.ForeColor = System.Drawing.Color.White;
            this.lblS2Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblS2Value.Text = "0";
            this.lblS2Value.Name = "lblS2Value";

            this.panelS3.BackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            this.panelS3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelS3.Width = 240;
            this.panelS3.Padding = new System.Windows.Forms.Padding(14, 8, 8, 8);
            this.panelS3.Controls.Add(this.lblS3Value);
            this.panelS3.Controls.Add(this.lblS3Title);
            this.lblS3Title.AutoSize = false;
            this.lblS3Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblS3Title.ForeColor = System.Drawing.Color.FromArgb(210, 235, 255);
            this.lblS3Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblS3Title.Height = 22;
            this.lblS3Title.Text = "Avg Order Value (BDT)";
            this.lblS3Value.AutoSize = false;
            this.lblS3Value.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblS3Value.ForeColor = System.Drawing.Color.White;
            this.lblS3Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblS3Value.Text = "0";
            this.lblS3Value.Name = "lblS3Value";

            // panelContent
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.panelContent.Controls.Add(this.dgvSales);
            this.panelContent.Controls.Add(this.lblGridTitle);

            this.lblGridTitle.AutoSize = false;
            this.lblGridTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGridTitle.Height = 36;
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblGridTitle.Padding = new System.Windows.Forms.Padding(4, 6, 0, 0);
            this.lblGridTitle.Text = "Sales Breakdown by Vendor";
            this.lblGridTitle.Name = "lblGridTitle";

            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.ReadOnly = true;
            this.dgvSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSales.BackgroundColor = System.Drawing.Color.White;
            this.dgvSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSales.ColumnHeadersHeight = 38;
            this.dgvSales.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.dgvSales.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSales.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvSales.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvSales.RowTemplate.Height = 38;
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // panelBottom
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(245, 248, 250);
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Height = 55;
            this.panelBottom.Controls.Add(this.btnClose);

            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(800, 11);
            this.btnClose.Size = new System.Drawing.Size(85, 34);
            this.btnClose.Text = "Close";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // SalesReport Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 620);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Report - NeedBridge";
            this.Load += new System.EventHandler(this.SalesReport_Load);
            this.panelTop.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelStats.ResumeLayout(false);
            this.panelS1.ResumeLayout(false);
            this.panelS2.ResumeLayout(false);
            this.panelS3.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.ComboBox cmbPeriod;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Panel panelS1;
        private System.Windows.Forms.Label lblS1Title;
        private System.Windows.Forms.Label lblS1Value;
        private System.Windows.Forms.Panel panelS2;
        private System.Windows.Forms.Label lblS2Title;
        private System.Windows.Forms.Label lblS2Value;
        private System.Windows.Forms.Panel panelS3;
        private System.Windows.Forms.Label lblS3Title;
        private System.Windows.Forms.Label lblS3Value;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnClose;
    }
}