using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeedBridge
{
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
        }

        private void SalesReport_Load(object sender, EventArgs e)
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

                // Summary stats
                string totalOrdersQ = "SELECT COUNT(*) FROM Orders WHERE order_status != 'Cancelled'" + dateFilter;
                string totalRevenueQ = "SELECT ISNULL(SUM(total_price),0) FROM Orders WHERE order_status != 'Cancelled'" + dateFilter;

                int totalOrders = Convert.ToInt32(DatabaseHelper.ExecuteScalar(totalOrdersQ));
                decimal totalRevenue = Convert.ToDecimal(DatabaseHelper.ExecuteScalar(totalRevenueQ));
                decimal avgOrder = totalOrders > 0 ? totalRevenue / totalOrders : 0;

                UpdateStat("lblS1Value", totalOrders.ToString());
                UpdateStat("lblS2Value", "৳" + totalRevenue.ToString("N0"));
                UpdateStat("lblS3Value", "৳" + avgOrder.ToString("N0"));

                // Vendor breakdown
                string query = @"
                    SELECT
                        u.full_name                         AS [Vendor],
                        COUNT(o.order_id)                   AS [Orders],
                        ISNULL(SUM(o.total_price), 0)       AS [Revenue (BDT)],
                        ISNULL(AVG(o.total_price), 0)       AS [Avg Order (BDT)],
                        COUNT(DISTINCT o.product_id)        AS [Products Sold]
                    FROM Orders o
                    JOIN Users u ON o.vendor_id = u.user_id
                    WHERE o.order_status != 'Cancelled'" + dateFilter + @"
                    GROUP BY u.full_name
                    ORDER BY SUM(o.total_price) DESC";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvSales.DataSource = dt;

                lblGridTitle.Text = "Sales Breakdown by Vendor — " + period
                    + " (" + dt.Rows.Count + " vendors)";
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
                    return ""; // All Time
            }
        }

        private void UpdateStat(string name, string value)
        {
            foreach (System.Windows.Forms.Control ctrl in panelStats.Controls)
            {
                if (ctrl is System.Windows.Forms.Panel)
                    foreach (System.Windows.Forms.Control inner in ctrl.Controls)
                        if (inner.Name == name) inner.Text = value;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}