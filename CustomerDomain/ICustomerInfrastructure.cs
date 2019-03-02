using System.Collections.Generic;

namespace CustomerDomain
{
    public interface ICustomerInfrastructure
    {
        IEnumerable<Customer> GetCustomer();
        Customer GetCustomer(int customerId);
    }
}