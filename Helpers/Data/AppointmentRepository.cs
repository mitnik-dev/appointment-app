using AppointmentApp.Core.DataTransfer;
using AppointmentApp.Core.Models;
using MySql.Data.MySqlClient;
using System.ComponentModel;

namespace AppointmentApp.Core.Data
{
    public static class AppointmentRepository
    {
        public static void AddAppointment(String username, Appointment appointment)
        {
            string insert = @"INSERT INTO appointment 
                             (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy)
                             VALUES (@customerId, @userId, @title, @description, @location, @contact, @type, @url, @start, @end, NOW(), @username, NOW(), @username)";

            using (MySqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(insert, connection))
                {
                    command.Parameters.AddWithValue("@customerId", appointment.CustomerID);
                    command.Parameters.AddWithValue("@userId", appointment.UserID);
                    command.Parameters.AddWithValue("@title", appointment.Title);
                    command.Parameters.AddWithValue("@description", appointment.Description);
                    command.Parameters.AddWithValue("@location", appointment.Location);
                    command.Parameters.AddWithValue("@contact", appointment.Contact);
                    command.Parameters.AddWithValue("@type", appointment.Type);
                    command.Parameters.AddWithValue("@url", appointment.Url);
                    command.Parameters.AddWithValue("@start", TimeZoneInfo.ConvertTimeBySystemTimeZoneId(appointment.Start, "Eastern Standard Time"));
                    command.Parameters.AddWithValue("@end", TimeZoneInfo.ConvertTimeBySystemTimeZoneId(appointment.End, "Eastern Standard Time"));
                    command.Parameters.AddWithValue("@username", username);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateAppointment(String username, Appointment appointment)
        {
            string update = @"UPDATE appointment
                             SET customerId = @customerId,
                                 userId = @userId,
                                 title = @title,
                                 description = @description,
                                 location = @location,
                                 contact = @contact,
                                 type = @type,
                                 url = @url,
                                 start = @start,
                                 end = @end,
                                 lastUpdate = NOW(),
                                 lastUpdateBy = @username
                             WHERE appointmentId = @appointmentId";

            using (MySqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(update, connection))
                {
                    command.Parameters.AddWithValue("@customerId", appointment.CustomerID);
                    command.Parameters.AddWithValue("@userId", appointment.UserID);
                    command.Parameters.AddWithValue("@title", appointment.Title);
                    command.Parameters.AddWithValue("@description", appointment.Description);
                    command.Parameters.AddWithValue("@location", appointment.Location);
                    command.Parameters.AddWithValue("@contact", appointment.Contact);
                    command.Parameters.AddWithValue("@type", appointment.Type);
                    command.Parameters.AddWithValue("@url", appointment.Url);
                    command.Parameters.AddWithValue("@start", TimeZoneInfo.ConvertTimeBySystemTimeZoneId(appointment.Start, "Eastern Standard Time"));
                    command.Parameters.AddWithValue("@end", TimeZoneInfo.ConvertTimeBySystemTimeZoneId(appointment.End, "Eastern Standard Time"));
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@appointmentId", appointment.AppointmentID);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteAppointment(int appointmentId)
        {
            string delete = @"DELETE FROM appointment WHERE appointmentId = @id";

            using (MySqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(delete, connection))
                {
                    command.Parameters.AddWithValue("@id", appointmentId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static BindingList<AppointmentRecord> GetAllAppointments()
        {
            string query = @"SELECT 
                        a.appointmentId, a.customerId, a.userId, a.title, a.description, 
                        a.location, a.contact, a.type, a.url, a.start, a.end,
                        c.customerName
                     FROM appointment a
                     JOIN customer c ON a.customerId = c.customerId";

            return QueryAppointments(query);
        }

        public static BindingList<AppointmentRecord> SearchAppointments(string search)
        {
            string query = @"SELECT 
                        a.appointmentId, a.customerId, a.userId, a.title, a.description, 
                        a.location, a.contact, a.type, a.url, a.start, a.end,
                        c.customerName
                     FROM appointment a
                     JOIN customer c ON a.customerId = c.customerId
                     WHERE a.title LIKE @search OR c.customerName LIKE @search";

            var parameters = new Dictionary<string, object>
            {
                { "@search", $"%{search}%" }
            };

            return QueryAppointments(query, parameters);
        }
        public static BindingList<AppointmentRecord> SearchAppointmentsByDate(DateTime searchDate)
        {
            string query = @"SELECT 
                        a.appointmentId, a.customerId, a.userId, a.title, a.description, 
                        a.location, a.contact, a.type, a.url, a.start, a.end,
                        c.customerName
                     FROM appointment a
                     JOIN customer c ON a.customerId = c.customerId
                     WHERE DATE(a.start) = DATE(@searchDate)";

            var parameters = new Dictionary<string, object>
            {
                { "@searchDate", searchDate }
            };

            return QueryAppointments(query, parameters);
        }

        public static BindingList<AppointmentRecord> SearchAppointmentsById(int? appointmentId)
        {
            string query = @"SELECT 
                        a.appointmentId, a.customerId, a.userId, a.title, a.description, 
                        a.location, a.contact, a.type, a.url, a.start, a.end,
                        c.customerName
                     FROM appointment a
                     JOIN customer c ON a.customerId = c.customerId
                     WHERE a.appointmentId = @appointmentId";

            var parameters = new Dictionary<string, object>
            {
                { "@appointmentId", appointmentId }
            };

            return QueryAppointments(query, parameters);
        }

        public static BindingList<AppointmentRecord> SearchAppointmentsByUser(int userId)
        {
            string query = @"SELECT 
                        a.appointmentId, a.customerId, a.userId, a.title, a.description, 
                        a.location, a.contact, a.type, a.url, a.start, a.end,
                        c.customerName
                     FROM appointment a
                     JOIN customer c ON a.customerId = c.customerId
                     WHERE a.userId = @userId";

            var parameters = new Dictionary<string, object>
            {
                { "@userId", userId }
            };

            return QueryAppointments(query, parameters);
        }

        private static BindingList<AppointmentRecord> QueryAppointments(string query, Dictionary<string, object>? parameters = null)
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
                        var results = new BindingList<AppointmentRecord>();
                        while (reader.Read())
                        {
                            results.Add(new AppointmentRecord
                            {
                                AppointmentID = reader.GetInt32("appointmentId"),
                                CustomerID = reader.GetInt32("customerId"),
                                UserID = reader.GetInt32("userId"),
                                Title = reader.GetString("title"),
                                Description = reader.GetString("description"),
                                Location = reader.GetString("location"),
                                Contact = reader.GetString("contact"),
                                Type = reader.GetString("type"),
                                Url = reader.GetString("url"),
                                Start = TimeZoneInfo.ConvertTime(reader.GetDateTime("start"), TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"), TimeZoneInfo.Local),
                                End = TimeZoneInfo.ConvertTime(reader.GetDateTime("end"), TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"), TimeZoneInfo.Local),
                                CustomerName = reader.GetString("customerName")
                            });
                        }
                        return results;
                    }
                }
            }
        }
    }
}
