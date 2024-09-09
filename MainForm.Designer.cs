namespace RestaurantPOS
{
    partial class mainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.buttons = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnMenuManagment = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttons
            // 
            this.buttons.BackColor = System.Drawing.Color.Transparent;
            this.buttons.Controls.Add(this.btnUser);
            this.buttons.Controls.Add(this.btnReports);
            this.buttons.Controls.Add(this.btnMenuManagment);
            this.buttons.Controls.Add(this.btnOrders);
            this.buttons.Location = new System.Drawing.Point(132, 88);
            this.buttons.Margin = new System.Windows.Forms.Padding(4);
            this.buttons.Name = "buttons";
            this.buttons.Size = new System.Drawing.Size(310, 188);
            this.buttons.TabIndex = 5;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Artifakt Element Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.Location = new System.Drawing.Point(158, 98);
            this.btnUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(152, 90);
            this.btnUser.TabIndex = 4;
            this.btnUser.Text = "User Managments";
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Artifakt Element Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.Location = new System.Drawing.Point(0, 98);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(150, 90);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Reports";
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnMenuManagment
            // 
            this.btnMenuManagment.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnMenuManagment.FlatAppearance.BorderSize = 0;
            this.btnMenuManagment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuManagment.Font = new System.Drawing.Font("Artifakt Element Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuManagment.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuManagment.Image")));
            this.btnMenuManagment.Location = new System.Drawing.Point(160, 0);
            this.btnMenuManagment.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenuManagment.Name = "btnMenuManagment";
            this.btnMenuManagment.Size = new System.Drawing.Size(150, 90);
            this.btnMenuManagment.TabIndex = 1;
            this.btnMenuManagment.Text = "Menu Managment";
            this.btnMenuManagment.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnMenuManagment.UseVisualStyleBackColor = false;
            this.btnMenuManagment.Click += new System.EventHandler(this.btnMenuManagment_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Artifakt Element Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.Black;
            this.btnOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnOrders.Image")));
            this.btnOrders.Location = new System.Drawing.Point(0, 0);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(150, 90);
            this.btnOrders.TabIndex = 0;
            this.btnOrders.Text = "Orders";
            this.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 6;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttons);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestaurantPOS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DoubleClick += new System.EventHandler(this.MainForm_DoubleClick);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.buttons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel buttons;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnMenuManagment;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Panel panel1;
    }
}

