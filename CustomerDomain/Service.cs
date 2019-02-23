using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerDomain
{
    public class Service
    {
        Infrastructure infrastructure = new Infrastructure();
        public IList<Customer> GetCustomer()
        {
            return infrastructure.GetCustomer();
        }
    }
}
