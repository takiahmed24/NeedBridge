namespace NeedBridge
{
    partial class ManageDiscounts
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lblDiscountLabel = new System.Windows.Forms.Label();
            this.txtDiscountPct = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
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
            this.lblTitle.Text = "Manage Discounts";

            this.lblSubtitle.AutoSize = false;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(189, 195, 199);
            this.lblSubtitle.Location = new System.Drawing.Point(20, 42);
            this.lblSubtitle.Size = new System.Drawing.Size(600, 20);
            this.lblSubtitle.Text = "Set or remove discounts on any product";

            // panelFilter
            this.panelFilter.BackColor = System.Drawing.Color.FromArgb(240, 245, 255);
            this.panelFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFilter.Controls.Add(this.lblSearch);
            this.panelFilter.Controls.Add(this.txtSearch);
            this.panelFilter.Controls.Add(this.lblCategory);
            this.panelFilter.Controls.Add(this.cmbCategory);
            this.panelFilter.Controls.Add(this.btnSearch);
            this.panelFilter.Controls.Add(this.btnRefresh);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Size = new System.Drawing.Size(950, 55);

            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSearch.Location = new System.Drawing.Point(15, 17);
            this.lblSearch.Text = "Search:";

            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(75, 13);
            this.txtSearch.Size = new System.Drawing.Size(200, 28);
            this.txtSearch.Name = "txtSearch";

            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(290, 17);
            this.lblCategory.Text = "Category:";

            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.Location = new System.Drawing.Point(360, 13);
            this.cmbCategory.Size = new System.Drawing.Size(160, 28);
            this.cmbCategory.Name = "cmbCategory";

            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(535, 12);
            this.btnSearch.Size = new System.Drawing.Size(90, 30);
            this.btnSearch.Text = "Search";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.btnRefresh.BackColor = System.Drawing.Color.Gray;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(635, 12);
            this.btnRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // panelContent
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
            this.dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProducts.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvProducts.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvProducts.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(189, 195, 199);
            this.dgvProducts.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProducts.RowTemplate.Height = 38;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // panelBottom
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(245, 248, 250);
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Height = 60;
            this.panelBottom.Controls.Add(this.lblDiscountLabel);
            this.panelBottom.Controls.Add(this.txtDiscountPct);
            this.panelBottom.Controls.Add(this.btnApply);
            this.panelBottom.Controls.Add(this.btnRemove);
            this.panelBottom.Controls.Add(this.btnClose);

            this.lblDiscountLabel.AutoSize = false;
            this.lblDiscountLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDiscountLabel.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblDiscountLabel.Location = new System.Drawing.Point(15, 20);
            this.lblDiscountLabel.Size = new System.Drawing.Size(110, 22);
            this.lblDiscountLabel.Text = "Discount %:";

            this.txtDiscountPct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscountPct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDiscountPct.Location = new System.Drawing.Point(130, 17);
            this.txtDiscountPct.Size = new System.Drawing.Size(80, 28);
            this.txtDiscountPct.Text = "10";
            this.txtDiscountPct.Name = "txtDiscountPct";

            this.btnApply.BackColor = System.Drawing.Color.FromArgb(22, 160, 133);
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(225, 13);
            this.btnApply.Size = new System.Drawing.Size(160, 34);
            this.btnApply.Text = "Apply Discount";
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);

            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(400, 13);
            this.btnRemove.Size = new System.Drawing.Size(160, 34);
            this.btnRemove.Text = "Remove Discount";
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(850, 13);
            this.btnClose.Size = new System.Drawing.Size(85, 34);
            this.btnClose.Text = "Close";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // ManageDiscounts Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManageDiscounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Discounts - NeedBridge";
            this.Load += new System.EventHandler(this.ManageDiscounts_Load);
            this.panelTop.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblDiscountLabel;
        private System.Windows.Forms.TextBox txtDiscountPct;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClose;
    }
}