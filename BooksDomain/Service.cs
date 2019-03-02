using System;
using System.Collections.Generic;
using System.Text;

namespace BooksDomain
{
    public class Service : IBookService
    {
        private IBooksInfrastructure _booksInfrastructure;
        public Service(IBooksInfrastructure booksInfrastructure)
        {
            _booksInfrastructure = booksInfrastructure;
        }
        
        public IEnumerable<BookDetail> GetBooks()
        {
            return _booksInfrastructure.GetBooks();
        }

        public BookDetail GetBooks(int? BookId)
        {
            return _booksInfrastructure.GetBooks(BookId);
        }
    }
}
