
using MySqlConnector;
using System;
using System.Configuration;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ElectorApp.Utils
{
    internal class Connection
    {
        // Nội dung chứng chỉ được lưu trữ trong code
        private static string caCertificateContent = @"
-----BEGIN CERTIFICATE-----
MIIEUDCCArigAwIBAgIUeTY+B8MWwsyiOS2s2HnnGVKATW0wDQYJKoZIhvcNAQEM
BQAwQDE+MDwGA1UEAww1ZDI3NjE3MWYtMjRiMi00Yzg4LTk4YTMtODQyNDkzOGY5
NTI5IEdFTiAxIFByb2plY3QgQ0EwHhcNMjUwODExMTQyOTQyWhcNMzUwODA5MTQy
OTQyWjBAMT4wPAYDVQQDDDVkMjc2MTcxZi0yNGIyLTRjODgtOThhMy04NDI0OTM4
Zjk1MjkgR0VOIDEgUHJvamVjdCBDQTCCAaIwDQYJKoZIhvcNAQEBBQADggGPADCC
AYoCggGBAKiQX3GX1+1QgwcelJ5W7yMdCn3OTpTW1eKHOXUKQS3rEzSFzJvqRQB+
hRa+FhCOPkMk1A2LmpPEd+blbRSy4qiziiB8YAGAzQGhEyT5Se+G3eorQ1ebsF2Z
kWZS+eehGMUyCj7xaGq5ClAD/qOFt4RAnfQO5kgnBTqfJE9BohCtqwCH/WZGeTLz
LTeuYGSlToSXsSMinwHP1SOu7hjEhhmR5YtzLFdwsgINKrLcQxQDQ4tvwv2NlJ/T
vCmsbJm8OuNkavVtyMeT6GZbq6hdmSpquf1jS8JPtQm/mgttAZw/qt+XaWwSmaM1
wT7jMLqnodvRHY4pLGD+2QmibakHZI7p/DHA1c0c0hpJ/9sBK1Zx86me6ucEVAF3
FSyElMU4KeO1mhC2YUAr29xoSPgd8S4wyWsAg3v+3UBC7G4yk7w6l4qbmlkRlQQx
pTTsLHRvCCWjhcbeOhB0YnIuw0vys0iCNcAJJRCwK47dnG/PqqK642jQfmyQ5kXS
6D1VTfrn0QIDAQABo0IwQDAdBgNVHQ4EFgQUWXDtVTQqFoQ47AqUWYhs248FDSow
EgYDVR0TAQH/BAgwBgEB/wIBADALBgNVHQ8EBAMCAQYwDQYJKoZIhvcNAQEMBQAD
ggGBABtw8itukJ/FJChGHrE3JxlE8xbkSxDwHoYc6v0x3JZ/JoyF57Vqch8UPAbK
QWhXWMmu/lWC+aZTSCt4RX/WTcGM13QtonB4NSjyacSfuZrhH3sLJMTlseePr+96
dWtWsJpEa9MvlXz+uWXiysLJhdkVwCc8Q7OA8a2U+0DQTArLkYejeeHQWedX1RoM
gsZumUb800v+Fi8tGH3c5LYAy9uyagpYbVbEDFnkpnuMfYlVOegT91wct8uLmLtS
mUtbCTAWtPVuASvHLcc8awxC2zwvfvLVDXZEM9YRu8BYVNCXMy2D8vT9rUlDMEZr
Q3Bibh08v+D95j9Xo/iEGIN3wnFKq5fxIuhVgiXsaR3kDieuqcBTt90AsKkmP1Aa
MwBEIgGz2oCsQZNR3gVPUug8wIDJTFlDmzO6RCyupPZ3PSa8eRLKluFLVu4pVa+7
0FSFSGREsYjnz1WF3zFT0ggzMAdQ7oTZDjpC4U8Anf3XU7HZQz3vxEJKRrHcMH+f
IqZWow==
-----END CERTIFICATE-----
";

        public static MySqlConnection GetMySqlConnection()
        {
            try
            {
                // Bước 1: Đọc chuỗi đã mã hóa từ App.config
                string encryptedString = ConfigurationManager.AppSettings["EncryptedConnectionString"];
                if (string.IsNullOrEmpty(encryptedString))
                {
                    throw new InvalidOperationException("Chuỗi kết nối không được tìm thấy trong App.config.");
                }

                // Bước 2: Giải mã chuỗi Base64
                byte[] data = Convert.FromBase64String(encryptedString);
                string connectionString = Encoding.UTF8.GetString(data);

                // Bước 3: Tạo file ca.pem tạm thời từ nội dung đã nhúng vào code
                string tempFilePath = Path.Combine(Path.GetTempPath(), "ca.pem");
                File.WriteAllText(tempFilePath, caCertificateContent);

                // Bước 4: Thêm tham số chứng chỉ SSL vào chuỗi kết nối
                connectionString += $";SslCa={tempFilePath};";

                // Bước 5: Tạo và trả về đối tượng kết nối
                MessageBox.Show("OK");
                MySqlConnection connection = new MySqlConnection(connectionString);
                return connection;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Lỗi định dạng chuỗi kết nối: " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chuẩn bị kết nối: " + ex.Message);
                return null;
            }
        }

        // ... (phương thức TestConnection vẫn giữ nguyên)
    }
}