namespace NeedBridge
{
    partial class CustomerHome
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
            this.btnCart = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cmbPrice = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelProducts = new System.Windows.Forms.Panel();
            this.lblProductsTitle = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();

            // ── panelTop ──────────────────────────────────────────────
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.panelTop.Controls.Add(this.lblBrand);
            this.panelTop.Controls.Add(this.lblWelcome);
            this.panelTop.Controls.Add(this.btnCart);
            this.panelTop.Controls.Add(this.btnOrders);
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
            this.lblBrand.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;

            this.lblWelcome.AutoSize = false;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(180, 220, 255);
            this.lblWelcome.Location = new System.Drawing.Point(225, 18);
            this.lblWelcome.Size = new System.Drawing.Size(400, 25);
            this.lblWelcome.Text = "Welcome!";
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;

            this.btnCart.BackColor = System.Drawing.Color.FromArgb(255, 165, 0);
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCart.ForeColor = System.Drawing.Color.White;
            this.btnCart.Location = new System.Drawing.Point(650, 13);
            this.btnCart.Size = new System.Drawing.Size(90, 34);
            this.btnCart.Text = "🛒 Cart";
            this.btnCart.Name = "btnCart";
            this.btnCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCart.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);

            this.btnOrders.BackColor = System.Drawing.Color.FromArgb(40, 120, 190);
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Location = new System.Drawing.Point(750, 13);
            this.btnOrders.Size = new System.Drawing.Size(90, 34);
            this.btnOrders.Text = "📦 Orders";
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrders.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);

            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(40, 120, 190);
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(850, 13);
            this.btnProfile.Size = new System.Drawing.Size(90, 34);
            this.btnProfile.Text = "👤 Profile";
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);

            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(950, 13);
            this.btnLogout.Size = new System.Drawing.Size(85, 34);
            this.btnLogout.Text = "Logout";
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // ── panelFilter ───────────────────────────────────────────
            this.panelFilter.BackColor = System.Drawing.Color.FromArgb(240, 245, 255);
            this.panelFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFilter.Controls.Add(this.lblSearch);
            this.panelFilter.Controls.Add(this.txtSearch);
            this.panelFilter.Controls.Add(this.lblCategory);
            this.panelFilter.Controls.Add(this.cmbCategory);
            this.panelFilter.Controls.Add(this.lblPrice);
            this.panelFilter.Controls.Add(this.cmbPrice);
            this.panelFilter.Controls.Add(this.btnSearch);
            this.panelFilter.Controls.Add(this.btnClear);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Size = new System.Drawing.Size(1100, 65);

            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearch.Location = new System.Drawing.Point(15, 10);
            this.lblSearch.Text = "Search:";

            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(15, 28);
            this.txtSearch.Size = new System.Drawing.Size(220, 28);
            this.txtSearch.Name = "txtSearch";

            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(250, 10);
            this.lblCategory.Text = "Category:";

            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.Location = new System.Drawing.Point(250, 28);
            this.cmbCategory.Size = new System.Drawing.Size(180, 28);
            this.cmbCategory.Name = "cmbCategory";

            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(445, 10);
            this.lblPrice.Text = "Price Range (BDT):";

            this.cmbPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPrice.Location = new System.Drawing.Point(445, 28);
            this.cmbPrice.Size = new System.Drawing.Size(180, 28);
            this.cmbPrice.Name = "cmbPrice";
            this.cmbPrice.Items.AddRange(new object[] {
                "All Prices", "Under ৳500", "৳500 - ৳1000",
                "৳1000 - ৳5000", "৳5000 - ৳10000", "Above ৳10000"
            });
            this.cmbPrice.SelectedIndex = 0;

            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(645, 26);
            this.btnSearch.Size = new System.Drawing.Size(100, 32);
            this.btnSearch.Text = "🔍 Search";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(755, 26);
            this.btnClear.Size = new System.Drawing.Size(80, 32);
            this.btnClear.Text = "Clear";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // ── panelProducts ─────────────────────────────────────────
            this.panelProducts.Controls.Add(this.dgvProducts);
            this.panelProducts.Controls.Add(this.lblProductsTitle);
            this.panelProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProducts.Padding = new System.Windows.Forms.Padding(10);
            this.panelProducts.BackColor = System.Drawing.Color.White;

            this.lblProductsTitle.AutoSize = false;
            this.lblProductsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblProductsTitle.ForeColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.lblProductsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProductsTitle.Height = 35;
            this.lblProductsTitle.Padding = new System.Windows.Forms.Padding(4, 5, 0, 0);
            this.lblProductsTitle.Text = "All Products";
            this.lblProductsTitle.Name = "lblProductsTitle";

            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.ColumnHeadersHeight = 38;
            this.dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProducts.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvProducts.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvProducts.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(200, 220, 255);
            this.dgvProducts.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProducts.RowTemplate.Height = 40;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellDoubleClick);

            // ── CustomerHome Form ─────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.Controls.Add(this.panelProducts);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelTop);
            this.Name = "CustomerHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NeedBridge - Shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomerHome_Load);
            this.panelTop.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cmbPrice;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblProductsTitle;
        private System.Windows.Forms.DataGridView dgvProducts;
    }
}