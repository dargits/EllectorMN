
﻿namespace ElectorApp.Forms
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            account = new TextBox();
            linkLabel_Register = new LinkLabel();
            label2 = new Label();
            button_Login = new Button();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            password = new TextBox();
            label1 = new Label();
            message = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(389, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // account
            // 
            account.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            account.Location = new Point(501, 299);
            account.Name = "account";
            account.Size = new Size(386, 47);
            account.TabIndex = 3;
            // 
            // linkLabel_Register
            // 
            linkLabel_Register.AutoSize = true;
            linkLabel_Register.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel_Register.Location = new Point(785, 463);
            linkLabel_Register.Name = "linkLabel_Register";
            linkLabel_Register.Size = new Size(102, 31);
            linkLabel_Register.TabIndex = 4;
            linkLabel_Register.TabStop = true;
            linkLabel_Register.Text = "Đăng Ký";
            linkLabel_Register.LinkClicked += linkLabel_Register_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(462, 463);
            label2.Name = "label2";
            label2.Size = new Size(253, 31);
            label2.TabIndex = 5;
            label2.Text = "Bạn chưa có tài khoản?";
            // 
            // button_Login
            // 
            button_Login.BackColor = SystemColors.Highlight;
            button_Login.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Login.ForeColor = SystemColors.Control;
            button_Login.Location = new Point(572, 568);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(190, 61);
            button_Login.TabIndex = 6;
            button_Login.Text = "Đăng Nhập";
            button_Login.UseVisualStyleBackColor = false;
            button_Login.Click += click_login;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(539, 116);
            label3.Name = "label3";
            label3.Size = new Size(455, 106);
            label3.TabIndex = 7;
            label3.Text = "ElectorAPP";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(449, 299);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(449, 384);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 47);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(501, 384);
            password.Name = "password";
            password.Size = new Size(386, 47);
            password.TabIndex = 11;
            password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 819);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 12;
            label1.Text = "byNSS";
            // 
            // message
            // 
            message.AutoSize = true;
            message.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            message.ForeColor = Color.Red;
            message.Location = new Point(518, 262);
            message.Name = "message";
            message.Size = new Size(0, 23);
            message.TabIndex = 13;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 853);
            Controls.Add(message);
            Controls.Add(label1);
            Controls.Add(password);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(button_Login);
            Controls.Add(label2);
            Controls.Add(linkLabel_Register);
            Controls.Add(account);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ElectorAPP";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox account;
        private LinkLabel linkLabel_Register;
        private Label label2;
        private Button button_Login;
        private Label label3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox password;
        private Label label1;
        private Label message;
    }
}