using AppointmentApp.Core.DataTransfer;
using AppointmentApp.Core.Models;
using MySql.Data.MySqlClient;
using System.ComponentModel;

namespace AppointmentApp.Core.Data
{
    public static class CustomerRepository
    {
        public static CustomerRecord AddCustomer(String username, Address address, City city, Country country, Customer customer)
        {
            using (MySqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        CountryRepository.RetrieveOrInsertCountry(username, country, connection, transaction);
                        city.CountryId = country.CountryId;

                        CityRepository.RetrieveOrInsertCity(username, city, connection, transaction);
                        address.CityId = city.CityId;

                        AddressRepository.RetrieveOrInsertAddress(username, address, connection, transaction);
                        customer.AddressId = address.AddressId;

                        InsertCustomer(username, customer, connection, transaction);

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            return new CustomerRecord
            {
                CustomerId = customer.CustomerId,
                CustomerName = customer.CustomerName,
                Active = customer.Active,
                AddressId = address.AddressId,
                Address1 = address.Address1,
                Address2 = address.Address2,
                PostalCode = address.PostalCode,
                Phone = address.Phone,
                CityId = city.CityId,
                CityName = city.CityName,
                CountryId = country.CountryId,
                CountryName = country.CountryName
            };
        }

        public static void ModifyCustomer(String username, Address address, City city, Country country, Customer customer)
        {
            using (MySqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        CountryRepository.RetrieveOrInsertCountry(username, country, connection, transaction);
                        city.CountryId = country.CountryId;

                        CityRepository.RetrieveOrInsertCity(username, city, connection, transaction);
                        address.CityId = city.CityId;

                        AddressRepository.RetrieveOrInsertAddress(username, address, connection, transaction);
                        customer.AddressId = address.AddressId;

                        UpdateCustomer(username, customer, connection, transaction);

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public static void DeleteCustomer(int customerId)
        {
            string delete = @"DELETE FROM customer WHERE customerId = @id";

            using (MySqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(delete, connection))
                {
                    command.Parameters.AddWithValue("@id", customerId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static BindingList<CustomerRecord> GetAllCustomers()
        {
            string query = @"SELECT 
                        c.customerId, c.customerName, c.active,
                        a.addressId, a.address, a.address2, a.postalCode, a.phone,
                        ci.cityId, ci.city,
                        co.countryId, co.country
                     FROM customer c
                     JOIN address a ON c.addressId = a.addressId
                     JOIN city ci   ON a.cityId    = ci.cityId
                     JOIN country co ON ci.countryId = co.countryId";

            return QueryCustomers(query);
        }
        public static BindingList<CustomerRecord> SearchCustomers(string search)
        {
            string query = @"SELECT
                        c.customerId, c.customerName, c.active,
                        a.addressId, a.address, a.address2, a.postalCode, a.phone,
                        ci.cityId, ci.city,
                        co.countryId, co.country
                     FROM customer c
                     JOIN address a ON c.addressId = a.addressId
                     JOIN city ci ON a.cityId = ci.cityId
                     JOIN country co ON ci.countryId = co.countryId
                     WHERE c.customerName LIKE @term";

            var parameters = new Dictionary<string, object>
            {
                { "@term", $"%{search}%" }
            };

            return QueryCustomers(query, parameters);
        }


        private static BindingList<CustomerRecord> QueryCustomers(string query, Dictionary<string, object>? parameters = null)
        {
            using (MySqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var p in parameters)
                            command.Parameters.AddWithValue(p.Key, p.Value);
                    }

                    using (var reader = command.ExecuteReader())
                    {
                        var results = new BindingList<CustomerRecord>();
                        while (reader.Read())
                        {
                            results.Add(new CustomerRecord
                            {
                                CustomerId = reader.GetInt32("customerId"),
                                CustomerName = reader.GetString("customerName"),
                                Active = reader.GetInt32("active"),

                                AddressId = reader.GetInt32("addressId"),
                                Address1 = reader.GetString("address"),
                                Address2 = reader.GetString("address2"),
                                PostalCode = reader.GetString("postalCode"),
                                Phone = reader.GetString("phone"),

                                CityId = reader.GetInt32("cityId"),
                                CityName = reader.GetString("city"),

                                CountryId = reader.GetInt32("countryId"),
                                CountryName = reader.GetString("country")
                            });
                        }
                        return results;
                    }
                }
            }
        }


        private static void InsertCustomer(string username, Customer customer, MySqlConnection connection, MySqlTransaction transaction)
        {
            string insert = @"INSERT INTO customer 
                             (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy)
                             VALUES (@customerName, @addressId, @active, NOW(), @username, NOW(), @username)";
            using (MySqlCommand command = new(insert, connection, transaction))
            {
                command.Parameters.AddWithValue("@customerName", customer.CustomerName);
                command.Parameters.AddWithValue("@addressId", customer.AddressId);
                command.Parameters.AddWithValue("@active", 1);
                command.Parameters.AddWithValue("@username", username.Length > 40 ? username.Substring(0, 40) : username);

                command.ExecuteNonQuery();

                customer.CustomerId = (int)command.LastInsertedId;
            }
        }

        private static void UpdateCustomer(string username, Customer customer, MySqlConnection connection, MySqlTransaction transaction)
        {
            string update = @"UPDATE customer
                      SET customerName = @customerName,
                          addressId    = @addressId,
                          active       = @active,
                          lastUpdate   = NOW(),
                          lastUpdateBy = @username
                      WHERE customerId = @customerId";

            using (MySqlCommand command = new(update, connection, transaction))
            {
                command.Parameters.AddWithValue("@customerName", customer.CustomerName);
                command.Parameters.AddWithValue("@addressId", customer.AddressId);
                command.Parameters.AddWithValue("@active", customer.Active);
                command.Parameters.AddWithValue("@username", username.Length > 40 ? username.Substring(0, 40) : username);
                command.Parameters.AddWithValue("@customerId", customer.CustomerId);

                command.ExecuteNonQuery();
            }
        }
    }
}
