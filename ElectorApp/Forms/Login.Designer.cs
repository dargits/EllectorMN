namespace ElectorApp.Forms
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
            account = new TextBox();
            password = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            message = new Label();
            SuspendLayout();
            // 
            // account
            // 
            account.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            account.Location = new Point(493, 176);
            account.Name = "account";
            account.Size = new Size(350, 43);
            account.TabIndex = 0;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            password.Location = new Point(493, 316);
            password.Name = "password";
            password.Size = new Size(350, 43);
            password.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(582, 403);
            button1.Name = "button1";
            button1.Size = new Size(178, 46);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += click_login;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(493, 144);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 3;
            label1.Text = "Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(493, 284);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // message
            // 
            message.AutoSize = true;
            message.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            message.Location = new Point(559, 490);
            message.Name = "message";
            message.Size = new Size(79, 25);
            message.TabIndex = 5;
            message.Text = "message";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 653);
            Controls.Add(message);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(password);
            Controls.Add(account);
            Name = "Login";
            Text = "Login";
            Load += Login_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox account;
        private TextBox password;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label message;
    }
}