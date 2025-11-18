using AppointmentApp.Core.Models;
using MySql.Data.MySqlClient;

namespace AppointmentApp.Core.Data
{
    internal static class CountryRepository
    {
        public static void RetrieveOrInsertCountry(String username, Country country, MySqlConnection connection, MySqlTransaction transaction)
        {
            string query = "SELECT countryId, country FROM country WHERE country=@name";

            using (MySqlCommand command = new(query, connection, transaction))
            {
                command.Parameters.AddWithValue("@name", country.CountryName);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        country.CountryId = reader.GetInt32("countryId");
                        return;
                    }
                }
            }

            string insert = @"INSERT INTO country (country, createDate, createdBy, lastUpdate, lastUpdateBy)
                         VALUES (@name, NOW(), @username , NOW(), @username)";

            using (MySqlCommand command = new(insert, connection, transaction))
            {
                command.Parameters.AddWithValue("@name", country.CountryName);
                command.Parameters.AddWithValue("@username", username.Length > 40 ? username.Substring(0, 40) : username);
                command.ExecuteNonQuery();

                int countryId = (int)command.LastInsertedId;

                country.CountryId = countryId;
            }
        }
    }
}
