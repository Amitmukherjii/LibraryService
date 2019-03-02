using System;
using Xunit;
using Moq;
using BooksDomain;
using System.Collections.Generic;
using AggregateModel;
using System.Linq;

namespace AggregrateModelTest
{
    public class LoadBookDetailsAggregateTest
    {
        List<BookDetail> blist;
        BookDetail bd;
        public LoadBookDetailsAggregateTest()
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
        public void LoadAllDetailsTest_ShouldReturnBookList()
        {
            var mockInfra = new Mock<IBookService>();
            mockInfra.Setup(a => a.GetBooks()).Returns(blist);
            var loadBookAggregrate = new LoadBooksDetailsAggregate(mockInfra.Object);

            var bookList =loadBookAggregrate.LoadAllDetails();
            //assert
            var res1 = bookList.Select(a => a.id);
            var setup = blist.Select(a => a.BookID);
            Assert.Equal(res1, setup);
        }

        [Fact]
        public void LoadDetailsByIdTest_ShouldReturnBook()
        {
            var mockInfra = new Mock<IBookService>();
            mockInfra.Setup(a => a.GetBooks(1)).Returns(bd);
            var loadBookAggregrate = new LoadBooksDetailsAggregate(mockInfra.Object);

            var bookList = loadBookAggregrate.LoadDetailsById(1);
            //assert
       
            Assert.Equal(bookList.id, bd.BookID);
        }
    }
}
