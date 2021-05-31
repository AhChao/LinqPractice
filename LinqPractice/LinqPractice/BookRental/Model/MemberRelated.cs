using System.Collections.Generic;

namespace LinqPractice.BookRental.Model
{
    public class MemberBasic
    {
        public string Username { get; set; }
        public decimal Balance { get; set; }
        public List<ContactInformation> Contacts { get; set; }
    }

    public class MemberDetail : MemberBasic
    {
        public List<BooksRentalRecord> RentalList { get; set; }
    }

    public class ContactInformation
    {
        public EnumConnectionWay ConnectionWay { get; set; }
        public int Priority { get; set; } //Lower Number Means Higher Priority
        public string ConnectionContent { get; set; }
    }

    public enum EnumConnectionWay
    {
        Phone = 0,
        CellPhone = 1,
        Pigeon = 2
    }
}