using BooksDomain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using CustomerDomain;
using AggregateModel;

namespace AggregrateModelTest
{
    public class LoadCustomerDetailsAggregateTest
    {
        Customer customer;
        BookDetail bd;
        public LoadCustomerDetailsAggregateTest()
        {
            customer = new Customer
            {
                ID = 1,
                CustomerName = "name",
                CustomerAddress = "temp",
                CustomerBorrowedBooks = 111,
                CustomerNumber =5
            };
            bd = new BookDetail
            {
                BookID = 1,
                BookName = "name",
                AddedBy = "temp",
                BookDescription = "dd"
            };
        }

        [Fact]
        public void LoadAllDetailsTest_ShouldReturnCustomerList()
        {
            //var mockBookService = new Mock<IBookService>(); 
            //var mockCustomerService = new Mock<ICustomerService>();
            //mockCustomerService.Setup(a => a.GetCustomer(1)).Returns(customer);
            //mockBookService.Setup(a => a.GetBooks(customer.CustomerBorrowedBooks)).Returns(bd);

            //var loadBookAggregrate = new LoadCustomerDetailsAggregate(mockCustomerService.Object,mockBookService.Object);

            //var model = loadBookAggregrate.LoadDetailsById(5);

            //Assert.Equal(model.CustomerID, customer.ID);
        }
    }
}
