using LinqPractice.BookRental.Model;
using System;
using System.Collections.Generic;

namespace LinqPractice.BookRental.Repository
{
    internal class BookRepository : IBookRepository
    {
        public List<BooksDetail> GetBooks()
        {
            throw new NotImplementedException();
        }

        public List<MemberDetail> GetMemberDetails()
        {
            throw new NotImplementedException();
        }
    }
}