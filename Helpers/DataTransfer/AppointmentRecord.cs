using AppointmentApp.Core.Models;

namespace AppointmentApp.Core.DataTransfer
{
    public class AppointmentRecord
    {
        public int AppointmentID { get; set; }
        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Contact { get; set; }
        public string Url { get; set; }
        public string Type { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string CustomerName { get; set; }
        public string FormatTime
        {
            get
            {
                return Start.ToString("t") + " - " + End.ToString("t");
            }
        }


        public Appointment ToAppointment() => new Appointment
        {
            AppointmentID = AppointmentID,
            CustomerID = CustomerID,
            UserID = UserID,
            Title = Title,
            Description = Description,
            Location = Location,
            Contact = Contact,
            Url = Url,
            Type = Type,
            Start = Start,
            End = End
        };
    }
}
