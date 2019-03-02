using System;
using Xunit;
using BooksDomain;
using Moq;
using System.Collections.Generic;

namespace BookDomainTest
{
    public class ServiceTest
    {
        List<BookDetail> blist;
        BookDetail bd;
        public ServiceTest()
        {
            blist = new List<BookDetail>();
            bd = new BookDetail
            {
                BookID = 1,
                BookName = "name",
                AddedBy = "temp",
                BookDescription = "dd"
            };
            blist.Add(bd);
        }
        [Fact]
        public void GetBooksTest_ShouldReturnBookList()
        {
            //arrange
            var mockInfra = new Mock<IBooksInfrastructure>();
            mockInfra.Setup(a => a.GetBooks()).Returns(blist);
            var service = new Service(mockInfra.Object);

            //act
            var list = service.GetBooks();

            //assert
            Assert.Equal(list, blist);
        }

        [Fact]
        public void GetBooksTest_Parameter_ShouldReturnBook()
        {
            //arrange
            var mockInfra = new Mock<IBooksInfrastructure>();
            mockInfra.Setup(a => a.GetBooks(1)).Returns(bd);
            var service = new Service(mockInfra.Object);

            //act
            var book = service.GetBooks(1);

            //assert
            Assert.Equal(book, bd);
        }
    }
}
