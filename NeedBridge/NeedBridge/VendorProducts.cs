using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeedBridge
{
    public partial class VendorProducts : Form
    {
        private int _selectedProductId = -1;

        public VendorProducts()
        {
            InitializeComponent();
        }

        private void VendorProducts_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts(string search = "")
        {
            try
            {
                string query = @"
                    SELECT
                        p.product_id        AS [ID],
                        p.product_name      AS [Product Name],
                        c.category_name     AS [Category],
                        p.price             AS [Price (BDT)],
                        p.discount_pct      AS [Discount %],
                        CAST(p.price - (p.price * p.discount_pct / 100) AS DECIMAL(10,2))
                                            AS [Final Price],
                        p.stock_qty         AS [Stock],
                        p.availability      AS [Status]
                    FROM Products p
                    JOIN Categories c ON p.category_id = c.category_id
                    WHERE p.vendor_id = @vendorId";

                if (!string.IsNullOrEmpty(search))
                    query += " AND p.product_name LIKE '%" + search + "%'";

                query += " ORDER BY p.created_at DESC";

                SqlParameter[] parameters = {
                    new SqlParameter("@vendorId", SessionManager.UserId)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                dgvProducts.DataSource = dt;

                if (dgvProducts.Columns.Contains("ID"))
                    dgvProducts.Columns["ID"].Visible = false;

                // Color out of stock
                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    int stock = Convert.ToInt32(row.Cells["Stock"].Value);
                    if (stock == 0)
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 220, 220);
                    else if (stock <= 5)
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 243, 205);
                }

                lblTitle.Text = "My Products (" + dt.Rows.Count + " listed)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0) return;

            try
            {
                _selectedProductId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ID"].Value);

                txtEditName.Text = dgvProducts.SelectedRows[0].Cells["Product Name"].Value.ToString();
                txtEditPrice.Text = dgvProducts.SelectedRows[0].Cells["Price (BDT)"].Value.ToString();
                txtEditDiscount.Text = dgvProducts.SelectedRows[0].Cells["Discount %"].Value.ToString();
                txtEditStock.Text = dgvProducts.SelectedRows[0].Cells["Stock"].Value.ToString();

                string avail = dgvProducts.SelectedRows[0].Cells["Status"].Value.ToString();
                cmbEditAvail.SelectedItem = avail;
            }
            catch { }
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            if (_selectedProductId == -1)
            {
                MessageBox.Show("Please select a product to edit.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtEditName.Text.Trim();
            string avail = cmbEditAvail.SelectedItem?.ToString() ?? "available";

            decimal price, discount;
            int stock;

            if (string.IsNullOrEmpty(name))
            { MessageBox.Show("Product name is required."); return; }

            if (!decimal.TryParse(txtEditPrice.Text.Trim(), out price) || price <= 0)
            { MessageBox.Show("Enter a valid price."); return; }

            if (!decimal.TryParse(txtEditDiscount.Text.Trim(), out discount) || discount < 0 || discount > 100)
            { MessageBox.Show("Discount must be 0-100."); return; }

            if (!int.TryParse(txtEditStock.Text.Trim(), out stock) || stock < 0)
            { MessageBox.Show("Enter a valid stock quantity."); return; }

            try
            {
                string query = @"
                    UPDATE Products
                    SET product_name = @name,
                        price        = @price,
                        discount_pct = @discount,
                        stock_qty    = @stock,
                        availability = @avail
                    WHERE product_id = @pid AND vendor_id = @vid";

                SqlParameter[] parameters = {
                    new SqlParameter("@name",     name),
                    new SqlParameter("@price",    price),
                    new SqlParameter("@discount", discount),
                    new SqlParameter("@stock",    stock),
                    new SqlParameter("@avail",    avail),
                    new SqlParameter("@pid",      _selectedProductId),
                    new SqlParameter("@vid",      SessionManager.UserId)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Product updated successfully!",
                    "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadProducts(txtSearch.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving: " + ex.Message);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (_selectedProductId == -1)
            {
                MessageBox.Show("Please select a product to delete.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string productName = dgvProducts.SelectedRows[0].Cells["Product Name"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                "Delete \"" + productName + "\"? This cannot be undone.",
                "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Products WHERE product_id = @pid AND vendor_id = @vid";
                    SqlParameter[] parameters = {
                        new SqlParameter("@pid", _selectedProductId),
                        new SqlParameter("@vid", SessionManager.UserId)
                    };
                    DatabaseHelper.ExecuteNonQuery(query, parameters);
                    _selectedProductId = -1;

                    MessageBox.Show("Product deleted.",
                        "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting: " + ex.Message +
                        "\nNote: Cannot delete products with existing orders.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddProduct addForm = new AddProduct();
            addForm.ShowDialog();
            LoadProducts();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadProducts(txtSearch.Text.Trim());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadProducts();
        }
    }
}