namespace NeedBridge
{
    partial class VendorOrders
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lblUpdateLabel = new System.Windows.Forms.Label();
            this.cmbNewStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(8, 80, 65);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblSubtitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Size = new System.Drawing.Size(950, 65);

            this.lblTitle.AutoSize = false;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 8);
            this.lblTitle.Size = new System.Drawing.Size(600, 32);
            this.lblTitle.Text = "My Orders";
            this.lblTitle.Name = "lblTitle";

            this.lblSubtitle.AutoSize = false;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(180, 255, 220);
            this.lblSubtitle.Location = new System.Drawing.Point(20, 42);
            this.lblSubtitle.Size = new System.Drawing.Size(600, 20);
            this.lblSubtitle.Text = "View and update delivery status of your orders";

            // panelFilter
            this.panelFilter.BackColor = System.Drawing.Color.FromArgb(240, 245, 255);
            this.panelFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFilter.Controls.Add(this.lblStatus);
            this.panelFilter.Controls.Add(this.cmbStatus);
            this.panelFilter.Controls.Add(this.btnFilter);
            this.panelFilter.Controls.Add(this.btnRefresh);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Size = new System.Drawing.Size(950, 55);

            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(15, 17);
            this.lblStatus.Text = "Filter by Status:";

            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatus.Location = new System.Drawing.Point(140, 13);
            this.cmbStatus.Size = new System.Drawing.Size(170, 28);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Items.AddRange(new object[] {
                "All Orders", "Placed", "Confirmed",
                "Shipped", "Out for Delivery", "Delivered", "Cancelled", "Returned"
            });
            this.cmbStatus.SelectedIndex = 0;

            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(8, 80, 65);
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(325, 12);
            this.btnFilter.Size = new System.Drawing.Size(80, 30);
            this.btnFilter.Text = "Filter";
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);

            this.btnRefresh.BackColor = System.Drawing.Color.Gray;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(415, 12);
            this.btnRefresh.Size = new System.Drawing.Size(80, 30);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // panelContent
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Padding = new System.Windows.Forms.Padding(10);
            this.panelContent.Controls.Add(this.dgvOrders);

            // dgvOrders
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrders.ColumnHeadersHeight = 38;
            this.dgvOrders.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(8, 80, 65);
            this.dgvOrders.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOrders.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvOrders.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvOrders.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(200, 240, 220);
            this.dgvOrders.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvOrders.RowTemplate.Height = 38;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // panelBottom
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(245, 248, 250);
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Height = 60;
            this.panelBottom.Controls.Add(this.lblUpdateLabel);
            this.panelBottom.Controls.Add(this.cmbNewStatus);
            this.panelBottom.Controls.Add(this.btnUpdateStatus);
            this.panelBottom.Controls.Add(this.btnClose);

            this.lblUpdateLabel.AutoSize = false;
            this.lblUpdateLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUpdateLabel.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblUpdateLabel.Location = new System.Drawing.Point(15, 20);
            this.lblUpdateLabel.Size = new System.Drawing.Size(130, 22);
            this.lblUpdateLabel.Text = "Update Status:";

            this.cmbNewStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbNewStatus.Location = new System.Drawing.Point(155, 16);
            this.cmbNewStatus.Size = new System.Drawing.Size(170, 28);
            this.cmbNewStatus.Name = "cmbNewStatus";
            this.cmbNewStatus.Items.AddRange(new object[] {
                "Confirmed", "Shipped", "Out for Delivery", "Delivered"
            });
            this.cmbNewStatus.SelectedIndex = 0;

            this.btnUpdateStatus.BackColor = System.Drawing.Color.FromArgb(8, 80, 65);
            this.btnUpdateStatus.FlatAppearance.BorderSize = 0;
            this.btnUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdateStatus.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStatus.Location = new System.Drawing.Point(340, 13);
            this.btnUpdateStatus.Size = new System.Drawing.Size(160, 34);
            this.btnUpdateStatus.Text = "Update Status";
            this.btnUpdateStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);

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

            // VendorOrders Form
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
            this.Name = "VendorOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Orders - NeedBridge";
            this.Load += new System.EventHandler(this.VendorOrders_Load);
            this.panelTop.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblUpdateLabel;
        private System.Windows.Forms.ComboBox cmbNewStatus;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Button btnClose;
    }
}