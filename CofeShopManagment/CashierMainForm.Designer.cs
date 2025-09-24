namespace CofeShopManagment
{
    partial class CashierMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierMainForm));
            panel1 = new Panel();
            label1 = new Label();
            close = new Label();
            panel2 = new Panel();
            order_btn = new Button();
            pictureBox1 = new PictureBox();
            logout_btn = new Button();
            customer_btn = new Button();
            addProducts_btn = new Button();
            dashbord_btn = new Button();
            username = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            cashierCustomersForm1 = new CafeShopManagementSystem.CashierCustomersForm();
            adminDashboard1 = new AdminDashboard();
            adminAddProducts1 = new CafeShopManagementSystem.AdminAddProducts();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1500, 42);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(290, 21);
            label1.TabIndex = 22;
            label1.Text = "Cafee Shop Managment System";
            // 
            // close
            // 
            close.AutoSize = true;
            close.Location = new Point(1460, 9);
            close.Name = "close";
            close.Size = new Size(18, 20);
            close.TabIndex = 21;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(7, 99, 102);
            panel2.Controls.Add(order_btn);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(customer_btn);
            panel2.Controls.Add(addProducts_btn);
            panel2.Controls.Add(dashbord_btn);
            panel2.Controls.Add(username);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 758);
            panel2.TabIndex = 4;
            // 
            // order_btn
            // 
            order_btn.FlatStyle = FlatStyle.Flat;
            order_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            order_btn.ForeColor = Color.White;
            order_btn.Location = new Point(12, 349);
            order_btn.Name = "order_btn";
            order_btn.Size = new Size(245, 38);
            order_btn.TabIndex = 33;
            order_btn.Text = "Order\r\n";
            order_btn.UseVisualStyleBackColor = true;
            order_btn.Click += order_btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(68, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 88);
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // logout_btn
            // 
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout_btn.ForeColor = Color.White;
            logout_btn.Location = new Point(12, 706);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(245, 38);
            logout_btn.TabIndex = 31;
            logout_btn.Text = "Logout";
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += logout_btn_Click;
            // 
            // customer_btn
            // 
            customer_btn.FlatStyle = FlatStyle.Flat;
            customer_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customer_btn.ForeColor = Color.White;
            customer_btn.Location = new Point(12, 413);
            customer_btn.Name = "customer_btn";
            customer_btn.Size = new Size(245, 38);
            customer_btn.TabIndex = 30;
            customer_btn.Text = "Customers";
            customer_btn.UseVisualStyleBackColor = true;
            customer_btn.Click += customer_btn_Click;
            // 
            // addProducts_btn
            // 
            addProducts_btn.FlatStyle = FlatStyle.Flat;
            addProducts_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProducts_btn.ForeColor = Color.White;
            addProducts_btn.Location = new Point(12, 289);
            addProducts_btn.Name = "addProducts_btn";
            addProducts_btn.Size = new Size(245, 38);
            addProducts_btn.TabIndex = 29;
            addProducts_btn.Text = "Add Products";
            addProducts_btn.UseVisualStyleBackColor = true;
            addProducts_btn.Click += addProducts_btn_Click;
            // 
            // dashbord_btn
            // 
            dashbord_btn.FlatStyle = FlatStyle.Flat;
            dashbord_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashbord_btn.ForeColor = Color.White;
            dashbord_btn.Location = new Point(12, 228);
            dashbord_btn.Name = "dashbord_btn";
            dashbord_btn.Size = new Size(245, 38);
            dashbord_btn.TabIndex = 26;
            dashbord_btn.Text = "Dashboard";
            dashbord_btn.UseVisualStyleBackColor = true;
            dashbord_btn.Click += button1_Click;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.ForeColor = Color.White;
            username.Location = new Point(122, 181);
            username.Name = "username";
            username.Size = new Size(79, 21);
            username.TabIndex = 25;
            username.Text = "Cashier";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 181);
            label3.Name = "label3";
            label3.Size = new Size(113, 21);
            label3.TabIndex = 24;
            label3.Text = "Username :";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(47, 117);
            label2.Name = "label2";
            label2.Size = new Size(168, 27);
            label2.TabIndex = 23;
            label2.Text = "Cashier Panel";
            // 
            // panel3
            // 
            panel3.Controls.Add(cashierCustomersForm1);
            panel3.Controls.Add(adminDashboard1);
            panel3.Controls.Add(adminAddProducts1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(290, 42);
            panel3.Name = "panel3";
            panel3.Size = new Size(1210, 758);
            panel3.TabIndex = 5;
            panel3.Paint += panel3_Paint;
            // 
            // cashierCustomersForm1
            // 
            cashierCustomersForm1.Location = new Point(0, 0);
            cashierCustomersForm1.Margin = new Padding(4, 5, 4, 5);
            cashierCustomersForm1.Name = "cashierCustomersForm1";
            cashierCustomersForm1.Size = new Size(1210, 744);
            cashierCustomersForm1.TabIndex = 2;
            // 
            // adminDashboard1
            // 
            adminDashboard1.Location = new Point(0, 3);
            adminDashboard1.Name = "adminDashboard1";
            adminDashboard1.Size = new Size(1201, 741);
            adminDashboard1.TabIndex = 1;
            // 
            // adminAddProducts1
            // 
            adminAddProducts1.Location = new Point(7, 8);
            adminAddProducts1.Margin = new Padding(4, 5, 4, 5);
            adminAddProducts1.Name = "adminAddProducts1";
            adminAddProducts1.Size = new Size(1248, 736);
            adminAddProducts1.TabIndex = 0;
            // 
            // CashierMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 800);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CashierMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashierMainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label close;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button logout_btn;
        private Button customer_btn;
        private Button addProducts_btn;
        private Button dashbord_btn;
        private Label username;
        private Label label3;
        private Label label2;
        private Button order_btn;
        private Panel panel3;
        private CafeShopManagementSystem.AdminAddProducts adminAddProducts1;
        private AdminDashboard adminDashboard1;
        private CafeShopManagementSystem.CashierCustomersForm cashierCustomersForm1;
    }
}