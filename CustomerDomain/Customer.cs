using System;

namespace CustomerDomain
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Customer_Name { get; set; }
        public int Customer_Borrowed_Books { get; set; }
        public int Customer_Number { get; set; }
        public string Customer_Address { get; set; }
        public DateTime AddedOn { get; set; }
    }
}
