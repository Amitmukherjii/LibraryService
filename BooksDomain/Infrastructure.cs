using System;
using System.Collections.Generic;
using System.Text;

namespace BooksDomain
{
    public class Infrastructure
    {
        IList<BookDetails> bookList = new List<BookDetails>();

        public IList<BookDetails> GetBooks()
        {
            BookDetails book1 = new BookDetails
            {
                id=1,
                name = "The Midnight Line",
                description = "Book Name 1",
                price = 123,
                picture = 1,
                AddedOn = DateTime.Today,
                AddedBy = 1,
                author= "Child Lee"
            };

            bookList.Add(book1);

            return bookList;
        }
    }
}
