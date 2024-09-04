using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantPOS
{

    public partial class MenuManagmentControl : UserControl
    {
        public event EventHandler BackButtonClicked; 
        string connectionString = "Data Source=DESKTOP-D87KK1G; Initial Catalog=RestaurantPOS; Integrated Security=True;";
        public MenuManagmentControl()
        {
            InitializeComponent();
            LoadData();
            LoadCategories();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        public void LoadData()
        {
            string query = "SELECT * FROM Products";

            using (SqlConnection connection = new SqlConnection(connectionString))
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

            using (SqlConnection connection = new SqlConnection(connectionString))
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
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
