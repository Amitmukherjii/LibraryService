using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerDomain
{
    public class Service : ICustomerService
    {
        private ICustomerInfrastructure _customerInfrastructure;
        public Service(ICustomerInfrastructure customerInfrastructure)
        {
            _customerInfrastructure = customerInfrastructure;
        }
        public IEnumerable<Customer> GetCustomer()
        {
            return _customerInfrastructure.GetCustomer();
        }

        public Customer GetCustomer(int customerId)
        {
            return _customerInfrastructure.GetCustomer(customerId);
        }
    }
}
