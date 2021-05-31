using System;
using System.Linq;
using LinqPractice.BookRental;
using LinqPractice.BookRental.Interface;
using LinqPracticeTest.Factory;
using NUnit.Framework;

namespace LinqPracticeTest
{
    public class BookServiceTest
    {
        private IBookService _bookService;

        [SetUp]
        public void Setup()
        {
            _bookService = new BookService(DbRepositoryFactory.GetFakeBookRepository());
        }

        [Test]
        public void Get_New_Books_With_20210526_Should_Correspond_Books()
        {
            Assert.AreEqual("Happy Every Day",_bookService.GetNewBooksWithPublishDate(new DateTime(2021,05,26)).FirstOrDefault().BookName);
        }
        [Test]
        public void Get_Rental_Record_Of_Martin_Should_Be_Two_Records()
        {
            Assert.AreEqual(2, _bookService.GetAllRentalRecordByUsername("Martin").Count);
        }
        [Test]
        public void Get_Member_List_By_Balance_By_Name_First_One_Should_Be_Capco()
        {
            Assert.AreEqual("Capco", _bookService.GetMemberListByBalanceByName());
        }
        [Test]
        public void Get_Sally_Paid_Amount_For_Now_Rent_Books_Should_Be_18()
        {
            Assert.AreEqual(18m, _bookService.GetTheUserPaidAmountForNowRentBooks("Sally"));
        }
        [Test]
        public void Generate_Connection_List_For_Books_Rent_Before_20210501_Should_Have_7_Count()
        {
            Assert.AreEqual(7, _bookService.GenerateConnectionListForBooksRentBeforeTheDate(new DateTime(2021,05,01)).Count);
        }

    }
}