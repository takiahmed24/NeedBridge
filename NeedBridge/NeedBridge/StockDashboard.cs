using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeedBridge
{
    public partial class StockDashboard : Form
    {
        public StockDashboard()
        {
            InitializeComponent();
        }

        private void StockDashboard_Load(object sender, EventArgs e)
        {
            LoadStats();
            LoadStock();
        }

        private void LoadStats()
        {
            try
            {
                int vendorId = SessionManager.UserId;

                string q1 = "SELECT COUNT(*) FROM Products WHERE vendor_id = @vid";
                string q2 = "SELECT COUNT(*) FROM Products WHERE vendor_id = @vid AND stock_qty > 5";
                string q3 = "SELECT COUNT(*) FROM Products WHERE vendor_id = @vid AND stock_qty > 0 AND stock_qty <= 5";
                string q4 = "SELECT COUNT(*) FROM Products WHERE vendor_id = @vid AND stock_qty = 0";

                SqlParameter[] p = { new SqlParameter("@vid", vendorId) };

                lblTotalValue.Text = DatabaseHelper.ExecuteScalar(q1, p).ToString();
                lblInStockValue.Text = DatabaseHelper.ExecuteScalar(q2, p).ToString();
                lblLowValue.Text = DatabaseHelper.ExecuteScalar(q3, p).ToString();
                lblOutValue.Text = DatabaseHelper.ExecuteScalar(q4, p).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stats: " + ex.Message);
            }
        }

        private void LoadStock(string filter = "")
        {
            try
            {
                string query = @"
                    SELECT
                        p.product_name      AS [Product Name],
                        c.category_name     AS [Category],
                        p.stock_qty         AS [Stock Qty],
                        p.price             AS [Price (BDT)],
                        p.discount_pct      AS [Discount %],
                        p.availability      AS [Status],
                        CASE
                            WHEN p.stock_qty = 0  THEN 'Out of Stock'
                            WHEN p.stock_qty <= 5 THEN 'Low Stock'
                            ELSE 'In Stock'
                        END                 AS [Stock Level]
                    FROM Products p
                    JOIN Categories c ON p.category_id = c.category_id
                    WHERE p.vendor_id = @vendorId";

                if (filter == "In Stock")
                    query += " AND p.stock_qty > 5";
                else if (filter == "Low Stock (< 5)")
                    query += " AND p.stock_qty > 0 AND p.stock_qty <= 5";
                else if (filter == "Out of Stock")
                    query += " AND p.stock_qty = 0";

                query += " ORDER BY p.stock_qty ASC";

                SqlParameter[] parameters = {
                    new SqlParameter("@vendorId", SessionManager.UserId)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                dgvStock.DataSource = dt;

                // Color rows
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

                lblTitle.Text = "Stock & Inventory (" + dt.Rows.Count + " products)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stock: " + ex.Message);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadStock(cmbFilter.SelectedItem?.ToString() ?? "All Products");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbFilter.SelectedIndex = 0;
            LoadStats();
            LoadStock();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}