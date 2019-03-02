using System.Collections.Generic;

namespace BooksDomain
{
    public interface IBookService
    {
        IEnumerable<BookDetail> GetBooks();
        BookDetail GetBooks(int? BookId);
    }
}