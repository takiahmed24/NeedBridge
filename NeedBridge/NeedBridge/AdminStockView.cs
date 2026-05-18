using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeedBridge
{
    public partial class AdminStockView : Form
    {
        public AdminStockView()
        {
            InitializeComponent();
        }

        private void AdminStockView_Load(object sender, EventArgs e)
        {
            LoadVendors();
            LoadStats();
            LoadStock();
        }

        private void LoadVendors()
        {
            try
            {
                cmbVendor.Items.Clear();
                cmbVendor.Items.Add("All Vendors");
                DataTable dt = DatabaseHelper.ExecuteQuery(
                    "SELECT full_name FROM Users WHERE user_type = 'vendor' ORDER BY full_name");
                foreach (DataRow row in dt.Rows)
                    cmbVendor.Items.Add(row["full_name"].ToString());
                cmbVendor.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading vendors: " + ex.Message);
            }
        }

        private void LoadStats()
        {
            try
            {
                string q1 = "SELECT COUNT(*) FROM Products";
                string q2 = "SELECT COUNT(*) FROM Products WHERE stock_qty > 5";
                string q3 = "SELECT COUNT(*) FROM Products WHERE stock_qty > 0 AND stock_qty <= 5";
                string q4 = "SELECT COUNT(*) FROM Products WHERE stock_qty = 0";

                lblTotalProductsValue.Text = DatabaseHelper.ExecuteScalar(q1).ToString();
                lblInStockValue.Text = DatabaseHelper.ExecuteScalar(q2).ToString();
                lblLowStockValue.Text = DatabaseHelper.ExecuteScalar(q3).ToString();
                lblOutOfStockValue.Text = DatabaseHelper.ExecuteScalar(q4).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stats: " + ex.Message);
            }
        }

        private void LoadStock(string stockFilter = "", string vendor = "")
        {
            try
            {
                string query = @"
                    SELECT
                        p.product_id        AS [ID],
                        p.product_name      AS [Product Name],
                        c.category_name     AS [Category],
                        u.full_name         AS [Vendor],
                        p.stock_qty         AS [Stock Qty],
                        p.price             AS [Price (BDT)],
                        p.discount_pct      AS [Discount %],
                        p.availability      AS [Status],
                        CASE
                            WHEN p.stock_qty = 0    THEN 'Out of Stock'
                            WHEN p.stock_qty <= 5   THEN 'Low Stock'
                            ELSE 'In Stock'
                        END                 AS [Stock Level]
                    FROM Products p
                    JOIN Categories c ON p.category_id = c.category_id
                    JOIN Users u      ON p.vendor_id   = u.user_id
                    WHERE 1=1";

                if (stockFilter == "In Stock")
                    query += " AND p.stock_qty > 5";
                else if (stockFilter == "Low Stock (< 5)")
                    query += " AND p.stock_qty > 0 AND p.stock_qty <= 5";
                else if (stockFilter == "Out of Stock")
                    query += " AND p.stock_qty = 0";

                if (!string.IsNullOrEmpty(vendor) && vendor != "All Vendors")
                    query += " AND u.full_name = '" + vendor + "'";

                query += " ORDER BY p.stock_qty ASC";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvStock.DataSource = dt;

                if (dgvStock.Columns.Contains("ID"))
                    dgvStock.Columns["ID"].Visible = false;

                // Color code rows
                foreach (DataGridViewRow row in dgvStock.Rows)
                {
                    string level = row.Cells["Stock Level"].Value?.ToString() ?? "";
                    if (level == "Out of Stock")
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 220, 220);
                    else if (level == "Low Stock")
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 243, 205);
                    else
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(230, 255, 230);
                }

                lblTitle.Text = "Stock Overview (" + dt.Rows.Count + " products)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stock: " + ex.Message);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadStock(
                cmbStockFilter.SelectedItem?.ToString() ?? "",
                cmbVendor.SelectedItem?.ToString() ?? "All Vendors"
            );
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbStockFilter.SelectedIndex = 0;
            cmbVendor.SelectedIndex = 0;
            LoadStats();
            LoadStock();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}