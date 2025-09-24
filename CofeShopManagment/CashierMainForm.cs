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
    public partial class CashierMainForm : Form
    {
        public CashierMainForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                adminDashboard1.Visible = true;
                adminAddProducts1.Visible = false;
                cashierCustomersForm1.Visible = false;

                AdminAddProducts aaProd = adminAddProducts1 as AdminAddProducts;

                if (aaProd != null)
                {
                    aaProd.refreshData();
                }
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to sign out?"
               , "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }

        private void addProducts_btn_Click(object sender, EventArgs e)
        {
            {
                adminDashboard1.Visible = false;
                adminAddProducts1.Visible = true;
                cashierCustomersForm1.Visible = false;

                AdminAddProducts aaProd = adminAddProducts1 as AdminAddProducts;

                if (aaProd != null)
                {
                    aaProd.refreshData();
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customer_btn_Click(object sender, EventArgs e)
        {
            {
                adminDashboard1.Visible = false;
                adminAddProducts1.Visible = false;
                cashierCustomersForm1.Visible = true;

                AdminAddProducts aaProd = adminAddProducts1 as AdminAddProducts;

                if (aaProd != null)
                {
                    aaProd.refreshData();
                }
            }
        }

        private void order_btn_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
