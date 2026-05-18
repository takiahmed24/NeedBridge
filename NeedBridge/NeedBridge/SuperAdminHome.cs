using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeedBridge
{
    public partial class SuperAdminHome : Form
    {
        public SuperAdminHome()
        {
            InitializeComponent();
        }

        private void SuperAdminHome_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + SessionManager.FullName + " | Super Admin";
            LoadStats();
            LoadAllUsers();
        }

        private void LoadStats()
        {
            try
            {
                string q1 = "SELECT COUNT(*) FROM Users WHERE user_type = 'admin'";
                string q2 = "SELECT COUNT(*) FROM Users WHERE user_type = 'vendor'";
                string q3 = "SELECT COUNT(*) FROM Users WHERE user_type = 'customer'";
                string q4 = "SELECT COUNT(*) FROM Orders";
                string q5 = "SELECT ISNULL(SUM(total_price),0) FROM Orders WHERE order_status != 'Cancelled'";

                lblS1Value.Text = DatabaseHelper.ExecuteScalar(q1).ToString();
                lblS2Value.Text = DatabaseHelper.ExecuteScalar(q2).ToString();
                lblS3Value.Text = DatabaseHelper.ExecuteScalar(q3).ToString();
                lblS4Value.Text = DatabaseHelper.ExecuteScalar(q4).ToString();
                lblS5Value.Text = "৳" + Convert.ToDecimal(DatabaseHelper.ExecuteScalar(q5)).ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stats: " + ex.Message);
            }
        }

        private void LoadAllUsers(string filter = "")
        {
            try
            {
                string query = @"
                    SELECT
                        user_id     AS [ID],
                        full_name   AS [Full Name],
                        username    AS [Username],
                        email       AS [Email],
                        user_type   AS [Role],
                        status      AS [Status],
                        created_at  AS [Joined]
                    FROM Users
                    WHERE user_type != 'superadmin'";

                if (!string.IsNullOrEmpty(filter))
                    query += " AND user_type = '" + filter + "'";

                query += " ORDER BY user_type, created_at DESC";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvUsers.DataSource = dt;

                if (dgvUsers.Columns.Contains("ID"))
                    dgvUsers.Columns["ID"].Visible = false;

                // Color by role
                foreach (DataGridViewRow row in dgvUsers.Rows)
                {
                    string role = row.Cells["Role"].Value?.ToString() ?? "";
                    string status = row.Cells["Status"].Value?.ToString() ?? "";

                    if (status == "suspended")
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 243, 205);
                    else if (role == "admin")
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 250, 210);
                    else if (role == "vendor")
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(230, 255, 235);
                    else
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                }

                lblGridTitle.Text = "All Users (" + dt.Rows.Count + " total)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadStats();
            LoadAllUsers();
        }

        private void btnManageAdmins_Click(object sender, EventArgs e)
        {
            // SuperAdmin can create and delete admin accounts
            SuperAdminManageAdmins form = new SuperAdminManageAdmins();
            form.ShowDialog();
            LoadStats();
            LoadAllUsers();
        }

        private void btnManageVendors_Click(object sender, EventArgs e)
        {
            ManageUsers form = new ManageUsers("vendor");
            form.ShowDialog();
            LoadStats();
            LoadAllUsers();
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            ManageUsers form = new ManageUsers("customer");
            form.ShowDialog();
            LoadStats();
            LoadAllUsers();
        }

        private void btnPlatformReport_Click(object sender, EventArgs e)
        {
            SalesReport form = new SalesReport();
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SessionManager.Clear();
                this.Close();
            }
        }
    }
}