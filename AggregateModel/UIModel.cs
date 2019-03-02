using System;
using System.Collections.Generic;
using System.Text;

namespace AggregateModel
{
    public class UIModel
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Picture { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string genres { get; set; }

        public int CustomerID { get; set; }
        public string Customer_Name { get; set; }
        public int? Customer_Borrowed_Books { get; set; }
        public string Customer_Address { get; set; }

    }
}
