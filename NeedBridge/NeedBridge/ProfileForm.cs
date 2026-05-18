using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeedBridge
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            LoadProfile();
        }

        private void LoadProfile()
        {
            try
            {
                string query = @"
                    SELECT full_name, username, email, phone,
                           address, user_type, created_at
                    FROM Users
                    WHERE user_id = @userId";

                SqlParameter[] parameters = {
                    new SqlParameter("@userId", SessionManager.UserId)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                if (dt.Rows.Count == 0) return;

                DataRow row = dt.Rows[0];

                txtFullName.Text = row["full_name"].ToString();
                txtUsername.Text = row["username"].ToString();
                txtEmail.Text = row["email"].ToString();
                txtPhone.Text = row["phone"].ToString();
                txtAddress.Text = row["address"].ToString();
                txtUserType.Text = row["user_type"].ToString().ToUpper();
                txtMemberSince.Text = Convert.ToDateTime(row["created_at"])
                                        .ToString("dd MMM yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();
            string oldPass = txtOldPass.Text.Trim();
            string newPass = txtNewPass.Text.Trim();
            string confPass = txtConfirmPass.Text.Trim();

            if (string.IsNullOrEmpty(fullName))
            {
                lblError.Text = "Full name cannot be empty."; return;
            }
            if (!string.IsNullOrEmpty(email) && !email.Contains("@"))
            {
                lblError.Text = "Please enter a valid email."; return;
            }

            try
            {
                // Update basic info
                string updateQuery = @"
                    UPDATE Users
                    SET full_name = @fullName,
                        email     = @email,
                        phone     = @phone,
                        address   = @address
                    WHERE user_id = @userId";

                SqlParameter[] updateParams = {
                    new SqlParameter("@fullName", fullName),
                    new SqlParameter("@email",    email),
                    new SqlParameter("@phone",    phone),
                    new SqlParameter("@address",  address),
                    new SqlParameter("@userId",   SessionManager.UserId)
                };
                DatabaseHelper.ExecuteNonQuery(updateQuery, updateParams);

                // Update session name
                SessionManager.FullName = fullName;

                // Change password if filled
                if (!string.IsNullOrEmpty(oldPass))
                {
                    if (string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(confPass))
                    {
                        lblError.Text = "Please fill in new and confirm password."; return;
                    }
                    if (newPass != confPass)
                    {
                        lblError.Text = "New passwords do not match."; return;
                    }
                    if (newPass.Length < 6)
                    {
                        lblError.Text = "New password must be at least 6 characters."; return;
                    }

                    // Verify old password
                    string checkQuery = @"SELECT COUNT(*) FROM Users
                                          WHERE user_id = @userId AND password = @oldPass";
                    SqlParameter[] checkParams = {
                        new SqlParameter("@userId",  SessionManager.UserId),
                        new SqlParameter("@oldPass", oldPass)
                    };
                    int match = Convert.ToInt32(DatabaseHelper.ExecuteScalar(checkQuery, checkParams));

                    if (match == 0)
                    {
                        lblError.Text = "Current password is incorrect."; return;
                    }

                    // Update password
                    string passQuery = @"UPDATE Users SET password = @newPass
                                         WHERE user_id = @userId";
                    SqlParameter[] passParams = {
                        new SqlParameter("@newPass", newPass),
                        new SqlParameter("@userId",  SessionManager.UserId)
                    };
                    DatabaseHelper.ExecuteNonQuery(passQuery, passParams);

                    // Clear password fields
                    txtOldPass.Clear();
                    txtNewPass.Clear();
                    txtConfirmPass.Clear();
                }

                MessageBox.Show(
                    "Profile updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                lblError.Text = "Error: " + ex.Message;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}