using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NeedBridge
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            try
            {
                cmbCategory.Items.Clear();
                string query = "SELECT category_id, category_name FROM Categories ORDER BY category_name";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                foreach (DataRow row in dt.Rows)
                {
                    cmbCategory.Items.Add(new CategoryItem(
                        Convert.ToInt32(row["category_id"]),
                        row["category_name"].ToString()
                    ));
                }

                if (cmbCategory.Items.Count > 0)
                    cmbCategory.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Product Image";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtImagePath.Text = ofd.FileName;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            string productName = txtProductName.Text.Trim();
            string description = txtDescription.Text.Trim();
            string priceText = txtPrice.Text.Trim();
            string discountText = txtDiscount.Text.Trim();
            string stockText = txtStock.Text.Trim();
            string imagePath = txtImagePath.Text.Trim();
            string availability = cmbAvailability.SelectedItem.ToString();

            // Validation
            if (string.IsNullOrEmpty(productName))
            {
                lblError.Text = "Product name is required."; return;
            }
            if (cmbCategory.SelectedItem == null)
            {
                lblError.Text = "Please select a category."; return;
            }
            if (string.IsNullOrEmpty(priceText))
            {
                lblError.Text = "Price is required."; return;
            }
            if (string.IsNullOrEmpty(stockText))
            {
                lblError.Text = "Stock quantity is required."; return;
            }

            decimal price, discount;
            int stock;

            if (!decimal.TryParse(priceText, out price) || price <= 0)
            {
                lblError.Text = "Please enter a valid price."; return;
            }
            if (!decimal.TryParse(discountText, out discount) || discount < 0 || discount > 100)
            {
                lblError.Text = "Discount must be between 0 and 100."; return;
            }
            if (!int.TryParse(stockText, out stock) || stock < 0)
            {
                lblError.Text = "Please enter a valid stock quantity."; return;
            }

            int categoryId = ((CategoryItem)cmbCategory.SelectedItem).Id;

            try
            {
                string query = @"
                    INSERT INTO Products 
                        (vendor_id, category_id, product_name, description, price, 
                         discount_pct, stock_qty, image_path, availability)
                    VALUES 
                        (@vendorId, @categoryId, @productName, @description, @price,
                         @discount, @stock, @imagePath, @availability)";

                SqlParameter[] parameters = {
                    new SqlParameter("@vendorId",    SessionManager.UserId),
                    new SqlParameter("@categoryId",  categoryId),
                    new SqlParameter("@productName", productName),
                    new SqlParameter("@description", description),
                    new SqlParameter("@price",       price),
                    new SqlParameter("@discount",    discount),
                    new SqlParameter("@stock",       stock),
                    new SqlParameter("@imagePath",   imagePath),
                    new SqlParameter("@availability",availability)
                };

                int rows = DatabaseHelper.ExecuteNonQuery(query, parameters);

                if (rows > 0)
                {
                    MessageBox.Show(
                        "Product added successfully!\nIt is now visible to customers.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "Error: " + ex.Message;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    // Helper class for ComboBox items
    public class CategoryItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CategoryItem(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString() { return Name; }
    }
}