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
                -- Tạo bảng Users để lưu trữ thông tin người dùng
                CREATE TABLE IF NOT EXISTS Users (
                    ID INT PRIMARY KEY AUTO_INCREMENT,
                    Account VARCHAR(50) NOT NULL UNIQUE,
                    Password VARCHAR(255) NOT NULL, -- Mật khẩu được lưu dưới dạng mã băm để bảo mật
                    IsAdmin BOOLEAN DEFAULT FALSE, -- TRUE cho quản trị viên, FALSE cho người dùng thông thường
                    Name VARCHAR(100) NULL,
                    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
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
