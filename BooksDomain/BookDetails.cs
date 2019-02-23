using System;
using System.Collections.Generic;
using System.Text;

namespace BooksDomain
{
    public class BookDetails
    {
        public int BookID { get; set; }
        public string Book_Name { get; set; }
        public int Book_Price { get; set; }
        public int Image_Name { get; set; }
        public string Book_Description { get; set; }
        public DateTime AddedOn { get; set; }
        public int AddedBy { get; set; }
        public string Author { get; set; }
    }
}
