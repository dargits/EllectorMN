
﻿namespace ElectorApp.Forms
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            account = new TextBox();
            password = new TextBox();
            repassword = new TextBox();
            name = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button_backLogin = new Button();
            button1 = new Button();
            message = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user1;
            pictureBox1.Location = new Point(580, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(266, 277);
            label2.Name = "label2";
            label2.Size = new Size(193, 38);
            label2.TabIndex = 2;
            label2.Text = "Tên Tài Khoản:";
            // 
            // account
            // 
            account.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            account.Location = new Point(560, 277);
            account.Name = "account";
            account.Size = new Size(431, 47);
            account.TabIndex = 3;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(560, 353);
            password.Name = "password";
            password.Size = new Size(431, 47);
            password.TabIndex = 5;
            // 
            // repassword
            // 
            repassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            repassword.Location = new Point(560, 435);
            repassword.Name = "repassword";
            repassword.Size = new Size(431, 47);
            repassword.TabIndex = 6;
            // 
            // name
            // 
            name.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name.Location = new Point(560, 511);
            name.Name = "name";
            name.Size = new Size(431, 47);
            name.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(266, 359);
            label1.Name = "label1";
            label1.Size = new Size(141, 38);
            label1.TabIndex = 8;
            label1.Text = "Mật Khẩu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(266, 441);
            label3.Name = "label3";
            label3.Size = new Size(268, 38);
            label3.TabIndex = 9;
            label3.Text = "Xác Nhận Mật Khẩu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(266, 517);
            label4.Name = "label4";
            label4.Size = new Size(147, 38);
            label4.TabIndex = 10;
            label4.Text = "Họ Và Tên:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(2, 819);
            label5.Name = "label5";
            label5.Size = new Size(67, 25);
            label5.TabIndex = 13;
            label5.Text = "byNSS";
            // 
            // button_backLogin
            // 
            button_backLogin.BackColor = SystemColors.Highlight;
            button_backLogin.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_backLogin.ForeColor = SystemColors.Control;
            button_backLogin.Location = new Point(410, 646);
            button_backLogin.Name = "button_backLogin";
            button_backLogin.Size = new Size(190, 61);
            button_backLogin.TabIndex = 14;
            button_backLogin.Text = "Đăng Nhập";
            button_backLogin.UseVisualStyleBackColor = false;
            button_backLogin.Click += button_backLogin_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(720, 646);
            button1.Name = "button1";
            button1.Size = new Size(190, 61);
            button1.TabIndex = 15;
            button1.Text = "Đăng Ký";
            button1.UseVisualStyleBackColor = false;
            button1.Click += click_Register;
            // 
            // message
            // 
            message.AutoSize = true;
            message.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            message.ForeColor = Color.Red;
            message.Location = new Point(601, 603);
            message.Name = "message";
            message.Size = new Size(0, 23);
            message.TabIndex = 16;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 853);
            Controls.Add(message);
            Controls.Add(button1);
            Controls.Add(button_backLogin);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(name);
            Controls.Add(repassword);
            Controls.Add(password);
            Controls.Add(account);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Ký";
            FormClosing += Close;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private TextBox account;
        private TextBox password;
        private TextBox repassword;
        private TextBox name;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button_backLogin;
        private Label message;
    }
}