using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
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
            return books.Where(x => x.PublishDate >= publishDate).Select(x=>new Book
            {
                BookName = x.BookName,
                Category = x.Category
            }).ToList();
        }

        public List<RentalRecord> GetAllRentalRecordByUsername(string Username)
        {
            //Call BookRepository GetBooks
            //Flatten data one user mapping many book
            var members = _bookRepository.GetMemberDetails();
            return members.SelectMany(member => member.RentalList, (member, rentalList) => new RentalRecord
            {
                BookName = rentalList.BookName,
                Username = member.Username,
                RentStartDate = rentalList.RentStartDate
            }).Where(r=>r.Username == Username).ToList();
        }

        public List<MemberBasic> GetMemberListByBalanceDescByName()
        {
            //Call BookRepository GetMember
            //User order to get list order by balance first, then by name
            var members = _bookRepository.GetMemberDetails();
            return members.Select(x => new MemberBasic
            {
                Username = x.Username,
                Balance = x.Balance,
                Contacts = x.Contacts
            }).OrderByDescending(x => x.Balance).ThenBy(x => x.Username).ToList();
        }

        public decimal GetTheUserPaidAmountForNowRentBooks(string username)
        {
            //Call BookRepository GetMember and GetBook
            //Join book data to get the person spent how much money on those rent books
            var books = _bookRepository.GetBooks();
            var members = _bookRepository.GetMemberDetails();

            return members.FirstOrDefault(x=>x.Username == username).RentalList
                .Join(books, r => r.BookName, b => b.BookName,
                (r, b) => b.RentalPrice).Sum();
        }

        public List<RentTimeNotification> GenerateConnectionListForBooksRentBeforeTheDate(DateTime date)
        {
            //Call BookRepository GetMember
            //Check rent date first, then check the people connection way
            //Connection way should take the first priority way of the list
            var members = _bookRepository.GetMemberDetails();
            return members.SelectMany(x => x.RentalList, (x, r) => new
            {
                x.Username,
                x.Contacts.OrderBy(c => c.Priority).First().ConnectionWay,
                x.Contacts.OrderBy(c => c.Priority).First().ConnectionContent,
                r.BookName,
                r.RentStartDate
            }).Where(r => r.RentStartDate <= date).Select(a => new RentTimeNotification()
            {
                BookName = a.BookName,
                Username = a.Username,
                ConnectionWay = a.ConnectionWay,
                ConnectionContent = a.ConnectionContent
            }).ToList();
        }
    }
}