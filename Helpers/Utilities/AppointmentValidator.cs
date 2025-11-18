using AppointmentApp.Core.Data;
using AppointmentApp.Core.Models;

namespace AppointmentApp.Core.Utilities
{
    public static class AppointmentValidator
    {
        private static readonly TimeZoneInfo EasternTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
        public static string? ValidateAppointment(Appointment appointment)
        {
            if (string.IsNullOrWhiteSpace(appointment.Title))
                return "Title is required.";
            if (string.IsNullOrWhiteSpace(appointment.Description))
                return "Description is required.";
            if (string.IsNullOrWhiteSpace(appointment.Location))
                return "Location is required.";
            if (string.IsNullOrWhiteSpace(appointment.Contact))
                return "Contact is required.";
            if (string.IsNullOrWhiteSpace(appointment.Type))
                return "Type is required.";

            if (!IsWithinBusinessHours(appointment.Start) || !IsWithinBusinessHours(appointment.End))
                return "Appointments must be scheduled during business hours (9:00 AM to 5:00 PM, Monday-Friday, Eastern Time).";

            if (appointment.Start >= appointment.End)
                return "Start time must be before end time.";

            if (appointment.Start <= DateTime.Now)
                return "Appointments must be scheduled in the future.";

            return null;
        }

        public static string? CheckForOverlappingAppointments(Appointment appointment, int? excludeAppointmentId = null)
        {
            var existingAppointments = AppointmentRepository.GetAllAppointments();

            foreach (var existing in existingAppointments)
            {
                if (excludeAppointmentId.HasValue && existing.AppointmentID == excludeAppointmentId.Value)
                    continue;

                if (existing.CustomerID == appointment.CustomerID || existing.UserID == appointment.UserID)
                {
                    if (appointment.Start < existing.End && appointment.End > existing.Start)
                    {
                        return $"This appointment overlaps with an existing appointment: \"{existing.Title}\" on {existing.Start:MM/dd/yyyy} from {existing.Start:HH:mm} to {existing.End:HH:mm}";
                    }
                }
            }

            return null;
        }

        private static bool IsWithinBusinessHours(DateTime dateTime)
        {
            dateTime = TimeZoneInfo.ConvertTime(dateTime, TimeZoneInfo.Local, EasternTimeZone);

            if (dateTime.DayOfWeek < DayOfWeek.Monday || dateTime.DayOfWeek > DayOfWeek.Friday)
                return false;

            return dateTime.TimeOfDay >= new TimeSpan(9, 0, 0) && dateTime.TimeOfDay <= new TimeSpan(17, 0, 0);
        }
    }
}
