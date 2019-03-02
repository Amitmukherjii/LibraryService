
using System.Collections.Generic;
using BooksDomain;
using CustomerDomain;

namespace AggregateModel
{
    public class LoadCustomerDetailsAggregate : ICustomerAggregate
    {
        private ICustomerService _customerService;
        private IBookService _bookService;
        public LoadCustomerDetailsAggregate(ICustomerService customerService, IBookService bookService)
        {
            _customerService = customerService;
            _bookService = bookService;
        }

        public IEnumerable<UIModel> LoadAllDetails()
        {
            throw new System.NotImplementedException();
        }

        public UIModel LoadDetailsById(int id)
        {
            var customer = _customerService.GetCustomer(id);
            var book = _bookService.GetBooks(customer.CustomerBorrowedBooks);


            UIModel loadEvent = new UIModel
            {
                id = book.BookID,
                Name = book.BookName,
                Price = book.BookPrice,
                Author = book.AddedBy,
                Description = book.BookDescription,
                Picture = 1,
                genres ="Fiction",
                CustomerID = customer.ID,
                Customer_Name = customer.CustomerName,
                Customer_Borrowed_Books = customer.CustomerBorrowedBooks,
                Customer_Address = customer.CustomerAddress,
            };
            return loadEvent;
        }
    }
}
    