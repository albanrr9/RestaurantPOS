using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace RestaurantPOS
{
    public partial class Reports : UserControl
    {
        public EventHandler BackButtonClicked;
        string query = @"
            SELECT Orders.OrderID, Orders.OrderDate, SUM(OrderItems.UnitPrice * OrderItems.Quantity) AS TotalPrice, Users.Username AS Username
            FROM Orders 
            JOIN OrderItems ON Orders.OrderID = OrderItems.OrderID
            JOIN Users ON Orders.Username = Users.Username
            WHERE Orders.Username = @WaiterID AND Orders.OrderDate BETWEEN @StartDate AND @EndDate
            GROUP BY Orders.OrderID, Orders.OrderDate, Users.Username";
        public Reports()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        private void Reports_Load(object sender, EventArgs e)
        {
            LoadWaiters();
            CenterPanel();
        }
        public string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }
        private void LoadWaiters()
        {
            List<Waiters> waiters = GetWaiters();
            cmbUsers.DataSource = waiters;
            cmbUsers.DisplayMember = "Name";
            cmbUsers.ValueMember = "Id";
        }
        private List<Waiters> GetWaiters()
        {
            List<Waiters> waiters = new List<Waiters>();
            string query = "SELECT ID, Username FROM Users";
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    waiters.Add(new Waiters
                    {
                        Id = reader.GetDecimal(0),
                        Name = reader.GetString(1)
                    });
                }
            }
            return waiters;
        }
        private void FilterSalesReportByWaiter(string query, string waiter, DateTime startDate, DateTime endDate)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@WaiterID", waiter);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewReport.DataSource = dataTable;
            }
        }
        private void btnToday_Click(object sender, EventArgs e)
        {
            Waiters selectedWaiter = cmbUsers.SelectedItem as Waiters;
            string waiterName = selectedWaiter.Name;
            Console.WriteLine(waiterName);
            if (waiterName == null)
            {
                MessageBox.Show("Please select a waiter.");
                return;
            }
            DateTime startDate = DateTime.Today;
            DateTime endDate = DateTime.Today.AddDays(1);
            FilterSalesReportByWaiter(query, waiterName, startDate, endDate);
        }
        private void btnYesterday_Click(object sender, EventArgs e)
        {
            Waiters selectedWaiter = cmbUsers.SelectedItem as Waiters;
            string waiterName = selectedWaiter.Name;
            Console.WriteLine(waiterName);
            if (waiterName == null)
            {
                MessageBox.Show("Please select a waiter.");
                return;
            }
            DateTime startDate = DateTime.Today.AddDays(-1);
            DateTime endDate = DateTime.Today;
            FilterSalesReportByWaiter(query, waiterName, startDate, endDate);
        }
        private void btnThisWeek_Click(object sender, EventArgs e)
        {
            Waiters selectedWaiter = cmbUsers.SelectedItem as Waiters;
            string waiterName = selectedWaiter.Name;
            Console.WriteLine(waiterName);
            if (waiterName == null)
            {
                MessageBox.Show("Please select a waiter.");
                return;
            }
            DayOfWeek currentDay = DateTime.Today.DayOfWeek;
            int daysToMonday = currentDay == DayOfWeek.Sunday ? 6 : (int)currentDay - (int)DayOfWeek.Monday;
            DateTime startOfWeek = DateTime.Today.AddDays(-daysToMonday);
            FilterSalesReportByWaiter(query, waiterName, startOfWeek, startOfWeek.AddDays(6));
        }
        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnToday_Click(sender, e);
        }
        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            Waiters selectedWaiter = cmbUsers.SelectedItem as Waiters;
            string waiterName = selectedWaiter.Name;
            Console.WriteLine(waiterName);
            if (waiterName == null)
            {
                MessageBox.Show("Please select a waiter.");
                return;
            }
            DateTime startOfMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);
            FilterSalesReportByWaiter(query, waiterName, startOfMonth, endOfMonth);
        }

        private void btnLastMonth_Click(object sender, EventArgs e)
        {
            Waiters selectedWaiter = cmbUsers.SelectedItem as Waiters;
            string waiterName = selectedWaiter.Name;
            Console.WriteLine(waiterName);
            if (waiterName == null)
            {
                MessageBox.Show("Please select a waiter.");
                return;
            }
            DateTime startOfMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(-1);
            DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);
            FilterSalesReportByWaiter(query, waiterName, startOfMonth, endOfMonth);
        }
        private void CenterPanel()
        {
            int x = (this.ClientSize.Width - panel1.Width) / 2;
            int y = (this.ClientSize.Height - panel1.Height) / 2;
            panel1.Location = new Point(x, y);
        }
        private void Reports_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }
    }
    public class Waiters
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
    }
}