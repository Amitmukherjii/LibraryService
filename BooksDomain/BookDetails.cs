using System;
using System.Collections.Generic;
using System.Text;

namespace BooksDomain
{
    public class BookDetails
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int picture { get; set; }
        public string description { get; set; }
        public DateTime AddedOn { get; set; }
        public int AddedBy { get; set; }
        public string author { get; set; }
    }
}
