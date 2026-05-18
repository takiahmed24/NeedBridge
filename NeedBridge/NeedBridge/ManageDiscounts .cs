using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeedBridge
{
    public partial class ManageDiscounts : Form
    {
        public ManageDiscounts()
        {
            InitializeComponent();
        }

        private void ManageDiscounts_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadProducts();
        }

        private void LoadCategories()
        {
            try
            {
                cmbCategory.Items.Clear();
                cmbCategory.Items.Add("All Categories");
                DataTable dt = DatabaseHelper.ExecuteQuery(
                    "SELECT category_name FROM Categories ORDER BY category_name");
                foreach (DataRow row in dt.Rows)
                    cmbCategory.Items.Add(row["category_name"].ToString());
                cmbCategory.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
        }

        private void LoadProducts(string search = "", string category = "")
        {
            try
            {
                string query = @"
                    SELECT
                        p.product_id        AS [ID],
                        p.product_name      AS [Product Name],
                        c.category_name     AS [Category],
                        u.full_name         AS [Vendor],
                        p.price             AS [Price (BDT)],
                        p.discount_pct      AS [Discount %],
                        CAST(p.price - (p.price * p.discount_pct / 100) AS DECIMAL(10,2))
                                            AS [Final Price (BDT)],
                        p.stock_qty         AS [Stock],
                        p.availability      AS [Status]
                    FROM Products p
                    JOIN Categories c ON p.category_id = c.category_id
                    JOIN Users u      ON p.vendor_id   = u.user_id
                    WHERE 1=1";

                if (!string.IsNullOrEmpty(search))
                    query += " AND p.product_name LIKE '%" + search + "%'";

                if (!string.IsNullOrEmpty(category) && category != "All Categories")
                    query += " AND c.category_name = '" + category + "'";

                query += " ORDER BY p.discount_pct DESC, p.product_name";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvProducts.DataSource = dt;

                if (dgvProducts.Columns.Contains("ID"))
                    dgvProducts.Columns["ID"].Visible = false;

                // Highlight discounted products
                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    decimal disc = Convert.ToDecimal(row.Cells["Discount %"].Value);
                    if (disc > 0)
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(230, 255, 230);
                }

                lblTitle.Text = "Manage Discounts (" + dt.Rows.Count + " products)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadProducts(txtSearch.Text.Trim(),
                cmbCategory.SelectedItem?.ToString() ?? "All Categories");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbCategory.SelectedIndex = 0;
            LoadProducts();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product first.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal discount;
            if (!decimal.TryParse(txtDiscountPct.Text.Trim(), out discount)
                || discount < 0 || discount > 100)
            {
                MessageBox.Show("Please enter a valid discount between 0 and 100.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int productId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ID"].Value);
            string productName = dgvProducts.SelectedRows[0].Cells["Product Name"].Value.ToString();

            try
            {
                string query = "UPDATE Products SET discount_pct = @disc WHERE product_id = @pid";
                SqlParameter[] parameters = {
                    new SqlParameter("@disc", discount),
                    new SqlParameter("@pid",  productId)
                };
                DatabaseHelper.ExecuteNonQuery(query, parameters);

                MessageBox.Show(
                    discount + "% discount applied to \"" + productName + "\" successfully!",
                    "Discount Applied", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadProducts(txtSearch.Text.Trim(),
                    cmbCategory.SelectedItem?.ToString() ?? "All Categories");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error applying discount: " + ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product first.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int productId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ID"].Value);
            string productName = dgvProducts.SelectedRows[0].Cells["Product Name"].Value.ToString();

            try
            {
                string query = "UPDATE Products SET discount_pct = 0 WHERE product_id = @pid";
                SqlParameter[] parameters = {
                    new SqlParameter("@pid", productId)
                };
                DatabaseHelper.ExecuteNonQuery(query, parameters);

                MessageBox.Show(
                    "Discount removed from \"" + productName + "\".",
                    "Discount Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadProducts(txtSearch.Text.Trim(),
                    cmbCategory.SelectedItem?.ToString() ?? "All Categories");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing discount: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}