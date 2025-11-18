using MySql.Data.MySqlClient;

namespace AppointmentApp.Core.Data
{
    public static class Database
    {
        private static readonly string connectionString =
            "server=127.0.0.1;port=3306;user=sqlUser;password=Passw0rd!;database=client_schedule;";
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
