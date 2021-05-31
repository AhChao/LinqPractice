using System;

namespace LinqPractice.BookRental.Model
{
    public class RentalRecord
    {
        public string BookName { get; set; }
        public string Username { get; set; }
        public DateTime RentStartDate { get; set; }
    }

    public class RentTimeNotification
    {
        public string Username { get; set; }
        public EnumConnectionWay ConnectionWay { get; set; }
        public string BookName { get; set; }
    }
}