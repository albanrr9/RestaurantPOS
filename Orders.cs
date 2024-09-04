using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace RestaurantPOS
{
    public partial class UserControl1 : UserControl
    {
        public event EventHandler BackButtonClicked;
        public UserControl1()
        {
            InitializeComponent();
            CenterPanel();
        }
        public string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            CenterPanel();
        }
        private void UserControl1_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }
        private void CenterPanel()
        {
            int x = (this.ClientSize.Width - groupBox1.Width) / 2;
            int y = (this.ClientSize.Height - groupBox1.Height) / 2;
            groupBox1.Location = new System.Drawing.Point(x, y);
            txtUsername.Focus();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool result = AuthenticateUser(username, password);
            if (result)
            {
                OrdersTablePage ordersTablePage = new OrdersTablePage(username);
                ordersTablePage.BackButtonClicked1 += OrdersTablePage_BackButtonClicked;
                LoadUserControl(ordersTablePage);
            }
        }
        private void OrdersTablePage_BackButtonClicked(object sender, EventArgs e)
        {
            this.panel1.Dock = DockStyle.None;
        }
        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLogin.PerformClick();
            }
        }
        public bool AuthenticateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
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
                        return true;
                    }
                }

                label3.Text = "Authentication failed";
                return false;
            }
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
        private void LoadUserControl(UserControl userControl)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(userControl);
            this.panel1.Dock = DockStyle.Fill;
            userControl.Dock = DockStyle.Fill;
        }
    }
}