namespace NeedBridge
{
    partial class AddProduct
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.cmbAvailability = new System.Windows.Forms.ComboBox();
            this.lblImagePath = new System.Windows.Forms.Label();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(8, 80, 65);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblSubtitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Size = new System.Drawing.Size(620, 70);

            this.lblTitle.AutoSize = false;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Size = new System.Drawing.Size(580, 32);
            this.lblTitle.Text = "Add New Product";

            this.lblSubtitle.AutoSize = false;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(180, 255, 220);
            this.lblSubtitle.Location = new System.Drawing.Point(20, 44);
            this.lblSubtitle.Size = new System.Drawing.Size(580, 20);
            this.lblSubtitle.Text = "Fill in the details below to list your product";

            // panelForm
            this.panelForm.AutoScroll = true;
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.panelForm.Controls.Add(this.lblProductName);
            this.panelForm.Controls.Add(this.txtProductName);
            this.panelForm.Controls.Add(this.lblDescription);
            this.panelForm.Controls.Add(this.txtDescription);
            this.panelForm.Controls.Add(this.lblCategory);
            this.panelForm.Controls.Add(this.cmbCategory);
            this.panelForm.Controls.Add(this.lblPrice);
            this.panelForm.Controls.Add(this.txtPrice);
            this.panelForm.Controls.Add(this.lblDiscount);
            this.panelForm.Controls.Add(this.txtDiscount);
            this.panelForm.Controls.Add(this.lblStock);
            this.panelForm.Controls.Add(this.txtStock);
            this.panelForm.Controls.Add(this.lblAvailability);
            this.panelForm.Controls.Add(this.cmbAvailability);
            this.panelForm.Controls.Add(this.lblImagePath);
            this.panelForm.Controls.Add(this.txtImagePath);
            this.panelForm.Controls.Add(this.btnBrowseImage);
            this.panelForm.Controls.Add(this.lblError);
            this.panelForm.Controls.Add(this.btnSave);
            this.panelForm.Controls.Add(this.btnCancel);

            // Product Name
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblProductName.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblProductName.Location = new System.Drawing.Point(30, 15);
            this.lblProductName.Text = "Product Name *";

            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtProductName.Location = new System.Drawing.Point(30, 37);
            this.txtProductName.Size = new System.Drawing.Size(530, 28);
            this.txtProductName.Name = "txtProductName";

            // Description
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblDescription.Location = new System.Drawing.Point(30, 75);
            this.lblDescription.Text = "Description";

            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.Location = new System.Drawing.Point(30, 97);
            this.txtDescription.Multiline = true;
            this.txtDescription.Size = new System.Drawing.Size(530, 65);
            this.txtDescription.Name = "txtDescription";

            // Category
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblCategory.Location = new System.Drawing.Point(30, 175);
            this.lblCategory.Text = "Category *";

            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.Location = new System.Drawing.Point(30, 197);
            this.cmbCategory.Size = new System.Drawing.Size(530, 28);
            this.cmbCategory.Name = "cmbCategory";

            // Price
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblPrice.Location = new System.Drawing.Point(30, 235);
            this.lblPrice.Text = "Price (BDT) *";

            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrice.Location = new System.Drawing.Point(30, 257);
            this.txtPrice.Size = new System.Drawing.Size(250, 28);
            this.txtPrice.Name = "txtPrice";

            // Discount
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblDiscount.Location = new System.Drawing.Point(30, 295);
            this.lblDiscount.Text = "Discount % (0 if none)";

            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDiscount.Location = new System.Drawing.Point(30, 317);
            this.txtDiscount.Size = new System.Drawing.Size(250, 28);
            this.txtDiscount.Text = "0";
            this.txtDiscount.Name = "txtDiscount";

            // Stock
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblStock.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblStock.Location = new System.Drawing.Point(30, 355);
            this.lblStock.Text = "Stock Quantity *";

            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStock.Location = new System.Drawing.Point(30, 377);
            this.txtStock.Size = new System.Drawing.Size(250, 28);
            this.txtStock.Name = "txtStock";

            // Availability
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblAvailability.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblAvailability.Location = new System.Drawing.Point(30, 415);
            this.lblAvailability.Text = "Availability";

            this.cmbAvailability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAvailability.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAvailability.Location = new System.Drawing.Point(30, 437);
            this.cmbAvailability.Size = new System.Drawing.Size(250, 28);
            this.cmbAvailability.Name = "cmbAvailability";
            this.cmbAvailability.Items.AddRange(new object[] { "available", "unavailable" });
            this.cmbAvailability.SelectedIndex = 0;

            // Image Path
            this.lblImagePath.AutoSize = true;
            this.lblImagePath.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblImagePath.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblImagePath.Location = new System.Drawing.Point(30, 475);
            this.lblImagePath.Text = "Product Image (optional)";

            this.txtImagePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImagePath.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtImagePath.Location = new System.Drawing.Point(30, 497);
            this.txtImagePath.Size = new System.Drawing.Size(420, 28);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.ReadOnly = true;

            this.btnBrowseImage.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.btnBrowseImage.FlatAppearance.BorderSize = 1;
            this.btnBrowseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowseImage.Location = new System.Drawing.Point(455, 497);
            this.btnBrowseImage.Size = new System.Drawing.Size(80, 28);
            this.btnBrowseImage.Text = "Browse";
            this.btnBrowseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);

            // Error
            this.lblError.AutoSize = false;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(30, 535);
            this.lblError.Size = new System.Drawing.Size(530, 20);
            this.lblError.Name = "lblError";
            this.lblError.Text = "";

            // Buttons
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(8, 80, 65);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(30, 563);
            this.btnSave.Size = new System.Drawing.Size(250, 40);
            this.btnSave.Text = "Save Product";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(295, 563);
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // AddProduct Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(620, 680);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Product";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.panelTop.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.ComboBox cmbAvailability;
        private System.Windows.Forms.Label lblImagePath;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}