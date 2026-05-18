namespace NeedBridge
{
    partial class AdminStockView
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
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.cmbStockFilter = new System.Windows.Forms.ComboBox();
            this.lblVendorFilter = new System.Windows.Forms.Label();
            this.cmbVendor = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelSummary = new System.Windows.Forms.Panel();
            this.panelTotalProducts = new System.Windows.Forms.Panel();
            this.lblTotalProductsTitle = new System.Windows.Forms.Label();
            this.lblTotalProductsValue = new System.Windows.Forms.Label();
            this.panelInStock = new System.Windows.Forms.Panel();
            this.lblInStockTitle = new System.Windows.Forms.Label();
            this.lblInStockValue = new System.Windows.Forms.Label();
            this.panelLowStock = new System.Windows.Forms.Panel();
            this.lblLowStockTitle = new System.Windows.Forms.Label();
            this.lblLowStockValue = new System.Windows.Forms.Label();
            this.panelOutOfStock = new System.Windows.Forms.Panel();
            this.lblOutOfStockTitle = new System.Windows.Forms.Label();
            this.lblOutOfStockValue = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelSummary.SuspendLayout();
            this.panelTotalProducts.SuspendLayout();
            this.panelInStock.SuspendLayout();
            this.panelLowStock.SuspendLayout();
            this.panelOutOfStock.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblSubtitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Size = new System.Drawing.Size(950, 65);

            this.lblTitle.AutoSize = false;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 8);
            this.lblTitle.Size = new System.Drawing.Size(600, 32);
            this.lblTitle.Text = "Stock Overview";

            this.lblSubtitle.AutoSize = false;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(189, 195, 199);
            this.lblSubtitle.Location = new System.Drawing.Point(20, 42);
            this.lblSubtitle.Size = new System.Drawing.Size(600, 20);
            this.lblSubtitle.Text = "Monitor stock levels across all vendors";

            // panelFilter
            this.panelFilter.BackColor = System.Drawing.Color.FromArgb(240, 245, 255);
            this.panelFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFilter.Controls.Add(this.lblFilterStatus);
            this.panelFilter.Controls.Add(this.cmbStockFilter);
            this.panelFilter.Controls.Add(this.lblVendorFilter);
            this.panelFilter.Controls.Add(this.cmbVendor);
            this.panelFilter.Controls.Add(this.btnFilter);
            this.panelFilter.Controls.Add(this.btnRefresh);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Size = new System.Drawing.Size(950, 55);

            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFilterStatus.Location = new System.Drawing.Point(15, 17);
            this.lblFilterStatus.Text = "Stock Level:";

            this.cmbStockFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStockFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStockFilter.Location = new System.Drawing.Point(105, 13);
            this.cmbStockFilter.Size = new System.Drawing.Size(150, 28);
            this.cmbStockFilter.Name = "cmbStockFilter";
            this.cmbStockFilter.Items.AddRange(new object[] {
                "All Products", "In Stock", "Low Stock (< 5)", "Out of Stock"
            });
            this.cmbStockFilter.SelectedIndex = 0;

            this.lblVendorFilter.AutoSize = true;
            this.lblVendorFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblVendorFilter.Location = new System.Drawing.Point(270, 17);
            this.lblVendorFilter.Text = "Vendor:";

            this.cmbVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbVendor.Location = new System.Drawing.Point(330, 13);
            this.cmbVendor.Size = new System.Drawing.Size(180, 28);
            this.cmbVendor.Name = "cmbVendor";

            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(525, 12);
            this.btnFilter.Size = new System.Drawing.Size(80, 30);
            this.btnFilter.Text = "Filter";
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);

            this.btnRefresh.BackColor = System.Drawing.Color.Gray;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(615, 12);
            this.btnRefresh.Size = new System.Drawing.Size(80, 30);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // panelSummary - 4 stat cards
            this.panelSummary.BackColor = System.Drawing.Color.FromArgb(245, 248, 250);
            this.panelSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSummary.Height = 100;
            this.panelSummary.Controls.Add(this.panelOutOfStock);
            this.panelSummary.Controls.Add(this.panelLowStock);
            this.panelSummary.Controls.Add(this.panelInStock);
            this.panelSummary.Controls.Add(this.panelTotalProducts);

            // Total Products card
            this.panelTotalProducts.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.panelTotalProducts.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTotalProducts.Width = 200;
            this.panelTotalProducts.Padding = new System.Windows.Forms.Padding(14, 8, 8, 8);
            this.panelTotalProducts.Controls.Add(this.lblTotalProductsValue);
            this.panelTotalProducts.Controls.Add(this.lblTotalProductsTitle);

            this.lblTotalProductsTitle.AutoSize = false;
            this.lblTotalProductsTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalProductsTitle.ForeColor = System.Drawing.Color.FromArgb(210, 235, 255);
            this.lblTotalProductsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalProductsTitle.Height = 22;
            this.lblTotalProductsTitle.Text = "Total Products";

            this.lblTotalProductsValue.AutoSize = false;
            this.lblTotalProductsValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTotalProductsValue.ForeColor = System.Drawing.Color.White;
            this.lblTotalProductsValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalProductsValue.Text = "0";
            this.lblTotalProductsValue.Name = "lblTotalProductsValue";

            // In Stock card
            this.panelInStock.BackColor = System.Drawing.Color.FromArgb(22, 160, 133);
            this.panelInStock.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInStock.Width = 200;
            this.panelInStock.Padding = new System.Windows.Forms.Padding(14, 8, 8, 8);
            this.panelInStock.Controls.Add(this.lblInStockValue);
            this.panelInStock.Controls.Add(this.lblInStockTitle);

            this.lblInStockTitle.AutoSize = false;
            this.lblInStockTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInStockTitle.ForeColor = System.Drawing.Color.FromArgb(210, 235, 255);
            this.lblInStockTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInStockTitle.Height = 22;
            this.lblInStockTitle.Text = "In Stock";

            this.lblInStockValue.AutoSize = false;
            this.lblInStockValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblInStockValue.ForeColor = System.Drawing.Color.White;
            this.lblInStockValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInStockValue.Text = "0";
            this.lblInStockValue.Name = "lblInStockValue";

            // Low Stock card
            this.panelLowStock.BackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            this.panelLowStock.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLowStock.Width = 200;
            this.panelLowStock.Padding = new System.Windows.Forms.Padding(14, 8, 8, 8);
            this.panelLowStock.Controls.Add(this.lblLowStockValue);
            this.panelLowStock.Controls.Add(this.lblLowStockTitle);

            this.lblLowStockTitle.AutoSize = false;
            this.lblLowStockTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLowStockTitle.ForeColor = System.Drawing.Color.FromArgb(210, 235, 255);
            this.lblLowStockTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLowStockTitle.Height = 22;
            this.lblLowStockTitle.Text = "Low Stock (< 5)";

            this.lblLowStockValue.AutoSize = false;
            this.lblLowStockValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblLowStockValue.ForeColor = System.Drawing.Color.White;
            this.lblLowStockValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLowStockValue.Text = "0";
            this.lblLowStockValue.Name = "lblLowStockValue";

            // Out of Stock card
            this.panelOutOfStock.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.panelOutOfStock.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOutOfStock.Width = 200;
            this.panelOutOfStock.Padding = new System.Windows.Forms.Padding(14, 8, 8, 8);
            this.panelOutOfStock.Controls.Add(this.lblOutOfStockValue);
            this.panelOutOfStock.Controls.Add(this.lblOutOfStockTitle);

            this.lblOutOfStockTitle.AutoSize = false;
            this.lblOutOfStockTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOutOfStockTitle.ForeColor = System.Drawing.Color.FromArgb(210, 235, 255);
            this.lblOutOfStockTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOutOfStockTitle.Height = 22;
            this.lblOutOfStockTitle.Text = "Out of Stock";

            this.lblOutOfStockValue.AutoSize = false;
            this.lblOutOfStockValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblOutOfStockValue.ForeColor = System.Drawing.Color.White;
            this.lblOutOfStockValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOutOfStockValue.Text = "0";
            this.lblOutOfStockValue.Name = "lblOutOfStockValue";

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
            this.dgvStock.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.dgvStock.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStock.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvStock.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvStock.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(189, 195, 199);
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
            this.btnClose.Location = new System.Drawing.Point(850, 11);
            this.btnClose.Size = new System.Drawing.Size(85, 34);
            this.btnClose.Text = "Close";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // AdminStockView Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 640);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminStockView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Overview - NeedBridge";
            this.Load += new System.EventHandler(this.AdminStockView_Load);
            this.panelTop.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelSummary.ResumeLayout(false);
            this.panelTotalProducts.ResumeLayout(false);
            this.panelInStock.ResumeLayout(false);
            this.panelLowStock.ResumeLayout(false);
            this.panelOutOfStock.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cmbStockFilter;
        private System.Windows.Forms.Label lblVendorFilter;
        private System.Windows.Forms.ComboBox cmbVendor;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.Panel panelTotalProducts;
        private System.Windows.Forms.Label lblTotalProductsTitle;
        private System.Windows.Forms.Label lblTotalProductsValue;
        private System.Windows.Forms.Panel panelInStock;
        private System.Windows.Forms.Label lblInStockTitle;
        private System.Windows.Forms.Label lblInStockValue;
        private System.Windows.Forms.Panel panelLowStock;
        private System.Windows.Forms.Label lblLowStockTitle;
        private System.Windows.Forms.Label lblLowStockValue;
        private System.Windows.Forms.Panel panelOutOfStock;
        private System.Windows.Forms.Label lblOutOfStockTitle;
        private System.Windows.Forms.Label lblOutOfStockValue;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnClose;
    }
}