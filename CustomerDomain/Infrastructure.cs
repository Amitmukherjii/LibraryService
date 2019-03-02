using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomerDomain
{
    public class Infrastructure : ICustomerInfrastructure
    {
        public IEnumerable<Customer> GetCustomer()
        {
            using (var context = new dbContext_Customer())
            {
                return context.Customers.ToList();
            }
        }

        public Customer GetCustomer(int customerId)
        {
            using (var context = new dbContext_Customer())
            {
                return context.Customers.Where(c => c.ID == customerId).AsQueryable().FirstOrDefault();
            }
        }
    }
}
