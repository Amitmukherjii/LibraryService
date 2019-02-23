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
                BookID=1,
                Book_Name = "",
                Book_Description = "Book Name 1",
                Book_Price = 123,
                Image_Name = 1,
                AddedOn = DateTime.Today,
                AddedBy = 1,
                Author="abc"
            };

            bookList.Add(book1);

            return bookList;
        }
    }
}
