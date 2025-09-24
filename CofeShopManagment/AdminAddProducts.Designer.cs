
namespace CafeShopManagementSystem
{
    partial class AdminAddProducts
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            DataGridView1 = new DataGridView();
            panel2 = new Panel();
            adminAddUsers_imageView = new PictureBox();
            adminAddUsers_importBtn = new Button();
            panel4 = new Panel();
            adminAddProducts_clearBtn = new Button();
            adminAddProducts_deleteBtn = new Button();
            adminAddProducts_updateBtn = new Button();
            adminAddProducts_addBtn = new Button();
            adminAddProducts_importBtn = new Button();
            panel3 = new Panel();
            adminAddProducts_imageView = new PictureBox();
            adminAddProducts_status = new ComboBox();
            label4 = new Label();
            adminAddProducts_price = new TextBox();
            label6 = new Label();
            adminAddProducts_stock = new TextBox();
            label7 = new Label();
            adminAddProducts_type = new ComboBox();
            label5 = new Label();
            adminAddProducts_name = new TextBox();
            label3 = new Label();
            adminAddProducts_id = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)adminAddUsers_imageView).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)adminAddProducts_imageView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(DataGridView1);
            panel1.Location = new Point(15, 5);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1208, 478);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(205, 28);
            label1.TabIndex = 3;
            label1.Text = "Data of Products";
            label1.Click += label1_Click;
            // 
            // DataGridView1
            // 
            DataGridView1.AllowUserToAddRows = false;
            DataGridView1.AllowUserToDeleteRows = false;
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 99, 102);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.EnableHeadersVisualStyles = false;
            DataGridView1.Location = new Point(20, 44);
            DataGridView1.Margin = new Padding(4, 5, 4, 5);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.ReadOnly = true;
            DataGridView1.RowHeadersVisible = false;
            DataGridView1.RowHeadersWidth = 51;
            DataGridView1.Size = new Size(1166, 412);
            DataGridView1.TabIndex = 2;
            DataGridView1.CellClick += DataGridView1_CellClick;
            DataGridView1.CellContentClick += DataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(adminAddUsers_imageView);
            panel2.Controls.Add(adminAddUsers_importBtn);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(adminAddProducts_clearBtn);
            panel2.Controls.Add(adminAddProducts_deleteBtn);
            panel2.Controls.Add(adminAddProducts_updateBtn);
            panel2.Controls.Add(adminAddProducts_addBtn);
            panel2.Controls.Add(adminAddProducts_importBtn);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(adminAddProducts_status);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(adminAddProducts_price);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(adminAddProducts_stock);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(adminAddProducts_type);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(adminAddProducts_name);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(adminAddProducts_id);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(15, 484);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1208, 261);
            panel2.TabIndex = 1;
            // 
            // adminAddUsers_imageView
            // 
            adminAddUsers_imageView.Location = new Point(1019, 9);
            adminAddUsers_imageView.Margin = new Padding(4, 5, 4, 5);
            adminAddUsers_imageView.Name = "adminAddUsers_imageView";
            adminAddUsers_imageView.Size = new Size(137, 166);
            adminAddUsers_imageView.SizeMode = PictureBoxSizeMode.StretchImage;
            adminAddUsers_imageView.TabIndex = 0;
            adminAddUsers_imageView.TabStop = false;
            // 
            // adminAddUsers_importBtn
            // 
            adminAddUsers_importBtn.BackColor = Color.FromArgb(7, 99, 102);
            adminAddUsers_importBtn.FlatStyle = FlatStyle.Flat;
            adminAddUsers_importBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddUsers_importBtn.ForeColor = Color.White;
            adminAddUsers_importBtn.Location = new Point(1019, 188);
            adminAddUsers_importBtn.Margin = new Padding(4, 5, 4, 5);
            adminAddUsers_importBtn.Name = "adminAddUsers_importBtn";
            adminAddUsers_importBtn.Size = new Size(137, 35);
            adminAddUsers_importBtn.TabIndex = 25;
            adminAddUsers_importBtn.Text = "Import";
            adminAddUsers_importBtn.UseVisualStyleBackColor = false;
            adminAddUsers_importBtn.Click += adminAddUsers_importBtn_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Location = new Point(1019, 9);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(137, 171);
            panel4.TabIndex = 24;
            // 
            // adminAddProducts_clearBtn
            // 
            adminAddProducts_clearBtn.BackColor = Color.FromArgb(7, 99, 102);
            adminAddProducts_clearBtn.FlatStyle = FlatStyle.Flat;
            adminAddProducts_clearBtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddProducts_clearBtn.ForeColor = Color.White;
            adminAddProducts_clearBtn.Location = new Point(855, 181);
            adminAddProducts_clearBtn.Margin = new Padding(4, 5, 4, 5);
            adminAddProducts_clearBtn.Name = "adminAddProducts_clearBtn";
            adminAddProducts_clearBtn.Size = new Size(131, 42);
            adminAddProducts_clearBtn.TabIndex = 23;
            adminAddProducts_clearBtn.Text = "CLEAR";
            adminAddProducts_clearBtn.UseVisualStyleBackColor = false;
            adminAddProducts_clearBtn.Click += adminAddProducts_clearBtn_Click;
            // 
            // adminAddProducts_deleteBtn
            // 
            adminAddProducts_deleteBtn.BackColor = Color.FromArgb(7, 99, 102);
            adminAddProducts_deleteBtn.FlatStyle = FlatStyle.Flat;
            adminAddProducts_deleteBtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddProducts_deleteBtn.ForeColor = Color.White;
            adminAddProducts_deleteBtn.Location = new Point(621, 181);
            adminAddProducts_deleteBtn.Margin = new Padding(4, 5, 4, 5);
            adminAddProducts_deleteBtn.Name = "adminAddProducts_deleteBtn";
            adminAddProducts_deleteBtn.Size = new Size(132, 42);
            adminAddProducts_deleteBtn.TabIndex = 22;
            adminAddProducts_deleteBtn.Text = "DELETE";
            adminAddProducts_deleteBtn.UseVisualStyleBackColor = false;
            adminAddProducts_deleteBtn.Click += adminAddProducts_deleteBtn_Click;
            // 
            // adminAddProducts_updateBtn
            // 
            adminAddProducts_updateBtn.BackColor = Color.FromArgb(7, 99, 102);
            adminAddProducts_updateBtn.FlatStyle = FlatStyle.Flat;
            adminAddProducts_updateBtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddProducts_updateBtn.ForeColor = Color.White;
            adminAddProducts_updateBtn.Location = new Point(377, 181);
            adminAddProducts_updateBtn.Margin = new Padding(4, 5, 4, 5);
            adminAddProducts_updateBtn.Name = "adminAddProducts_updateBtn";
            adminAddProducts_updateBtn.Size = new Size(145, 42);
            adminAddProducts_updateBtn.TabIndex = 21;
            adminAddProducts_updateBtn.Text = "UPDATE";
            adminAddProducts_updateBtn.UseVisualStyleBackColor = false;
            adminAddProducts_updateBtn.Click += adminAddProducts_updateBtn_Click;
            // 
            // adminAddProducts_addBtn
            // 
            adminAddProducts_addBtn.BackColor = Color.FromArgb(7, 99, 102);
            adminAddProducts_addBtn.FlatStyle = FlatStyle.Flat;
            adminAddProducts_addBtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddProducts_addBtn.ForeColor = Color.White;
            adminAddProducts_addBtn.Location = new Point(135, 181);
            adminAddProducts_addBtn.Margin = new Padding(4, 5, 4, 5);
            adminAddProducts_addBtn.Name = "adminAddProducts_addBtn";
            adminAddProducts_addBtn.Size = new Size(133, 42);
            adminAddProducts_addBtn.TabIndex = 20;
            adminAddProducts_addBtn.Text = "ADD";
            adminAddProducts_addBtn.UseVisualStyleBackColor = false;
            adminAddProducts_addBtn.Click += adminAddProducts_addBtn_Click;
            // 
            // adminAddProducts_importBtn
            // 
            adminAddProducts_importBtn.BackColor = Color.FromArgb(7, 99, 102);
            adminAddProducts_importBtn.FlatStyle = FlatStyle.Flat;
            adminAddProducts_importBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddProducts_importBtn.ForeColor = Color.White;
            adminAddProducts_importBtn.Location = new Point(1453, 248);
            adminAddProducts_importBtn.Margin = new Padding(4, 5, 4, 5);
            adminAddProducts_importBtn.Name = "adminAddProducts_importBtn";
            adminAddProducts_importBtn.Size = new Size(144, 51);
            adminAddProducts_importBtn.TabIndex = 19;
            adminAddProducts_importBtn.Text = "Import";
            adminAddProducts_importBtn.UseVisualStyleBackColor = false;
          
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Controls.Add(adminAddProducts_imageView);
            panel3.Location = new Point(1453, 51);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(144, 188);
            panel3.TabIndex = 19;
            // 
            // adminAddProducts_imageView
            // 
            adminAddProducts_imageView.Location = new Point(0, 0);
            adminAddProducts_imageView.Margin = new Padding(4, 5, 4, 5);
            adminAddProducts_imageView.Name = "adminAddProducts_imageView";
            adminAddProducts_imageView.Size = new Size(144, 188);
            adminAddProducts_imageView.SizeMode = PictureBoxSizeMode.StretchImage;
            adminAddProducts_imageView.TabIndex = 18;
            adminAddProducts_imageView.TabStop = false;
            // 
            // adminAddProducts_status
            // 
            adminAddProducts_status.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddProducts_status.FormattingEnabled = true;
            adminAddProducts_status.Items.AddRange(new object[] { "Available", "Unavailable" });
            adminAddProducts_status.Location = new Point(691, 104);
            adminAddProducts_status.Margin = new Padding(4, 5, 4, 5);
            adminAddProducts_status.Name = "adminAddProducts_status";
            adminAddProducts_status.Size = new Size(281, 37);
            adminAddProducts_status.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(560, 120);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 22);
            label4.TabIndex = 17;
            label4.Text = "Status:";
            // 
            // adminAddProducts_price
            // 
            adminAddProducts_price.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddProducts_price.Location = new Point(691, 52);
            adminAddProducts_price.Margin = new Padding(4, 5, 4, 5);
            adminAddProducts_price.Name = "adminAddProducts_price";
            adminAddProducts_price.Size = new Size(281, 30);
            adminAddProducts_price.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(560, 57);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(94, 22);
            label6.TabIndex = 15;
            label6.Text = "Price ($):";
            // 
            // adminAddProducts_stock
            // 
            adminAddProducts_stock.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddProducts_stock.Location = new Point(691, 9);
            adminAddProducts_stock.Margin = new Padding(4, 5, 4, 5);
            adminAddProducts_stock.Name = "adminAddProducts_stock";
            adminAddProducts_stock.Size = new Size(281, 30);
            adminAddProducts_stock.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(560, 17);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(69, 22);
            label7.TabIndex = 13;
            label7.Text = "Stock:";
            // 
            // adminAddProducts_type
            // 
            adminAddProducts_type.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddProducts_type.FormattingEnabled = true;
            adminAddProducts_type.Items.AddRange(new object[] { "Meal", "Drinks" });
            adminAddProducts_type.Location = new Point(173, 105);
            adminAddProducts_type.Margin = new Padding(4, 5, 4, 5);
            adminAddProducts_type.Name = "adminAddProducts_type";
            adminAddProducts_type.Size = new Size(281, 37);
            adminAddProducts_type.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(93, 112);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(61, 22);
            label5.TabIndex = 11;
            label5.Text = "Type:";
            // 
            // adminAddProducts_name
            // 
            adminAddProducts_name.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddProducts_name.Location = new Point(173, 57);
            adminAddProducts_name.Margin = new Padding(4, 5, 4, 5);
            adminAddProducts_name.Name = "adminAddProducts_name";
            adminAddProducts_name.Size = new Size(281, 30);
            adminAddProducts_name.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 59);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(147, 22);
            label3.TabIndex = 6;
            label3.Text = "Product Name:";
            // 
            // adminAddProducts_id
            // 
            adminAddProducts_id.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddProducts_id.Location = new Point(173, 17);
            adminAddProducts_id.Margin = new Padding(4, 5, 4, 5);
            adminAddProducts_id.Name = "adminAddProducts_id";
            adminAddProducts_id.Size = new Size(281, 30);
            adminAddProducts_id.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 22);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 4;
            label2.Text = "Product ID:";
            // 
            // AdminAddProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AdminAddProducts";
            Size = new Size(1251, 745);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)adminAddUsers_imageView).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)adminAddProducts_imageView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adminAddProducts_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adminAddProducts_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox adminAddProducts_type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox adminAddProducts_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adminAddProducts_price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox adminAddProducts_stock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button adminAddProducts_importBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox adminAddProducts_imageView;
        private System.Windows.Forms.Button adminAddProducts_clearBtn;
        private System.Windows.Forms.Button adminAddProducts_deleteBtn;
        private System.Windows.Forms.Button adminAddProducts_updateBtn;
        private System.Windows.Forms.Button adminAddProducts_addBtn;
        private System.Windows.Forms.DataGridView DataGridView1;
        private PictureBox adminAddUsers_imageView;
        private Button adminAddUsers_importBtn;
        private Panel panel4;
    }
}