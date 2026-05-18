using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeedBridge
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Basic validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Please enter both username and password.";
                return;
            }

            try
            {
                string query = "SELECT user_id, full_name, user_type, status FROM Users " +
                               "WHERE username = @username AND password = @password";

                SqlParameter[] parameters = {
                    new SqlParameter("@username", username),
                    new SqlParameter("@password", password)
                };

                DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);

                if (result.Rows.Count == 0)
                {
                    lblError.Text = "Invalid username or password.";
                    txtPassword.Clear();
                    return;
                }

                DataRow user = result.Rows[0];
                string status = user["status"].ToString();

                if (status != "active")
                {
                    lblError.Text = "Your account has been suspended. Contact admin.";
                    return;
                }

                int userId = Convert.ToInt32(user["user_id"]);
                string fullName = user["full_name"].ToString();
                string userType = user["user_type"].ToString();

                // Save session info
                SessionManager.UserId = userId;
                SessionManager.FullName = fullName;
                SessionManager.UserType = userType;

                // Route to correct home form based on user_type
                Form homeForm = null;

                switch (userType)
                {
                    case "superadmin":
                        homeForm = new SuperAdminHome();
                        break;
                    case "admin":
                        homeForm = new AdminHome();
                        break;
                    case "vendor":
                        homeForm = new VendorHome();
                        break;
                    case "customer":
                        homeForm = new CustomerHome();
                        break;
                    default:
                        lblError.Text = "Unknown user type. Contact support.";
                        return;
                }

                this.Hide();
                homeForm.FormClosed += (s, args) => this.Close();
                homeForm.Show();
            }
            catch (Exception ex)
            {
                lblError.Text = "Connection error. Check database.";
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblRegisterLink_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.FormClosed += (s, args) => this.Show();
            registerForm.Show();
        }

        private void lblBrand_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}