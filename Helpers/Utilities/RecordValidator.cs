using AppointmentApp.Core.DataTransfer;
using System.Text.RegularExpressions;


namespace AppointmentApp.Core.Utilities
{
    public static class RecordValidator
    {
        public static string? RequiredFields(CustomerRecord customerRecord)
        {
            if (string.IsNullOrWhiteSpace(customerRecord.CustomerName))
                return "Customer name is required.";
            if (string.IsNullOrWhiteSpace(customerRecord.Address1))
                return "Address is required.";
            if (string.IsNullOrWhiteSpace(customerRecord.PostalCode))
                return "Postal code is required.";
            if (string.IsNullOrWhiteSpace(customerRecord.Phone))
                return "Phone number is required.";
            if (string.IsNullOrWhiteSpace(customerRecord.CityName))
                return "City is required.";
            if (string.IsNullOrWhiteSpace(customerRecord.CountryName))
                return "Country is required.";

            return null;
        }

        public static void TrimFields(CustomerRecord customerRecord)
        {
            customerRecord.CustomerName = customerRecord.CustomerName.Trim();
            customerRecord.Address1 = customerRecord.Address1.Trim();
            customerRecord.Address2 = customerRecord.Address2.Trim();
            customerRecord.PostalCode = customerRecord.PostalCode.Trim();
            customerRecord.Phone = customerRecord.Phone.Trim();
            customerRecord.CityName = customerRecord.CityName.Trim();
            customerRecord.CountryName = customerRecord.CountryName.Trim();
        }
        public static string? ValidatePhone(string phone)
        {
            if (!Regex.IsMatch(phone, @"^(?=.*\d)(?=.*-)[0-9-]+$"))
            {
                return "Phone number must contain only digits and dashes.";
            }
            return null;
        }
    }
}
