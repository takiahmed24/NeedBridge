using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeedBridge
{
    public partial class VendorHome : Form
    {
        public VendorHome()
        {
            InitializeComponent();
        }

        private void VendorHome_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + SessionManager.FullName + " | Vendor Dashboard";
            LoadDashboardStats();
            LoadRecentOrders();
        }

        private void LoadDashboardStats()
        {
            try
            {
                int vendorId = SessionManager.UserId;

                // Total products
                string q1 = "SELECT COUNT(*) FROM Products WHERE vendor_id = @vid";
                int totalProducts = Convert.ToInt32(DatabaseHelper.ExecuteScalar(q1,
                    new SqlParameter[] { new SqlParameter("@vid", vendorId) }));

                // Total orders
                string q2 = "SELECT COUNT(*) FROM Orders WHERE vendor_id = @vid";
                int totalOrders = Convert.ToInt32(DatabaseHelper.ExecuteScalar(q2,
                    new SqlParameter[] { new SqlParameter("@vid", vendorId) }));

                // Total earnings
                string q3 = "SELECT ISNULL(SUM(total_price), 0) FROM Orders WHERE vendor_id = @vid AND order_status != 'Cancelled'";
                decimal totalEarnings = Convert.ToDecimal(DatabaseHelper.ExecuteScalar(q3,
                    new SqlParameter[] { new SqlParameter("@vid", vendorId) }));

                // Low stock (less than 5 items)
                string q4 = "SELECT COUNT(*) FROM Products WHERE vendor_id = @vid AND stock_qty < 5";
                int lowStock = Convert.ToInt32(DatabaseHelper.ExecuteScalar(q4,
                    new SqlParameter[] { new SqlParameter("@vid", vendorId) }));

                // Update stat panels
                // Find labels by name in panelMain
                UpdateStatLabel("lblStat1Value", totalProducts.ToString());
                UpdateStatLabel("lblStat2Value", totalOrders.ToString());
                UpdateStatLabel("lblStat3Value", "৳" + totalEarnings.ToString("N0"));
                UpdateStatLabel("lblStat4Value", lowStock.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stats: " + ex.Message);
            }
        }

        private void UpdateStatLabel(string labelName, string value)
        {
            foreach (System.Windows.Forms.Control ctrl in panelMain.Controls)
            {
                if (ctrl is System.Windows.Forms.Panel)
                {
                    foreach (System.Windows.Forms.Control inner in ctrl.Controls)
                    {
                        if (inner.Name == labelName)
                            inner.Text = value;
                    }
                }
            }
        }

        private void LoadRecentOrders()
        {
            try
            {
                string query = @"
                    SELECT TOP 10
                        o.order_id          AS [Order ID],
                        u.full_name         AS [Customer],
                        p.product_name      AS [Product],
                        o.quantity          AS [Qty],
                        o.total_price       AS [Total (BDT)],
                        o.order_status      AS [Status],
                        o.payment_method    AS [Payment],
                        o.order_date        AS [Date]
                    FROM Orders o
                    JOIN Users u    ON o.customer_id = u.user_id
                    JOIN Products p ON o.product_id  = p.product_id
                    WHERE o.vendor_id = @vendorId
                    ORDER BY o.order_date DESC";

                SqlParameter[] parameters = {
                    new SqlParameter("@vendorId", SessionManager.UserId)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                dgvRecentOrders.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboardStats();
            LoadRecentOrders();
        }

        private void btnMyProducts_Click(object sender, EventArgs e)
        {
            VendorProducts form = new VendorProducts();
            form.ShowDialog();
            LoadDashboardStats();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct form = new AddProduct();
            form.ShowDialog();
            LoadDashboardStats();
        }

        private void btnMyOrders_Click(object sender, EventArgs e)
        {
            VendorOrders form = new VendorOrders();
            form.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            StockDashboard form = new StockDashboard();
            form.ShowDialog();
        }

        private void btnEarnings_Click(object sender, EventArgs e)
        {
            EarningsReport form = new EarningsReport();
            form.ShowDialog();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileForm form = new ProfileForm();
            form.ShowDialog();
            lblWelcome.Text = "Welcome, " + SessionManager.FullName + " | Vendor Dashboard";
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