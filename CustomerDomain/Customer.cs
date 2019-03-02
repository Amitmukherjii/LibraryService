using System;
using System.Collections.Generic;

namespace CustomerDomain
{
    public partial class Customer
    {
        public int ID { get; set; }
        public int? CustomerBorrowedBooks { get; set; }
        public string CustomerName { get; set; }
        public int CustomerNumber { get; set; }
        public string CustomerAddress { get; set; }
        public DateTime AddedOn { get; set; }
    }
}