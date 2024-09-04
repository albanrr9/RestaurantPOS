using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace RestaurantPOS
{
    public partial class UserManagment : UserControl
    {
        public event EventHandler BackButtonClicked;
        public UserManagment()
        {
            InitializeComponent();
            CenterPanel();
        }
        public string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        private void CenterPanel()
        {
            int x = (this.ClientSize.Width - groupBox1.Width) / 2;
            int y = (this.ClientSize.Height - groupBox1.Height) / 2;
            groupBox1.Location = new System.Drawing.Point(x, y);
            txtUsername.Focus();
        }
        private void UserManagment_Load(object sender, EventArgs e)
        {
            CenterPanel();
        }
        private void UserManagment_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string result = AuthenticateAdminUser(username, password);
            if (result == "Login successful")
            {
                UserManagment2 userManagment2 = new UserManagment2();
                userManagment2.BackButtonClicked += UserManagment2_BackButtonClicked;
                LoadUserControl(userManagment2);
            }
        }
        public string AuthenticateAdminUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                string query = "SELECT PasswordHash, AdminRights FROM Users WHERE Username = @username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string storedHash = reader["PasswordHash"].ToString();
                    string enteredHash = HashPassword(password);
                    bool isAdmin = Convert.ToBoolean(reader["AdminRights"]);
                    if (storedHash == enteredHash)
                    {
                        if (isAdmin)
                        {
                            label3.Text = "Login successful";
                            label3.ForeColor = System.Drawing.Color.Green;
                            return "Login successful";
                        }
                        else
                        {
                            label3.Text = "Your access is limited";
                            label3.ForeColor = System.Drawing.Color.Red;
                            return "Your access is limited";
                        }
                    }
                    else
                    {
                        label3.Text = "Invalid credentials";
                        label3.ForeColor = System.Drawing.Color.Red;
                        return "Invalid credentials";
                    }
                }
                label3.Text = "Invalid credentials";
                label3.ForeColor = System.Drawing.Color.Red;
                return "Invalid credentials";
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
        private void UserManagment2_BackButtonClicked(object sender, EventArgs e)
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
    }
}