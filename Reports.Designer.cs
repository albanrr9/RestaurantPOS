namespace RestaurantPOS
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnYesterday = new System.Windows.Forms.Button();
            this.btnThisWeek = new System.Windows.Forms.Button();
            this.btnThisMonth = new System.Windows.Forms.Button();
            this.btnLastMonth = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnBack.TabIndex = 7;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbUsers
            // 
            this.cmbUsers.BackColor = System.Drawing.Color.Gray;
            this.cmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsers.ForeColor = System.Drawing.Color.White;
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(0, 0);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(156, 28);
            this.cmbUsers.TabIndex = 10;
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.dataGridViewReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReport.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.dataGridViewReport.Location = new System.Drawing.Point(0, 68);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.ReadOnly = true;
            this.dataGridViewReport.Size = new System.Drawing.Size(482, 633);
            this.dataGridViewReport.TabIndex = 11;
            // 
            // btnToday
            // 
            this.btnToday.AutoSize = true;
            this.btnToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.btnToday.FlatAppearance.BorderSize = 0;
            this.btnToday.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnToday.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.ForeColor = System.Drawing.Color.White;
            this.btnToday.Location = new System.Drawing.Point(0, 34);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(64, 28);
            this.btnToday.TabIndex = 12;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnYesterday
            // 
            this.btnYesterday.AutoSize = true;
            this.btnYesterday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.btnYesterday.FlatAppearance.BorderSize = 0;
            this.btnYesterday.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnYesterday.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnYesterday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYesterday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYesterday.ForeColor = System.Drawing.Color.White;
            this.btnYesterday.Location = new System.Drawing.Point(70, 34);
            this.btnYesterday.Name = "btnYesterday";
            this.btnYesterday.Size = new System.Drawing.Size(92, 28);
            this.btnYesterday.TabIndex = 13;
            this.btnYesterday.Text = "Yesterday";
            this.btnYesterday.UseVisualStyleBackColor = false;
            this.btnYesterday.Click += new System.EventHandler(this.btnYesterday_Click);
            // 
            // btnThisWeek
            // 
            this.btnThisWeek.AutoSize = true;
            this.btnThisWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.btnThisWeek.FlatAppearance.BorderSize = 0;
            this.btnThisWeek.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnThisWeek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnThisWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThisWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThisWeek.ForeColor = System.Drawing.Color.White;
            this.btnThisWeek.Location = new System.Drawing.Point(168, 34);
            this.btnThisWeek.Name = "btnThisWeek";
            this.btnThisWeek.Size = new System.Drawing.Size(98, 28);
            this.btnThisWeek.TabIndex = 14;
            this.btnThisWeek.Text = "This Week";
            this.btnThisWeek.UseVisualStyleBackColor = false;
            this.btnThisWeek.Click += new System.EventHandler(this.btnThisWeek_Click);
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.AutoSize = true;
            this.btnThisMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.btnThisMonth.FlatAppearance.BorderSize = 0;
            this.btnThisMonth.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnThisMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnThisMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThisMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThisMonth.ForeColor = System.Drawing.Color.White;
            this.btnThisMonth.Location = new System.Drawing.Point(272, 34);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(102, 28);
            this.btnThisMonth.TabIndex = 15;
            this.btnThisMonth.Text = "This Month";
            this.btnThisMonth.UseVisualStyleBackColor = false;
            this.btnThisMonth.Click += new System.EventHandler(this.btnThisMonth_Click);
            // 
            // btnLastMonth
            // 
            this.btnLastMonth.AutoSize = true;
            this.btnLastMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.btnLastMonth.FlatAppearance.BorderSize = 0;
            this.btnLastMonth.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnLastMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLastMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastMonth.ForeColor = System.Drawing.Color.White;
            this.btnLastMonth.Location = new System.Drawing.Point(380, 34);
            this.btnLastMonth.Name = "btnLastMonth";
            this.btnLastMonth.Size = new System.Drawing.Size(102, 28);
            this.btnLastMonth.TabIndex = 16;
            this.btnLastMonth.Text = "Last Month";
            this.btnLastMonth.UseVisualStyleBackColor = false;
            this.btnLastMonth.Click += new System.EventHandler(this.btnLastMonth_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbUsers);
            this.panel1.Controls.Add(this.btnLastMonth);
            this.panel1.Controls.Add(this.dataGridViewReport);
            this.panel1.Controls.Add(this.btnThisMonth);
            this.panel1.Controls.Add(this.btnToday);
            this.panel1.Controls.Add(this.btnThisWeek);
            this.panel1.Controls.Add(this.btnYesterday);
            this.panel1.Location = new System.Drawing.Point(349, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 701);
            this.panel1.TabIndex = 17;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Name = "Reports";
            this.Size = new System.Drawing.Size(1306, 823);
            this.Load += new System.EventHandler(this.Reports_Load);
            this.Resize += new System.EventHandler(this.Reports_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnYesterday;
        private System.Windows.Forms.Button btnThisWeek;
        private System.Windows.Forms.Button btnThisMonth;
        private System.Windows.Forms.Button btnLastMonth;
        private System.Windows.Forms.Panel panel1;
    }
}
