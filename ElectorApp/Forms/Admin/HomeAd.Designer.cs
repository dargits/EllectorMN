namespace ElectorApp.Forms.Admin
{
    partial class HomeAd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeAd));
            panel1 = new Panel();
            nameAdmin = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(nameAdmin);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1330, 100);
            panel1.TabIndex = 4;
            // 
            // nameAdmin
            // 
            nameAdmin.AutoSize = true;
            nameAdmin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            nameAdmin.ForeColor = Color.Lime;
            nameAdmin.Location = new Point(1019, 42);
            nameAdmin.Name = "nameAdmin";
            nameAdmin.Size = new Size(65, 25);
            nameAdmin.TabIndex = 6;
            nameAdmin.Text = "label3";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(863, 42);
            label2.Name = "label2";
            label2.Size = new Size(162, 25);
            label2.TabIndex = 4;
            label2.Text = "Xin Chào ADMIN,";
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
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(1204, 34);
            button2.Name = "button2";
            button2.Size = new Size(115, 37);
            button2.TabIndex = 2;
            button2.Text = "Đăng xuất";
            button2.UseVisualStyleBackColor = false;
            button2.Click += logout;
            // 
            // HomeAd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 853);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1350, 900);
            MinimumSize = new Size(1350, 900);
            Name = "HomeAd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ElectorApp";
            FormClosing += Close;
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label nameAdmin;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Button button2;
    }
}