using System;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantPOS
{
    public partial class OrdersTablePage : UserControl
    {
        public event EventHandler BackButtonClicked;
        public string table = "";
        public string userName;
        public OrdersTablePage(string username)
        {
            InitializeComponent();
            for (int i = 1; i <= 49; i++)
            {
                // Find the button by name
                Button tableButton = this.Controls.Find("table" + i, true).FirstOrDefault() as Button;

                if (tableButton != null)
                {
                    // Assign the Click event handler
                    tableButton.Click += new EventHandler(Table_Click);
                }
                else
                {
                    MessageBox.Show("Button table" + i + " not found!"); // Debug message if not found
                }
            }
            this.userName = username;
        }

        private void OrdersTablePage_Load(object sender, EventArgs e)
        {
            
        }

        private void Table_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button; // Or PictureBox if you're using that
            if (clickedButton != null)
            {
                string buttonText = clickedButton.Text; // e.g., "table 1"
                string tableNumberString = buttonText.Split(' ')[1]; // Splits into ["table", "1"] and takes the second part
                int tableNumber = int.Parse(tableNumberString); 
                OrderForm orderForm = new OrderForm(tableNumber, userName);
                LoadUserControl(orderForm);
            }
        }

        private void LoadUserControl(UserControl userControl)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(userControl);
            this.panel1.Dock = DockStyle.Fill;
            userControl.Dock = DockStyle.Fill;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
