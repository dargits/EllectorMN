using ElectorApp.Services.AuthService.cs;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        public async void click_Register(object sender, EventArgs e)
        {
            string Account = account.Text;
            string Password = password.Text.Replace(" ", "");
            string Repassword = repassword.Text.Replace(" ", "");
            string Name = name.Text;

            if (string.IsNullOrEmpty(Account) || string.IsNullOrEmpty(Password) ||
                string.IsNullOrEmpty(Repassword) || string.IsNullOrEmpty(Name))
                {
                message.Text = "Vui lòng nhập đủ các trường.";
                await Task.Delay(3000);
                message.ForeColor = Color.Red;
                message.Text = "";
                return;
            }
            AuthService AuthService = new AuthService();

            string mess = AuthService.createAccount(Account, Password,Repassword,Name);
            if (mess.Equals("Tạo tài khoản thành công."))
                message.ForeColor = Color.Green;
            else
                message.ForeColor = Color.Red;

            message.Text = mess;
            await Task.Delay(3000);
            message.Text = "";

        }

        private void button_backLogin_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
