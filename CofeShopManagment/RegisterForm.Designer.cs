namespace CofeShopManagment
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            panel1 = new Panel();
            label4 = new Label();
            register_loginBtn = new Button();
            label5 = new Label();
            register_btn = new Button();
            register_showPass = new CheckBox();
            register_cPassword = new MaskedTextBox();
            label3 = new Label();
            register_username = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            register_password = new MaskedTextBox();
            label6 = new Label();
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
            panel1.Controls.Add(register_loginBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 394);
            panel1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 304);
            label4.Name = "label4";
            label4.Size = new Size(198, 17);
            label4.TabIndex = 9;
            label4.Text = "Already have an account?";
            // 
            // register_loginBtn
            // 
            register_loginBtn.BackColor = Color.FromArgb(7, 99, 102);
            register_loginBtn.FlatStyle = FlatStyle.Flat;
            register_loginBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_loginBtn.ForeColor = SystemColors.ButtonHighlight;
            register_loginBtn.Location = new Point(12, 334);
            register_loginBtn.Name = "register_loginBtn";
            register_loginBtn.Size = new Size(189, 29);
            register_loginBtn.TabIndex = 8;
            register_loginBtn.Text = "SIGNIN";
            register_loginBtn.UseVisualStyleBackColor = false;
            register_loginBtn.Click += register_loginBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(587, 9);
            label5.Name = "label5";
            label5.Size = new Size(18, 20);
            label5.TabIndex = 17;
            label5.Text = "X";
            // 
            // register_btn
            // 
            register_btn.BackColor = Color.FromArgb(7, 99, 102);
            register_btn.FlatStyle = FlatStyle.Flat;
            register_btn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_btn.ForeColor = SystemColors.ButtonHighlight;
            register_btn.Location = new Point(257, 304);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(94, 29);
            register_btn.TabIndex = 16;
            register_btn.Text = "SIGNUP";
            register_btn.UseVisualStyleBackColor = false;
            register_btn.Click += register_btn_Click;
            // 
            // register_showPass
            // 
            register_showPass.AutoSize = true;
            register_showPass.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            register_showPass.Location = new Point(238, 256);
            register_showPass.Name = "register_showPass";
            register_showPass.Size = new Size(127, 21);
            register_showPass.TabIndex = 15;
            register_showPass.Text = "SHow Password";
            register_showPass.UseVisualStyleBackColor = true;
            register_showPass.CheckedChanged += register_showPass_CheckedChanged;
            // 
            // register_cPassword
            // 
            register_cPassword.Location = new Point(238, 223);
            register_cPassword.Name = "register_cPassword";
            register_cPassword.PasswordChar = '*';
            register_cPassword.Size = new Size(223, 27);
            register_cPassword.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(238, 200);
            label3.Name = "label3";
            label3.Size = new Size(160, 20);
            label3.TabIndex = 13;
            label3.Text = "Confirm Password";
            // 
            // register_username
            // 
            register_username.Location = new Point(238, 120);
            register_username.Name = "register_username";
            register_username.Size = new Size(223, 27);
            register_username.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(238, 95);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 11;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(252, 46);
            label1.Name = "label1";
            label1.Size = new Size(99, 27);
            label1.TabIndex = 10;
            label1.Text = "SING IN";
            // 
            // register_password
            // 
            register_password.Location = new Point(238, 173);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(223, 27);
            register_password.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(238, 150);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 19;
            label6.Text = "Password";
            // 
            // close
            // 
            close.AutoSize = true;
            close.Location = new Point(514, 10);
            close.Name = "close";
            close.Size = new Size(18, 20);
            close.TabIndex = 20;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 88);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 394);
            Controls.Add(close);
            Controls.Add(label6);
            Controls.Add(register_password);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(register_btn);
            Controls.Add(register_showPass);
            Controls.Add(register_cPassword);
            Controls.Add(label3);
            Controls.Add(register_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Button register_loginBtn;
        private Label label5;
        private Button register_btn;
        private CheckBox register_showPass;
        private MaskedTextBox register_cPassword;
        private Label label3;
        private MaskedTextBox register_username;
        private Label label2;
        private Label label1;
        private MaskedTextBox register_password;
        private Label label6;
        private Label close;
        private PictureBox pictureBox1;
    }
}