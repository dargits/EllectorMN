using MySqlConnector;
using System;
using System.Collections.Generic;
using ElectorApp.Utils;

namespace ElectorApp.Repository
{
    internal class PollRepository
    {
        public int InsertPoll(MySqlConnection connection, MySqlTransaction transaction, string title, string description, int userId)
        {
            string pollQuery = @"
                INSERT INTO Polls (Title, Description, CreatedAt, IsActive, UserID)
                VALUES (@Title, @Description, @CreatedAt, @IsActive, @UserID);
                SELECT LAST_INSERT_ID();";

            using (MySqlCommand pollCommand = new MySqlCommand(pollQuery, connection, transaction))
            {
                pollCommand.Parameters.AddWithValue("@Title", title);
                pollCommand.Parameters.AddWithValue("@Description", description);
                pollCommand.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                pollCommand.Parameters.AddWithValue("@IsActive", true);
                pollCommand.Parameters.AddWithValue("@UserID", userId);

                return Convert.ToInt32(pollCommand.ExecuteScalar());
            }
        }

        public void InsertOption(MySqlConnection connection, MySqlTransaction transaction, int pollId, string optionText, string imageUrl)
        {
            string optionsQuery = @"
                INSERT INTO Options (PollID, OptionText, ImageUrl)
                VALUES (@PollID, @OptionText, @ImageUrl);";

            using (MySqlCommand optionCommand = new MySqlCommand(optionsQuery, connection, transaction))
            {
                optionCommand.Parameters.AddWithValue("@PollID", pollId);
                optionCommand.Parameters.AddWithValue("@OptionText", optionText);
                optionCommand.Parameters.AddWithValue("@ImageUrl", (object)imageUrl ?? DBNull.Value);
                optionCommand.ExecuteNonQuery();
            }
        }
    }
}