using System;

namespace CS_Project.Service
{

    static class Service
    {
        private static string Connexion;
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
        }

    }
}