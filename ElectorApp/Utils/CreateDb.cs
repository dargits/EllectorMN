using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
namespace ElectorApp.Utils
{
    internal class CreateDb
    {
        public static void create()
        {
            // Các câu lệnh SQL để tạo các bảng cho ứng dụng bình chọn
            string sqlScript = @"
                -- Tạo bảng Users
                CREATE TABLE IF NOT EXISTS Users (
                    ID INT PRIMARY KEY AUTO_INCREMENT,
                    Username VARCHAR(50) NOT NULL UNIQUE,
                    Password VARCHAR(255) NOT NULL,
                    IsAdmin TINYINT(1) DEFAULT 0,
                    FullName VARCHAR(100) NULL,
                    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP
                );

                -- Tạo bảng Polls
                CREATE TABLE IF NOT EXISTS Polls (
                    ID INT PRIMARY KEY AUTO_INCREMENT,
                    Title VARCHAR(255) NOT NULL,
                    Description TEXT NULL,
                    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                    IsActive TINYINT(1) DEFAULT 1
                );

                -- Tạo bảng Options
                CREATE TABLE IF NOT EXISTS Options (
                    ID INT PRIMARY KEY AUTO_INCREMENT,
                    PollID INT NOT NULL,
                    OptionText VARCHAR(255) NOT NULL,
                    FOREIGN KEY (PollID) REFERENCES Polls(ID) ON DELETE CASCADE ON UPDATE CASCADE
                );

                -- Tạo bảng Votes
                CREATE TABLE IF NOT EXISTS Votes (
                    ID INT PRIMARY KEY AUTO_INCREMENT,
                    PollID INT NOT NULL,
                    OptionID INT NOT NULL,
                    UserID INT NOT NULL,
                    VotedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                    FOREIGN KEY (PollID) REFERENCES Polls(ID) ON DELETE CASCADE ON UPDATE CASCADE,
                    FOREIGN KEY (OptionID) REFERENCES Options(ID) ON DELETE CASCADE ON UPDATE CASCADE,
                    FOREIGN KEY (UserID) REFERENCES Users(ID) ON DELETE CASCADE ON UPDATE CASCADE
                );
            ";


            try
            {
                // Đảm bảo lớp 'Connection' và phương thức 'GetConnection()' được triển khai đúng cách
                // để cung cấp một thể hiện MySqlConnection hợp lệ.
                using (MySqlConnection connection = Connection.GetConnection())
                {
                    if (connection != null)
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand(sqlScript, connection);
                        command.ExecuteNonQuery();
                        //MessageBox.Show("Các bảng cơ sở dữ liệu đã được tạo thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể thiết lập kết nối cơ sở dữ liệu. Vui lòng kiểm tra chuỗi kết nối của bạn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu việc tạo bảng thất bại
                MessageBox.Show("Lỗi kết nối database: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
