namespace AppointmentApp.Core.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int AddressId { get; set; }
        public int Active { get; set; }
    }
}
