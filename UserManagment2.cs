using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace RestaurantPOS
{
    public partial class UserManagment2 : UserControl
    {
        public event EventHandler BackButtonClicked; 
        string connectionString = "Data Source=DESKTOP-D87KK1G; Initial Catalog=RestaurantPOS; Integrated Security=True;";
        public UserManagment2()
        {
            InitializeComponent();
            CenterPanel();
            LoadData();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        private void LoadData()
        {
            string query = "SELECT * FROM Users";
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
        private void CenterPanel()
        {
            int x = (this.ClientSize.Width - groupBox1.Width) / 2;
            int y = (this.ClientSize.Height - groupBox1.Height) / 2;
            groupBox1.Location = new System.Drawing.Point(x, y);
            txtUsername.Focus();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                txtUsername.Text = selectedRow.Cells["Username"].Value.ToString();
                txtPassword.Text = selectedRow.Cells["PasswordHash"].Value.ToString();
                chkAdmin.Checked = Convert.ToBoolean(selectedRow.Cells["AdminRights"].Value);
            }
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            bool isAdmin = chkAdmin.Checked;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (IsUsernameTaken(username))
            {
                MessageBox.Show("This username is already taken. Please choose a different one.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string hashedPassword = HashPassword(password);
            string insertQuery = "INSERT INTO Users (Username, PasswordHash, AdminRights) VALUES (@Username, @Password, @AdminRights)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", hashedPassword);
                command.Parameters.AddWithValue("@AdminRights", isAdmin);
                connection.Open();
                int result = command.ExecuteNonQuery();
                connection.Close();
                if (result > 0)
                {
                    MessageBox.Show("User added successfully!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Error adding user.");
                }
            }
        }
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            string currentUsername = txtUsername.Text.Trim();
            string newPassword = txtPassword.Text.Trim();
            bool isAdmin = chkAdmin.Checked;
            if (string.IsNullOrWhiteSpace(currentUsername))
            {
                MessageBox.Show("Please select a user to update.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Please enter a new password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string hashedPassword = HashPassword(newPassword);
            string updateQuery = "UPDATE Users SET PasswordHash = @Password, AdminRights = @AdminRights WHERE Username = @Username";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@Password", hashedPassword);
                command.Parameters.AddWithValue("@AdminRights", isAdmin);
                command.Parameters.AddWithValue("@Username", currentUsername);
                connection.Open();
                int result = command.ExecuteNonQuery();
                connection.Close();
                if (result > 0)
                {
                    MessageBox.Show("User updated successfully!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Error updating user. User may not exist.");
                }
            }
        }
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please select a user to delete.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the user '{username}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            string deleteQuery = "DELETE FROM Users WHERE Username = @Username";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                connection.Open();
                int result1 = command.ExecuteNonQuery();
                connection.Close();
                if (result1 > 0)
                {
                    MessageBox.Show("User deleted successfully!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Error deleting user. User may not exist.");
                }
            }
        }
        private bool IsUsernameTaken(string username)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                connection.Close();
                return count > 0;
            }
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private void UserManagment2_Load(object sender, EventArgs e)
        {
            CenterPanel();
        }
        private void UserManagment2_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }
    }
}