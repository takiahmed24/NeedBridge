using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeedBridge
{
    public partial class ManageReviews : Form
    {
        public ManageReviews()
        {
            InitializeComponent();
        }

        private void ManageReviews_Load(object sender, EventArgs e)
        {
            LoadReviews();
        }

        private void LoadReviews(string search = "", int rating = 0)
        {
            try
            {
                string query = @"
                    SELECT
                        r.review_id     AS [ID],
                        u.full_name     AS [Customer],
                        p.product_name  AS [Product],
                        v.full_name     AS [Vendor],
                        r.rating        AS [Rating],
                        r.comment       AS [Comment],
                        r.review_date   AS [Date]
                    FROM Reviews r
                    JOIN Users u    ON r.customer_id = u.user_id
                    JOIN Products p ON r.product_id  = p.product_id
                    JOIN Users v    ON p.vendor_id   = v.user_id
                    WHERE 1=1";

                if (!string.IsNullOrEmpty(search))
                    query += " AND (u.full_name LIKE '%" + search + "%' OR p.product_name LIKE '%" + search + "%' OR r.comment LIKE '%" + search + "%')";

                if (rating > 0)
                    query += " AND r.rating = " + rating;

                query += " ORDER BY r.review_date DESC";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvReviews.DataSource = dt;

                if (dgvReviews.Columns.Contains("ID"))
                    dgvReviews.Columns["ID"].Visible = false;

                // Color low ratings red
                foreach (DataGridViewRow row in dgvReviews.Rows)
                {
                    int r2 = Convert.ToInt32(row.Cells["Rating"].Value);
                    if (r2 <= 2)
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 230, 230);
                    else if (r2 == 5)
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(230, 255, 230);
                }

                lblTitle.Text = "⭐ Manage Reviews (" + dt.Rows.Count + " found)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reviews: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            int rating = cmbRating.SelectedIndex; // 0 = all, 1-5 = star count
            LoadReviews(search, rating);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbRating.SelectedIndex = 0;
            LoadReviews();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvReviews.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a review to delete.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int reviewId = Convert.ToInt32(dgvReviews.SelectedRows[0].Cells["ID"].Value);
            string customer = dgvReviews.SelectedRows[0].Cells["Customer"].Value.ToString();
            string product = dgvReviews.SelectedRows[0].Cells["Product"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                "Delete review by \"" + customer + "\" for \"" + product + "\"?\nThis cannot be undone.",
                "Delete Review",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Reviews WHERE review_id = @reviewId";
                    SqlParameter[] parameters = {
                        new SqlParameter("@reviewId", reviewId)
                    };
                    DatabaseHelper.ExecuteNonQuery(query, parameters);

                    MessageBox.Show("Review deleted successfully.",
                        "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadReviews(txtSearch.Text.Trim(), cmbRating.SelectedIndex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting review: " + ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}