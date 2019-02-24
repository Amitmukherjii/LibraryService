using System;

namespace AggregateModel
{
    public class LoadCustomerDetailsAggregate
    {
        
        public LoadCustomerEvent LoadCustomerDetails(int customerId)
        {
            LoadCustomerEvent loadEvent = new LoadCustomerEvent
            {
                id = 1,
                Name = "Amit",
                Price = 123,
                Author = "Test",
                Description = "test",
                Picture = 1,
                genres ="Fiction",
                CustomerID = 1,
                Customer_Name = "Amit",
                Customer_Borrowed_Books = 1,
                Customer_Address = "",
            };
            return loadEvent;
        }
    }
}
    