namespace CofeShopManagment
{
    partial class AdminMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            panel1 = new Panel();
            label1 = new Label();
            close = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            cashierCustomersForm1 = new CafeShopManagementSystem.CashierCustomersForm();
            adminDashboardForm1 = new AdminDashboard();
            adminAddProducts1 = new CafeShopManagementSystem.AdminAddProducts();
            adminAddUsers1 = new CafeShopManagement.AdminAddUsers();
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
            panel1.Size = new Size(1500, 45);
            panel1.TabIndex = 0;
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
            close.Click += close_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(7, 99, 102);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 745);
            panel2.TabIndex = 1;
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
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(12, 695);
            button5.Name = "button5";
            button5.Size = new Size(245, 38);
            button5.TabIndex = 31;
            button5.Text = "Logout";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(12, 401);
            button4.Name = "button4";
            button4.Size = new Size(245, 38);
            button4.TabIndex = 30;
            button4.Text = "Customers";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(12, 338);
            button3.Name = "button3";
            button3.Size = new Size(245, 38);
            button3.TabIndex = 29;
            button3.Text = "Add Products";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(12, 282);
            button2.Name = "button2";
            button2.Size = new Size(245, 38);
            button2.TabIndex = 28;
            button2.Text = "Add Cashier";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 221);
            button1.Name = "button1";
            button1.Size = new Size(245, 38);
            button1.TabIndex = 26;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(122, 181);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 25;
            label4.Text = "Admin";
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
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(47, 117);
            label2.Name = "label2";
            label2.Size = new Size(152, 27);
            label2.TabIndex = 23;
            label2.Text = "Admin Panel";
            // 
            // panel3
            // 
            panel3.Controls.Add(cashierCustomersForm1);
            panel3.Controls.Add(adminDashboardForm1);
            panel3.Controls.Add(adminAddProducts1);
            panel3.Controls.Add(adminAddUsers1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(290, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(1210, 745);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // cashierCustomersForm1
            // 
            cashierCustomersForm1.Location = new Point(0, 0);
            cashierCustomersForm1.Margin = new Padding(4, 5, 4, 5);
            cashierCustomersForm1.Name = "cashierCustomersForm1";
            cashierCustomersForm1.Size = new Size(1206, 745);
            cashierCustomersForm1.TabIndex = 23;
            // 
            // adminDashboardForm1
            // 
            adminDashboardForm1.Location = new Point(7, 6);
            adminDashboardForm1.Name = "adminDashboardForm1";
            adminDashboardForm1.Size = new Size(1487, 808);
            adminDashboardForm1.TabIndex = 2;
            // 
            // adminAddProducts1
            // 
            adminAddProducts1.Location = new Point(37, 37);
            adminAddProducts1.Margin = new Padding(4, 5, 4, 5);
            adminAddProducts1.Name = "adminAddProducts1";
            adminAddProducts1.Size = new Size(1516, 868);
            adminAddProducts1.TabIndex = 1;
            // 
            // adminAddUsers1
            // 
            adminAddUsers1.Location = new Point(7, 0);
            adminAddUsers1.Margin = new Padding(4, 5, 4, 5);
            adminAddUsers1.Name = "adminAddUsers1";
            adminAddUsers1.Size = new Size(1199, 731);
            adminAddUsers1.TabIndex = 0;
            adminAddUsers1.Load += adminAddUsers1_Load_1;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 790);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMain";
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
        private Panel panel2;
        private Label label1;
        private Label close;
        private Label label2;
        private Button button1;
        private Label label4;
        private Label label3;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
        private Panel panel3;
        private PictureBox pictureBox1;
        private CafeShopManagement.AdminAddUsers adminAddUsers1;
        private CafeShopManagementSystem.AdminAddProducts adminAddProducts1;
        private AdminDashboard adminDashboardForm1;
        private CafeShopManagementSystem.CashierCustomersForm cashierCustomersForm1;
    }
}