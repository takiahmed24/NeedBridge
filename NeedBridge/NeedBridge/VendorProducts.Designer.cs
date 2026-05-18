namespace NeedBridge
{
    partial class VendorProducts
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.lblEditTitle = new System.Windows.Forms.Label();
            this.lblEditName = new System.Windows.Forms.Label();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.lblEditPrice = new System.Windows.Forms.Label();
            this.txtEditPrice = new System.Windows.Forms.TextBox();
            this.lblEditDiscount = new System.Windows.Forms.Label();
            this.txtEditDiscount = new System.Windows.Forms.TextBox();
            this.lblEditStock = new System.Windows.Forms.Label();
            this.txtEditStock = new System.Windows.Forms.TextBox();
            this.lblEditAvail = new System.Windows.Forms.Label();
            this.cmbEditAvail = new System.Windows.Forms.ComboBox();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panelEdit.SuspendLayout();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(8, 80, 65);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblSubtitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Size = new System.Drawing.Size(1100, 65);

            this.lblTitle.AutoSize = false;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 8);
            this.lblTitle.Size = new System.Drawing.Size(600, 32);
            this.lblTitle.Text = "My Products";

            this.lblSubtitle.AutoSize = false;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(180, 255, 220);
            this.lblSubtitle.Location = new System.Drawing.Point(20, 42);
            this.lblSubtitle.Size = new System.Drawing.Size(600, 20);
            this.lblSubtitle.Text = "Manage your product listings";

            // panelFilter
            this.panelFilter.BackColor = System.Drawing.Color.FromArgb(240, 245, 255);
            this.panelFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFilter.Controls.Add(this.lblSearch);
            this.panelFilter.Controls.Add(this.txtSearch);
            this.panelFilter.Controls.Add(this.btnSearch);
            this.panelFilter.Controls.Add(this.btnRefresh);
            this.panelFilter.Controls.Add(this.btnAddNew);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Size = new System.Drawing.Size(1100, 55);

            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSearch.Location = new System.Drawing.Point(15, 17);
            this.lblSearch.Text = "Search:";

            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(75, 13);
            this.txtSearch.Size = new System.Drawing.Size(220, 28);
            this.txtSearch.Name = "txtSearch";

            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(8, 80, 65);
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(310, 12);
            this.btnSearch.Size = new System.Drawing.Size(90, 30);
            this.btnSearch.Text = "Search";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.btnRefresh.BackColor = System.Drawing.Color.Gray;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(410, 12);
            this.btnRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(515, 12);
            this.btnAddNew.Size = new System.Drawing.Size(120, 30);
            this.btnAddNew.Text = "+ Add Product";
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);

            // panelContent — left side with product grid
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Padding = new System.Windows.Forms.Padding(10);
            this.panelContent.Controls.Add(this.dgvProducts);

            // dgvProducts
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.ColumnHeadersHeight = 38;
            this.dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(8, 80, 65);
            this.dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProducts.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvProducts.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvProducts.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(200, 240, 220);
            this.dgvProducts.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProducts.RowTemplate.Height = 38;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.SelectionChanged += new System.EventHandler(this.dgvProducts_SelectionChanged);

            // panelEdit — right side edit panel
            this.panelEdit.BackColor = System.Drawing.Color.FromArgb(245, 248, 250);
            this.panelEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEdit.Width = 280;
            this.panelEdit.Controls.Add(this.lblEditTitle);
            this.panelEdit.Controls.Add(this.lblEditName);
            this.panelEdit.Controls.Add(this.txtEditName);
            this.panelEdit.Controls.Add(this.lblEditPrice);
            this.panelEdit.Controls.Add(this.txtEditPrice);
            this.panelEdit.Controls.Add(this.lblEditDiscount);
            this.panelEdit.Controls.Add(this.txtEditDiscount);
            this.panelEdit.Controls.Add(this.lblEditStock);
            this.panelEdit.Controls.Add(this.txtEditStock);
            this.panelEdit.Controls.Add(this.lblEditAvail);
            this.panelEdit.Controls.Add(this.cmbEditAvail);
            this.panelEdit.Controls.Add(this.btnSaveEdit);
            this.panelEdit.Controls.Add(this.btnDeleteProduct);

            this.lblEditTitle.AutoSize = false;
            this.lblEditTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblEditTitle.ForeColor = System.Drawing.Color.FromArgb(8, 80, 65);
            this.lblEditTitle.Location = new System.Drawing.Point(15, 15);
            this.lblEditTitle.Size = new System.Drawing.Size(250, 25);
            this.lblEditTitle.Text = "Edit Selected Product";

            this.lblEditName.AutoSize = true;
            this.lblEditName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEditName.Location = new System.Drawing.Point(15, 55);
            this.lblEditName.Text = "Product Name";

            this.txtEditName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEditName.Location = new System.Drawing.Point(15, 75);
            this.txtEditName.Size = new System.Drawing.Size(248, 28);
            this.txtEditName.Name = "txtEditName";

            this.lblEditPrice.AutoSize = true;
            this.lblEditPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEditPrice.Location = new System.Drawing.Point(15, 115);
            this.lblEditPrice.Text = "Price (BDT)";

            this.txtEditPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEditPrice.Location = new System.Drawing.Point(15, 135);
            this.txtEditPrice.Size = new System.Drawing.Size(248, 28);
            this.txtEditPrice.Name = "txtEditPrice";

            this.lblEditDiscount.AutoSize = true;
            this.lblEditDiscount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEditDiscount.Location = new System.Drawing.Point(15, 175);
            this.lblEditDiscount.Text = "Discount %";

            this.txtEditDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditDiscount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEditDiscount.Location = new System.Drawing.Point(15, 195);
            this.txtEditDiscount.Size = new System.Drawing.Size(248, 28);
            this.txtEditDiscount.Name = "txtEditDiscount";

            this.lblEditStock.AutoSize = true;
            this.lblEditStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEditStock.Location = new System.Drawing.Point(15, 235);
            this.lblEditStock.Text = "Stock Quantity";

            this.txtEditStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditStock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEditStock.Location = new System.Drawing.Point(15, 255);
            this.txtEditStock.Size = new System.Drawing.Size(248, 28);
            this.txtEditStock.Name = "txtEditStock";

            this.lblEditAvail.AutoSize = true;
            this.lblEditAvail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEditAvail.Location = new System.Drawing.Point(15, 295);
            this.lblEditAvail.Text = "Availability";

            this.cmbEditAvail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditAvail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEditAvail.Location = new System.Drawing.Point(15, 315);
            this.cmbEditAvail.Size = new System.Drawing.Size(248, 28);
            this.cmbEditAvail.Name = "cmbEditAvail";
            this.cmbEditAvail.Items.AddRange(new object[] { "available", "unavailable" });
            this.cmbEditAvail.SelectedIndex = 0;

            this.btnSaveEdit.BackColor = System.Drawing.Color.FromArgb(8, 80, 65);
            this.btnSaveEdit.FlatAppearance.BorderSize = 0;
            this.btnSaveEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveEdit.ForeColor = System.Drawing.Color.White;
            this.btnSaveEdit.Location = new System.Drawing.Point(15, 360);
            this.btnSaveEdit.Size = new System.Drawing.Size(248, 38);
            this.btnSaveEdit.Text = "Save Changes";
            this.btnSaveEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);

            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnDeleteProduct.FlatAppearance.BorderSize = 0;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Location = new System.Drawing.Point(15, 410);
            this.btnDeleteProduct.Size = new System.Drawing.Size(248, 38);
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);

            // VendorProducts Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelTop);
            this.Name = "VendorProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Products - NeedBridge";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VendorProducts_Load);
            this.panelTop.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Label lblEditTitle;
        private System.Windows.Forms.Label lblEditName;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label lblEditPrice;
        private System.Windows.Forms.TextBox txtEditPrice;
        private System.Windows.Forms.Label lblEditDiscount;
        private System.Windows.Forms.TextBox txtEditDiscount;
        private System.Windows.Forms.Label lblEditStock;
        private System.Windows.Forms.TextBox txtEditStock;
        private System.Windows.Forms.Label lblEditAvail;
        private System.Windows.Forms.ComboBox cmbEditAvail;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Button btnDeleteProduct;
    }
}