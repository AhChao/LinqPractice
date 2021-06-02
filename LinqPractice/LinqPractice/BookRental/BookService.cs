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
            //Call BookRepository GetBooks
            //Filter the books in the list
            var books = _bookRepository.GetBooks();
            throw new NotImplementedException();
        }

        public List<RentalRecord> GetAllRentalRecordByUsername(string Username)
        {
            //Call BookRepository GetMember
            //Flatten data one user mapping many book
            var members = _bookRepository.GetMemberDetails();
            throw new NotImplementedException();
        }

        public List<MemberBasic> GetMemberListByBalanceDescByName()
        {
            //Call BookRepository GetMember
            //User order to get list order by balance first, then by name
            var members = _bookRepository.GetMemberDetails();
            throw new NotImplementedException();
        }

        public decimal GetTheUserPaidAmountForNowRentBooks(string username)
        {
            //Call BookRepository GetMember and GetBook
            //Join book data to get the person spent how much money on those rent books
            var books = _bookRepository.GetBooks();
            var members = _bookRepository.GetMemberDetails();
            throw new NotImplementedException();
        }

        public List<RentTimeNotification> GenerateConnectionListForBooksRentBeforeTheDate(DateTime date)
        {
            //Call BookRepository GetMember
            //Check rent date first, then check the people connection way
            //Connection way should take the first priority way of the list
            var members = _bookRepository.GetMemberDetails();
            throw new NotImplementedException();
        }
    }
}