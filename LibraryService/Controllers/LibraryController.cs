using System;
using System.Collections.Generic;
using AggregateModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private ICustomerAggregate _customerAggregate;
        private IBookAggregate _bookAggregate;
        public LibraryController(ICustomerAggregate customerAggregate, IBookAggregate bookAggregate)
        {
            _customerAggregate = customerAggregate;
            _bookAggregate = bookAggregate;
        }
        
        //IAggregate 
        [HttpGet]
        [Route("customers/{customerId}/orders")]
        public ActionResult<UIModel> GetCustomer(int customerID)
        {
            return _customerAggregate.LoadDetailsById(customerID);
        }

        [HttpGet]
        [Route("AllBooks")]
        public IEnumerable<UIModel> GetAllBooks()
        {
            return _bookAggregate.LoadAllDetails();
        }

        [HttpGet]
        [Route("Books/Id={bookId}")]
        public ActionResult<UIModel> GetBooksById(int bookId)
        {
            return _bookAggregate.LoadDetailsById(bookId);
        }
    }
}