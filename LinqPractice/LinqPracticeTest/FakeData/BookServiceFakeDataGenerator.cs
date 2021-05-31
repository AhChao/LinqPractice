using LinqPractice.BookRental.Model;
using System;
using System.Collections.Generic;

namespace LinqPracticeTest.FakeData
{
    internal class BookServiceFakeDataGenerator
    {
        public static List<BooksDetail> GetFakeBooks()
        {
            return new List<BooksDetail>()
            {
                new BooksDetail
                {
                    BookName = "Happy Every Day",
                    PublishDate = new DateTime(2021, 5, 30),
                    Category = EnumCategory.Exercise,
                    RentalPrice = 5,
                    AvailableForCheckedOut = 3,
                    CheckedOutCount = 1
                },
                new BooksDetail
                {
                    BookName = "Be A Programmer",
                    PublishDate = new DateTime(2021, 1, 1),
                    Category = EnumCategory.Fantasy,
                    RentalPrice = 2,
                    AvailableForCheckedOut = 3,
                    CheckedOutCount = 3
                },
                new BooksDetail
                {
                    BookName = "Minna no Nihongo",
                    PublishDate = new DateTime(2001, 3, 1),
                    Category = EnumCategory.Language,
                    RentalPrice = 1.5m,
                    AvailableForCheckedOut = 10,
                    CheckedOutCount = 1
                },
                new BooksDetail
                {
                    BookName = "Road To Linq",
                    PublishDate = new DateTime(2018, 7, 7),
                    Category = EnumCategory.Programming,
                    RentalPrice = 3m,
                    AvailableForCheckedOut = 5,
                    CheckedOutCount = 0
                },
                new BooksDetail
                {
                    BookName = "Clean Code",
                    PublishDate = new DateTime(2008, 8, 1),
                    Category = EnumCategory.Programming,
                    RentalPrice = 10m,
                    AvailableForCheckedOut = 4,
                    CheckedOutCount = 4
                },
                new BooksDetail
                {
                    BookName = "All About Cooking",
                    PublishDate = new DateTime(2021, 5, 25),
                    Category = EnumCategory.Unknown,
                    RentalPrice = 1m,
                    AvailableForCheckedOut = 5,
                    CheckedOutCount = 3
                }
            };
        }

        public static List<MemberDetail> GetFakeMemberData()
        {
            return new List<MemberDetail>()
            {
                new MemberDetail
                {
                    Username = "Martin",
                    Balance = 50,
                    Contacts = new List<ContactInformation>
                    {
                        new ContactInformation
                        {
                            ConnectionWay = EnumConnectionWay.CellPhone,
                            Priority = 2,
                            ConnectionContent = "0912138291"
                        },
                        new ContactInformation
                        {
                            ConnectionWay = EnumConnectionWay.Pigeon,
                            Priority = 1,
                            ConnectionContent = "Mary"
                        }
                    },
                    RentalList = new List<BooksRentalRecord>()
                    {
                        new BooksRentalRecord
                        {
                            BookName = "Clean Code",
                            Category = EnumCategory.Programming,
                            RentDays = 30,
                            RentStartDate = new DateTime(2021,5,15)
                        },
                        new BooksRentalRecord
                        {
                            BookName = "Minna no Nihongo",
                            Category = EnumCategory.Language,
                            RentDays = 100,
                            RentStartDate = new DateTime(2021,4,1)
                        }
                    }
                },
                new MemberDetail
                {
                    Username = "Monika",
                    Balance = 50,
                    Contacts = new List<ContactInformation>
                    {
                        new ContactInformation
                        {
                            ConnectionWay = EnumConnectionWay.Phone,
                            Priority = 1,
                            ConnectionContent = "02-21344321"
                        }
                    },
                    RentalList =  new List<BooksRentalRecord>()
                    {
                        new BooksRentalRecord
                        {
                            BookName = "Clean Code",
                            Category = EnumCategory.Programming,
                            RentDays = 30,
                            RentStartDate = new DateTime(2021,5,15)
                        },
                        new BooksRentalRecord
                        {
                            BookName = "All About Cooking",
                            Category = EnumCategory.Unknown,
                            RentDays = 15,
                            RentStartDate = new DateTime(2021,5,25)
                        },
                        new BooksRentalRecord
                        {
                            BookName = "Be A Programmer",
                            Category = EnumCategory.Programming,
                            RentDays = 60,
                            RentStartDate = new DateTime(2021,4,29)
                        }
                    }
                },
                new MemberDetail
                {
                    Username = "Sally",
                    Balance = 1,
                    Contacts = new List<ContactInformation>()
                    {
                        new ContactInformation
                        {
                            ConnectionWay = EnumConnectionWay.Pigeon,
                            Priority = 1,
                            ConnectionContent = "George"
                        }
                    },
                    RentalList = new List<BooksRentalRecord>
                    {
                        new BooksRentalRecord
                        {
                            BookName = "Clean Code",
                            Category = EnumCategory.Programming,
                            RentDays = 30,
                            RentStartDate = new DateTime(2021,5,15)
                        },
                        new BooksRentalRecord
                        {
                            BookName = "Be A Programmer",
                            Category = EnumCategory.Programming,
                            RentDays = 60,
                            RentStartDate = new DateTime(2021,4,24)
                        },
                        new BooksRentalRecord
                        {
                            BookName = "Happy Every Day",
                            Category = EnumCategory.Exercise,
                            RentDays = 365,
                            RentStartDate = new DateTime(2021,1,1)
                        },
                        new BooksRentalRecord
                        {
                            BookName = "All About Cooking",
                            Category = EnumCategory.Unknown,
                            RentDays = 75,
                            RentStartDate = new DateTime(2021,4,15)
                        },
                    }
                },
                new MemberDetail
                {
                    Username = "Capco",
                    Balance = 50,
                    Contacts = new List<ContactInformation>(){
                        new ContactInformation
                        {
                            ConnectionWay = EnumConnectionWay.Pigeon,
                            Priority = 1,
                            ConnectionContent = "Nitend"
                        }
                    },
                    RentalList = new List<BooksRentalRecord>()
                    {
                        new BooksRentalRecord
                        {
                            BookName = "Be A Programmer",
                            Category = EnumCategory.Programming,
                            RentDays = 40,
                            RentStartDate = new DateTime(2021,4,24)
                        },
                        new BooksRentalRecord
                        {
                            BookName = "All About Cooking",
                            Category = EnumCategory.Unknown,
                            RentDays = 40,
                            RentStartDate = new DateTime(2021,4,15)
                        }
                    }
                }
            };
        }
    }
}