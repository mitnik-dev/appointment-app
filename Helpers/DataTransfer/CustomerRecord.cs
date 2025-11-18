using AppointmentApp.Core.Models;

namespace AppointmentApp.Core.DataTransfer
{
    public class CustomerRecord
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int Active { get; set; }
        public int AddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string FullAddress
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Address2))
                {
                    return $"{Address1} {PostalCode}";
                }
                else
                {
                    return $"{Address1}, {Address2} {PostalCode}";
                }
            }
        }
        public string PostalCode { get; set; }
        public string Phone { get; set; }

        public int CityId { get; set; }
        public string CityName { get; set; }

        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public Customer ToCustomer() => new Customer
        {
            CustomerId = CustomerId,
            CustomerName = CustomerName,
            AddressId = AddressId,
            Active = Active
        };

        public Address ToAddress() => new Address
        {
            AddressId = AddressId,
            Address1 = Address1,
            Address2 = Address2,
            PostalCode = PostalCode,
            Phone = Phone,
            CityId = CityId
        };

        public City ToCity() => new City
        {
            CityId = CityId,
            CityName = CityName,
            CountryId = CountryId
        };

        public Country ToCountry() => new Country
        {
            CountryId = CountryId,
            CountryName = CountryName
        };
    }
}
