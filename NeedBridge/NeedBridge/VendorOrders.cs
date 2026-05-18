using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeedBridge
{
    public partial class VendorOrders : Form
    {
        public VendorOrders()
        {
            InitializeComponent();
        }

        private void VendorOrders_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders(string statusFilter = "")
        {
            try
            {
                string query = @"
                    SELECT
                        o.order_id          AS [Order ID],
                        u.full_name         AS [Customer],
                        p.product_name      AS [Product],
                        o.quantity          AS [Qty],
                        o.total_price       AS [Total (BDT)],
                        o.order_status      AS [Status],
                        o.payment_method    AS [Payment],
                        o.delivery_address  AS [Delivery Address],
                        o.order_date        AS [Order Date]
                    FROM Orders o
                    JOIN Users u    ON o.customer_id = u.user_id
                    JOIN Products p ON o.product_id  = p.product_id
                    WHERE o.vendor_id = @vendorId";

                if (!string.IsNullOrEmpty(statusFilter) && statusFilter != "All Orders")
                    query += " AND o.order_status = '" + statusFilter + "'";

                query += " ORDER BY o.order_date DESC";

                SqlParameter[] parameters = {
                    new SqlParameter("@vendorId", SessionManager.UserId)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                dgvOrders.DataSource = dt;

                // Color rows by status
                foreach (DataGridViewRow row in dgvOrders.Rows)
                {
                    string status = row.Cells["Status"].Value?.ToString() ?? "";
                    switch (status)
                    {
                        case "Placed":
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 250, 220); break;
                        case "Confirmed":
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(220, 240, 255); break;
                        case "Shipped":
                        case "Out for Delivery":
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(220, 255, 240); break;
                        case "Delivered":
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(210, 255, 210); break;
                        case "Cancelled":
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 220, 220); break;
                        case "Returned":
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 220, 255); break;
                    }
                }

                lblTitle.Text = "My Orders (" + dt.Rows.Count + " found)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadOrders(cmbStatus.SelectedItem?.ToString() ?? "All Orders");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 0;
            LoadOrders();
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to update.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int orderId = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["Order ID"].Value);
            string currentStatus = dgvOrders.SelectedRows[0].Cells["Status"].Value.ToString();
            string newStatus = cmbNewStatus.SelectedItem?.ToString() ?? "";

            if (currentStatus == "Cancelled" || currentStatus == "Returned")
            {
                MessageBox.Show("Cannot update a " + currentStatus + " order.",
                    "Cannot Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentStatus == "Delivered")
            {
                MessageBox.Show("Order is already delivered.",
                    "Already Delivered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                string query = @"UPDATE Orders
                                 SET order_status = @status, updated_at = GETDATE()
                                 WHERE order_id = @orderId AND vendor_id = @vendorId";

                SqlParameter[] parameters = {
                    new SqlParameter("@status",   newStatus),
                    new SqlParameter("@orderId",  orderId),
                    new SqlParameter("@vendorId", SessionManager.UserId)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Order #" + orderId + " updated to: " + newStatus,
                    "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadOrders(cmbStatus.SelectedItem?.ToString() ?? "All Orders");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating order: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}