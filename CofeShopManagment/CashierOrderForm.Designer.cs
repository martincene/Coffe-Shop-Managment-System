
namespace CafeShopManagementSystem
{
    partial class CashierOrderForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierOrderForm));
            panel1 = new Panel();
            label1 = new Label();
            cashierOrderForm_menuTable = new DataGridView();
            panel2 = new Panel();
            label7 = new Label();
            label5 = new Label();
            cashierOrderForm_clearBtn = new Button();
            cashierOrderForm_removeBtn = new Button();
            cashierOrderForm_addBtn = new Button();
            cashierOrderForm_price = new Label();
            label8 = new Label();
            label6 = new Label();
            cashierOrderForm_quantity = new NumericUpDown();
            cashierOrderForm_prodName = new Label();
            label3 = new Label();
            cashierOrderForm_productID = new ComboBox();
            label2 = new Label();
            cashierOrderForm_type = new ComboBox();
            label4 = new Label();
            panel3 = new Panel();
            cashierOrderForm_receiptBtn = new Button();
            cashierOrderForm_payBtn = new Button();
            cashierOrderForm_change = new Label();
            label13 = new Label();
            cashierOrderForm_amount = new TextBox();
            label11 = new Label();
            cashierOrderForm_orderPrice = new Label();
            label10 = new Label();
            cashierOrderForm_orderTable = new DataGridView();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cashierOrderForm_menuTable).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cashierOrderForm_quantity).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cashierOrderForm_orderTable).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cashierOrderForm_menuTable);
            panel1.Location = new Point(4, 20);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(765, 419);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 28);
            label1.TabIndex = 3;
            label1.Text = "Menu";
            // 
            // cashierOrderForm_menuTable
            // 
            cashierOrderForm_menuTable.AllowUserToAddRows = false;
            cashierOrderForm_menuTable.AllowUserToDeleteRows = false;
            cashierOrderForm_menuTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cashierOrderForm_menuTable.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 99, 102);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            cashierOrderForm_menuTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            cashierOrderForm_menuTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cashierOrderForm_menuTable.EnableHeadersVisualStyles = false;
            cashierOrderForm_menuTable.Location = new Point(16, 46);
            cashierOrderForm_menuTable.Margin = new Padding(4, 5, 4, 5);
            cashierOrderForm_menuTable.Name = "cashierOrderForm_menuTable";
            cashierOrderForm_menuTable.ReadOnly = true;
            cashierOrderForm_menuTable.RowHeadersVisible = false;
            cashierOrderForm_menuTable.RowHeadersWidth = 51;
            cashierOrderForm_menuTable.Size = new Size(733, 353);
            cashierOrderForm_menuTable.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cashierOrderForm_clearBtn);
            panel2.Controls.Add(cashierOrderForm_removeBtn);
            panel2.Controls.Add(cashierOrderForm_addBtn);
            panel2.Controls.Add(cashierOrderForm_price);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(cashierOrderForm_quantity);
            panel2.Controls.Add(cashierOrderForm_prodName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cashierOrderForm_productID);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cashierOrderForm_type);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(4, 435);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(765, 308);
            panel2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(187, 93);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(128, 22);
            label7.TabIndex = 28;
            label7.Text = "Test Product";
            label7.Click += label7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(187, 166);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(43, 22);
            label5.TabIndex = 27;
            label5.Text = "100";
            // 
            // cashierOrderForm_clearBtn
            // 
            cashierOrderForm_clearBtn.BackColor = Color.FromArgb(7, 99, 102);
            cashierOrderForm_clearBtn.FlatStyle = FlatStyle.Flat;
            cashierOrderForm_clearBtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrderForm_clearBtn.ForeColor = Color.White;
            cashierOrderForm_clearBtn.Location = new Point(492, 239);
            cashierOrderForm_clearBtn.Margin = new Padding(4, 5, 4, 5);
            cashierOrderForm_clearBtn.Name = "cashierOrderForm_clearBtn";
            cashierOrderForm_clearBtn.Size = new Size(176, 45);
            cashierOrderForm_clearBtn.TabIndex = 24;
            cashierOrderForm_clearBtn.Text = "CLEAR";
            cashierOrderForm_clearBtn.UseVisualStyleBackColor = false;
            cashierOrderForm_clearBtn.Click += cashierOrderForm_clearBtn_Click_1;
            // 
            // cashierOrderForm_removeBtn
            // 
            cashierOrderForm_removeBtn.BackColor = Color.FromArgb(7, 99, 102);
            cashierOrderForm_removeBtn.FlatStyle = FlatStyle.Flat;
            cashierOrderForm_removeBtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrderForm_removeBtn.ForeColor = Color.White;
            cashierOrderForm_removeBtn.Location = new Point(268, 239);
            cashierOrderForm_removeBtn.Margin = new Padding(4, 5, 4, 5);
            cashierOrderForm_removeBtn.Name = "cashierOrderForm_removeBtn";
            cashierOrderForm_removeBtn.Size = new Size(152, 45);
            cashierOrderForm_removeBtn.TabIndex = 23;
            cashierOrderForm_removeBtn.Text = "REMOVE";
            cashierOrderForm_removeBtn.UseVisualStyleBackColor = false;
            cashierOrderForm_removeBtn.Click += cashierOrderForm_removeBtn_Click;
            // 
            // cashierOrderForm_addBtn
            // 
            cashierOrderForm_addBtn.BackColor = Color.FromArgb(7, 99, 102);
            cashierOrderForm_addBtn.FlatStyle = FlatStyle.Flat;
            cashierOrderForm_addBtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrderForm_addBtn.ForeColor = Color.White;
            cashierOrderForm_addBtn.Location = new Point(36, 239);
            cashierOrderForm_addBtn.Margin = new Padding(4, 5, 4, 5);
            cashierOrderForm_addBtn.Name = "cashierOrderForm_addBtn";
            cashierOrderForm_addBtn.Size = new Size(159, 45);
            cashierOrderForm_addBtn.TabIndex = 22;
            cashierOrderForm_addBtn.Text = "ADD";
            cashierOrderForm_addBtn.UseVisualStyleBackColor = false;
            cashierOrderForm_addBtn.Click += cashierOrderForm_addBtn_Click;
            // 
            // cashierOrderForm_price
            // 
            cashierOrderForm_price.AutoSize = true;
            cashierOrderForm_price.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrderForm_price.Location = new Point(187, 262);
            cashierOrderForm_price.Margin = new Padding(4, 0, 4, 0);
            cashierOrderForm_price.Name = "cashierOrderForm_price";
            cashierOrderForm_price.Size = new Size(0, 22);
            cashierOrderForm_price.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(85, 163);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(94, 22);
            label8.TabIndex = 20;
            label8.Text = "Price ($):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(432, 101);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(93, 22);
            label6.TabIndex = 19;
            label6.Text = "Quantity:";
            // 
            // cashierOrderForm_quantity
            // 
            cashierOrderForm_quantity.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrderForm_quantity.Location = new Point(554, 94);
            cashierOrderForm_quantity.Margin = new Padding(4, 5, 4, 5);
            cashierOrderForm_quantity.Name = "cashierOrderForm_quantity";
            cashierOrderForm_quantity.Size = new Size(182, 35);
            cashierOrderForm_quantity.TabIndex = 18;
            // 
            // cashierOrderForm_prodName
            // 
            cashierOrderForm_prodName.AutoSize = true;
            cashierOrderForm_prodName.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrderForm_prodName.Location = new Point(187, 174);
            cashierOrderForm_prodName.Margin = new Padding(4, 0, 4, 0);
            cashierOrderForm_prodName.Name = "cashierOrderForm_prodName";
            cashierOrderForm_prodName.Size = new Size(0, 22);
            cashierOrderForm_prodName.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 93);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(147, 22);
            label3.TabIndex = 16;
            label3.Text = "Product Name:";
            // 
            // cashierOrderForm_productID
            // 
            cashierOrderForm_productID.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrderForm_productID.FormattingEnabled = true;
            cashierOrderForm_productID.Location = new Point(554, 14);
            cashierOrderForm_productID.Margin = new Padding(4, 5, 4, 5);
            cashierOrderForm_productID.Name = "cashierOrderForm_productID";
            cashierOrderForm_productID.Size = new Size(182, 37);
            cashierOrderForm_productID.TabIndex = 15;
            cashierOrderForm_productID.SelectedIndexChanged += cashierOrderForm_productID_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(432, 29);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 22);
            label2.TabIndex = 14;
            label2.Text = "Product ID:";
            // 
            // cashierOrderForm_type
            // 
            cashierOrderForm_type.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrderForm_type.FormattingEnabled = true;
            cashierOrderForm_type.Items.AddRange(new object[] { "Meal", "Drinks" });
            cashierOrderForm_type.Location = new Point(187, 14);
            cashierOrderForm_type.Margin = new Padding(4, 5, 4, 5);
            cashierOrderForm_type.Name = "cashierOrderForm_type";
            cashierOrderForm_type.Size = new Size(214, 37);
            cashierOrderForm_type.TabIndex = 13;
            cashierOrderForm_type.SelectedIndexChanged += cashierOrderForm_type_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(118, 22);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 22);
            label4.TabIndex = 12;
            label4.Text = "Type:";
            label4.Click += label4_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(cashierOrderForm_receiptBtn);
            panel3.Controls.Add(cashierOrderForm_payBtn);
            panel3.Controls.Add(cashierOrderForm_change);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(cashierOrderForm_amount);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(cashierOrderForm_orderPrice);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(cashierOrderForm_orderTable);
            panel3.Location = new Point(777, 20);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(437, 723);
            panel3.TabIndex = 2;
            // 
            // cashierOrderForm_receiptBtn
            // 
            cashierOrderForm_receiptBtn.BackColor = Color.FromArgb(7, 99, 102);
            cashierOrderForm_receiptBtn.FlatStyle = FlatStyle.Flat;
            cashierOrderForm_receiptBtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrderForm_receiptBtn.ForeColor = Color.White;
            cashierOrderForm_receiptBtn.Location = new Point(21, 666);
            cashierOrderForm_receiptBtn.Margin = new Padding(4, 5, 4, 5);
            cashierOrderForm_receiptBtn.Name = "cashierOrderForm_receiptBtn";
            cashierOrderForm_receiptBtn.Size = new Size(382, 41);
            cashierOrderForm_receiptBtn.TabIndex = 30;
            cashierOrderForm_receiptBtn.Text = "RECEIPT";
            cashierOrderForm_receiptBtn.UseVisualStyleBackColor = false;
            cashierOrderForm_receiptBtn.Click += cashierOrderForm_receiptBtn_Click;
            // 
            // cashierOrderForm_payBtn
            // 
            cashierOrderForm_payBtn.BackColor = Color.FromArgb(7, 99, 102);
            cashierOrderForm_payBtn.FlatStyle = FlatStyle.Flat;
            cashierOrderForm_payBtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrderForm_payBtn.ForeColor = Color.White;
            cashierOrderForm_payBtn.Location = new Point(21, 611);
            cashierOrderForm_payBtn.Margin = new Padding(4, 5, 4, 5);
            cashierOrderForm_payBtn.Name = "cashierOrderForm_payBtn";
            cashierOrderForm_payBtn.Size = new Size(382, 45);
            cashierOrderForm_payBtn.TabIndex = 29;
            cashierOrderForm_payBtn.Text = "PAY";
            cashierOrderForm_payBtn.UseVisualStyleBackColor = false;
            cashierOrderForm_payBtn.Click += cashierOrderForm_payBtn_Click;
            // 
            // cashierOrderForm_change
            // 
            cashierOrderForm_change.AutoSize = true;
            cashierOrderForm_change.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrderForm_change.Location = new Point(225, 569);
            cashierOrderForm_change.Margin = new Padding(4, 0, 4, 0);
            cashierOrderForm_change.Name = "cashierOrderForm_change";
            cashierOrderForm_change.Size = new Size(21, 22);
            cashierOrderForm_change.TabIndex = 26;
            cashierOrderForm_change.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(101, 569);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(116, 22);
            label13.TabIndex = 25;
            label13.Text = "Change ($):";
            // 
            // cashierOrderForm_amount
            // 
            cashierOrderForm_amount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrderForm_amount.Location = new Point(225, 511);
            cashierOrderForm_amount.Margin = new Padding(4, 5, 4, 5);
            cashierOrderForm_amount.Name = "cashierOrderForm_amount";
            cashierOrderForm_amount.Size = new Size(178, 30);
            cashierOrderForm_amount.TabIndex = 28;
            cashierOrderForm_amount.TextChanged += cashierOrderForm_amount_TextChanged;
            cashierOrderForm_amount.KeyDown += cashierOrderForm_amount_KeyDown;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(100, 515);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(117, 22);
            label11.TabIndex = 27;
            label11.Text = "Amount ($):";
            // 
            // cashierOrderForm_orderPrice
            // 
            cashierOrderForm_orderPrice.AutoSize = true;
            cashierOrderForm_orderPrice.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrderForm_orderPrice.Location = new Point(211, 459);
            cashierOrderForm_orderPrice.Margin = new Padding(4, 0, 4, 0);
            cashierOrderForm_orderPrice.Name = "cashierOrderForm_orderPrice";
            cashierOrderForm_orderPrice.Size = new Size(21, 22);
            cashierOrderForm_orderPrice.TabIndex = 26;
            cashierOrderForm_orderPrice.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(100, 459);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(94, 22);
            label10.TabIndex = 25;
            label10.Text = "Price ($):";
            // 
            // cashierOrderForm_orderTable
            // 
            cashierOrderForm_orderTable.AllowUserToAddRows = false;
            cashierOrderForm_orderTable.AllowUserToDeleteRows = false;
            cashierOrderForm_orderTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cashierOrderForm_orderTable.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(7, 99, 102);
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            cashierOrderForm_orderTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            cashierOrderForm_orderTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cashierOrderForm_orderTable.EnableHeadersVisualStyles = false;
            cashierOrderForm_orderTable.Location = new Point(62, 25);
            cashierOrderForm_orderTable.Margin = new Padding(4, 5, 4, 5);
            cashierOrderForm_orderTable.Name = "cashierOrderForm_orderTable";
            cashierOrderForm_orderTable.ReadOnly = true;
            cashierOrderForm_orderTable.RowHeadersVisible = false;
            cashierOrderForm_orderTable.RowHeadersWidth = 51;
            cashierOrderForm_orderTable.Size = new Size(318, 363);
            cashierOrderForm_orderTable.TabIndex = 4;
            cashierOrderForm_orderTable.CellClick += cashierOrderForm_orderTable_CellClick;
            cashierOrderForm_orderTable.CellContentClick += cashierOrderForm_orderTable_CellContentClick;
            // 
            // printDocument1
            // 
            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // CashierOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CashierOrderForm";
            Size = new Size(1251, 751);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cashierOrderForm_menuTable).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cashierOrderForm_quantity).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cashierOrderForm_orderTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView cashierOrderForm_menuTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cashierOrderForm_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cashierOrderForm_productID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cashierOrderForm_prodName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown cashierOrderForm_quantity;
        private System.Windows.Forms.Label cashierOrderForm_price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cashierOrderForm_addBtn;
        private System.Windows.Forms.Button cashierOrderForm_removeBtn;
        private System.Windows.Forms.Button cashierOrderForm_clearBtn;
        private System.Windows.Forms.Label cashierOrderForm_orderPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView cashierOrderForm_orderTable;
        private System.Windows.Forms.TextBox cashierOrderForm_amount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label cashierOrderForm_change;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button cashierOrderForm_payBtn;
        private System.Windows.Forms.Button cashierOrderForm_receiptBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Label label7;
        private Label label5;
    }
}