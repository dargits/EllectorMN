using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectorApp.Models;

namespace ElectorApp.Repository
{
    internal class UserRepository
    {
        public UserRepository() { }

        private string FindUserByAccount = "SELECT * FROM Users WHERE Account = @Account;";

        private string FindUSerById = "SELECT * FROM Users WHERE UserId = @UserId;";

        private string CreateAccount = "INSERT INTO Users (Account, Password, IsAdmin, Name)" +
            " VALUES (@Account, @Password, @IsAdmin, @Name);";

        private string ExitByAccount = "SELECT COUNT(*) FROM Users WHERE Account = @Account;";


        public int createAccount(string account, string password, String name)
        {
            using (MySqlConnection connection = Utils.Connection.GetConnection())
            {
                connection.Open();
                string query = CreateAccount;
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = query;

                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Account", account);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@IsAdmin", false);
                    command.Parameters.AddWithValue("@CreatedAt", DateTime.Now);

                    return command.ExecuteNonQuery();
                }
            }
        }

        public bool existsByAccount(string account)
        {
            using (MySqlConnection connection = Utils.Connection.GetConnection())
            {
                connection.Open();
                string query = ExitByAccount;
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@Account", account);
                    if ((long)command.ExecuteScalar() == 0) return false;
                    return true;
                }
            }
        }
        public User findUserByAccount(string account)
        {
            // Sử dụng khối 'using' để đảm bảo kết nối được đóng sau khi hoàn thành
            using (MySqlConnection connection = Utils.Connection.GetConnection())
            {
                
                connection.Open(); // Mở kết nối đến database
                // Định nghĩa câu lệnh SQL với tham số
                string sql = FindUserByAccount;
                // Sử dụng khối 'using' cho MySqlCommand
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    // Thêm tham số để tránh SQL Injection
                    command.Parameters.AddWithValue("@Account", account);
                    // Thực thi câu lệnh và nhận MySqlDataReader để đọc dữ liệu
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string Acccount = reader.GetString("Account");
                            bool IsAdmin = reader.GetBoolean("IsAdmin");
                            string Name = reader.GetString("Name");
                            int ID = reader.GetInt32("ID");
                            string Password = reader.GetString("Password");

                            return new User(ID, Acccount, IsAdmin, Name, Password);

                        }
                        return null;
                    }
                }
            }
        }

        public User findUserById(int Id)
        {
            // Sử dụng khối 'using' để đảm bảo kết nối được đóng sau khi hoàn thành
            using (MySqlConnection connection = Utils.Connection.GetConnection())
            {

                connection.Open(); // Mở kết nối đến database
                // Định nghĩa câu lệnh SQL với tham số
                string sql = FindUSerById;
                // Sử dụng khối 'using' cho MySqlCommand
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    // Thêm tham số để tránh SQL Injection
                    command.Parameters.AddWithValue("@UserId", Id);
                    // Thực thi câu lệnh và nhận MySqlDataReader để đọc dữ liệu
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string Acccount = reader.GetString("Account");
                            bool IsAdmin = reader.GetBoolean("IsAdmin");
                            string Name = reader.GetString("Name");
                            string Password = reader.GetString("Password");

                            return new User(Id, Acccount, IsAdmin, Name, Password);

                        }
                        return null;
                    }
                }
            }

        }

    }
}
