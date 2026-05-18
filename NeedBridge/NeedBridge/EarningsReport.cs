using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeedBridge
{
    public partial class EarningsReport : Form
    {
        public EarningsReport()
        {
            InitializeComponent();
        }

        private void EarningsReport_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            try
            {
                string period = cmbPeriod.SelectedItem.ToString();
                string dateFilter = GetDateFilter(period);
                int vendorId = SessionManager.UserId;

                // Summary stats
                string q1 = "SELECT ISNULL(SUM(total_price),0) FROM Orders WHERE vendor_id = @vid AND order_status != 'Cancelled'" + dateFilter;
                string q2 = "SELECT COUNT(*) FROM Orders WHERE vendor_id = @vid AND order_status != 'Cancelled'" + dateFilter;

                SqlParameter[] p = { new SqlParameter("@vid", vendorId) };

                decimal totalEarnings = Convert.ToDecimal(DatabaseHelper.ExecuteScalar(q1, p));
                int totalOrders = Convert.ToInt32(DatabaseHelper.ExecuteScalar(q2, p));
                decimal avgOrder = totalOrders > 0 ? totalEarnings / totalOrders : 0;

                lblTotalEarningsValue.Text = "৳" + totalEarnings.ToString("N0");
                lblTotalOrdersValue.Text = totalOrders.ToString();
                lblAvgOrderValue.Text = "৳" + avgOrder.ToString("N0");

                // Product breakdown
                string query = @"
                    SELECT
                        p.product_name              AS [Product],
                        COUNT(o.order_id)           AS [Orders],
                        SUM(o.quantity)             AS [Units Sold],
                        ISNULL(SUM(o.total_price),0)AS [Revenue (BDT)],
                        p.stock_qty                 AS [Remaining Stock]
                    FROM Orders o
                    JOIN Products p ON o.product_id = p.product_id
                    WHERE o.vendor_id = @vendorId
                    AND o.order_status != 'Cancelled'" + dateFilter + @"
                    GROUP BY p.product_name, p.stock_qty
                    ORDER BY SUM(o.total_price) DESC";

                SqlParameter[] qp = { new SqlParameter("@vendorId", vendorId) };
                DataTable dt = DatabaseHelper.ExecuteQuery(query, qp);
                dgvEarnings.DataSource = dt;

                lblGridTitle.Text = "Sales Breakdown by Product — " + period
                    + " (" + dt.Rows.Count + " products)";
                lblTitle.Text = "Earnings Report — " + period;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report: " + ex.Message);
            }
        }

        private string GetDateFilter(string period)
        {
            switch (period)
            {
                case "Today":
                    return " AND CAST(order_date AS DATE) = CAST(GETDATE() AS DATE)";
                case "This Week":
                    return " AND order_date >= DATEADD(DAY, -7, GETDATE())";
                case "This Month":
                    return " AND MONTH(order_date) = MONTH(GETDATE()) AND YEAR(order_date) = YEAR(GETDATE())";
                case "Last Month":
                    return " AND MONTH(order_date) = MONTH(DATEADD(MONTH,-1,GETDATE())) AND YEAR(order_date) = YEAR(DATEADD(MONTH,-1,GETDATE()))";
                default:
                    return "";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}