using System;
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

        public OrderForm(int tableNumber, string username)
        {
            InitializeComponent();
            this.tableNumber = tableNumber;
            this.userName = username;
            this.Text = "Order - Table " + tableNumber;
        }

        private void LoadProducts(string query)
        {
            string connectionString = "Data Source=DESKTOP-D87KK1G; Initial Catalog=RestaurantPOS; Integrated Security=True;";
            flowLayoutPanel1.Controls.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int productId = reader.GetInt32(0);
                    string productName = reader.GetString(1);
                    decimal productPrice = reader.GetDecimal(2);

                    Button productButton = new Button
                    {
                        Text = $"{productName}\n${productPrice:F2}",
                        Tag = productId,
                        Size = new Size(150, 100),
                        AutoSize = false
                    };

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
                decimal productPrice = decimal.Parse(clickedButton.Text.Split('\n')[1].TrimStart('$'));

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
                    // Update quantity and subtotal if the item already exists
                    int currentQuantity = int.Parse(existingItem.SubItems[1].Text); // Assuming quantity is in the second column
                    currentQuantity++;
                    existingItem.SubItems[1].Text = currentQuantity.ToString(); // Update quantity
                    existingItem.SubItems[2].Text = productPrice.ToString("F2"); // Ensure price is correct (in case of updates)
                    existingItem.SubItems[3].Text = (currentQuantity * productPrice).ToString("F2"); // Update subtotal
                }
                else
                {
                    // Add a new item if it doesn't exist
                    ListViewItem newItem = new ListViewItem(productName);
                    newItem.SubItems.Add("1"); // Quantity
                    newItem.SubItems.Add(productPrice.ToString("F2")); // Unit Price
                    newItem.SubItems.Add(productPrice.ToString("F2")); // Subtotal (quantity 1 * unit price)
                    listViewOrder.Items.Add(newItem);
                }

                // Update total order cost
                totalOrderCost += productPrice;
                UpdateTotalCostLabel();
            }
        }

        private void UpdateTotalCostLabel()
        {
            lblTotalCost.Text = $"Total: ${totalOrderCost:F2}";
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT ProductID, ProductName, Price FROM Products";
            LoadProducts(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT ProductID, ProductName, Price FROM Products";
            LoadProducts(query);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT ProductID, ProductName, Price FROM Products where Category = 'Coffee'";
            LoadProducts(query);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "SELECT ProductID, ProductName, Price FROM Products where Category = 'Tea'";
            LoadProducts(query);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "SELECT ProductID, ProductName, Price FROM Products where Category = 'Food'";
            LoadProducts(query);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "SELECT ProductID, ProductName, Price FROM Products where Category = 'Other Drinks'";
            LoadProducts(query);
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            // Calculate the required paper height dynamically based on the content
            float totalHeight = CalculateReceiptHeight();
            PaperSize paperSize = new PaperSize("Custom", 58, (int)totalHeight); // Width: 58mm, Height: calculated dynamically
            printDocument1.DefaultPageSettings.PaperSize = paperSize;

            // Set margins in hundredths of an inch (e.g., 10 = 0.1 inch)
            Margins margins = new Margins(8, 8, 8, 8); // Left, Right, Top, Bottom margins
            printDocument1.DefaultPageSettings.Margins = margins;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                // Print the document
                printDocument1.Print();
            }
        }

        private float CalculateReceiptHeight()
        {
            // Base height for header, footer, and logo
            float totalHeight = 200; // You can adjust this base value as needed

            // Add height for each item in the ListView
            float lineHeight = 12; // Assuming each line height is 12 pixels
            totalHeight += listViewOrder.Items.Count * lineHeight * 2; // Each item has two lines (product and subtotal)

            // Add additional height for totals and tax section
            totalHeight += lineHeight * 5; // Adjust this value if you have more lines in the totals section

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

            // Helper function to center text
            float CenterText(string text, Font font, PrintPageEventArgs args)
            {
                SizeF textSize = g.MeasureString(text, font);
                return args.MarginBounds.Left + (args.MarginBounds.Width - textSize.Width) / 2;
            }

            // Header
            string companyName = "\"Restaurant POS\" SH.P.K.";
            string rruga = "RRUGA ADRIATIKU";
            string qyteti = "MITROVICË";
            string fiscalNumber = "NR. FISKAL: XXXXXXXXX";
            string vatNumber = "NR. TVSH: XXXXXXXXX";

            // Center and print each line
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

            g.DrawString(userName, printFont, Brushes.Black, e.MarginBounds.Left, y);
            y += lineHeight * 2;

            // Iterate through the items in the ListView
            foreach (ListViewItem item in listViewOrder.Items)
            {
                string productName = item.SubItems[0].Text;
                string quantity = item.SubItems[1].Text;
                string price = item.SubItems[2].Text;
                string subtotal = item.SubItems[3].Text;

                // Left-align product name
                g.DrawString(productName, printFont, Brushes.Black, e.MarginBounds.Left, y);

                // Calculate the position for the quantity and price
                SizeF quantitySize = g.MeasureString(quantity, printFont);
                SizeF priceSize = g.MeasureString(price, printFont);
                SizeF quantityPrice = g.MeasureString($"{quantity} x {price}€", printFont);

                float quantityX = e.MarginBounds.Right - quantityPrice.Width; // Offset for spacing
                float priceX = e.MarginBounds.Right - priceSize.Width;

                // Draw dotted line
                float startX = e.MarginBounds.Left + g.MeasureString(productName, printFont).Width + 5;
                float endX = quantityX - 15; // Leave some space before quantity
                float dotSpacing = 3; // Adjust spacing between dots

                for (float x = startX; x < endX; x += dotSpacing)
                {
                    g.DrawString(".", printFont, Brushes.Black, x, y);
                }

                // Draw the quantity and price
                g.DrawString($"{quantity} x {price}€", printFont, Brushes.Black, quantityX, y);

                y += lineHeight;

                // Draw subtotal on the next line, aligned to the right
                string subtotalText = $"Nentotali: {subtotal:F2}€";
                float subtotalX = e.MarginBounds.Right - g.MeasureString(subtotalText, printFont).Width;
                g.DrawString(subtotalText, printFont, Brushes.Black, subtotalX, y);

                y += lineHeight;
            }

            // Separator line
            y += lineHeight;
            g.DrawLine(Pens.Black, e.MarginBounds.Left, y, e.MarginBounds.Right, y);
            y += lineHeight;

            // Total cost section
            string totalCost = $"{totalOrderCost:F2}€";
            string tax = "TVSH E=18,00%";
            string taxAmount = $"{totalOrderCost * 0.18M:F2}€";
            string totalWithoutTax = $"{totalOrderCost * 0.82M:F2}€";

            // Draw "TOTALI NE EURO" and the total cost
            g.DrawString("TOTALI NE EURO", boldFont, Brushes.Black, e.MarginBounds.Left, y);

            SizeF totalCostSize = g.MeasureString(totalCost, printFont);
            float totalCostX = e.MarginBounds.Right - totalCostSize.Width;

            for (float x = e.MarginBounds.Left + g.MeasureString("TOTALI NE EURO", boldFont).Width + 5; x < totalCostX - 15; x += 3)
            {
                g.DrawString(".", printFont, Brushes.Black, x, y);
            }

            g.DrawString(totalCost, printFont, Brushes.Black, totalCostX, y);
            y += lineHeight;

            // Draw tax and tax amount
            g.DrawString(tax, printFont, Brushes.Black, e.MarginBounds.Left, y);

            SizeF taxAmountSize = g.MeasureString(taxAmount, printFont);
            float taxAmountX = e.MarginBounds.Right - taxAmountSize.Width;

            for (float x = e.MarginBounds.Left + g.MeasureString(tax, printFont).Width + 5; x < taxAmountX - 15; x += 3)
            {
                g.DrawString(".", printFont, Brushes.Black, x, y);
            }

            g.DrawString(taxAmount, printFont, Brushes.Black, taxAmountX, y);
            y += lineHeight;

            // Draw total without tax and align it to the right with dots
            g.DrawString("TOT. PA TVSH:", printFont, Brushes.Black, e.MarginBounds.Left, y);

            SizeF totalWithoutTaxSize = g.MeasureString(totalWithoutTax, printFont);
            float totalWithoutTaxX = e.MarginBounds.Right - totalWithoutTaxSize.Width;

            for (float x = e.MarginBounds.Left + g.MeasureString("TOT. PA TVSH:", printFont).Width + 5; x < totalWithoutTaxX - 15; x += 3)
            {
                g.DrawString(".", printFont, Brushes.Black, x, y);
            }

            g.DrawString(totalWithoutTax, printFont, Brushes.Black, totalWithoutTaxX, y);
            y += lineHeight * 3;

            // Footer
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

            // Fiscal Coupon
            string fiscalText = "KUPON FISKAL NR. XXXX";
            string rksMef = "RKS MEF";
            g.DrawString(fiscalText, boldFont, Brushes.Black, CenterText(fiscalText, boldFont, e), y);
            y += lineHeight;
            g.DrawString(rksMef, boldFont, Brushes.Black, CenterText(rksMef, boldFont, e), y);
        }

    }
}
