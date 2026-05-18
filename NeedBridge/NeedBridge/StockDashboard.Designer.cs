namespace NeedBridge
{
    partial class StockDashboard
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
            this.panelSummary = new System.Windows.Forms.Panel();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.panelInStock = new System.Windows.Forms.Panel();
            this.lblInStockTitle = new System.Windows.Forms.Label();
            this.lblInStockValue = new System.Windows.Forms.Label();
            this.panelLow = new System.Windows.Forms.Panel();
            this.lblLowTitle = new System.Windows.Forms.Label();
            this.lblLowValue = new System.Windows.Forms.Label();
            this.panelOut = new System.Windows.Forms.Panel();
            this.lblOutTitle = new System.Windows.Forms.Label();
            this.lblOutValue = new System.Windows.Forms.Label();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelSummary.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.panelInStock.SuspendLayout();
            this.panelLow.SuspendLayout();
            this.panelOut.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
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
            this.lblTitle.Text = "Stock & Inventory";
            this.lblTitle.Name = "lblTitle";

            this.lblSubtitle.AutoSize = false;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(180, 255, 220);
            this.lblSubtitle.Location = new System.Drawing.Point(20, 42);
            this.lblSubtitle.Size = new System.Drawing.Size(600, 20);
            this.lblSubtitle.Text = "Monitor your product stock levels";

            // panelSummary
            this.panelSummary.BackColor = System.Drawing.Color.FromArgb(245, 248, 250);
            this.panelSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSummary.Height = 100;
            this.panelSummary.Controls.Add(this.panelOut);
            this.panelSummary.Controls.Add(this.panelLow);
            this.panelSummary.Controls.Add(this.panelInStock);
            this.panelSummary.Controls.Add(this.panelTotal);

            // Total card
            this.panelTotal.BackColor = System.Drawing.Color.FromArgb(8, 80, 65);
            this.panelTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTotal.Width = 190;
            this.panelTotal.Padding = new System.Windows.Forms.Padding(14, 8, 8, 8);
            this.panelTotal.Controls.Add(this.lblTotalValue);
            this.panelTotal.Controls.Add(this.lblTotalTitle);

            this.lblTotalTitle.AutoSize = false;
            this.lblTotalTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalTitle.ForeColor = System.Drawing.Color.FromArgb(180, 255, 220);
            this.lblTotalTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalTitle.Height = 22;
            this.lblTotalTitle.Text = "Total Products";

            this.lblTotalValue.AutoSize = false;
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTotalValue.ForeColor = System.Drawing.Color.White;
            this.lblTotalValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalValue.Text = "0";
            this.lblTotalValue.Name = "lblTotalValue";

            // InStock card
            this.panelInStock.BackColor = System.Drawing.Color.FromArgb(22, 160, 133);
            this.panelInStock.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInStock.Width = 190;
            this.panelInStock.Padding = new System.Windows.Forms.Padding(14, 8, 8, 8);
            this.panelInStock.Controls.Add(this.lblInStockValue);
            this.panelInStock.Controls.Add(this.lblInStockTitle);

            this.lblInStockTitle.AutoSize = false;
            this.lblInStockTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInStockTitle.ForeColor = System.Drawing.Color.FromArgb(210, 255, 240);
            this.lblInStockTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInStockTitle.Height = 22;
            this.lblInStockTitle.Text = "In Stock";

            this.lblInStockValue.AutoSize = false;
            this.lblInStockValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblInStockValue.ForeColor = System.Drawing.Color.White;
            this.lblInStockValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInStockValue.Text = "0";
            this.lblInStockValue.Name = "lblInStockValue";

            // Low stock card
            this.panelLow.BackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            this.panelLow.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLow.Width = 190;
            this.panelLow.Padding = new System.Windows.Forms.Padding(14, 8, 8, 8);
            this.panelLow.Controls.Add(this.lblLowValue);
            this.panelLow.Controls.Add(this.lblLowTitle);

            this.lblLowTitle.AutoSize = false;
            this.lblLowTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLowTitle.ForeColor = System.Drawing.Color.FromArgb(255, 240, 200);
            this.lblLowTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLowTitle.Height = 22;
            this.lblLowTitle.Text = "Low Stock (< 5)";

            this.lblLowValue.AutoSize = false;
            this.lblLowValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblLowValue.ForeColor = System.Drawing.Color.White;
            this.lblLowValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLowValue.Text = "0";
            this.lblLowValue.Name = "lblLowValue";

            // Out of stock card
            this.panelOut.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.panelOut.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOut.Width = 190;
            this.panelOut.Padding = new System.Windows.Forms.Padding(14, 8, 8, 8);
            this.panelOut.Controls.Add(this.lblOutValue);
            this.panelOut.Controls.Add(this.lblOutTitle);

            this.lblOutTitle.AutoSize = false;
            this.lblOutTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOutTitle.ForeColor = System.Drawing.Color.FromArgb(255, 210, 200);
            this.lblOutTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOutTitle.Height = 22;
            this.lblOutTitle.Text = "Out of Stock";

            this.lblOutValue.AutoSize = false;
            this.lblOutValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblOutValue.ForeColor = System.Drawing.Color.White;
            this.lblOutValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOutValue.Text = "0";
            this.lblOutValue.Name = "lblOutValue";

            // panelFilter
            this.panelFilter.BackColor = System.Drawing.Color.FromArgb(240, 245, 255);
            this.panelFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFilter.Controls.Add(this.lblFilter);
            this.panelFilter.Controls.Add(this.cmbFilter);
            this.panelFilter.Controls.Add(this.btnFilter);
            this.panelFilter.Controls.Add(this.btnRefresh);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Size = new System.Drawing.Size(900, 55);

            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFilter.Location = new System.Drawing.Point(15, 17);
            this.lblFilter.Text = "Show:";

            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFilter.Location = new System.Drawing.Point(65, 13);
            this.cmbFilter.Size = new System.Drawing.Size(170, 28);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Items.AddRange(new object[] {
                "All Products", "In Stock", "Low Stock (< 5)", "Out of Stock"
            });
            this.cmbFilter.SelectedIndex = 0;

            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(8, 80, 65);
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(250, 12);
            this.btnFilter.Size = new System.Drawing.Size(80, 30);
            this.btnFilter.Text = "Filter";
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);

            this.btnRefresh.BackColor = System.Drawing.Color.Gray;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(340, 12);
            this.btnRefresh.Size = new System.Drawing.Size(80, 30);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // panelContent
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Padding = new System.Windows.Forms.Padding(10);
            this.panelContent.Controls.Add(this.dgvStock);

            // dgvStock
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.ReadOnly = true;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStock.ColumnHeadersHeight = 38;
            this.dgvStock.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(8, 80, 65);
            this.dgvStock.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStock.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvStock.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvStock.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(200, 240, 220);
            this.dgvStock.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvStock.RowTemplate.Height = 38;
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

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

            // StockDashboard Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 640);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StockDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock & Inventory - NeedBridge";
            this.Load += new System.EventHandler(this.StockDashboard_Load);
            this.panelTop.ResumeLayout(false);
            this.panelSummary.ResumeLayout(false);
            this.panelTotal.ResumeLayout(false);
            this.panelInStock.ResumeLayout(false);
            this.panelLow.ResumeLayout(false);
            this.panelOut.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Panel panelInStock;
        private System.Windows.Forms.Label lblInStockTitle;
        private System.Windows.Forms.Label lblInStockValue;
        private System.Windows.Forms.Panel panelLow;
        private System.Windows.Forms.Label lblLowTitle;
        private System.Windows.Forms.Label lblLowValue;
        private System.Windows.Forms.Panel panelOut;
        private System.Windows.Forms.Label lblOutTitle;
        private System.Windows.Forms.Label lblOutValue;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnClose;
    }
}