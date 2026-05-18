namespace NeedBridge
{
    partial class SuperAdminManageAdmins
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
            this.panelAdd = new System.Windows.Forms.Panel();
            this.lblAddTitle = new System.Windows.Forms.Label();
            this.lblNewName = new System.Windows.Forms.Label();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.lblNewUsername = new System.Windows.Forms.Label();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.lblNewEmail = new System.Windows.Forms.Label();
            this.txtNewEmail = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnCreateAdmin = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblAdminList = new System.Windows.Forms.Label();
            this.dgvAdmins = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnSuspend = new System.Windows.Forms.Button();
            this.btnActivate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(20, 20, 30);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblSubtitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Size = new System.Drawing.Size(1050, 65);

            this.lblTitle.AutoSize = false;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(255, 215, 0);
            this.lblTitle.Location = new System.Drawing.Point(20, 8);
            this.lblTitle.Size = new System.Drawing.Size(600, 32);
            this.lblTitle.Text = "Manage Admins";

            this.lblSubtitle.AutoSize = false;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.lblSubtitle.Location = new System.Drawing.Point(20, 42);
            this.lblSubtitle.Size = new System.Drawing.Size(600, 20);
            this.lblSubtitle.Text = "Create, suspend or delete admin accounts";

            // panelAdd — left side create form
            this.panelAdd.BackColor = System.Drawing.Color.FromArgb(30, 30, 45);
            this.panelAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAdd.Width = 280;
            this.panelAdd.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.panelAdd.Controls.Add(this.lblAddTitle);
            this.panelAdd.Controls.Add(this.lblNewName);
            this.panelAdd.Controls.Add(this.txtNewName);
            this.panelAdd.Controls.Add(this.lblNewUsername);
            this.panelAdd.Controls.Add(this.txtNewUsername);
            this.panelAdd.Controls.Add(this.lblNewEmail);
            this.panelAdd.Controls.Add(this.txtNewEmail);
            this.panelAdd.Controls.Add(this.lblNewPassword);
            this.panelAdd.Controls.Add(this.txtNewPassword);
            this.panelAdd.Controls.Add(this.lblError);
            this.panelAdd.Controls.Add(this.btnCreateAdmin);

            this.lblAddTitle.AutoSize = false;
            this.lblAddTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAddTitle.ForeColor = System.Drawing.Color.FromArgb(255, 215, 0);
            this.lblAddTitle.Location = new System.Drawing.Point(20, 15);
            this.lblAddTitle.Size = new System.Drawing.Size(240, 26);
            this.lblAddTitle.Text = "Create New Admin";

            this.lblNewName.AutoSize = true;
            this.lblNewName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNewName.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.lblNewName.Location = new System.Drawing.Point(20, 55);
            this.lblNewName.Text = "Full Name";

            this.txtNewName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewName.Location = new System.Drawing.Point(20, 75);
            this.txtNewName.Size = new System.Drawing.Size(238, 28);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.BackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.txtNewName.ForeColor = System.Drawing.Color.White;

            this.lblNewUsername.AutoSize = true;
            this.lblNewUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNewUsername.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.lblNewUsername.Location = new System.Drawing.Point(20, 115);
            this.lblNewUsername.Text = "Username";

            this.txtNewUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewUsername.Location = new System.Drawing.Point(20, 135);
            this.txtNewUsername.Size = new System.Drawing.Size(238, 28);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.BackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.txtNewUsername.ForeColor = System.Drawing.Color.White;

            this.lblNewEmail.AutoSize = true;
            this.lblNewEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNewEmail.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.lblNewEmail.Location = new System.Drawing.Point(20, 175);
            this.lblNewEmail.Text = "Email";

            this.txtNewEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewEmail.Location = new System.Drawing.Point(20, 195);
            this.txtNewEmail.Size = new System.Drawing.Size(238, 28);
            this.txtNewEmail.Name = "txtNewEmail";
            this.txtNewEmail.BackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.txtNewEmail.ForeColor = System.Drawing.Color.White;

            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNewPassword.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.lblNewPassword.Location = new System.Drawing.Point(20, 235);
            this.lblNewPassword.Text = "Password";

            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewPassword.Location = new System.Drawing.Point(20, 255);
            this.txtNewPassword.Size = new System.Drawing.Size(238, 28);
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.txtNewPassword.ForeColor = System.Drawing.Color.White;

            this.lblError.AutoSize = false;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(255, 100, 100);
            this.lblError.Location = new System.Drawing.Point(20, 295);
            this.lblError.Size = new System.Drawing.Size(238, 20);
            this.lblError.Name = "lblError";
            this.lblError.Text = "";

            this.btnCreateAdmin.BackColor = System.Drawing.Color.FromArgb(255, 215, 0);
            this.btnCreateAdmin.FlatAppearance.BorderSize = 0;
            this.btnCreateAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAdmin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCreateAdmin.ForeColor = System.Drawing.Color.FromArgb(20, 20, 30);
            this.btnCreateAdmin.Location = new System.Drawing.Point(20, 325);
            this.btnCreateAdmin.Size = new System.Drawing.Size(238, 42);
            this.btnCreateAdmin.Text = "Create Admin";
            this.btnCreateAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateAdmin.Click += new System.EventHandler(this.btnCreateAdmin_Click);

            // panelContent — right side admin list
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.panelContent.Controls.Add(this.dgvAdmins);
            this.panelContent.Controls.Add(this.lblAdminList);

            this.lblAdminList.AutoSize = false;
            this.lblAdminList.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAdminList.Height = 36;
            this.lblAdminList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAdminList.ForeColor = System.Drawing.Color.FromArgb(20, 20, 30);
            this.lblAdminList.Padding = new System.Windows.Forms.Padding(4, 6, 0, 0);
            this.lblAdminList.Text = "Current Admin Accounts";
            this.lblAdminList.Name = "lblAdminList";

            this.dgvAdmins.AllowUserToAddRows = false;
            this.dgvAdmins.AllowUserToDeleteRows = false;
            this.dgvAdmins.ReadOnly = true;
            this.dgvAdmins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdmins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdmins.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdmins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdmins.ColumnHeadersHeight = 38;
            this.dgvAdmins.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(20, 20, 30);
            this.dgvAdmins.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(255, 215, 0);
            this.dgvAdmins.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvAdmins.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvAdmins.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 240, 150);
            this.dgvAdmins.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAdmins.RowTemplate.Height = 38;
            this.dgvAdmins.Name = "dgvAdmins";
            this.dgvAdmins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // panelBottom
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(245, 248, 250);
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Height = 60;
            this.panelBottom.Controls.Add(this.btnSuspend);
            this.panelBottom.Controls.Add(this.btnActivate);
            this.panelBottom.Controls.Add(this.btnDelete);
            this.panelBottom.Controls.Add(this.btnClose);

            this.btnSuspend.BackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            this.btnSuspend.FlatAppearance.BorderSize = 0;
            this.btnSuspend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuspend.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSuspend.ForeColor = System.Drawing.Color.White;
            this.btnSuspend.Location = new System.Drawing.Point(295, 13);
            this.btnSuspend.Size = new System.Drawing.Size(140, 34);
            this.btnSuspend.Text = "Suspend";
            this.btnSuspend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuspend.Click += new System.EventHandler(this.btnSuspend_Click);

            this.btnActivate.BackColor = System.Drawing.Color.FromArgb(22, 160, 133);
            this.btnActivate.FlatAppearance.BorderSize = 0;
            this.btnActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActivate.ForeColor = System.Drawing.Color.White;
            this.btnActivate.Location = new System.Drawing.Point(450, 13);
            this.btnActivate.Size = new System.Drawing.Size(140, 34);
            this.btnActivate.Text = "Activate";
            this.btnActivate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);

            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(605, 13);
            this.btnDelete.Size = new System.Drawing.Size(140, 34);
            this.btnDelete.Text = "Delete Admin";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(950, 13);
            this.btnClose.Size = new System.Drawing.Size(85, 34);
            this.btnClose.Text = "Close";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // SuperAdminManageAdmins Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 620);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SuperAdminManageAdmins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Admins - NeedBridge";
            this.Load += new System.EventHandler(this.SuperAdminManageAdmins_Load);
            this.panelTop.ResumeLayout(false);
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Label lblAddTitle;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label lblNewUsername;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.Label lblNewEmail;
        private System.Windows.Forms.TextBox txtNewEmail;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnCreateAdmin;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblAdminList;
        private System.Windows.Forms.DataGridView dgvAdmins;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnSuspend;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
    }
}