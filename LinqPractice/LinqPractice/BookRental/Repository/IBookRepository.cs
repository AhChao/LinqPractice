using LinqPractice.BookRental.Model;
using System.Collections.Generic;

namespace LinqPractice.BookRental.Repository
{
    public interface IBookRepository
    {
        List<BooksDetail> GetBooks();

        List<MemberDetail> GetMemberDetails();
    }
}