using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Supermarket_Management_System_In_csharp
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmlogin fl = new frmlogin();
            fl.ShowDialog();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_dashborad.Height;
            SidePanel.Top = btn_dashborad.Top;
            uC_dashboard1.BringToFront();
        }

        private void btn_Categories_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Categories.Height;
            SidePanel.Top = btn_Categories.Top;
            uC_categories1.BringToFront();
        }

        private void btn_Products_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Products.Height;
            SidePanel.Top = btn_Products.Top;
            uC_products1.BringToFront();
        }

        private void btn_Orders_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Orders.Height;
            SidePanel.Top = btn_Orders.Top;
            uC_orders1.BringToFront();
        }

        private void btn_Sales_Invoice_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_billing.Height;
            SidePanel.Top = btn_billing.Top;
            uC_Billing1.BringToFront();
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_sellers.Height;
            SidePanel.Top = btn_sellers.Top;
            uC_Sellers1.BringToFront();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            uC_dashboard1.BringToFront();
        }

       

        

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmlogin fl = new frmlogin();
            fl.ShowDialog();
        }

        

        private void uC_products1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uC_Sellers1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = btn_sellers.Height;
            SidePanel.Top = btn_sellers.Top;
            uC_StockerKeepers1.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
