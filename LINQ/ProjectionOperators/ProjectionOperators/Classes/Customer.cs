
namespace ProjectionOperators.Classes
{
    public class Customer
    {
        public string CustomerId;
        public string CompanyName;
        public string Address;
        public string City;
        public string Region;
        public string PostalCode;
        public string Country;
        public string Phone;
        public string Fax;
        public Order[] Orders;

        public Customer(string customerId, string companyName)
        {
            CustomerId = customerId;
            CompanyName = companyName;
        }

        public Customer()
        {

        }
    }
}
