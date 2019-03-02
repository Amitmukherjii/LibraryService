using System.Collections.Generic;

namespace BooksDomain
{
    public interface IBooksInfrastructure
    {
        IEnumerable<BookDetail> GetBooks();
        BookDetail GetBooks(int? BookId);
    }
}