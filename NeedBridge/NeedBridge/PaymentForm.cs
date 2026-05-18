using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeedBridge
{
    public partial class PaymentForm : Form
    {
        private int _productId;
        private int _vendorId;
        private int _qty;
        private decimal _total;

        public PaymentForm(int productId, int vendorId, int qty, decimal total)
        {
            InitializeComponent();
            _productId = productId;
            _vendorId = vendorId;
            _qty = qty;
            _total = total;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            lblTotalValue.Text = "৳" + _total.ToString("N0");

            // Pre-fill delivery address from profile
            try
            {
                string query = "SELECT address FROM Users WHERE user_id = @uid";
                SqlParameter[] p = { new SqlParameter("@uid", SessionManager.UserId) };
                DataTable dt = DatabaseHelper.ExecuteQuery(query, p);
                if (dt.Rows.Count > 0)
                    txtDeliveryAddress.Text = dt.Rows[0]["address"].ToString();
            }
            catch { }

            UpdatePaymentPanel();
        }

        private void PaymentMethod_Changed(object sender, EventArgs e)
        {
            UpdatePaymentPanel();
        }

        private void UpdatePaymentPanel()
        {
            if (rbCOD.Checked)
            {
                panelPaymentDetails.Visible = false;
                lblPaymentInstruction.Text = "Pay cash upon delivery.";
            }
            else if (rbBkash.Checked)
            {
                panelPaymentDetails.Visible = true;
                lblPaymentInstruction.Text = "Send to bKash: 01700-000000 | Enter your bKash number:";
            }
            else if (rbNagad.Checked)
            {
                panelPaymentDetails.Visible = true;
                lblPaymentInstruction.Text = "Send to Nagad: 01700-000000 | Enter your Nagad number:";
            }
            else if (rbRocket.Checked)
            {
                panelPaymentDetails.Visible = true;
                lblPaymentInstruction.Text = "Send to Rocket: 01700-000000 | Enter your Rocket number:";
            }
            else if (rbCard.Checked)
            {
                panelPaymentDetails.Visible = true;
                lblPaymentInstruction.Text = "Enter your card number (dummy - 16 digits):";
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            string deliveryAddress = txtDeliveryAddress.Text.Trim();
            string paymentRef = txtPaymentRef.Text.Trim();

            if (string.IsNullOrEmpty(deliveryAddress))
            {
                lblError.Text = "Please enter your delivery address."; return;
            }

            if (!rbCOD.Checked && string.IsNullOrEmpty(paymentRef))
            {
                lblError.Text = "Please enter your payment reference number."; return;
            }

            string paymentMethod = rbBkash.Checked ? "bKash" :
                                   rbNagad.Checked ? "Nagad" :
                                   rbRocket.Checked ? "Rocket" :
                                   rbCard.Checked ? "Card" : "COD";

            try
            {
                // 1 — Insert Order
                string orderQuery = @"
                    INSERT INTO Orders
                        (customer_id, product_id, vendor_id, quantity, total_price,
                         order_status, payment_method, delivery_address)
                    OUTPUT INSERTED.order_id
                    VALUES
                        (@custId, @prodId, @vendId, @qty, @total,
                         'Placed', @payMethod, @address)";

                SqlParameter[] orderParams = {
                    new SqlParameter("@custId",    SessionManager.UserId),
                    new SqlParameter("@prodId",    _productId),
                    new SqlParameter("@vendId",    _vendorId),
                    new SqlParameter("@qty",       _qty),
                    new SqlParameter("@total",     _total),
                    new SqlParameter("@payMethod", paymentMethod),
                    new SqlParameter("@address",   deliveryAddress)
                };

                int orderId = Convert.ToInt32(
                    DatabaseHelper.ExecuteScalar(orderQuery, orderParams));

                // 2 — Insert Payment
                string paymentQuery = @"
                    INSERT INTO Payments
                        (order_id, customer_id, amount, payment_method, transaction_ref, payment_status)
                    VALUES
                        (@orderId, @custId, @amount, @payMethod, @ref, 'completed')";

                SqlParameter[] payParams = {
                    new SqlParameter("@orderId",   orderId),
                    new SqlParameter("@custId",    SessionManager.UserId),
                    new SqlParameter("@amount",    _total),
                    new SqlParameter("@payMethod", paymentMethod),
                    new SqlParameter("@ref",       string.IsNullOrEmpty(paymentRef) ? "COD" : paymentRef)
                };
                DatabaseHelper.ExecuteNonQuery(paymentQuery, payParams);

                // 3 — Reduce stock
                string stockQuery = @"
                    UPDATE Products
                    SET stock_qty = stock_qty - @qty,
                        availability = CASE WHEN stock_qty - @qty <= 0
                                       THEN 'unavailable' ELSE availability END
                    WHERE product_id = @prodId";

                SqlParameter[] stockParams = {
                    new SqlParameter("@qty",    _qty),
                    new SqlParameter("@prodId", _productId)
                };
                DatabaseHelper.ExecuteNonQuery(stockQuery, stockParams);

                // 4 — Remove from cart if exists
                string cartQuery = @"DELETE FROM Cart
                                     WHERE customer_id = @custId AND product_id = @prodId";
                SqlParameter[] cartParams = {
                    new SqlParameter("@custId", SessionManager.UserId),
                    new SqlParameter("@prodId", _productId)
                };
                DatabaseHelper.ExecuteNonQuery(cartQuery, cartParams);

                MessageBox.Show(
                    "Order placed successfully!\n\n" +
                    "Order ID: #" + orderId + "\n" +
                    "Total Paid: ৳" + _total.ToString("N0") + "\n" +
                    "Payment: " + paymentMethod + "\n" +
                    "Status: Placed\n\n" +
                    "Track your order in My Orders.",
                    "Order Confirmed!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.Close();
            }
            catch (Exception ex)
            {
                lblError.Text = "Error: " + ex.Message;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTotalValue_Click(object sender, EventArgs e)
        {

        }
    }
}