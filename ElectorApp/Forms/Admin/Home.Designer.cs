namespace ElectorApp.Forms.Admin
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label1 = new Label();
            label2 = new Label();
            FullName = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(557, 25);
            label1.Name = "label1";
            label1.Size = new Size(261, 46);
            label1.TabIndex = 0;
            label1.Text = "Trang Quản trị ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 43);
            label2.Name = "label2";
            label2.Size = new Size(123, 28);
            label2.TabIndex = 1;
            label2.Text = "Chào mừng: ";
            // 
            // FullName
            // 
            FullName.AutoSize = true;
            FullName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FullName.ForeColor = Color.ForestGreen;
            FullName.Location = new Point(150, 43);
            FullName.Name = "FullName";
            FullName.Size = new Size(82, 31);
            FullName.TabIndex = 2;
            FullName.Text = "admin";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(21, 780);
            button1.Name = "button1";
            button1.Size = new Size(138, 37);
            button1.TabIndex = 3;
            button1.Text = "Đăng xuất";
            button1.UseVisualStyleBackColor = false;
            button1.Click += logout;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 853);
            Controls.Add(button1);
            Controls.Add(FullName);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1350, 900);
            MinimumSize = new Size(1350, 900);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ElectorApp";
            FormClosing += Close;
            Load += Home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label FullName;
        private Button button1;
    }
}