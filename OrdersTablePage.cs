using System;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantPOS
{
    public partial class OrdersTablePage : UserControl
    {
        public event EventHandler BackButtonClicked1;
        public string table = "";
        public string userName;
        public OrdersTablePage(string username)
        {
            InitializeComponent();
            CenterPanel();
            InitializeTableButtons();
            this.userName = username;
        }
        private void OrdersTablePage_Load(object sender, EventArgs e)
        {
            CenterPanel();
        }
        private void OrdersTablePage_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }
        private void CenterPanel()
        {
            int x = (this.ClientSize.Width - panel1.Width) / 2;
            int y = (this.ClientSize.Height - panel1.Height) / 2;
            panel1.Location = new System.Drawing.Point(x, y);
        }
        private void InitializeTableButtons()
        {
            for (int i = 1; i <= 49; i++)
            {
                Button tableButton = this.Controls.Find("table" + i, true).FirstOrDefault() as Button;

                if (tableButton != null)
                {
                    tableButton.Click += new EventHandler(Table_Click);
                }
                else
                {
                    MessageBox.Show("Button table" + i + " not found!");
                }
            }
        }
        private void Table_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonText = clickedButton.Text;
                string tableNumberString = buttonText.Split(' ')[1];
                int tableNumber = int.Parse(tableNumberString);
                OrderForm orderForm = new OrderForm(tableNumber, userName);
                orderForm.BackButtonClicked2 += OrderForm_BackButtonClicked;
                LoadUserControl(orderForm);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            BackButtonClicked1?.Invoke(this, EventArgs.Empty);
        }
        private void OrderForm_BackButtonClicked(object sender, EventArgs e)
        {
            this.panel2.Dock = DockStyle.None;
        }
        private void LoadUserControl(UserControl userControl)
        {
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(userControl);
            this.panel2.Dock = DockStyle.Fill;
            userControl.Dock = DockStyle.Fill;
        }
    }
}