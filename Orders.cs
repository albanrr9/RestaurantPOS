using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace RestaurantPOS
{
    public partial class UserControl1 : UserControl
    {
        public event EventHandler BackButtonClicked;
        public virtual string PlaceholderText { get; set; }

        public UserControl1()
        {
            InitializeComponent();
            CenterPanel();
            TextBox textBox2 = new TextBox();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void CenterPanel()
        {
            // Calculate the new position
            int x = (this.ClientSize.Width - groupBox1.Width) / 2;
            int y = (this.ClientSize.Height - groupBox1.Height) / 2;

            // Set the new position
            groupBox1.Location = new System.Drawing.Point(x, y);
            txtUsername.Focus();
        }

        private static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void UserControl1_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool result = AuthenticateUser(username, password);

            if (result)
            {
                OrdersTablePage ordersTablePage = new OrdersTablePage(username);
                ordersTablePage.BackButtonClicked += OrdersTablePage_BackButtonClicked;
                LoadUserControl(ordersTablePage);
            }
        }

        private void OrdersTablePage_BackButtonClicked(object sender, EventArgs e)
        {
            this.panel1.Dock = DockStyle.None;
        }

        public bool AuthenticateUser(string username, string password)
        {
            // Replace with your actual database connection string
            string connectionString = "Data Source=DESKTOP-D87KK1G; Initial Catalog=RestaurantPOS; Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT PasswordHash FROM Users WHERE Username = @username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string storedHash = reader["PasswordHash"].ToString();
                    string enteredHash = HashPassword(password);

                    if (storedHash == enteredHash)
                    {
                        label3.Text = "Authentication Successful";
                        return true; // Authentication successful
                    }
                }

                label3.Text = "Authentication failed";
                return false; // Authentication failed
            }
        }

        private void LoadUserControl(UserControl userControl)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(userControl);
            this.panel1.Dock = DockStyle.Fill;
            userControl.Dock = DockStyle.Fill;
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevent the default "ding" sound
                txtPassword.Focus();   // Move focus to the PasswordTextBox
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevent the default "ding" sound
                btnLogin.PerformClick(); // Trigger the LoginButton click event
            }
        }
    }
}
