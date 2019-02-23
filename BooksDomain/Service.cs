using System;
using System.Collections.Generic;
using System.Text;

namespace BooksDomain
{
    public class Service
    {
        Infrastructure infrastructure = new Infrastructure();
        public IList<BookDetails> GetBooks()
        {
           return infrastructure.GetBooks();
        }
    }
}
