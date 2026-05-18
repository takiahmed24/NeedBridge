using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeedBridge
{
    public partial class MyOrdersForm : Form
    {
        public MyOrdersForm()
        {
            InitializeComponent();
        }

        private void MyOrdersForm_Load(object sender, EventArgs e)
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
                        p.product_name      AS [Product],
                        u.full_name         AS [Vendor],
                        o.quantity          AS [Qty],
                        o.total_price       AS [Total (BDT)],
                        o.order_status      AS [Status],
                        o.payment_method    AS [Payment],
                        o.delivery_address  AS [Delivery Address],
                        o.order_date        AS [Order Date],
                        o.updated_at        AS [Last Updated]
                    FROM Orders o
                    JOIN Products p ON o.product_id = p.product_id
                    JOIN Users u    ON o.vendor_id  = u.user_id
                    WHERE o.customer_id = @custId";

                if (!string.IsNullOrEmpty(statusFilter) && statusFilter != "All Orders")
                    query += " AND o.order_status = '" + statusFilter + "'";

                query += " ORDER BY o.order_date DESC";

                SqlParameter[] parameters = {
                    new SqlParameter("@custId", SessionManager.UserId)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                dgvOrders.DataSource = dt;

                // Color rows based on status
                foreach (DataGridViewRow row in dgvOrders.Rows)
                {
                    string status = row.Cells["Status"].Value?.ToString() ?? "";
                    switch (status)
                    {
                        case "Placed":
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 250, 230);
                            break;
                        case "Confirmed":
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(230, 245, 255);
                            break;
                        case "Shipped":
                        case "Out for Delivery":
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(230, 255, 240);
                            break;
                        case "Delivered":
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(220, 255, 220);
                            break;
                        case "Cancelled":
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 230, 230);
                            break;
                        case "Returned":
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 230, 255);
                            break;
                    }
                }

                lblTitle.Text = "📦 My Orders (" + dt.Rows.Count + " found)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string status = cmbStatus.SelectedItem?.ToString() ?? "All Orders";
            LoadOrders(status);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 0;
            LoadOrders();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to cancel.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int orderId = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["Order ID"].Value);
            string status = dgvOrders.SelectedRows[0].Cells["Status"].Value.ToString();

            if (status == "Shipped" || status == "Out for Delivery" || status == "Delivered")
            {
                MessageBox.Show("Cannot cancel order that is already " + status + ".",
                    "Cannot Cancel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (status == "Cancelled")
            {
                MessageBox.Show("This order is already cancelled.",
                    "Already Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to cancel Order #" + orderId + "?",
                "Cancel Order",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    // Update order status
                    string query = @"UPDATE Orders
                                     SET order_status = 'Cancelled', updated_at = GETDATE()
                                     WHERE order_id = @orderId";
                    SqlParameter[] parameters = {
                        new SqlParameter("@orderId", orderId)
                    };
                    DatabaseHelper.ExecuteNonQuery(query, parameters);

                    // Restore stock
                    string stockQuery = @"
                        UPDATE Products
                        SET stock_qty = stock_qty + o.quantity,
                            availability = 'available'
                        FROM Products p
                        JOIN Orders o ON p.product_id = o.product_id
                        WHERE o.order_id = @orderId";
                    DatabaseHelper.ExecuteNonQuery(stockQuery, parameters);

                    MessageBox.Show("Order #" + orderId + " has been cancelled successfully.",
                        "Order Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadOrders();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error cancelling order: " + ex.Message);
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to return.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int orderId = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["Order ID"].Value);
            string status = dgvOrders.SelectedRows[0].Cells["Status"].Value.ToString();

            if (status != "Delivered")
            {
                MessageBox.Show("You can only return orders that have been Delivered.",
                    "Cannot Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Request a return for Order #" + orderId + "?\nStock will be restored.",
                "Return Order",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string query = @"UPDATE Orders
                                     SET order_status = 'Returned', updated_at = GETDATE()
                                     WHERE order_id = @orderId";
                    SqlParameter[] parameters = {
                        new SqlParameter("@orderId", orderId)
                    };
                    DatabaseHelper.ExecuteNonQuery(query, parameters);

                    // Restore stock
                    string stockQuery = @"
                        UPDATE Products
                        SET stock_qty = stock_qty + o.quantity
                        FROM Products p
                        JOIN Orders o ON p.product_id = o.product_id
                        WHERE o.order_id = @orderId";
                    DatabaseHelper.ExecuteNonQuery(stockQuery, parameters);

                    MessageBox.Show("Return request submitted for Order #" + orderId + ".",
                        "Return Requested", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadOrders();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error returning order: " + ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}