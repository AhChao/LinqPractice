using System;
using System.Collections.Generic;
using LinqPractice.BookRental.Interface;
using LinqPractice.BookRental.Model;
using LinqPractice.BookRental.Repository;

namespace LinqPractice.BookRental
{
    public class BookService : IBookService
    {
        protected IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public List<Book> GetNewBooksWithPublishDate(DateTime publishDate)
        {
            throw new NotImplementedException();
        }

        public List<RentalRecord> GetAllRentalRecordByUsername(string Username)
        {
            throw new NotImplementedException();
        }

        public List<MemberBasic> GetMemberListByBalanceByName()
        {
            throw new NotImplementedException();
        }

        public decimal GetTheUserPaidAmountForNowRentBooks(string Username)
        {
            throw new NotImplementedException();
        }

        public List<RentTimeNotification> GenerateConnectionListForBooksRentBeforeTheDate(DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}