namespace CofeShopManagment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label4 = new Label();
            login_registerBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            login_username = new MaskedTextBox();
            label3 = new Label();
            login_password = new MaskedTextBox();
            login_showPass = new CheckBox();
            login_btn = new Button();
            close = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 99, 102);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(login_registerBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 375);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 300);
            label4.Name = "label4";
            label4.Size = new Size(130, 17);
            label4.TabIndex = 9;
            label4.Text = "Create account?";
            // 
            // login_registerBtn
            // 
            login_registerBtn.BackColor = Color.FromArgb(7, 99, 102);
            login_registerBtn.FlatStyle = FlatStyle.Flat;
            login_registerBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_registerBtn.ForeColor = SystemColors.ButtonHighlight;
            login_registerBtn.Location = new Point(3, 330);
            login_registerBtn.Name = "login_registerBtn";
            login_registerBtn.Size = new Size(169, 29);
            login_registerBtn.TabIndex = 8;
            login_registerBtn.Text = "Register";
            login_registerBtn.UseVisualStyleBackColor = false;
            login_registerBtn.Click += login_registerBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(209, 70);
            label1.Name = "label1";
            label1.Size = new Size(99, 27);
            label1.TabIndex = 1;
            label1.Text = "SING IN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(209, 129);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 2;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // login_username
            // 
            login_username.Location = new Point(209, 152);
            login_username.Name = "login_username";
            login_username.Size = new Size(146, 27);
            login_username.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(209, 200);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // login_password
            // 
            login_password.Location = new Point(209, 223);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(146, 27);
            login_password.TabIndex = 5;
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_showPass.Location = new Point(209, 256);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(127, 21);
            login_showPass.TabIndex = 6;
            login_showPass.Text = "SHow Password";
            login_showPass.UseVisualStyleBackColor = true;
            login_showPass.CheckedChanged += login_showPass_CheckedChanged;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(7, 99, 102);
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.ForeColor = SystemColors.ButtonHighlight;
            login_btn.Location = new Point(227, 294);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(94, 29);
            login_btn.TabIndex = 7;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Location = new Point(392, 5);
            close.Name = "close";
            close.Size = new Size(18, 20);
            close.TabIndex = 8;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 88);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 375);
            Controls.Add(close);
            Controls.Add(login_btn);
            Controls.Add(login_showPass);
            Controls.Add(login_password);
            Controls.Add(label3);
            Controls.Add(login_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private MaskedTextBox login_username;
        private Label label3;
        private MaskedTextBox login_password;
        private CheckBox login_showPass;
        private Button login_btn;
        private Label label4;
        private Button login_registerBtn;
        private Label close;
        private PictureBox pictureBox1;
    }
}
