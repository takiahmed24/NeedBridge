using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeedBridge
{
    public partial class CartForm : Form
    {
        public CartForm()
        {
            InitializeComponent();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            LoadCart();
        }

        private void LoadCart()
        {
            try
            {
                string query = @"
                    SELECT
                        c.cart_id,
                        p.product_id,
                        p.vendor_id,
                        p.product_name                                              AS [Product Name],
                        u.full_name                                                 AS [Vendor],
                        p.price                                                     AS [Unit Price (BDT)],
                        p.discount_pct                                              AS [Discount %],
                        CAST(p.price - (p.price * p.discount_pct / 100)
                             AS DECIMAL(10,2))                                      AS [Final Price (BDT)],
                        c.quantity                                                  AS [Qty],
                        CAST((p.price - (p.price * p.discount_pct / 100)) * c.quantity
                             AS DECIMAL(10,2))                                      AS [Subtotal (BDT)]
                    FROM Cart c
                    JOIN Products p ON c.product_id = p.product_id
                    JOIN Users u    ON p.vendor_id  = u.user_id
                    WHERE c.customer_id = @custId
                    ORDER BY c.added_at DESC";

                SqlParameter[] parameters = {
                    new SqlParameter("@custId", SessionManager.UserId)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                dgvCart.DataSource = dt;

                // Hide internal columns
                if (dgvCart.Columns.Contains("cart_id")) dgvCart.Columns["cart_id"].Visible = false;
                if (dgvCart.Columns.Contains("product_id")) dgvCart.Columns["product_id"].Visible = false;
                if (dgvCart.Columns.Contains("vendor_id")) dgvCart.Columns["vendor_id"].Visible = false;

                // Calculate total
                decimal total = 0;
                foreach (DataRow row in dt.Rows)
                    total += Convert.ToDecimal(row["Subtotal (BDT)"]);

                lblTotalValue.Text = "৳" + total.ToString("N0");

                if (dt.Rows.Count == 0)
                    lblTotalValue.Text = "৳0  (Cart is empty)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cart: " + ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to remove.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cartId = Convert.ToInt32(dgvCart.SelectedRows[0].Cells["cart_id"].Value);
            string productName = dgvCart.SelectedRows[0].Cells["Product Name"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                "Remove \"" + productName + "\" from cart?",
                "Remove Item",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Cart WHERE cart_id = @cartId";
                    SqlParameter[] parameters = {
                        new SqlParameter("@cartId", cartId)
                    };
                    DatabaseHelper.ExecuteNonQuery(query, parameters);
                    LoadCart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error removing item: " + ex.Message);
                }
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count == 0)
            {
                MessageBox.Show("Your cart is empty!", "Empty Cart",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Checkout first item in cart (one at a time payment)
            if (dgvCart.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to checkout.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow row = dgvCart.SelectedRows[0];
            int productId = Convert.ToInt32(row.Cells["product_id"].Value);
            int vendorId = Convert.ToInt32(row.Cells["vendor_id"].Value);
            int qty = Convert.ToInt32(row.Cells["Qty"].Value);
            decimal total = Convert.ToDecimal(row.Cells["Subtotal (BDT)"].Value);

            PaymentForm paymentForm = new PaymentForm(productId, vendorId, qty, total);
            paymentForm.ShowDialog();

            // Refresh cart after payment
            LoadCart();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}