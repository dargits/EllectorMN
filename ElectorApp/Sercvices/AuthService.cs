using ElectorApp.Models;
using ElectorApp.Repository;
using ElectorApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ElectorApp.Services.AuthService.cs
{
    internal class AuthService
    {
        private UserRepository userRepository = new UserRepository();

        public AuthService() { }

        public AuthService(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public string createAccount(string account, string password, string repassword, string name)
        {
            if (userRepository.existsByAccount(account)) return "Tài khoản này đã tồn tại.";
            if (!repassword.Equals(password)) return "Mật khẩu xác nhận không khớp.";
            if (userRepository.createAccount(account, password, name) == 1) return "Tạo tài khoản thành công.";
            return "Tạo tài khoản thất bại.";
        }
        public string Login(string account, string password)
        {
            User user = userRepository.findUserByAccount(account);
            if (user == null) return $"Tài khoản không tông tại. {account}";

            if (user.Password == password)
            {
                SessionManager.Login(user.ID, user.IsAdmin);
                return "Đăng Nhập Thành Công.";
            }
            else return "Mật khẩu không chính xác.";
        }


    }
}

