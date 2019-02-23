using System;
using System.Collections.Generic;

namespace CustomerDomain
{
    public class Infrastructure
    {
        IList<Customer> custList = new List<Customer>();
       
        public IList<Customer> GetCustomer()
        {
            Customer customer1 = new Customer
            {
                Customer_Name = "",
                Customer_Borrowed_Books = 1,
                Customer_Number = 123,
                Customer_Address = "abc",
                AddedOn = DateTime.Today
            };

            custList.Add(customer1);

            return custList;
        }
    }
}
