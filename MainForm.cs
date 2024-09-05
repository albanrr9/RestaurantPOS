using System;
using System.Windows.Forms;

namespace RestaurantPOS
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            CenterPanel();
        }
        public void LoadUserControl(UserControl userControl)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(userControl);
            this.panel1.Dock = DockStyle.Fill;
            userControl.Dock = DockStyle.Fill;
        }
        private void UserControl_BackButtonClicked(object sender, EventArgs e)
        {
            this.panel1.Dock = DockStyle.None;
        }
        private void MainForm_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            CenterPanel();
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }
        private void CenterPanel()
        {
            int x = (this.ClientSize.Width - buttons.Width) / 2;
            int y = (this.ClientSize.Height - buttons.Height) / 2;
            buttons.Location = new System.Drawing.Point(x, y);
        }
        private void btnOrders_Click(object sender, EventArgs e)
        {
            UserControl1 userControl = new UserControl1();
            userControl.BackButtonClicked += UserControl_BackButtonClicked;
            LoadUserControl(userControl);
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            UserManagment userManagment = new UserManagment();
            userManagment.BackButtonClicked += UserControl_BackButtonClicked;
            LoadUserControl(userManagment);
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
        private void btnMenuManagment_Click(object sender, EventArgs e)
        {
            MenuManagmentLogin menuManagmentlogin = new MenuManagmentLogin();
            menuManagmentlogin.BackButtonClicked += UserControl_BackButtonClicked;
            LoadUserControl(menuManagmentlogin);
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}