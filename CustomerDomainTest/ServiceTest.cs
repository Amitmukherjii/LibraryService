using CustomerDomain;
using System;
using System.Collections.Generic;
using Xunit;
using Moq;

namespace CustomerDomainTest
{
    public class ServiceTest
    {
        List<Customer> customerList;
        Customer customer;
        public ServiceTest()
        {
            customerList = new List<Customer>();
            customer = new Customer
            {
                ID = 1,
                CustomerName = "name",
                CustomerAddress = "temp",
                AddedOn = DateTime.Now,
                CustomerBorrowedBooks=1,
                CustomerNumber=123
            };
            customerList.Add(customer);
        }

        [Fact]
        public void GetCustomerTest_ShouldReturnCustomerList()
        {
            //arrange
            var mockInfra = new Mock<ICustomerInfrastructure>();
            mockInfra.Setup(a => a.GetCustomer()).Returns(customerList);
            var service = new Service(mockInfra.Object);

            //act
            var list = service.GetCustomer();

            //assert
            Assert.Equal(list, customerList);
        }

        [Fact]
        public void GetCustomerTest_Parameter_ShouldReturnCustomer()
        {
            //arrange
            var mockInfra = new Mock<ICustomerInfrastructure>();
            mockInfra.Setup(a => a.GetCustomer(1)).Returns(customer);
            var service = new Service(mockInfra.Object);

            //act
            var cust = service.GetCustomer(1);

            //assert
            Assert.Equal(cust, customer);
        }
    }
}
