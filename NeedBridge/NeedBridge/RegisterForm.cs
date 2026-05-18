using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeedBridge
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            cmbUserType.SelectedIndex = 0; // default: customer
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Get all values
            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();
            string password = txtPassword.Text.Trim();
            string userType = cmbUserType.SelectedItem.ToString();

            // Validation
            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                lblError.Text = "Full name, username, email and password are required.";
                return;
            }

            if (password.Length < 6)
            {
                lblError.Text = "Password must be at least 6 characters.";
                return;
            }

            if (!email.Contains("@"))
            {
                lblError.Text = "Please enter a valid email address.";
                return;
            }

            try
            {
                // Check if username already exists
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE username = @username";
                SqlParameter[] checkParams = {
                    new SqlParameter("@username", username)
                };

                int exists = Convert.ToInt32(DatabaseHelper.ExecuteScalar(checkQuery, checkParams));

                if (exists > 0)
                {
                    lblError.Text = "Username already taken. Please choose another.";
                    return;
                }

                // Insert new user
                string insertQuery = @"INSERT INTO Users 
                    (full_name, username, password, email, phone, address, user_type, status)
                    VALUES 
                    (@fullName, @username, @password, @email, @phone, @address, @userType, 'active')";

                SqlParameter[] insertParams = {
                    new SqlParameter("@fullName", fullName),
                    new SqlParameter("@username", username),
                    new SqlParameter("@password", password),
                    new SqlParameter("@email",    email),
                    new SqlParameter("@phone",    phone),
                    new SqlParameter("@address",  address),
                    new SqlParameter("@userType", userType)
                };

                int rows = DatabaseHelper.ExecuteNonQuery(insertQuery, insertParams);

                if (rows > 0)
                {
                    MessageBox.Show(
                        "Account created successfully!\nYou can now login.",
                        "Registration Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    // Go back to login
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "Error: " + ex.Message;
            }
        }

        private void lblLoginLink_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}