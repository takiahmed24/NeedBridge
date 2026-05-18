namespace NeedBridge
{
    partial class MyOrdersForm
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
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblSubtitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Size = new System.Drawing.Size(900, 70);

            this.lblTitle.AutoSize = false;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Size = new System.Drawing.Size(500, 32);
            this.lblTitle.Text = "📦 My Orders";

            this.lblSubtitle.AutoSize = false;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(180, 220, 255);
            this.lblSubtitle.Location = new System.Drawing.Point(20, 44);
            this.lblSubtitle.Size = new System.Drawing.Size(500, 20);
            this.lblSubtitle.Text = "Track and manage your orders";

            // panelFilter
            this.panelFilter.BackColor = System.Drawing.Color.FromArgb(240, 245, 255);
            this.panelFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFilter.Controls.Add(this.lblFilterStatus);
            this.panelFilter.Controls.Add(this.cmbStatus);
            this.panelFilter.Controls.Add(this.btnFilter);
            this.panelFilter.Controls.Add(this.btnRefresh);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Size = new System.Drawing.Size(900, 55);

            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFilterStatus.Location = new System.Drawing.Point(15, 17);
            this.lblFilterStatus.Text = "Filter by Status:";

            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatus.Location = new System.Drawing.Point(130, 13);
            this.cmbStatus.Size = new System.Drawing.Size(160, 28);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Items.AddRange(new object[] {
                "All Orders", "Placed", "Confirmed",
                "Shipped", "Out for Delivery", "Delivered", "Cancelled", "Returned"
            });
            this.cmbStatus.SelectedIndex = 0;

            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(305, 12);
            this.btnFilter.Size = new System.Drawing.Size(90, 30);
            this.btnFilter.Text = "Filter";
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);

            this.btnRefresh.BackColor = System.Drawing.Color.Gray;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(405, 12);
            this.btnRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnRefresh.Text = "🔄 Refresh";
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
            this.dgvOrders.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.dgvOrders.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOrders.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvOrders.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvOrders.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(200, 220, 255);
            this.dgvOrders.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvOrders.RowTemplate.Height = 40;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // panelBottom
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(245, 248, 250);
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Height = 60;
            this.panelBottom.Controls.Add(this.btnCancel);
            this.panelBottom.Controls.Add(this.btnReturn);
            this.panelBottom.Controls.Add(this.btnClose);

            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(15, 13);
            this.btnCancel.Size = new System.Drawing.Size(160, 34);
            this.btnCancel.Text = "✕ Cancel Order";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(190, 13);
            this.btnReturn.Size = new System.Drawing.Size(160, 34);
            this.btnReturn.Text = "↩ Return Order";
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);

            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(800, 13);
            this.btnClose.Size = new System.Drawing.Size(80, 34);
            this.btnClose.Text = "Close";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // MyOrdersForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MyOrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Orders - NeedBridge";
            this.Load += new System.EventHandler(this.MyOrdersForm_Load);
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
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnClose;
    }
}