using MySql.Data.MySqlClient;

namespace FashionStore.Data
{
    public class ConnectDB
    {
        private static string hostname = "localhost";
        private static string username = "root";
        private static string password = "";
        private static string database = "clothes";
        private static int port = 3306;

        public static MySqlConnection ConnectionMySql ()
        {
            string connStr = String.Format($"Server={hostname}; Database={database}; User={username}; Password={password}; Port={port}");
            return new MySqlConnection(connStr);
        }
    }
}
