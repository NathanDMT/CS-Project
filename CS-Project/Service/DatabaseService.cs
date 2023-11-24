using System;
using MySql.Data.MySqlClient;

namespace CS_Project.Service
{

    static class DatabaseService
    {
        private static MySqlConnection Connexion;

        private const string _server = "localhost";
        private const string _port = "3306";
        private const string _user = "root";
        private const string _password = "";
        private const string _database = "menageleccsharp";

        public static void InitializeConnection()
        {
            var url = $"server={_server};" +
                  $"port={_port};" +
                  $"user={_user};" +
                  $"password={_password};" +
                  $"database={_database};";

            Connexion = new MySqlConnection(url);
        }

        public static MySqlConnection GetConnexion() { 
            return Connexion;
        }

    }
}