using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace RestaurantPOS
{
    public partial class OrderForm : UserControl
    {
        private decimal totalOrderCost = 0;
        private readonly int tableNumber;
        public string userName;
        public event EventHandler BackButtonClicked2;
        public OrderForm(int tableNumber, string username)
        {
            InitializeComponent();
            this.tableNumber = tableNumber;
            this.userName = username;
        }
        public string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }
        private void LoadProducts(string query)
        {
            flowLayoutPanel1.Controls.Clear();
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int productId = reader.GetInt32(0);
                    string productName = reader.GetString(1);
                    decimal productPrice = reader.GetDecimal(2);
                    Console.WriteLine($"{productName} {productPrice}");
                    Button productButton = new Button
                    {
                        Text = $"{productName}\n{productPrice:F2}€",
                        Tag = productId,
                        Size = new Size(150, 100),
                        AutoSize = false,
                        ForeColor = Color.White,
                        BackColor = Color.ForestGreen,
                        FlatStyle = FlatStyle.Flat
                    };
                    productButton.FlatAppearance.BorderSize = 0;
                    productButton.Font = new Font("Artifakt Element", 14, FontStyle.Regular);
                    productButton.Click += ProductButton_Click;
                    flowLayoutPanel1.Controls.Add(productButton);
                }
            }
        }
        private void ProductButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                int productId = (int)clickedButton.Tag;
                string productName = clickedButton.Text.Split('\n')[0];
                decimal productPrice = decimal.Parse(clickedButton.Text.Split('\n')[1].TrimEnd('€'));
                ListViewItem existingItem = null;
                foreach (ListViewItem item in listViewOrder.Items)
                {
                    if (item.Text == productName)
                    {
                        existingItem = item;
                        break;
                    }
                }
                if (existingItem != null)
                {
                    int currentQuantity = int.Parse(existingItem.SubItems[1].Text);
                    currentQuantity++;
                    existingItem.SubItems[1].Text = currentQuantity.ToString();
                    existingItem.SubItems[2].Text = productPrice.ToString("F2");
                    existingItem.SubItems[3].Text = (currentQuantity * productPrice).ToString("F2");
                }
                else
                {
                    ListViewItem newItem = new ListViewItem(productName);
                    newItem.SubItems.Add("1");
                    newItem.SubItems.Add(productPrice.ToString("F2"));
                    newItem.SubItems.Add(productPrice.ToString("F2"));
                    listViewOrder.Items.Add(newItem);
                }
                UpdateTotalCostLabel();
            }
        }
        private void UpdateTotalCostLabel()
        {
            totalOrderCost = 0;
            foreach (ListViewItem item in listViewOrder.Items)
            {
                totalOrderCost += decimal.Parse(item.SubItems[3].Text);
            }
            lblTotalCost.Text = $"Total: {totalOrderCost:F2}€";
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT ProductID, ProductName, Price FROM Products";
            LoadProducts(query);
        }
        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            SaveOrderToDatabase();
            float totalHeight = CalculateReceiptHeight();
            PaperSize paperSize = new PaperSize("Thermall", 58, (int)totalHeight);
            printDocument1.DefaultPageSettings.PaperSize = paperSize;
            Margins margins = new Margins(8, 8, 8, 8);
            printDocument1.DefaultPageSettings.Margins = margins;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        private float CalculateReceiptHeight()
        {
            float totalHeight = 200;
            float lineHeight = 12;
            totalHeight += listViewOrder.Items.Count * lineHeight * 2;
            totalHeight += lineHeight * 5;
            return totalHeight;
        }
        private void PrintReceipt(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float y = e.MarginBounds.Top;
            Font printFont = new Font("Cascadia Code", 9);
            Font boldFont = new Font("Cascadia Code", 9, FontStyle.Bold);
            Font titleFont = new Font("Cascadia Code", 11, FontStyle.Bold);
            float lineHeight = printFont.GetHeight(e.Graphics);
            Image logo = Image.FromFile("C:\\Users\\alban\\OneDrive\\Documents\\Visual Studio 2022\\RestaurantPOS\\icon.ico");
            int logoWidth = 70;
            int logoHeight = 70;
            float logoX = e.MarginBounds.Left + (e.MarginBounds.Width - logoWidth) / 2;
            g.DrawImage(logo, logoX, y, logoWidth, logoHeight);
            y += logoHeight + lineHeight;
            float CenterText(string text, Font font, PrintPageEventArgs args)
            {
                SizeF textSize = g.MeasureString(text, font);
                return args.MarginBounds.Left + (args.MarginBounds.Width - textSize.Width) / 2;
            }
            string companyName = "\"Restaurant POS\" SH.P.K.";
            string rruga = "RRUGA ADRIATIKU";
            string qyteti = "MITROVICË";
            string fiscalNumber = "NR. FISKAL: XXXXXXXXX";
            string vatNumber = "NR. TVSH: XXXXXXXXX";
            g.DrawString(companyName, titleFont, Brushes.Black, CenterText(companyName, titleFont, e), y);
            y += lineHeight * 2;
            g.DrawString(rruga, printFont, Brushes.Black, CenterText(rruga, printFont, e), y);
            y += lineHeight;
            g.DrawString(qyteti, printFont, Brushes.Black, CenterText(qyteti, printFont, e), y);
            y += lineHeight * 2;
            g.DrawString(fiscalNumber, boldFont, Brushes.Black, CenterText(fiscalNumber, boldFont, e), y);
            y += lineHeight;
            g.DrawString(vatNumber, boldFont, Brushes.Black, CenterText(vatNumber, boldFont, e), y);
            y += lineHeight * 2;
            g.DrawString($"Table: {tableNumber}", boldFont, Brushes.Black, e.MarginBounds.Left, y);
            g.DrawString($"Waiter: {userName}", boldFont, Brushes.Black, e.MarginBounds.Right - 100, y);
            y += lineHeight * 2;
            foreach (ListViewItem item in listViewOrder.Items)
            {
                string productName = item.SubItems[0].Text;
                string quantity = item.SubItems[1].Text;
                string price = item.SubItems[2].Text;
                string subtotal = item.SubItems[3].Text;
                g.DrawString(productName, printFont, Brushes.Black, e.MarginBounds.Left, y);
                SizeF quantitySize = g.MeasureString(quantity, printFont);
                SizeF priceSize = g.MeasureString(price, printFont);
                SizeF quantityPrice = g.MeasureString($"{quantity} x {price}€", printFont);
                float quantityX = e.MarginBounds.Right - quantityPrice.Width;
                float priceX = e.MarginBounds.Right - priceSize.Width;
                float startX = e.MarginBounds.Left + g.MeasureString(productName, printFont).Width;
                float endX = quantityX - 10;
                float dotSpacing = 3;
                for (float x = startX; x < endX; x += dotSpacing)
                {
                    g.DrawString(".", printFont, Brushes.Black, x, y);
                }
                g.DrawString($"{quantity} x {price}€", printFont, Brushes.Black, quantityX, y);
                y += lineHeight;
                string subtotalText = $"Nentotali: {subtotal:F2}€";
                float subtotalX = e.MarginBounds.Right - g.MeasureString(subtotalText, printFont).Width;
                g.DrawString(subtotalText, printFont, Brushes.Black, subtotalX, y);
                y += lineHeight;
            }
            y += lineHeight;
            g.DrawLine(Pens.Black, e.MarginBounds.Left, y, e.MarginBounds.Right, y);
            y += lineHeight;
            string totalCost = $"{totalOrderCost:F2}€";
            string tax = "TVSH E=18,00%";
            string taxAmount = $"{totalOrderCost * 0.18M:F2}€";
            string totalWithoutTax = $"{totalOrderCost * 0.82M:F2}€";
            g.DrawString("TOTALI NE EURO", boldFont, Brushes.Black, e.MarginBounds.Left, y);
            SizeF totalCostSize = g.MeasureString(totalCost, printFont);
            float totalCostX = e.MarginBounds.Right - totalCostSize.Width;
            for (float x = e.MarginBounds.Left + g.MeasureString("TOTALI NE EURO", boldFont).Width; x < totalCostX - 10; x += 3)
            {
                g.DrawString(".", printFont, Brushes.Black, x, y);
            }
            g.DrawString(totalCost, printFont, Brushes.Black, totalCostX, y);
            y += lineHeight;
            g.DrawString(tax, printFont, Brushes.Black, e.MarginBounds.Left, y);
            SizeF taxAmountSize = g.MeasureString(taxAmount, printFont);
            float taxAmountX = e.MarginBounds.Right - taxAmountSize.Width;
            for (float x = e.MarginBounds.Left + g.MeasureString(tax, printFont).Width; x < taxAmountX - 10; x += 3)
            {
                g.DrawString(".", printFont, Brushes.Black, x, y);
            }
            g.DrawString(taxAmount, printFont, Brushes.Black, taxAmountX, y);
            y += lineHeight;
            g.DrawString("TOT. PA TVSH:", printFont, Brushes.Black, e.MarginBounds.Left, y);
            SizeF totalWithoutTaxSize = g.MeasureString(totalWithoutTax, printFont);
            float totalWithoutTaxX = e.MarginBounds.Right - totalWithoutTaxSize.Width;
            for (float x = e.MarginBounds.Left + g.MeasureString("TOT. PA TVSH:", printFont).Width; x < totalWithoutTaxX - 10; x += 3)
            {
                g.DrawString(".", printFont, Brushes.Black, x, y);
            }
            g.DrawString(totalWithoutTax, printFont, Brushes.Black, totalWithoutTaxX, y);
            y += lineHeight * 3;
            string dateTime = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            string articleInfo = $"ARTIKUJT: {listViewOrder.Items.Count}";
            string serialNumber = "XXXXXXXX";
            string uniqueCode = "NR. SERIK: XXXXXXXXXX";
            g.DrawString(articleInfo, printFont, Brushes.Black, CenterText(articleInfo, printFont, e), y);
            y += lineHeight;
            g.DrawString(dateTime, printFont, Brushes.Black, CenterText(dateTime, printFont, e), y);
            y += lineHeight * 2;
            g.DrawString(serialNumber, printFont, Brushes.Black, CenterText(serialNumber, printFont, e), y);
            y += lineHeight;
            g.DrawString(uniqueCode, printFont, Brushes.Black, CenterText(uniqueCode, printFont, e), y);
            y += lineHeight * 2;
            string fiscalText = "KUPON FISKAL NR. XXXX";
            string rksMef = "RKS MEF";
            g.DrawString(fiscalText, boldFont, Brushes.Black, CenterText(fiscalText, boldFont, e), y);
            y += lineHeight;
            g.DrawString(rksMef, boldFont, Brushes.Black, CenterText(rksMef, boldFont, e), y);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            BackButtonClicked2?.Invoke(this, EventArgs.Empty);
        }
        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            listViewOrder.Items.Clear();
            lblTotalCost.Text = $"Total: 0.00€";
            totalOrderCost = 0;
        }
        private void listViewOrder_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewOrder.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewOrder.SelectedItems[0];
                int currentQuantity = int.Parse(selectedItem.SubItems[1].Text);
                if (currentQuantity > 1)
                {
                    currentQuantity--;
                    selectedItem.SubItems[1].Text = currentQuantity.ToString();
                    decimal unitPrice = decimal.Parse(selectedItem.SubItems[2].Text);
                    selectedItem.SubItems[3].Text = (currentQuantity * unitPrice).ToString("F2");
                }
                else
                {
                    listViewOrder.Items.Remove(selectedItem);
                }
                UpdateTotalCostLabel();
            }
        }
        private void btnAllProducts_Click(object sender, EventArgs e)
        {
            string query = "SELECT ProductID, ProductName, Price FROM Products";
            LoadProducts(query);
        }
        private void btnCoffee_Click(object sender, EventArgs e)
        {
            string query = "SELECT ProductID, ProductName, Price FROM Products where CategoryID = 1";
            LoadProducts(query);
        }
        private void btnColdDrinks_Click(object sender, EventArgs e)
        {
            string query = "SELECT ProductID, ProductName, Price FROM Products where CategoryID = 2";
            LoadProducts(query);
        }
        private void btnJuices_Click(object sender, EventArgs e)
        {
            string query = "SELECT ProductID, ProductName, Price FROM Products where CategoryID = 3";
            LoadProducts(query);
        }
        private void btnDesserts_Click(object sender, EventArgs e)
        {
            string query = "SELECT ProductID, ProductName, Price FROM Products where CategoryID = 4";
            LoadProducts(query);
        }
        private void btnIceCream_Click(object sender, EventArgs e)
        {
            string query = "SELECT ProductID, ProductName, Price FROM Products where CategoryID = 5";
            LoadProducts(query);
        }
        private void btnGrilledFood_Click(object sender, EventArgs e)
        {
            string query = "SELECT ProductID, ProductName, Price FROM Products where CategoryID = 6";
            LoadProducts(query);
        }
        private void btnFish_Click(object sender, EventArgs e)
        {
            string query = "SELECT ProductID, ProductName, Price FROM Products where CategoryID = 7";
            LoadProducts(query);
        }
        private void btnPizza_Click(object sender, EventArgs e)
        {
            string query = "SELECT ProductID, ProductName, Price FROM Products where CategoryID = 8";
            LoadProducts(query);
        }
        private void btnSalad_Click(object sender, EventArgs e)
        {
            string query = "SELECT ProductID, ProductName, Price FROM Products where CategoryID = 10";
            LoadProducts(query);
        }
        private void btnRisotto_Click(object sender, EventArgs e)
        {
            string query = "SELECT ProductID, ProductName, Price FROM Products where CategoryID = 11";
            LoadProducts(query);
        }
        private void btnPasta_Click(object sender, EventArgs e)
        {
            string query = "SELECT ProductID, ProductName, Price FROM Products where CategoryID = 12";
            LoadProducts(query);
        }
        private void SaveOrderToDatabase()
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand orderCommand = new SqlCommand(
                    "INSERT INTO Orders (TableNumber, TotalPrice, Username, OrderDate) VALUES (@TableNumber, @TotalPrice, @Username, @OrderDate); SELECT SCOPE_IDENTITY();", connection))
                {
                    orderCommand.Parameters.AddWithValue("@TableNumber", tableNumber);
                    orderCommand.Parameters.AddWithValue("@TotalPrice", totalOrderCost);
                    orderCommand.Parameters.AddWithValue("@Username", userName);
                    orderCommand.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                    int orderId = Convert.ToInt32(orderCommand.ExecuteScalar());
                    if (orderId > 0)
                    {
                        foreach (ListViewItem item in listViewOrder.Items)
                        {
                            string productName = item.SubItems[0].Text;
                            int quantity = int.Parse(item.SubItems[1].Text);
                            decimal unitPrice = decimal.Parse(item.SubItems[2].Text);
                            decimal subtotal = decimal.Parse(item.SubItems[3].Text);
                            using (SqlCommand itemCommand = new SqlCommand(
                                "INSERT INTO OrderItems (OrderID, ProductID, Quantity, UnitPrice, Subtotal) VALUES (@OrderID, @ProductID, @Quantity, @UnitPrice, @Subtotal)", connection))
                            {
                                itemCommand.Parameters.AddWithValue("@OrderID", orderId);
                                itemCommand.Parameters.AddWithValue("@ProductID", GetProductIdByName(productName));
                                itemCommand.Parameters.AddWithValue("@Quantity", quantity);
                                itemCommand.Parameters.AddWithValue("@UnitPrice", unitPrice);
                                itemCommand.Parameters.AddWithValue("@Subtotal", subtotal);
                                itemCommand.ExecuteNonQuery();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve OrderID.");
                    }
                }
            }
        }
        private int GetProductIdByName(string productName)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();
                string query = "SELECT ProductID FROM Products WHERE ProductName = @ProductName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", productName);
                    return (int)command.ExecuteScalar();
                }
            }
        }
    }
}