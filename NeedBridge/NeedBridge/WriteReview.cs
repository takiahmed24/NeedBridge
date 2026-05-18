using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NeedBridge
{
    public partial class WriteReview : Form
    {
        private int _productId;

        public WriteReview(int productId)
        {
            InitializeComponent();
            _productId = productId;
        }

        private void WriteReview_Load(object sender, EventArgs e)
        {
            LoadProductInfo();
            UpdateRatingDesc();
        }

        private void LoadProductInfo()
        {
            try
            {
                string query = "SELECT product_name FROM Products WHERE product_id = @pid";
                SqlParameter[] p = { new SqlParameter("@pid", _productId) };
                DataTable dt = DatabaseHelper.ExecuteQuery(query, p);

                if (dt.Rows.Count > 0)
                    lblProductInfo.Text = "Product: " + dt.Rows[0]["product_name"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Star_Changed(object sender, EventArgs e)
        {
            UpdateRatingDesc();
        }

        private void UpdateRatingDesc()
        {
            int rating = GetSelectedRating();
            switch (rating)
            {
                case 1: lblRatingDesc.Text = "😞  Poor — very disappointed"; break;
                case 2: lblRatingDesc.Text = "😐  Fair — below expectations"; break;
                case 3: lblRatingDesc.Text = "🙂  Good — meets expectations"; break;
                case 4: lblRatingDesc.Text = "😊  Very Good — happy with it!"; break;
                case 5: lblRatingDesc.Text = "🤩  Excellent — highly recommended!"; break;
            }
        }

        private int GetSelectedRating()
        {
            if (rb5.Checked) return 5;
            if (rb4.Checked) return 4;
            if (rb3.Checked) return 3;
            if (rb2.Checked) return 2;
            return 1;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            int rating = GetSelectedRating();
            string comment = txtComment.Text.Trim();

            // Check if customer has ordered this product
            try
            {
                string checkQuery = @"
                    SELECT COUNT(*) FROM Orders
                    WHERE customer_id = @custId
                    AND   product_id  = @prodId
                    AND   order_status NOT IN ('Cancelled')";

                SqlParameter[] checkParams = {
                    new SqlParameter("@custId", SessionManager.UserId),
                    new SqlParameter("@prodId", _productId)
                };

                int ordered = Convert.ToInt32(DatabaseHelper.ExecuteScalar(checkQuery, checkParams));

                if (ordered == 0)
                {
                    lblError.Text = "You can only review products you have ordered.";
                    return;
                }

                // Check if already reviewed
                string dupQuery = @"SELECT COUNT(*) FROM Reviews
                                    WHERE customer_id = @custId AND product_id = @prodId";
                int already = Convert.ToInt32(DatabaseHelper.ExecuteScalar(dupQuery, checkParams));

                if (already > 0)
                {
                    lblError.Text = "You have already reviewed this product.";
                    return;
                }

                // Get order_id for this product
                string orderQuery = @"SELECT TOP 1 order_id FROM Orders
                                      WHERE customer_id = @custId AND product_id = @prodId
                                      AND order_status NOT IN ('Cancelled')
                                      ORDER BY order_date DESC";
                int orderId = Convert.ToInt32(DatabaseHelper.ExecuteScalar(orderQuery, checkParams));

                // Insert review
                string insertQuery = @"
                    INSERT INTO Reviews (customer_id, product_id, order_id, rating, comment)
                    VALUES (@custId, @prodId, @orderId, @rating, @comment)";

                SqlParameter[] insertParams = {
                    new SqlParameter("@custId",  SessionManager.UserId),
                    new SqlParameter("@prodId",  _productId),
                    new SqlParameter("@orderId", orderId),
                    new SqlParameter("@rating",  rating),
                    new SqlParameter("@comment", comment)
                };

                DatabaseHelper.ExecuteNonQuery(insertQuery, insertParams);

                MessageBox.Show(
                    "Thank you for your review!\n" +
                    "Rating: " + new string('⭐', rating),
                    "Review Submitted",
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
    }
}