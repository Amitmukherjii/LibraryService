using System.Collections.Generic;

namespace CustomerDomain
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetCustomer();
        Customer GetCustomer(int customerId);
    }
}