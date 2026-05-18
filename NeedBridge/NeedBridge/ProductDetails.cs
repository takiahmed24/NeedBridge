using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeedBridge
{
    public partial class ProductDetails : Form
    {
        private int _productId;
        private int _vendorId;
        private decimal _finalPrice;

        public ProductDetails(int productId)
        {
            InitializeComponent();
            _productId = productId;
        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {
            LoadProductDetails();
            LoadReviews();
        }

        private void LoadProductDetails()
        {
            try
            {
                string query = @"
                    SELECT
                        p.product_id,
                        p.vendor_id,
                        p.product_name,
                        p.description,
                        c.category_name,
                        u.full_name      AS vendor_name,
                        p.price,
                        p.discount_pct,
                        CAST(p.price - (p.price * p.discount_pct / 100) AS DECIMAL(10,2)) AS final_price,
                        p.stock_qty,
                        p.availability,
                        p.image_path
                    FROM Products p
                    JOIN Categories c ON p.category_id = c.category_id
                    JOIN Users u      ON p.vendor_id   = u.user_id
                    WHERE p.product_id = @productId";

                SqlParameter[] parameters = {
                    new SqlParameter("@productId", _productId)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Product not found.");
                    this.Close();
                    return;
                }

                DataRow row = dt.Rows[0];
                _vendorId = Convert.ToInt32(row["vendor_id"]);
                _finalPrice = Convert.ToDecimal(row["final_price"]);

                // Fill UI
                lblTitle.Text = row["product_name"].ToString();
                lblProductName.Text = row["product_name"].ToString();
                lblCategory.Text = "Category: " + row["category_name"].ToString();
                lblVendor.Text = "Sold by: " + row["vendor_name"].ToString();

                decimal price = Convert.ToDecimal(row["price"]);
                decimal discount = Convert.ToDecimal(row["discount_pct"]);

                lblPriceOriginal.Text = discount > 0
                    ? "Original: ৳" + price.ToString("N0")
                    : "";
                lblPriceFinal.Text = "৳" + _finalPrice.ToString("N0");
                lblDiscount.Text = discount > 0 ? discount.ToString("0") + "% OFF" : "";
                lblStock.Text = "Stock: " + row["stock_qty"].ToString();

                string avail = row["availability"].ToString();
                lblAvailability.Text = avail == "available" ? "✔ Available" : "✗ Unavailable";
                lblAvailability.ForeColor = avail == "available"
                    ? System.Drawing.Color.Green
                    : System.Drawing.Color.Red;

                string desc = row["description"].ToString();
                lblDescription.Text = string.IsNullOrEmpty(desc) ? "No description available." : desc;

                // Set max qty
                int stock = Convert.ToInt32(row["stock_qty"]);
                numQty.Maximum = stock > 0 ? stock : 1;

                // Disable buttons if unavailable
                bool canBuy = avail == "available" && stock > 0;
                btnAddToCart.Enabled = canBuy;
                btnBuyNow.Enabled = canBuy;

                // Load image
                string imagePath = row["image_path"].ToString();
                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    picProduct.Image = System.Drawing.Image.FromFile(imagePath);
                    picProduct.Visible = true;
                    lblNoImage.Visible = false;
                }
                else
                {
                    picProduct.Visible = false;
                    lblNoImage.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product: " + ex.Message);
            }
        }

        private void LoadReviews()
        {
            try
            {
                string query = @"
                    SELECT
                        u.full_name  AS [Customer],
                        r.rating     AS [Rating ⭐],
                        r.comment    AS [Comment],
                        r.review_date AS [Date]
                    FROM Reviews r
                    JOIN Users u ON r.customer_id = u.user_id
                    WHERE r.product_id = @productId
                    ORDER BY r.review_date DESC";

                SqlParameter[] parameters = {
                    new SqlParameter("@productId", _productId)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                dgvReviews.DataSource = dt;

                lblReviewTitle.Text = "Customer Reviews (" + dt.Rows.Count + ")";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reviews: " + ex.Message);
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                int qty = Convert.ToInt32(numQty.Value);

                // Check if already in cart
                string checkQuery = @"SELECT cart_id, quantity FROM Cart
                                      WHERE customer_id = @custId AND product_id = @prodId";
                SqlParameter[] checkParams = {
                    new SqlParameter("@custId", SessionManager.UserId),
                    new SqlParameter("@prodId", _productId)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(checkQuery, checkParams);

                if (dt.Rows.Count > 0)
                {
                    // Update quantity
                    int cartId = Convert.ToInt32(dt.Rows[0]["cart_id"]);
                    int existingQty = Convert.ToInt32(dt.Rows[0]["quantity"]);

                    string updateQuery = "UPDATE Cart SET quantity = @qty WHERE cart_id = @cartId";
                    SqlParameter[] updateParams = {
                        new SqlParameter("@qty",    existingQty + qty),
                        new SqlParameter("@cartId", cartId)
                    };
                    DatabaseHelper.ExecuteNonQuery(updateQuery, updateParams);
                }
                else
                {
                    // Insert new cart item
                    string insertQuery = @"INSERT INTO Cart (customer_id, product_id, quantity)
                                          VALUES (@custId, @prodId, @qty)";
                    SqlParameter[] insertParams = {
                        new SqlParameter("@custId", SessionManager.UserId),
                        new SqlParameter("@prodId", _productId),
                        new SqlParameter("@qty",    qty)
                    };
                    DatabaseHelper.ExecuteNonQuery(insertQuery, insertParams);
                }

                MessageBox.Show(
                    qty + " item(s) added to your cart!",
                    "Added to Cart",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding to cart: " + ex.Message);
            }
        }

        private void btnBuyNow_Click(object sender, EventArgs e)
        {
            int qty = Convert.ToInt32(numQty.Value);
            decimal total = _finalPrice * qty;

            PaymentForm paymentForm = new PaymentForm(_productId, _vendorId, qty, total);
            paymentForm.ShowDialog();

            // Refresh after purchase
            LoadProductDetails();
            LoadReviews();
        }

        private void btnWriteReview_Click(object sender, EventArgs e)
        {
            WriteReview reviewForm = new WriteReview(_productId);
            reviewForm.ShowDialog();
            LoadReviews();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}