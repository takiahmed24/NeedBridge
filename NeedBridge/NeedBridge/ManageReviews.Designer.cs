namespace NeedBridge
{
    partial class ManageReviews
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
            this.lblRating = new System.Windows.Forms.Label();
            this.cmbRating = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.dgvReviews = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).BeginInit();
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
            this.lblTitle.Text = "⭐ Manage Reviews";

            this.lblSubtitle.AutoSize = false;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(189, 195, 199);
            this.lblSubtitle.Location = new System.Drawing.Point(20, 42);
            this.lblSubtitle.Size = new System.Drawing.Size(600, 20);
            this.lblSubtitle.Text = "View and delete inappropriate reviews";

            // panelFilter
            this.panelFilter.BackColor = System.Drawing.Color.FromArgb(240, 245, 255);
            this.panelFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFilter.Controls.Add(this.lblSearch);
            this.panelFilter.Controls.Add(this.txtSearch);
            this.panelFilter.Controls.Add(this.lblRating);
            this.panelFilter.Controls.Add(this.cmbRating);
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
            this.txtSearch.Size = new System.Drawing.Size(220, 28);
            this.txtSearch.Name = "txtSearch";

            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblRating.Location = new System.Drawing.Point(310, 17);
            this.lblRating.Text = "Rating:";

            this.cmbRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRating.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRating.Location = new System.Drawing.Point(365, 13);
            this.cmbRating.Size = new System.Drawing.Size(130, 28);
            this.cmbRating.Name = "cmbRating";
            this.cmbRating.Items.AddRange(new object[] {
                "All Ratings", "⭐ 1 Star", "⭐⭐ 2 Stars",
                "⭐⭐⭐ 3 Stars", "⭐⭐⭐⭐ 4 Stars", "⭐⭐⭐⭐⭐ 5 Stars"
            });
            this.cmbRating.SelectedIndex = 0;

            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(510, 12);
            this.btnSearch.Size = new System.Drawing.Size(90, 30);
            this.btnSearch.Text = "🔍 Search";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.btnRefresh.BackColor = System.Drawing.Color.Gray;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(610, 12);
            this.btnRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // panelContent
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Padding = new System.Windows.Forms.Padding(10);
            this.panelContent.Controls.Add(this.dgvReviews);

            // dgvReviews
            this.dgvReviews.AllowUserToAddRows = false;
            this.dgvReviews.AllowUserToDeleteRows = false;
            this.dgvReviews.ReadOnly = true;
            this.dgvReviews.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReviews.BackgroundColor = System.Drawing.Color.White;
            this.dgvReviews.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReviews.ColumnHeadersHeight = 38;
            this.dgvReviews.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.dgvReviews.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReviews.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvReviews.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvReviews.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(189, 195, 199);
            this.dgvReviews.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvReviews.RowTemplate.Height = 40;
            this.dgvReviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReviews.Name = "dgvReviews";
            this.dgvReviews.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // panelBottom
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(245, 248, 250);
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Height = 60;
            this.panelBottom.Controls.Add(this.btnDelete);
            this.panelBottom.Controls.Add(this.btnClose);

            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(15, 13);
            this.btnDelete.Size = new System.Drawing.Size(180, 34);
            this.btnDelete.Text = "🗑 Delete Review";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

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

            // ManageReviews Form
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
            this.Name = "ManageReviews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Reviews - NeedBridge";
            this.Load += new System.EventHandler(this.ManageReviews_Load);
            this.panelTop.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.ComboBox cmbRating;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.DataGridView dgvReviews;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
    }
}