using BooksDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AggregateModel
{
    
    public class LoadBooksDetailsAggregate: IBookAggregate
    {
        private IBookService _bookService;
        public LoadBooksDetailsAggregate(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IEnumerable<UIModel> LoadAllDetails()
        {
            var books = _bookService.GetBooks();
            var bookList = new List<UIModel>();
            var model = new UIModel();
            foreach (var book in books)
            {
                model.id = book.BookID;
                model.Description = book.BookDescription;
                model.Author = book.AddedBy;
                model.Name = book.BookName;
                bookList.Add(model);
            }
            return bookList;
        }

        public UIModel LoadDetailsById(int id)
        {
            var book = _bookService.GetBooks(id);
            var loadEvent = new UIModel
            {
                id = book.BookID,
                Name = book.BookName,
                Price = book.BookPrice,
                Author = book.AddedBy,
                Description = book.BookDescription,
                Picture = 1,
                genres = "Fiction"
               
            };
            return loadEvent;
        }
    }
}
