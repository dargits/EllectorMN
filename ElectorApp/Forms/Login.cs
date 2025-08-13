using ElectorApp.Services.AuthService.cs;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectorApp.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private async void click_login(object sender, EventArgs e)
        {
            string Account = account.Text.Trim();
            string Password = password.Text.Trim();

            if (string.IsNullOrEmpty(Account) || string.IsNullOrEmpty(Password))
            {
                message.Text = "Vui lòng nhập đủ các trường có đánh dấu '*'.";

                await Task.Delay(3000);
                message.ForeColor = Color.Red;
                message.Text = "";
                return;
            }

            AuthService AuthService = new AuthService();

            string mess = AuthService.Login(Account, Password);
            if (mess.Equals("Đăng Nhập Thành Công."))
                message.ForeColor = Color.Green;
            else
                message.ForeColor = Color.Red;

            message.Text = mess;
            await Task.Delay(3000);
            message.Text = "";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_DoubleClick(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }
    }
}
