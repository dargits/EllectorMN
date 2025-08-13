using MySqlConnector;
using System.Configuration;

namespace ElectorApp.Utils
{
    internal static class Connection
    {
        public static MySqlConnection GetConnection()
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyDb"].ConnectionString;
            return new MySqlConnection(connStr);
        }
    }
}
