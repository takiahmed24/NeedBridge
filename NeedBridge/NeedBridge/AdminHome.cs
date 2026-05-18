using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeedBridge
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + SessionManager.FullName + " | Admin Dashboard";
            LoadStats();
            LoadRecentOrders();
        }

        private void LoadStats()
        {
            try
            {
                // Total vendors
                string q1 = "SELECT COUNT(*) FROM Users WHERE user_type = 'vendor'";
                UpdateStatLabel("lblStat1Value", DatabaseHelper.ExecuteScalar(q1).ToString());

                // Total customers
                string q2 = "SELECT COUNT(*) FROM Users WHERE user_type = 'customer'";
                UpdateStatLabel("lblStat2Value", DatabaseHelper.ExecuteScalar(q2).ToString());

                // Total orders
                string q3 = "SELECT COUNT(*) FROM Orders";
                UpdateStatLabel("lblStat3Value", DatabaseHelper.ExecuteScalar(q3).ToString());

                // Total revenue
                string q4 = "SELECT ISNULL(SUM(total_price),0) FROM Orders WHERE order_status != 'Cancelled'";
                decimal revenue = Convert.ToDecimal(DatabaseHelper.ExecuteScalar(q4));
                UpdateStatLabel("lblStat4Value", "৳" + revenue.ToString("N0"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stats: " + ex.Message);
            }
        }

        private void UpdateStatLabel(string name, string value)
        {
            foreach (System.Windows.Forms.Control ctrl in panelStats.Controls)
            {
                if (ctrl is System.Windows.Forms.Panel)
                    foreach (System.Windows.Forms.Control inner in ctrl.Controls)
                        if (inner.Name == name) inner.Text = value;
            }
        }

        private void LoadRecentOrders()
        {
            try
            {
                string query = @"
                    SELECT TOP 15
                        o.order_id       AS [Order ID],
                        cu.full_name     AS [Customer],
                        p.product_name   AS [Product],
                        ve.full_name     AS [Vendor],
                        o.quantity       AS [Qty],
                        o.total_price    AS [Total (BDT)],
                        o.order_status   AS [Status],
                        o.payment_method AS [Payment],
                        o.order_date     AS [Date]
                    FROM Orders o
                    JOIN Users cu   ON o.customer_id = cu.user_id
                    JOIN Users ve   ON o.vendor_id   = ve.user_id
                    JOIN Products p ON o.product_id  = p.product_id
                    ORDER BY o.order_date DESC";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvRecent.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadStats();
            LoadRecentOrders();
        }

        private void btnManageVendors_Click(object sender, EventArgs e)
        {
            ManageUsers form = new ManageUsers("vendor");
            form.ShowDialog();
            LoadStats();
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            ManageUsers form = new ManageUsers("customer");
            form.ShowDialog();
            LoadStats();
        }

        private void btnManageReviews_Click(object sender, EventArgs e)
        {
            ManageReviews form = new ManageReviews();
            form.ShowDialog();
        }

        private void btnDisputes_Click(object sender, EventArgs e)
        {
            ManageDisputes form = new ManageDisputes();
            form.ShowDialog();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            SalesReport form = new SalesReport();
            form.ShowDialog();
        }

        private void btnDiscounts_Click(object sender, EventArgs e)
        {
            ManageDiscounts form = new ManageDiscounts();
            form.ShowDialog();
        }

        private void btnStockView_Click(object sender, EventArgs e)
        {
            AdminStockView form = new AdminStockView();
            form.ShowDialog();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileForm form = new ProfileForm();
            form.ShowDialog();
            lblWelcome.Text = "Welcome, " + SessionManager.FullName + " | Admin Dashboard";
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