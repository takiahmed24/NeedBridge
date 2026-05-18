using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeedBridge
{
    public partial class SuperAdminManageAdmins : Form
    {
        public SuperAdminManageAdmins()
        {
            InitializeComponent();
        }

        private void SuperAdminManageAdmins_Load(object sender, EventArgs e)
        {
            LoadAdmins();
        }

        private void LoadAdmins()
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
                        status      AS [Status],
                        created_at  AS [Created]
                    FROM Users
                    WHERE user_type = 'admin'
                    ORDER BY created_at DESC";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvAdmins.DataSource = dt;

                if (dgvAdmins.Columns.Contains("ID"))
                    dgvAdmins.Columns["ID"].Visible = false;

                foreach (DataGridViewRow row in dgvAdmins.Rows)
                {
                    string status = row.Cells["Status"].Value?.ToString() ?? "";
                    if (status == "suspended")
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 243, 205);
                }

                lblAdminList.Text = "Current Admin Accounts (" + dt.Rows.Count + ")";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading admins: " + ex.Message);
            }
        }

        private void btnCreateAdmin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            string fullName = txtNewName.Text.Trim();
            string username = txtNewUsername.Text.Trim();
            string email = txtNewEmail.Text.Trim();
            string password = txtNewPassword.Text.Trim();

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password))
            {
                lblError.Text = "Name, username and password required.";
                return;
            }

            if (password.Length < 6)
            {
                lblError.Text = "Password must be 6+ characters.";
                return;
            }

            try
            {
                // Check username exists
                string checkQ = "SELECT COUNT(*) FROM Users WHERE username = @u";
                int exists = Convert.ToInt32(DatabaseHelper.ExecuteScalar(checkQ,
                    new SqlParameter[] { new SqlParameter("@u", username) }));

                if (exists > 0)
                {
                    lblError.Text = "Username already taken.";
                    return;
                }

                string insertQ = @"
                    INSERT INTO Users (full_name, username, password, email, user_type, status)
                    VALUES (@name, @username, @password, @email, 'admin', 'active')";

                SqlParameter[] parameters = {
                    new SqlParameter("@name",     fullName),
                    new SqlParameter("@username", username),
                    new SqlParameter("@password", password),
                    new SqlParameter("@email",    email)
                };

                DatabaseHelper.ExecuteNonQuery(insertQ, parameters);

                MessageBox.Show(
                    "Admin account created!\n\nName: " + fullName +
                    "\nUsername: " + username +
                    "\nPassword: " + password,
                    "Admin Created",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Clear form
                txtNewName.Clear();
                txtNewUsername.Clear();
                txtNewEmail.Clear();
                txtNewPassword.Clear();

                LoadAdmins();
            }
            catch (Exception ex)
            {
                lblError.Text = "Error: " + ex.Message;
            }
        }

        private int GetSelectedAdminId()
        {
            if (dgvAdmins.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an admin first.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
            return Convert.ToInt32(dgvAdmins.SelectedRows[0].Cells["ID"].Value);
        }

        private void btnSuspend_Click(object sender, EventArgs e)
        {
            int adminId = GetSelectedAdminId();
            if (adminId == -1) return;

            string name = dgvAdmins.SelectedRows[0].Cells["Full Name"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                "Suspend admin \"" + name + "\"?",
                "Suspend Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    DatabaseHelper.ExecuteNonQuery(
                        "UPDATE Users SET status = 'suspended' WHERE user_id = @id",
                        new SqlParameter[] { new SqlParameter("@id", adminId) });

                    MessageBox.Show(name + " has been suspended.",
                        "Suspended", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAdmins();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            int adminId = GetSelectedAdminId();
            if (adminId == -1) return;

            string name = dgvAdmins.SelectedRows[0].Cells["Full Name"].Value.ToString();

            try
            {
                DatabaseHelper.ExecuteNonQuery(
                    "UPDATE Users SET status = 'active' WHERE user_id = @id",
                    new SqlParameter[] { new SqlParameter("@id", adminId) });

                MessageBox.Show(name + "'s account is now active.",
                    "Activated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAdmins();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int adminId = GetSelectedAdminId();
            if (adminId == -1) return;

            string name = dgvAdmins.SelectedRows[0].Cells["Full Name"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                "Permanently delete admin \"" + name + "\"?\nThis cannot be undone!",
                "Delete Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    DatabaseHelper.ExecuteNonQuery(
                        "DELETE FROM Users WHERE user_id = @id AND user_type = 'admin'",
                        new SqlParameter[] { new SqlParameter("@id", adminId) });

                    MessageBox.Show(name + " has been deleted.",
                        "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAdmins();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}