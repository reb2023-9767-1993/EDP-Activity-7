using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GradingSystem
{
    public static class DbConfig
    {
        // Double-check your Port and Password (pwd) match your XAMPP/MySQL settings
        private static string connString = "server=127.0.0.1;port=3306;uid=root;pwd=1234;database=grading_system";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connString);
        }
    }
}