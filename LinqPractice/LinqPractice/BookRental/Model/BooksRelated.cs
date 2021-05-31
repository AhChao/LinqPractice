using System;

namespace LinqPractice.BookRental.Model
{
    public class Book
    {
        public string BookName { get; set; }
        public EnumCategory Category { get; set; }
    }

    public class BooksDetail : Book
    {
        public DateTime PublishDate { get; set; }
        public decimal RentalPrice { get; set; }
        public int AvailableForCheckedOut { get; set; }
        public int CheckedOutCount { get; set; }
        public int BookCount => AvailableForCheckedOut + CheckedOutCount;
    }

    public class BooksRentalRecord : Book
    {
        public int RentDays { get; set; }
        public DateTime RentStartDate { get; set; }
    }

    public enum EnumCategory
    {
        Unknown = 0,
        Fantasy = 1,
        Language = 2,
        Programming = 3,
        Exercise = 4
    }
}