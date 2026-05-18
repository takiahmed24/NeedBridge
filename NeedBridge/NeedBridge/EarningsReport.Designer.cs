namespace NeedBridge
{
    partial class EarningsReport
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
            this.panelSummary = new System.Windows.Forms.Panel();
            this.panelTotalEarnings = new System.Windows.Forms.Panel();
            this.lblTotalEarningsTitle = new System.Windows.Forms.Label();
            this.lblTotalEarningsValue = new System.Windows.Forms.Label();
            this.panelTotalOrders = new System.Windows.Forms.Panel();
            this.lblTotalOrdersTitle = new System.Windows.Forms.Label();
            this.lblTotalOrdersValue = new System.Windows.Forms.Label();
            this.panelAvgOrder = new System.Windows.Forms.Panel();
            this.lblAvgOrderTitle = new System.Windows.Forms.Label();
            this.lblAvgOrderValue = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.dgvEarnings = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelSummary.SuspendLayout();
            this.panelTotalEarnings.SuspendLayout();
            this.panelTotalOrders.SuspendLayout();
            this.panelAvgOrder.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEarnings)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(8, 80, 65);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblSubtitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Size = new System.Drawing.Size(900, 65);

            this.lblTitle.AutoSize = false;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 8);
            this.lblTitle.Size = new System.Drawing.Size(600, 32);
            this.lblTitle.Text = "Earnings Report";
            this.lblTitle.Name = "lblTitle";

            this.lblSubtitle.AutoSize = false;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(180, 255, 220);
            this.lblSubtitle.Location = new System.Drawing.Point(20, 42);
            this.lblSubtitle.Size = new System.Drawing.Size(600, 20);
            this.lblSubtitle.Text = "View your revenue and sales breakdown";

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
            this.cmbPeriod.Size = new System.Drawing.Size(170, 28);
            this.cmbPeriod.Name = "cmbPeriod";
            this.cmbPeriod.Items.AddRange(new object[] {
                "Today", "This Week", "This Month", "Last Month", "All Time"
            });
            this.cmbPeriod.SelectedIndex = 2;

            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(8, 80, 65);
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(310, 12);
            this.btnLoad.Size = new System.Drawing.Size(110, 30);
            this.btnLoad.Text = "Load Report";
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            // panelSummary
            this.panelSummary.BackColor = System.Drawing.Color.FromArgb(245, 248, 250);
            this.panelSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSummary.Height = 100;
            this.panelSummary.Controls.Add(this.panelAvgOrder);
            this.panelSummary.Controls.Add(this.panelTotalOrders);
            this.panelSummary.Controls.Add(this.panelTotalEarnings);

            // Total Earnings card
            this.panelTotalEarnings.BackColor = System.Drawing.Color.FromArgb(8, 80, 65);
            this.panelTotalEarnings.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTotalEarnings.Width = 240;
            this.panelTotalEarnings.Padding = new System.Windows.Forms.Padding(14, 8, 8, 8);
            this.panelTotalEarnings.Controls.Add(this.lblTotalEarningsValue);
            this.panelTotalEarnings.Controls.Add(this.lblTotalEarningsTitle);

            this.lblTotalEarningsTitle.AutoSize = false;
            this.lblTotalEarningsTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalEarningsTitle.ForeColor = System.Drawing.Color.FromArgb(180, 255, 220);
            this.lblTotalEarningsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalEarningsTitle.Height = 22;
            this.lblTotalEarningsTitle.Text = "Total Earnings (BDT)";

            this.lblTotalEarningsValue.AutoSize = false;
            this.lblTotalEarningsValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTotalEarningsValue.ForeColor = System.Drawing.Color.White;
            this.lblTotalEarningsValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalEarningsValue.Text = "৳0";
            this.lblTotalEarningsValue.Name = "lblTotalEarningsValue";

            // Total Orders card
            this.panelTotalOrders.BackColor = System.Drawing.Color.FromArgb(22, 160, 133);
            this.panelTotalOrders.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTotalOrders.Width = 240;
            this.panelTotalOrders.Padding = new System.Windows.Forms.Padding(14, 8, 8, 8);
            this.panelTotalOrders.Controls.Add(this.lblTotalOrdersValue);
            this.panelTotalOrders.Controls.Add(this.lblTotalOrdersTitle);

            this.lblTotalOrdersTitle.AutoSize = false;
            this.lblTotalOrdersTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalOrdersTitle.ForeColor = System.Drawing.Color.FromArgb(210, 255, 240);
            this.lblTotalOrdersTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalOrdersTitle.Height = 22;
            this.lblTotalOrdersTitle.Text = "Total Orders";

            this.lblTotalOrdersValue.AutoSize = false;
            this.lblTotalOrdersValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTotalOrdersValue.ForeColor = System.Drawing.Color.White;
            this.lblTotalOrdersValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalOrdersValue.Text = "0";
            this.lblTotalOrdersValue.Name = "lblTotalOrdersValue";

            // Avg Order card
            this.panelAvgOrder.BackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            this.panelAvgOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAvgOrder.Width = 240;
            this.panelAvgOrder.Padding = new System.Windows.Forms.Padding(14, 8, 8, 8);
            this.panelAvgOrder.Controls.Add(this.lblAvgOrderValue);
            this.panelAvgOrder.Controls.Add(this.lblAvgOrderTitle);

            this.lblAvgOrderTitle.AutoSize = false;
            this.lblAvgOrderTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAvgOrderTitle.ForeColor = System.Drawing.Color.FromArgb(255, 240, 200);
            this.lblAvgOrderTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAvgOrderTitle.Height = 22;
            this.lblAvgOrderTitle.Text = "Avg Order Value (BDT)";

            this.lblAvgOrderValue.AutoSize = false;
            this.lblAvgOrderValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblAvgOrderValue.ForeColor = System.Drawing.Color.White;
            this.lblAvgOrderValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvgOrderValue.Text = "৳0";
            this.lblAvgOrderValue.Name = "lblAvgOrderValue";

            // panelContent
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.panelContent.Controls.Add(this.dgvEarnings);
            this.panelContent.Controls.Add(this.lblGridTitle);

            this.lblGridTitle.AutoSize = false;
            this.lblGridTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGridTitle.Height = 36;
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(8, 80, 65);
            this.lblGridTitle.Padding = new System.Windows.Forms.Padding(4, 6, 0, 0);
            this.lblGridTitle.Text = "Sales Breakdown by Product";
            this.lblGridTitle.Name = "lblGridTitle";

            this.dgvEarnings.AllowUserToAddRows = false;
            this.dgvEarnings.AllowUserToDeleteRows = false;
            this.dgvEarnings.ReadOnly = true;
            this.dgvEarnings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEarnings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEarnings.BackgroundColor = System.Drawing.Color.White;
            this.dgvEarnings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEarnings.ColumnHeadersHeight = 38;
            this.dgvEarnings.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(8, 80, 65);
            this.dgvEarnings.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEarnings.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvEarnings.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvEarnings.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(200, 240, 220);
            this.dgvEarnings.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEarnings.RowTemplate.Height = 38;
            this.dgvEarnings.Name = "dgvEarnings";
            this.dgvEarnings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

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

            // EarningsReport Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 640);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EarningsReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Earnings Report - NeedBridge";
            this.Load += new System.EventHandler(this.EarningsReport_Load);
            this.panelTop.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelSummary.ResumeLayout(false);
            this.panelTotalEarnings.ResumeLayout(false);
            this.panelTotalOrders.ResumeLayout(false);
            this.panelAvgOrder.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEarnings)).EndInit();
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
        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.Panel panelTotalEarnings;
        private System.Windows.Forms.Label lblTotalEarningsTitle;
        private System.Windows.Forms.Label lblTotalEarningsValue;
        private System.Windows.Forms.Panel panelTotalOrders;
        private System.Windows.Forms.Label lblTotalOrdersTitle;
        private System.Windows.Forms.Label lblTotalOrdersValue;
        private System.Windows.Forms.Panel panelAvgOrder;
        private System.Windows.Forms.Label lblAvgOrderTitle;
        private System.Windows.Forms.Label lblAvgOrderValue;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.DataGridView dgvEarnings;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnClose;
    }
}