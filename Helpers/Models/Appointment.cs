using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentApp.Core.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Contact {  get; set; }
        public string Type {  get; set; }
        public string Url { get; set; }
        public DateTime Start {  get; set; }
        public DateTime End { get; set; }
    }
}
