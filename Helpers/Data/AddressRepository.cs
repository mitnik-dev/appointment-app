using AppointmentApp.Core.Models;
using MySql.Data.MySqlClient;

namespace AppointmentApp.Core.Data
{
    internal class AddressRepository
    {
        public static void RetrieveOrInsertAddress(string username, Address address, MySqlConnection connection, MySqlTransaction transaction)
        {
            string query = @"SELECT addressId, address, address2, cityId, postalCode, phone 
                        FROM address 
                        WHERE address = @address
                          AND address2 = @address2
                          AND postalCode = @postal 
                          AND phone = @phone 
                          AND cityId = @cityId";


            using (var checkCmd = new MySqlCommand(query, connection, transaction))
            {
                checkCmd.Parameters.AddWithValue("@address", address.Address1);
                checkCmd.Parameters.AddWithValue("@address2", address.Address2);
                checkCmd.Parameters.AddWithValue("@postal", address.PostalCode);
                checkCmd.Parameters.AddWithValue("@phone", address.Phone);
                checkCmd.Parameters.AddWithValue("@cityId", address.CityId);

                using (var reader = checkCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        address.AddressId = reader.GetInt32("addressId");
                        return;
                    }
                }
            }


            string insert = @"INSERT INTO address 
                           (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) 
                         VALUES 
                           (@address, @address2, @cityId, @postal, @phone, NOW(), @username, NOW(), @username)";

            using (var insertCmd = new MySqlCommand(insert, connection, transaction))
            {
                insertCmd.Parameters.AddWithValue("@address", address.Address1);
                insertCmd.Parameters.AddWithValue("@address2", address.Address2);
                insertCmd.Parameters.AddWithValue("@cityId", address.CityId);
                insertCmd.Parameters.AddWithValue("@postal", address.PostalCode);
                insertCmd.Parameters.AddWithValue("@phone", address.Phone);
                insertCmd.Parameters.AddWithValue("@username", username.Length > 40 ? username.Substring(0, 40) : username);

                insertCmd.ExecuteNonQuery();
                int newId = (int)insertCmd.LastInsertedId;

                address.AddressId = newId;
            }
        }
    }
}
