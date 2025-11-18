using AppointmentApp.Core.Models;
using MySql.Data.MySqlClient;

namespace AppointmentApp.Core.Data
{
    internal class CityRepository
    {
        public static void RetrieveOrInsertCity(string username, City city, MySqlConnection connection, MySqlTransaction transaction)
        {
            string query = "SELECT cityId, city, countryId FROM city WHERE city=@name and countryId=@countryId";

            using (MySqlCommand command = new(query, connection, transaction))
            {
                command.Parameters.AddWithValue("@name", city.CityName);
                command.Parameters.AddWithValue("@countryId", city.CountryId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        city.CityId = reader.GetInt32("cityId");
                        return;
                    }
                }
            }

            string insert = @"INSERT INTO city (city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy)
                         VALUES (@cityName, @countryId, NOW(), @username, NOW(), @username)";

            using (MySqlCommand command = new(insert, connection, transaction))
            {
                command.Parameters.AddWithValue("@cityName", city.CityName);
                command.Parameters.AddWithValue("@countryId", city.CountryId);
                command.Parameters.AddWithValue("@username", username.Length > 40 ? username.Substring(0, 40) : username);

                command.ExecuteNonQuery();

                int cityId = (int)command.LastInsertedId;

                city.CityId = cityId;
            }
        }
    }
}
