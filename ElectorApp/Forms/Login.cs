using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElectorApp.Services;
using ElectorApp.Services.AuthService.cs;
namespace ElectorApp.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent(); // Khởi tạo các control trên form
        }

        private void linkLabel_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }
        private async void click_login(object sender, EventArgs e)
        {
            string Account = account.Text.Replace(" ", "");
            string Password = password.Text.Replace(" ", "");

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
        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
