namespace ElectorApp.Forms.User
{
    partial class HomeUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUser));
            FullName = new Label();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            nameUser = new Label();
            panel2 = new Panel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // FullName
            // 
            FullName.AutoSize = true;
            FullName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FullName.ForeColor = Color.Black;
            FullName.Location = new Point(191, 37);
            FullName.Name = "FullName";
            FullName.Size = new Size(0, 28);
            FullName.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(1204, 34);
            button1.Name = "button1";
            button1.Size = new Size(115, 37);
            button1.TabIndex = 2;
            button1.Text = "Đăng xuất";
            button1.UseVisualStyleBackColor = false;
            button1.Click += logout;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 8);
            label1.Name = "label1";
            label1.Size = new Size(345, 81);
            label1.TabIndex = 0;
            label1.Text = "ElectorAPP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(940, 42);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 4;
            label2.Text = "Xin Chào,";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.vote;
            pictureBox1.Location = new Point(21, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(nameUser);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1330, 100);
            panel1.TabIndex = 3;
            // 
            // nameUser
            // 
            nameUser.AutoSize = true;
            nameUser.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            nameUser.Location = new Point(1026, 42);
            nameUser.Name = "nameUser";
            nameUser.Size = new Size(65, 25);
            nameUser.TabIndex = 6;
            nameUser.Text = "label3";
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Location = new Point(1, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(429, 744);
            panel2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 9);
            label4.Name = "label4";
            label4.Size = new Size(400, 38);
            label4.TabIndex = 0;
            label4.Text = "Các cuộc bầu cử đang diễn ra.";
            // 
            // HomeUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 853);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(FullName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1350, 900);
            MinimumSize = new Size(1350, 900);
            Name = "HomeUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ElectorApp";
            FormClosing += Close;
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label FullName;
        private Button button1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private Label nameUser;
    }
}