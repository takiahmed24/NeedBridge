namespace NeedBridge
{
    partial class ProductDetails
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();

            this.panelContent = new System.Windows.Forms.Panel();

            this.panelLeft = new System.Windows.Forms.Panel();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.lblNoImage = new System.Windows.Forms.Label();

            this.panelRight = new System.Windows.Forms.Panel();

            this.lblProductName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblVendor = new System.Windows.Forms.Label();

            this.lblPriceOriginal = new System.Windows.Forms.Label();
            this.lblPriceFinal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();

            this.lblStock = new System.Windows.Forms.Label();
            this.lblAvailability = new System.Windows.Forms.Label();

            this.lblDescTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();

            this.lblSeparator = new System.Windows.Forms.Label();

            this.lblQtyLabel = new System.Windows.Forms.Label();
            this.numQty = new System.Windows.Forms.NumericUpDown();

            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnBuyNow = new System.Windows.Forms.Button();

            this.lblReviewTitle = new System.Windows.Forms.Label();
            this.dgvReviews = new System.Windows.Forms.DataGridView();

            this.btnWriteReview = new System.Windows.Forms.Button();

            // panelTop
            this.panelTop.SuspendLayout();

            // panelContent
            this.panelContent.SuspendLayout();

            // panelLeft
            this.panelLeft.SuspendLayout();

            // pic
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();

            // panelRight
            this.panelRight.SuspendLayout();

            // numeric
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();

            // dgv
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).BeginInit();

            this.SuspendLayout();

            // =========================================================
            // panelTop
            // =========================================================

            this.panelTop.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1000, 55);
            this.panelTop.TabIndex = 0;

            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.btnClose);

            // =========================================================
            // lblTitle
            // =========================================================

            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 30);
            this.lblTitle.Text = "Product Details";

            // =========================================================
            // btnClose
            // =========================================================

            this.btnClose.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(890, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 32);
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // =========================================================
            // panelContent
            // =========================================================

            this.panelContent.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 55);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1000, 625);

            this.panelContent.Controls.Add(this.panelRight);
            this.panelContent.Controls.Add(this.panelLeft);

            // =========================================================
            // panelLeft
            // =========================================================

            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Width = 300;
            this.panelLeft.Padding = new System.Windows.Forms.Padding(20);

            this.panelLeft.Controls.Add(this.picProduct);
            this.panelLeft.Controls.Add(this.lblNoImage);

            // =========================================================
            // picProduct
            // =========================================================

            this.picProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picProduct.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.Name = "picProduct";

            // =========================================================
            // lblNoImage
            // =========================================================

            this.lblNoImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoImage.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNoImage.ForeColor = System.Drawing.Color.Gray;
            this.lblNoImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoImage.Text = "No Image Available";
            this.lblNoImage.Name = "lblNoImage";

            // =========================================================
            // panelRight
            // =========================================================

            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.AutoScroll = true;
            this.panelRight.Padding = new System.Windows.Forms.Padding(25, 20, 25, 20);

            this.panelRight.Controls.Add(this.lblProductName);
            this.panelRight.Controls.Add(this.lblCategory);
            this.panelRight.Controls.Add(this.lblVendor);

            this.panelRight.Controls.Add(this.lblPriceOriginal);
            this.panelRight.Controls.Add(this.lblPriceFinal);
            this.panelRight.Controls.Add(this.lblDiscount);

            this.panelRight.Controls.Add(this.lblStock);
            this.panelRight.Controls.Add(this.lblAvailability);

            this.panelRight.Controls.Add(this.lblDescTitle);
            this.panelRight.Controls.Add(this.lblDescription);

            this.panelRight.Controls.Add(this.lblSeparator);

            this.panelRight.Controls.Add(this.lblQtyLabel);
            this.panelRight.Controls.Add(this.numQty);

            this.panelRight.Controls.Add(this.btnAddToCart);
            this.panelRight.Controls.Add(this.btnBuyNow);

            this.panelRight.Controls.Add(this.lblReviewTitle);
            this.panelRight.Controls.Add(this.dgvReviews);

            this.panelRight.Controls.Add(this.btnWriteReview);

            // =========================================================
            // lblProductName
            // =========================================================

            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblProductName.ForeColor = System.Drawing.Color.Black;
            this.lblProductName.Location = new System.Drawing.Point(25, 20);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(580, 40);
            this.lblProductName.Text = "Product Name";

            // =========================================================
            // lblCategory
            // =========================================================

            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCategory.ForeColor = System.Drawing.Color.Gray;
            this.lblCategory.Location = new System.Drawing.Point(25, 70);
            this.lblCategory.Size = new System.Drawing.Size(500, 22);
            this.lblCategory.Text = "Category: Electronics";

            // =========================================================
            // lblVendor
            // =========================================================

            this.lblVendor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblVendor.ForeColor = System.Drawing.Color.Gray;
            this.lblVendor.Location = new System.Drawing.Point(25, 95);
            this.lblVendor.Size = new System.Drawing.Size(500, 22);
            this.lblVendor.Text = "Sold By: Vendor";

            // =========================================================
            // lblPriceOriginal
            // =========================================================

            this.lblPriceOriginal.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPriceOriginal.ForeColor = System.Drawing.Color.Gray;
            this.lblPriceOriginal.Location = new System.Drawing.Point(25, 135);
            this.lblPriceOriginal.Size = new System.Drawing.Size(300, 25);
            this.lblPriceOriginal.Text = "Original Price: ৳45000";

            // =========================================================
            // lblPriceFinal
            // =========================================================

            this.lblPriceFinal.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblPriceFinal.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.lblPriceFinal.Location = new System.Drawing.Point(25, 165);
            this.lblPriceFinal.Size = new System.Drawing.Size(400, 45);
            this.lblPriceFinal.Text = "৳40500";

            // =========================================================
            // lblDiscount
            // =========================================================

            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDiscount.ForeColor = System.Drawing.Color.Green;
            this.lblDiscount.Location = new System.Drawing.Point(25, 220);
            this.lblDiscount.Size = new System.Drawing.Size(100, 22);
            this.lblDiscount.Text = "10% OFF";

            // =========================================================
            // lblStock
            // =========================================================

            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStock.Location = new System.Drawing.Point(150, 220);
            this.lblStock.Size = new System.Drawing.Size(120, 22);
            this.lblStock.Text = "Stock: 20";

            // =========================================================
            // lblAvailability
            // =========================================================

            this.lblAvailability.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAvailability.ForeColor = System.Drawing.Color.Green;
            this.lblAvailability.Location = new System.Drawing.Point(300, 220);
            this.lblAvailability.Size = new System.Drawing.Size(150, 22);
            this.lblAvailability.Text = "Available";

            // =========================================================
            // lblDescTitle
            // =========================================================

            this.lblDescTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescTitle.Location = new System.Drawing.Point(25, 265);
            this.lblDescTitle.Size = new System.Drawing.Size(150, 22);
            this.lblDescTitle.Text = "Description";

            // =========================================================
            // lblDescription
            // =========================================================

            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblDescription.Location = new System.Drawing.Point(25, 295);
            this.lblDescription.Size = new System.Drawing.Size(580, 60);
            this.lblDescription.Text = "No description available.";

            // =========================================================
            // separator
            // =========================================================

            this.lblSeparator.BackColor = System.Drawing.Color.LightGray;
            this.lblSeparator.Location = new System.Drawing.Point(25, 370);
            this.lblSeparator.Size = new System.Drawing.Size(580, 1);

            // =========================================================
            // qty label
            // =========================================================

            this.lblQtyLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblQtyLabel.Location = new System.Drawing.Point(25, 390);
            this.lblQtyLabel.Size = new System.Drawing.Size(100, 22);
            this.lblQtyLabel.Text = "Quantity";

            // =========================================================
            // numQty
            // =========================================================

            this.numQty.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.numQty.Location = new System.Drawing.Point(25, 420);
            this.numQty.Minimum = 1;
            this.numQty.Maximum = 100;
            this.numQty.Value = 1;
            this.numQty.Size = new System.Drawing.Size(100, 32);

            // =========================================================
            // btnAddToCart
            // =========================================================

            this.btnAddToCart.BackColor = System.Drawing.Color.Orange;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(25, 475);
            this.btnAddToCart.Size = new System.Drawing.Size(180, 42);
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);

            // =========================================================
            // btnBuyNow
            // =========================================================

            this.btnBuyNow.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnBuyNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyNow.FlatAppearance.BorderSize = 0;
            this.btnBuyNow.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBuyNow.ForeColor = System.Drawing.Color.White;
            this.btnBuyNow.Location = new System.Drawing.Point(225, 475);
            this.btnBuyNow.Size = new System.Drawing.Size(180, 42);
            this.btnBuyNow.Text = "Buy Now";
            this.btnBuyNow.UseVisualStyleBackColor = false;
            this.btnBuyNow.Click += new System.EventHandler(this.btnBuyNow_Click);

            // =========================================================
            // review title
            // =========================================================

            this.lblReviewTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblReviewTitle.ForeColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.lblReviewTitle.Location = new System.Drawing.Point(25, 545);
            this.lblReviewTitle.Size = new System.Drawing.Size(300, 28);
            this.lblReviewTitle.Text = "Customer Reviews";

            // =========================================================
            // dgvReviews
            // =========================================================

            this.dgvReviews.AllowUserToAddRows = false;
            this.dgvReviews.AllowUserToDeleteRows = false;
            this.dgvReviews.ReadOnly = true;

            this.dgvReviews.BackgroundColor = System.Drawing.Color.White;
            this.dgvReviews.BorderStyle = System.Windows.Forms.BorderStyle.None;

            this.dgvReviews.ColumnHeadersHeight = 32;
            this.dgvReviews.EnableHeadersVisualStyles = false;

            headerStyle.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            cellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.dgvReviews.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvReviews.DefaultCellStyle = cellStyle;

            this.dgvReviews.RowTemplate.Height = 30;

            this.dgvReviews.Location = new System.Drawing.Point(25, 580);
            this.dgvReviews.Size = new System.Drawing.Size(580, 130);

            this.dgvReviews.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // =========================================================
            // btnWriteReview
            // =========================================================

            this.btnWriteReview.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.btnWriteReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWriteReview.FlatAppearance.BorderSize = 0;
            this.btnWriteReview.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnWriteReview.ForeColor = System.Drawing.Color.White;
            this.btnWriteReview.Location = new System.Drawing.Point(25, 730);
            this.btnWriteReview.Size = new System.Drawing.Size(160, 35);
            this.btnWriteReview.Text = "Write Review";
            this.btnWriteReview.UseVisualStyleBackColor = false;
            this.btnWriteReview.Click += new System.EventHandler(this.btnWriteReview_Click);

            // =========================================================
            // ProductDetails Form
            // =========================================================

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor = System.Drawing.Color.White;

            this.ClientSize = new System.Drawing.Size(1000, 680);

            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTop);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.Name = "ProductDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Details";

            this.Load += new System.EventHandler(this.ProductDetails_Load);

            // =========================================================
            // Resume
            // =========================================================

            this.panelTop.ResumeLayout(false);

            this.panelContent.ResumeLayout(false);

            this.panelLeft.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();

            this.panelRight.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).EndInit();

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;

        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Label lblNoImage;

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblVendor;

        private System.Windows.Forms.Label lblPriceOriginal;
        private System.Windows.Forms.Label lblPriceFinal;
        private System.Windows.Forms.Label lblDiscount;

        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblAvailability;

        private System.Windows.Forms.Label lblDescTitle;
        private System.Windows.Forms.Label lblDescription;

        private System.Windows.Forms.Label lblSeparator;

        private System.Windows.Forms.Label lblQtyLabel;
        private System.Windows.Forms.NumericUpDown numQty;

        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnBuyNow;

        private System.Windows.Forms.Label lblReviewTitle;
        private System.Windows.Forms.DataGridView dgvReviews;

        private System.Windows.Forms.Button btnWriteReview;
    }
}