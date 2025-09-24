
namespace CafeShopManagementSystem
{
    partial class CashierCustomersForm
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
            datagridview1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridview1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(datagridview1);
            panel1.Location = new Point(21, 96);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1198, 623);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(175, 28);
            label1.TabIndex = 3;
            label1.Text = "All Customers";
            // 
            // datagridview1
            // 
            datagridview1.AllowUserToAddRows = false;
            datagridview1.AllowUserToDeleteRows = false;
            datagridview1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridview1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 99, 102);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            datagridview1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            datagridview1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridview1.EnableHeadersVisualStyles = false;
            datagridview1.Location = new Point(16, 93);
            datagridview1.Margin = new Padding(4, 5, 4, 5);
            datagridview1.Name = "datagridview1";
            datagridview1.ReadOnly = true;
            datagridview1.RowHeadersVisible = false;
            datagridview1.RowHeadersWidth = 51;
            datagridview1.Size = new Size(1153, 503);
            datagridview1.TabIndex = 2;
            // 
            // CashierCustomersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CashierCustomersForm";
            Size = new Size(1250, 750);
            Load += CashierCustomersForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datagridview1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagridview1;
    }
}