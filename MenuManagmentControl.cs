using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RestaurantPOS
{
    public partial class MenuManagmentControl : UserControl
    {
        public event EventHandler BackButtonClicked; 
        public MenuManagmentControl()
        {
            InitializeComponent();
            LoadData();
            LoadCategories();
        }
        public string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        public void LoadData()
        {
            string query = "SELECT * FROM Products";
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                connection.Open();
                dataAdapter.Fill(dataTable);
                connection.Close();
                dataGridView1.DataSource = dataTable;
            }
        }
        private List<Category> GetCategoriesFromDatabase()
        {
            List<Category> categories = new List<Category>();
            string query = "SELECT CategoryID, CategoryName FROM Categories";
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    categories.Add(new Category
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1)
                    });
                }
            }
            return categories;
        }
        private void LoadCategories()
        {
            List<Category> categories = GetCategoriesFromDatabase();
            comboBoxCategory.DataSource = categories;
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "Id";
        }
        public bool IsProductInDatabase(string productName)
        {
            string query = "SELECT COUNT(*) FROM Products WHERE ProductName = @ProductName";
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProductName", productName);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                connection.Close();
                return count > 0;
            }
        }
        public void btnAddProduct_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text.Trim();
            string priceText = txtPrice.Text.Trim();
            if (comboBoxCategory.SelectedValue == null || !int.TryParse(comboBoxCategory.SelectedValue.ToString(), out int categoryId))
            {
                MessageBox.Show("Please select a valid category.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(productName) || string.IsNullOrWhiteSpace(priceText) || !decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("Please fill in all fields correctly.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (IsProductInDatabase(productName))
            {
                MessageBox.Show("This product is already registered. Please check again.", "Duplicate Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string insertQuery = "INSERT INTO Products (ProductName, Price, CategoryID) VALUES (@ProductName, @Price, @CategoryID)";
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@ProductName", productName);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@CategoryID", categoryId);
                connection.Open();
                int result = command.ExecuteNonQuery();
                connection.Close();
                if (result > 0)
                {
                    MessageBox.Show("Product added successfully!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Error adding product.");
                }
            }
        }
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            string currentProduct = txtProductName.Text.Trim();
            string newPrice = txtPrice.Text.Trim();
            if (comboBoxCategory.SelectedValue == null || !int.TryParse(comboBoxCategory.SelectedValue.ToString(), out int categoryId))
            {
                MessageBox.Show("Please select a valid category.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(currentProduct) || string.IsNullOrWhiteSpace(newPrice) || !decimal.TryParse(newPrice, out decimal price))
            {
                MessageBox.Show("Please fill in all fields correctly.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string updateQuery = "UPDATE Products SET Price = @Price, CategoryID = @CategoryID WHERE ProductName = @ProductName";
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@CategoryID", categoryId);
                command.Parameters.AddWithValue("@ProductName", currentProduct);
                connection.Open();
                int result = command.ExecuteNonQuery();
                connection.Close();
                if (result > 0)
                {
                    MessageBox.Show("Product updated successfully!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Error updating product. Product may not exist.");
                }
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                txtProductName.Text = selectedRow.Cells["ProductName"].Value.ToString();
                txtPrice.Text = selectedRow.Cells["Price"].Value.ToString();
            }
        }
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            string product = txtProductName.Text.Trim();
            if (string.IsNullOrWhiteSpace(product))
            {
                MessageBox.Show("Please select a product to delete.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the user '{product}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            string deleteQuery = "DELETE FROM Products WHERE ProductName = @Product";
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@Product", product);
                connection.Open();
                int result1 = command.ExecuteNonQuery();
                connection.Close();
                if (result1 > 0)
                {
                    MessageBox.Show("Product deleted successfully!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Error deleting product. Product may not exist.");
                }
            }
        }
    }
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}