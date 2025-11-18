using AppointmentApp.Core.Models;
using MySql.Data.MySqlClient;

namespace AppointmentApp.Core.Data
{
    public static class UserRepository
    {

        public static User? VerifyLogin(string username, string password)
        {
            using (MySqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                string query = @"SELECT userId, userName, password, active
                                 FROM user
                                 WHERE userName=@username AND password=@password AND active=1";

                using (MySqlCommand command = new(query, connection))
                {
                    command.Parameters.AddWithValue("username", username);
                    command.Parameters.AddWithValue("password", password);


                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                UserId = reader.GetInt32("userId"),
                                UserName = reader.GetString("userName"),
                                Password = reader.GetString("password"),
                                Active = reader.GetBoolean("active")
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}
