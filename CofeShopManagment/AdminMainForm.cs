using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeShopManagementSystem;

namespace CofeShopManagment
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void adminAddUsers1_Load(object sender, EventArgs e)
        {

        }

        private void adminAddUsers1_Load_1(object sender, EventArgs e)
        {

        }

        private void close_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Sign out?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminDashboardForm1.Visible = true;
            adminAddUsers1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomersForm1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminDashboardForm1.Visible = false;
            adminAddUsers1.Visible = true;
            adminAddProducts1.Visible = false;
            cashierCustomersForm1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminDashboardForm1.Visible = false;
            adminAddUsers1.Visible = false;
            adminAddProducts1.Visible = true;
            cashierCustomersForm1.Visible = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            adminDashboardForm1.Visible = false;
            adminAddUsers1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomersForm1.Visible = true;

            CashierCustomersForm ccForm = cashierCustomersForm1 as CashierCustomersForm;

            if (ccForm != null)
            {
                ccForm.refreshData();
            }
        }
    }
}
