using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BooksDomain
{
    public class Infrastructure : IBooksInfrastructure
    {
        public IEnumerable<BookDetail> GetBooks()
        {
            using (dbContext_Book context = new dbContext_Book())
            {
                return context.BookDetails.ToList();
            }
        }

        public BookDetail GetBooks(int? bookId)
        {
            using (var context = new dbContext_Book())
            {
                return context.BookDetails.Where(c => c.BookID == bookId).AsQueryable().FirstOrDefault();
            }
        }
    }
}
