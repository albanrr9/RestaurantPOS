namespace RestaurantPOS
{
    partial class OrderForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.btnAllProducts = new System.Windows.Forms.Button();
            this.btnCoffee = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnColdDrinks = new System.Windows.Forms.Button();
            this.btnJuices = new System.Windows.Forms.Button();
            this.btnDesserts = new System.Windows.Forms.Button();
            this.btnIceCream = new System.Windows.Forms.Button();
            this.btnGrilledFood = new System.Windows.Forms.Button();
            this.btnFish = new System.Windows.Forms.Button();
            this.btnPizza = new System.Windows.Forms.Button();
            this.btnSalad = new System.Windows.Forms.Button();
            this.btnPasta = new System.Windows.Forms.Button();
            this.btnRisotto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewOrder
            // 
            this.listViewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewOrder.BackColor = System.Drawing.SystemColors.Window;
            this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.product,
            this.quantity,
            this.price,
            this.subtotal});
            this.listViewOrder.HideSelection = false;
            this.listViewOrder.Location = new System.Drawing.Point(0, 0);
            this.listViewOrder.MinimumSize = new System.Drawing.Size(420, 4);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(420, 664);
            this.listViewOrder.TabIndex = 2;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Details;
            this.listViewOrder.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewOrder_MouseDoubleClick);
            // 
            // product
            // 
            this.product.Text = "Product";
            this.product.Width = 150;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            this.quantity.Width = 70;
            // 
            // price
            // 
            this.price.Text = "Price";
            this.price.Width = 100;
            // 
            // subtotal
            // 
            this.subtotal.Text = "Subtotal";
            this.subtotal.Width = 100;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTotalCost.BackColor = System.Drawing.Color.ForestGreen;
            this.lblTotalCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.ForeColor = System.Drawing.Color.White;
            this.lblTotalCost.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTotalCost.Location = new System.Drawing.Point(0, 664);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(210, 70);
            this.lblTotalCost.TabIndex = 3;
            this.lblTotalCost.Text = "Total: 0.00€";
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAllProducts
            // 
            this.btnAllProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAllProducts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAllProducts.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAllProducts.FlatAppearance.BorderSize = 0;
            this.btnAllProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllProducts.ForeColor = System.Drawing.Color.White;
            this.btnAllProducts.Location = new System.Drawing.Point(3, 753);
            this.btnAllProducts.Name = "btnAllProducts";
            this.btnAllProducts.Size = new System.Drawing.Size(90, 48);
            this.btnAllProducts.TabIndex = 4;
            this.btnAllProducts.Text = "Te gjitha";
            this.btnAllProducts.UseVisualStyleBackColor = false;
            this.btnAllProducts.Click += new System.EventHandler(this.btnAllProducts_Click);
            // 
            // btnCoffee
            // 
            this.btnCoffee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCoffee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCoffee.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCoffee.FlatAppearance.BorderSize = 0;
            this.btnCoffee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoffee.ForeColor = System.Drawing.Color.White;
            this.btnCoffee.Location = new System.Drawing.Point(99, 753);
            this.btnCoffee.Name = "btnCoffee";
            this.btnCoffee.Size = new System.Drawing.Size(90, 48);
            this.btnCoffee.TabIndex = 5;
            this.btnCoffee.Text = "Coffee";
            this.btnCoffee.UseVisualStyleBackColor = false;
            this.btnCoffee.Click += new System.EventHandler(this.btnCoffee_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 31);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1160, 714);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrintReceipt.AutoSize = true;
            this.btnPrintReceipt.BackColor = System.Drawing.Color.Teal;
            this.btnPrintReceipt.FlatAppearance.BorderSize = 0;
            this.btnPrintReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReceipt.ForeColor = System.Drawing.Color.White;
            this.btnPrintReceipt.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintReceipt.Image")));
            this.btnPrintReceipt.Location = new System.Drawing.Point(0, 734);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(420, 70);
            this.btnPrintReceipt.TabIndex = 10;
            this.btnPrintReceipt.Text = "Print Receipt";
            this.btnPrintReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPrintReceipt.UseVisualStyleBackColor = false;
            this.btnPrintReceipt.Click += new System.EventHandler(this.btnPrintReceipt_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintReceipt);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClearOrder);
            this.panel1.Controls.Add(this.btnPrintReceipt);
            this.panel1.Controls.Add(this.lblTotalCost);
            this.panel1.Controls.Add(this.listViewOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1166, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 804);
            this.panel1.TabIndex = 11;
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClearOrder.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClearOrder.FlatAppearance.BorderSize = 0;
            this.btnClearOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearOrder.ForeColor = System.Drawing.Color.White;
            this.btnClearOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnClearOrder.Image")));
            this.btnClearOrder.Location = new System.Drawing.Point(210, 664);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(210, 70);
            this.btnClearOrder.TabIndex = 11;
            this.btnClearOrder.Text = "Clear Order";
            this.btnClearOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClearOrder.UseVisualStyleBackColor = false;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(25, 25);
            this.btnBack.TabIndex = 12;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnColdDrinks
            // 
            this.btnColdDrinks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnColdDrinks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnColdDrinks.BackColor = System.Drawing.Color.ForestGreen;
            this.btnColdDrinks.FlatAppearance.BorderSize = 0;
            this.btnColdDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColdDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColdDrinks.ForeColor = System.Drawing.Color.White;
            this.btnColdDrinks.Location = new System.Drawing.Point(195, 753);
            this.btnColdDrinks.Name = "btnColdDrinks";
            this.btnColdDrinks.Size = new System.Drawing.Size(90, 48);
            this.btnColdDrinks.TabIndex = 13;
            this.btnColdDrinks.Text = "Cold Drinks";
            this.btnColdDrinks.UseVisualStyleBackColor = false;
            this.btnColdDrinks.Click += new System.EventHandler(this.btnColdDrinks_Click);
            // 
            // btnJuices
            // 
            this.btnJuices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnJuices.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnJuices.BackColor = System.Drawing.Color.ForestGreen;
            this.btnJuices.FlatAppearance.BorderSize = 0;
            this.btnJuices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJuices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJuices.ForeColor = System.Drawing.Color.White;
            this.btnJuices.Location = new System.Drawing.Point(291, 753);
            this.btnJuices.Name = "btnJuices";
            this.btnJuices.Size = new System.Drawing.Size(90, 48);
            this.btnJuices.TabIndex = 14;
            this.btnJuices.Text = "Juices";
            this.btnJuices.UseVisualStyleBackColor = false;
            this.btnJuices.Click += new System.EventHandler(this.btnJuices_Click);
            // 
            // btnDesserts
            // 
            this.btnDesserts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDesserts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDesserts.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDesserts.FlatAppearance.BorderSize = 0;
            this.btnDesserts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesserts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesserts.ForeColor = System.Drawing.Color.White;
            this.btnDesserts.Location = new System.Drawing.Point(483, 753);
            this.btnDesserts.Name = "btnDesserts";
            this.btnDesserts.Size = new System.Drawing.Size(90, 48);
            this.btnDesserts.TabIndex = 15;
            this.btnDesserts.Text = "Desserts";
            this.btnDesserts.UseVisualStyleBackColor = false;
            this.btnDesserts.Click += new System.EventHandler(this.btnDesserts_Click);
            // 
            // btnIceCream
            // 
            this.btnIceCream.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIceCream.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIceCream.BackColor = System.Drawing.Color.ForestGreen;
            this.btnIceCream.FlatAppearance.BorderSize = 0;
            this.btnIceCream.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIceCream.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIceCream.ForeColor = System.Drawing.Color.White;
            this.btnIceCream.Location = new System.Drawing.Point(387, 753);
            this.btnIceCream.Name = "btnIceCream";
            this.btnIceCream.Size = new System.Drawing.Size(90, 48);
            this.btnIceCream.TabIndex = 16;
            this.btnIceCream.Text = "Ice Cream";
            this.btnIceCream.UseVisualStyleBackColor = false;
            this.btnIceCream.Click += new System.EventHandler(this.btnIceCream_Click);
            // 
            // btnGrilledFood
            // 
            this.btnGrilledFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGrilledFood.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGrilledFood.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGrilledFood.FlatAppearance.BorderSize = 0;
            this.btnGrilledFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrilledFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrilledFood.ForeColor = System.Drawing.Color.White;
            this.btnGrilledFood.Location = new System.Drawing.Point(675, 753);
            this.btnGrilledFood.Name = "btnGrilledFood";
            this.btnGrilledFood.Size = new System.Drawing.Size(90, 48);
            this.btnGrilledFood.TabIndex = 17;
            this.btnGrilledFood.Text = "Grilled Food";
            this.btnGrilledFood.UseVisualStyleBackColor = false;
            this.btnGrilledFood.Click += new System.EventHandler(this.btnGrilledFood_Click);
            // 
            // btnFish
            // 
            this.btnFish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFish.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFish.BackColor = System.Drawing.Color.ForestGreen;
            this.btnFish.FlatAppearance.BorderSize = 0;
            this.btnFish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFish.ForeColor = System.Drawing.Color.White;
            this.btnFish.Location = new System.Drawing.Point(771, 753);
            this.btnFish.Name = "btnFish";
            this.btnFish.Size = new System.Drawing.Size(90, 48);
            this.btnFish.TabIndex = 18;
            this.btnFish.Text = "Fish";
            this.btnFish.UseVisualStyleBackColor = false;
            this.btnFish.Click += new System.EventHandler(this.btnFish_Click);
            // 
            // btnPizza
            // 
            this.btnPizza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPizza.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPizza.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPizza.FlatAppearance.BorderSize = 0;
            this.btnPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPizza.ForeColor = System.Drawing.Color.White;
            this.btnPizza.Location = new System.Drawing.Point(867, 753);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(90, 48);
            this.btnPizza.TabIndex = 19;
            this.btnPizza.Text = "Pizza";
            this.btnPizza.UseVisualStyleBackColor = false;
            this.btnPizza.Click += new System.EventHandler(this.btnPizza_Click);
            // 
            // btnSalad
            // 
            this.btnSalad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalad.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSalad.FlatAppearance.BorderSize = 0;
            this.btnSalad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalad.ForeColor = System.Drawing.Color.White;
            this.btnSalad.Location = new System.Drawing.Point(963, 753);
            this.btnSalad.Name = "btnSalad";
            this.btnSalad.Size = new System.Drawing.Size(90, 48);
            this.btnSalad.TabIndex = 20;
            this.btnSalad.Text = "Salad";
            this.btnSalad.UseVisualStyleBackColor = false;
            this.btnSalad.Click += new System.EventHandler(this.btnSalad_Click);
            // 
            // btnPasta
            // 
            this.btnPasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPasta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPasta.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPasta.FlatAppearance.BorderSize = 0;
            this.btnPasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasta.ForeColor = System.Drawing.Color.White;
            this.btnPasta.Location = new System.Drawing.Point(579, 753);
            this.btnPasta.Name = "btnPasta";
            this.btnPasta.Size = new System.Drawing.Size(90, 48);
            this.btnPasta.TabIndex = 21;
            this.btnPasta.Text = "Pasta";
            this.btnPasta.UseVisualStyleBackColor = false;
            this.btnPasta.Click += new System.EventHandler(this.btnPasta_Click);
            // 
            // btnRisotto
            // 
            this.btnRisotto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRisotto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRisotto.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRisotto.FlatAppearance.BorderSize = 0;
            this.btnRisotto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRisotto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRisotto.ForeColor = System.Drawing.Color.White;
            this.btnRisotto.Location = new System.Drawing.Point(1059, 753);
            this.btnRisotto.Name = "btnRisotto";
            this.btnRisotto.Size = new System.Drawing.Size(90, 48);
            this.btnRisotto.TabIndex = 22;
            this.btnRisotto.Text = "Risotto";
            this.btnRisotto.UseVisualStyleBackColor = false;
            this.btnRisotto.Click += new System.EventHandler(this.btnRisotto_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.btnPasta);
            this.Controls.Add(this.btnGrilledFood);
            this.Controls.Add(this.btnIceCream);
            this.Controls.Add(this.btnFish);
            this.Controls.Add(this.btnDesserts);
            this.Controls.Add(this.btnPizza);
            this.Controls.Add(this.btnJuices);
            this.Controls.Add(this.btnSalad);
            this.Controls.Add(this.btnColdDrinks);
            this.Controls.Add(this.btnRisotto);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnCoffee);
            this.Controls.Add(this.btnAllProducts);
            this.Name = "OrderForm";
            this.Size = new System.Drawing.Size(1586, 804);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.ColumnHeader product;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Button btnAllProducts;
        private System.Windows.Forms.Button btnCoffee;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ColumnHeader subtotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClearOrder;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnColdDrinks;
        private System.Windows.Forms.Button btnJuices;
        private System.Windows.Forms.Button btnDesserts;
        private System.Windows.Forms.Button btnIceCream;
        private System.Windows.Forms.Button btnGrilledFood;
        private System.Windows.Forms.Button btnFish;
        private System.Windows.Forms.Button btnPizza;
        private System.Windows.Forms.Button btnSalad;
        private System.Windows.Forms.Button btnPasta;
        private System.Windows.Forms.Button btnRisotto;
    }
}