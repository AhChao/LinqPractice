using System;
using System.Collections.Generic;
using LinqPractice.BookRental.Model;

namespace LinqPractice.BookRental.Interface
{
    public interface IBookService
    {
        List<Book>GetNewBooksWithPublishDate(DateTime publishDate);
        List<RentalRecord> GetAllRentalRecordByUsername(string Username);
        List<MemberBasic> GetMemberListByBalanceByName();
        decimal GetTheUserPaidAmountForNowRentBooks(string Username);
        List<RentTimeNotification> GenerateConnectionListForBooksRentBeforeTheDate(DateTime date);
    }
}