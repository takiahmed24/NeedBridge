using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeedBridge
{
    public partial class ManageUsers : Form
    {
        private string _userType;

        public ManageUsers(string userType)
        {
            InitializeComponent();
            _userType = userType;
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            // Set title based on user type
            lblTitle.Text = _userType == "vendor"
                ? "🏪 Manage Vendors"
                : "👥 Manage Customers";
            lblSubtitle.Text = _userType == "vendor"
                ? "View, suspend or delete vendor accounts"
                : "View, suspend or delete customer accounts";
            this.Text = (_userType == "vendor" ? "Manage Vendors" : "Manage Customers")
                        + " - NeedBridge";

            LoadUsers();
        }

        private void LoadUsers(string search = "", string status = "All")
        {
            try
            {
                string query = @"
                    SELECT
                        user_id     AS [ID],
                        full_name   AS [Full Name],
                        username    AS [Username],
                        email       AS [Email],
                        phone       AS [Phone],
                        address     AS [Address],
                        status      AS [Status],
                        created_at  AS [Joined]
                    FROM Users
                    WHERE user_type = @userType";

                if (!string.IsNullOrEmpty(search))
                    query += " AND (full_name LIKE '%" + search + "%' OR username LIKE '%" + search + "%' OR email LIKE '%" + search + "%')";

                if (status != "All")
                    query += " AND status = '" + status + "'";

                query += " ORDER BY created_at DESC";

                SqlParameter[] parameters = {
                    new SqlParameter("@userType", _userType)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                dgvUsers.DataSource = dt;

                if (dgvUsers.Columns.Contains("ID"))
                    dgvUsers.Columns["ID"].Visible = false;

                // Color rows by status
                foreach (DataGridViewRow row in dgvUsers.Rows)
                {
                    string s = row.Cells["Status"].Value?.ToString() ?? "";
                    if (s == "suspended")
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 243, 205);
                    else if (s == "banned")
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 220, 220);
                }

                lblTitle.Text = (_userType == "vendor" ? "🏪 Manage Vendors" : "👥 Manage Customers")
                                + " (" + dt.Rows.Count + " found)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private int GetSelectedUserId()
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user first.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
            return Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["ID"].Value);
        }

        private void UpdateUserStatus(int userId, string newStatus)
        {
            try
            {
                string query = "UPDATE Users SET status = @status WHERE user_id = @userId";
                SqlParameter[] parameters = {
                    new SqlParameter("@status", newStatus),
                    new SqlParameter("@userId", userId)
                };
                DatabaseHelper.ExecuteNonQuery(query, parameters);
                LoadUsers(txtSearch.Text.Trim(), cmbStatus.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating status: " + ex.Message);
            }
        }

        private void btnSuspend_Click(object sender, EventArgs e)
        {
            int userId = GetSelectedUserId();
            if (userId == -1) return;

            string name = dgvUsers.SelectedRows[0].Cells["Full Name"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                "Suspend account of \"" + name + "\"?\nThey will not be able to login.",
                "Suspend User",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                UpdateUserStatus(userId, "suspended");
                MessageBox.Show(name + " has been suspended.",
                    "Suspended", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            int userId = GetSelectedUserId();
            if (userId == -1) return;

            string name = dgvUsers.SelectedRows[0].Cells["Full Name"].Value.ToString();
            UpdateUserStatus(userId, "active");
            MessageBox.Show(name + "'s account has been activated.",
                "Activated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int userId = GetSelectedUserId();
            if (userId == -1) return;

            string name = dgvUsers.SelectedRows[0].Cells["Full Name"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                "Permanently delete account of \"" + name + "\"?\nThis cannot be undone!",
                "Delete User",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    // Delete user (cascade will handle related records if set up)
                    string query = "DELETE FROM Users WHERE user_id = @userId";
                    SqlParameter[] parameters = {
                        new SqlParameter("@userId", userId)
                    };
                    DatabaseHelper.ExecuteNonQuery(query, parameters);

                    MessageBox.Show(name + "'s account has been deleted.",
                        "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadUsers(txtSearch.Text.Trim(), cmbStatus.SelectedItem.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting user: " + ex.Message +
                        "\n\nNote: Cannot delete users with existing orders.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadUsers(txtSearch.Text.Trim(), cmbStatus.SelectedItem.ToString());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbStatus.SelectedIndex = 0;
            LoadUsers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}