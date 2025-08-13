using MySqlConnector;
using System;
using System.Collections.Generic;
using ElectorApp.Repository;
using ElectorApp.Utils;

namespace ElectorApp.Service
{
    internal class PollService
    {
        private readonly PollRepository _pollRepository;

        public PollService()
        {
            _pollRepository = new PollRepository();
        }

        public String CreatePoll(string title, string description, int userId, List<(string OptionText, string ImageUrl)> options)
        {
            using (MySqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Logic nghiệp vụ: gọi phương thức từ Repository
                    int newPollId = _pollRepository.InsertPoll(connection, transaction, title, description, userId);

                    foreach (var option in options)
                    {
                        _pollRepository.InsertOption(connection, transaction, newPollId, option.OptionText, option.ImageUrl);
                    }

                    // Hoàn tất giao dịch
                    transaction.Commit();
                    return "Tạo cuộc bình chọn thành công.";
                }
                catch (Exception ex)
                {
                    // Hủy bỏ giao dịch nếu có lỗi
                    transaction.Rollback();
                    Console.WriteLine($"Lỗi tạo cuộc bình chọn: {ex.Message}");
                    throw; // Ném lại lỗi để lớp gọi có thể xử lý
                }
            }
        }
    }
}