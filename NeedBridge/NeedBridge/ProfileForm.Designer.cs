namespace NeedBridge
{
    partial class ProfileForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.txtUserType = new System.Windows.Forms.TextBox();
            this.lblMemberSince = new System.Windows.Forms.Label();
            this.txtMemberSince = new System.Windows.Forms.TextBox();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.lblChangePass = new System.Windows.Forms.Label();
            this.lblOldPass = new System.Windows.Forms.Label();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblSubtitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Size = new System.Drawing.Size(580, 70);

            this.lblTitle.AutoSize = false;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Size = new System.Drawing.Size(540, 32);
            this.lblTitle.Text = "My Profile";

            this.lblSubtitle.AutoSize = false;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(180, 220, 255);
            this.lblSubtitle.Location = new System.Drawing.Point(20, 44);
            this.lblSubtitle.Size = new System.Drawing.Size(540, 20);
            this.lblSubtitle.Text = "View and update your account details";

            // panelForm
            this.panelForm.AutoScroll = true;
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Controls.Add(this.lblFullName);
            this.panelForm.Controls.Add(this.txtFullName);
            this.panelForm.Controls.Add(this.lblUsername);
            this.panelForm.Controls.Add(this.txtUsername);
            this.panelForm.Controls.Add(this.lblEmail);
            this.panelForm.Controls.Add(this.txtEmail);
            this.panelForm.Controls.Add(this.lblPhone);
            this.panelForm.Controls.Add(this.txtPhone);
            this.panelForm.Controls.Add(this.lblAddress);
            this.panelForm.Controls.Add(this.txtAddress);
            this.panelForm.Controls.Add(this.lblUserType);
            this.panelForm.Controls.Add(this.txtUserType);
            this.panelForm.Controls.Add(this.lblMemberSince);
            this.panelForm.Controls.Add(this.txtMemberSince);
            this.panelForm.Controls.Add(this.lblSeparator);
            this.panelForm.Controls.Add(this.lblChangePass);
            this.panelForm.Controls.Add(this.lblOldPass);
            this.panelForm.Controls.Add(this.txtOldPass);
            this.panelForm.Controls.Add(this.lblNewPass);
            this.panelForm.Controls.Add(this.txtNewPass);
            this.panelForm.Controls.Add(this.lblConfirmPass);
            this.panelForm.Controls.Add(this.txtConfirmPass);
            this.panelForm.Controls.Add(this.lblError);
            this.panelForm.Controls.Add(this.btnSave);
            this.panelForm.Controls.Add(this.btnClose);

            // Full Name
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblFullName.Location = new System.Drawing.Point(30, 15);
            this.lblFullName.Text = "Full Name";

            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFullName.Location = new System.Drawing.Point(30, 37);
            this.txtFullName.Size = new System.Drawing.Size(500, 28);
            this.txtFullName.Name = "txtFullName";

            // Username
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblUsername.Location = new System.Drawing.Point(30, 75);
            this.lblUsername.Text = "Username (cannot change)";

            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.Location = new System.Drawing.Point(30, 97);
            this.txtUsername.Size = new System.Drawing.Size(500, 28);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            // Email
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblEmail.Location = new System.Drawing.Point(30, 135);
            this.lblEmail.Text = "Email";

            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(30, 157);
            this.txtEmail.Size = new System.Drawing.Size(500, 28);
            this.txtEmail.Name = "txtEmail";

            // Phone
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblPhone.Location = new System.Drawing.Point(30, 195);
            this.lblPhone.Text = "Phone Number";

            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.Location = new System.Drawing.Point(30, 217);
            this.txtPhone.Size = new System.Drawing.Size(500, 28);
            this.txtPhone.Name = "txtPhone";

            // Address
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblAddress.Location = new System.Drawing.Point(30, 255);
            this.lblAddress.Text = "Address";

            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddress.Location = new System.Drawing.Point(30, 277);
            this.txtAddress.Size = new System.Drawing.Size(500, 28);
            this.txtAddress.Name = "txtAddress";

            // UserType
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblUserType.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblUserType.Location = new System.Drawing.Point(30, 315);
            this.lblUserType.Text = "Account Type";

            this.txtUserType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUserType.Location = new System.Drawing.Point(30, 337);
            this.txtUserType.Size = new System.Drawing.Size(230, 28);
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.ReadOnly = true;
            this.txtUserType.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            // Member Since
            this.lblMemberSince.AutoSize = true;
            this.lblMemberSince.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblMemberSince.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblMemberSince.Location = new System.Drawing.Point(280, 315);
            this.lblMemberSince.Text = "Member Since";

            this.txtMemberSince.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMemberSince.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMemberSince.Location = new System.Drawing.Point(280, 337);
            this.txtMemberSince.Size = new System.Drawing.Size(250, 28);
            this.txtMemberSince.Name = "txtMemberSince";
            this.txtMemberSince.ReadOnly = true;
            this.txtMemberSince.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            // Separator
            this.lblSeparator.AutoSize = false;
            this.lblSeparator.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.lblSeparator.Location = new System.Drawing.Point(30, 380);
            this.lblSeparator.Size = new System.Drawing.Size(500, 1);

            // Change Password
            this.lblChangePass.AutoSize = false;
            this.lblChangePass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblChangePass.ForeColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.lblChangePass.Location = new System.Drawing.Point(30, 392);
            this.lblChangePass.Size = new System.Drawing.Size(500, 26);
            this.lblChangePass.Text = "Change Password (optional)";

            // Old Password
            this.lblOldPass.AutoSize = true;
            this.lblOldPass.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblOldPass.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblOldPass.Location = new System.Drawing.Point(30, 428);
            this.lblOldPass.Text = "Current Password";

            this.txtOldPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOldPass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOldPass.Location = new System.Drawing.Point(30, 450);
            this.txtOldPass.Size = new System.Drawing.Size(500, 28);
            this.txtOldPass.PasswordChar = '*';
            this.txtOldPass.Name = "txtOldPass";

            // New Password
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNewPass.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblNewPass.Location = new System.Drawing.Point(30, 488);
            this.lblNewPass.Text = "New Password";

            this.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewPass.Location = new System.Drawing.Point(30, 510);
            this.txtNewPass.Size = new System.Drawing.Size(500, 28);
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Name = "txtNewPass";

            // Confirm Password
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblConfirmPass.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblConfirmPass.Location = new System.Drawing.Point(30, 548);
            this.lblConfirmPass.Text = "Confirm New Password";

            this.txtConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmPass.Location = new System.Drawing.Point(30, 570);
            this.txtConfirmPass.Size = new System.Drawing.Size(500, 28);
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.Name = "txtConfirmPass";

            // Error
            this.lblError.AutoSize = false;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(30, 608);
            this.lblError.Size = new System.Drawing.Size(500, 20);
            this.lblError.Name = "lblError";
            this.lblError.Text = "";

            // Buttons
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(30, 638);
            this.btnSave.Size = new System.Drawing.Size(230, 40);
            this.btnSave.Text = "Save Changes";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(275, 638);
            this.btnClose.Size = new System.Drawing.Size(130, 40);
            this.btnClose.Text = "Close";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // ProfileForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 720);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Profile - NeedBridge";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.TextBox txtUserType;
        private System.Windows.Forms.Label lblMemberSince;
        private System.Windows.Forms.TextBox txtMemberSince;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.Label lblChangePass;
        private System.Windows.Forms.Label lblOldPass;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}