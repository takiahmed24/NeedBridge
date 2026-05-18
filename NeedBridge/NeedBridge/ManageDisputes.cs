using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeedBridge
{
    public partial class ManageDisputes : Form
    {
        public ManageDisputes()
        {
            InitializeComponent();
        }

        private void ManageDisputes_Load(object sender, EventArgs e)
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
                        cu.full_name        AS [Customer],
                        p.product_name      AS [Product],
                        ve.full_name        AS [Vendor],
                        o.quantity          AS [Qty],
                        o.total_price       AS [Total (BDT)],
                        o.order_status      AS [Status],
                        o.payment_method    AS [Payment],
                        o.delivery_address  AS [Address],
                        o.order_date        AS [Date]
                    FROM Orders o
                    JOIN Users cu   ON o.customer_id = cu.user_id
                    JOIN Users ve   ON o.vendor_id   = ve.user_id
                    JOIN Products p ON o.product_id  = p.product_id
                    WHERE 1=1";

                if (!string.IsNullOrEmpty(statusFilter) && statusFilter != "All Orders")
                    query += " AND o.order_status = '" + statusFilter + "'";

                query += " ORDER BY o.order_date DESC";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);
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

                lblTitle.Text = "⚠ Dispute Center (" + dt.Rows.Count + " orders)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
        }

        private int GetSelectedOrderId()
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order first.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
            return Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["Order ID"].Value);
        }

        private void UpdateOrderStatus(int orderId, string newStatus)
        {
            try
            {
                string query = @"UPDATE Orders
                                 SET order_status = @status, updated_at = GETDATE()
                                 WHERE order_id = @orderId";
                SqlParameter[] parameters = {
                    new SqlParameter("@status",  newStatus),
                    new SqlParameter("@orderId", orderId)
                };
                DatabaseHelper.ExecuteNonQuery(query, parameters);
                LoadOrders(cmbStatus.SelectedItem.ToString());

                MessageBox.Show("Order #" + orderId + " status updated to: " + newStatus,
                    "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating order: " + ex.Message);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int orderId = GetSelectedOrderId();
            if (orderId == -1) return;

            string current = dgvOrders.SelectedRows[0].Cells["Status"].Value.ToString();
            if (current != "Placed")
            {
                MessageBox.Show("Only 'Placed' orders can be confirmed.",
                    "Cannot Confirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            UpdateOrderStatus(orderId, "Confirmed");
        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {
            int orderId = GetSelectedOrderId();
            if (orderId == -1) return;

            string current = dgvOrders.SelectedRows[0].Cells["Status"].Value.ToString();
            if (current == "Delivered" || current == "Cancelled")
            {
                MessageBox.Show("Cannot update this order's status.",
                    "Cannot Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cycle through statuses
            string next = current == "Confirmed" ? "Shipped" :
                          current == "Shipped" ? "Out for Delivery" :
                          current == "Out for Delivery" ? "Delivered" : "Delivered";

            UpdateOrderStatus(orderId, next);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            int orderId = GetSelectedOrderId();
            if (orderId == -1) return;

            string current = dgvOrders.SelectedRows[0].Cells["Status"].Value.ToString();
            if (current == "Delivered" || current == "Cancelled")
            {
                MessageBox.Show("Cannot cancel this order.",
                    "Cannot Cancel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Cancel Order #" + orderId + "? Stock will be restored.",
                "Cancel Order", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    UpdateOrderStatus(orderId, "Cancelled");

                    // Restore stock
                    string stockQuery = @"
                        UPDATE Products
                        SET stock_qty = stock_qty + o.quantity,
                            availability = 'available'
                        FROM Products p
                        JOIN Orders o ON p.product_id = o.product_id
                        WHERE o.order_id = @orderId";
                    SqlParameter[] sp = { new SqlParameter("@orderId", orderId) };
                    DatabaseHelper.ExecuteNonQuery(stockQuery, sp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void cmbStatus_Changed(object sender, EventArgs e)
        {
            LoadOrders(cmbStatus.SelectedItem.ToString());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 0;
            LoadOrders();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}