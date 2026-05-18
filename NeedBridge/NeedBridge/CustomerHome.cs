using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeedBridge
{
    public partial class CustomerHome : Form
    {
        public CustomerHome()
        {
            InitializeComponent();
        }

        private void CustomerHome_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + SessionManager.FullName + "!";
            LoadCategories();
            LoadProducts();
        }

        private void LoadCategories()
        {
            try
            {
                cmbCategory.Items.Clear();
                cmbCategory.Items.Add("All Categories");

                string query = "SELECT category_name FROM Categories ORDER BY category_name";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                foreach (DataRow row in dt.Rows)
                    cmbCategory.Items.Add(row["category_name"].ToString());

                cmbCategory.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
        }

        private void LoadProducts(string searchText = "", string category = "", string priceRange = "")
        {
            try
            {
                string query = @"
                    SELECT
                        p.product_id,
                        p.product_name   AS [Product Name],
                        c.category_name  AS [Category],
                        u.full_name      AS [Vendor],
                        p.price          AS [Price (BDT)],
                        p.discount_pct   AS [Discount %],
                        CAST(p.price - (p.price * p.discount_pct / 100) AS DECIMAL(10,2)) AS [Final Price (BDT)],
                        p.stock_qty      AS [Stock],
                        p.availability   AS [Availability]
                    FROM Products p
                    JOIN Categories c ON p.category_id = c.category_id
                    JOIN Users u      ON p.vendor_id   = u.user_id
                    WHERE p.availability = 'available'
                    AND p.stock_qty > 0";

                if (!string.IsNullOrEmpty(searchText))
                    query += " AND p.product_name LIKE '%" + searchText + "%'";

                if (!string.IsNullOrEmpty(category) && category != "All Categories")
                    query += " AND c.category_name = '" + category + "'";

                if (!string.IsNullOrEmpty(priceRange))
                {
                    switch (priceRange)
                    {
                        case "Under ৳500": query += " AND p.price < 500"; break;
                        case "৳500 - ৳1000": query += " AND p.price BETWEEN 500 AND 1000"; break;
                        case "৳1000 - ৳5000": query += " AND p.price BETWEEN 1000 AND 5000"; break;
                        case "৳5000 - ৳10000": query += " AND p.price BETWEEN 5000 AND 10000"; break;
                        case "Above ৳10000": query += " AND p.price > 10000"; break;
                    }
                }

                query += " ORDER BY p.created_at DESC";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvProducts.DataSource = dt;

                if (dgvProducts.Columns.Contains("product_id"))
                    dgvProducts.Columns["product_id"].Visible = false;

                lblProductsTitle.Text = "All Products (" + dt.Rows.Count + " found)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            string category = cmbCategory.SelectedItem?.ToString() ?? "All Categories";
            string priceRange = cmbPrice.SelectedItem?.ToString() ?? "All Prices";
            if (priceRange == "All Prices") priceRange = "";
            LoadProducts(searchText, category, priceRange);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbCategory.SelectedIndex = 0;
            cmbPrice.SelectedIndex = 0;
            LoadProducts();
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int productId = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["product_id"].Value);
            ProductDetails detailsForm = new ProductDetails(productId);
            detailsForm.ShowDialog();
            LoadProducts();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            CartForm cartForm = new CartForm();
            cartForm.ShowDialog();
            LoadProducts();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            MyOrdersForm ordersForm = new MyOrdersForm();
            ordersForm.ShowDialog();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                SessionManager.Clear();
                this.Close();
            }
        }
    }
}