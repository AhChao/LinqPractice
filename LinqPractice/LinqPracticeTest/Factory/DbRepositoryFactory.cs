using LinqPractice.BookRental.Repository;
using LinqPracticeTest.FakeData;
using NSubstitute;

namespace LinqPracticeTest.Factory
{
    internal class DbRepositoryFactory
    {
        public static IBookRepository GetFakeBookRepository()
        {
            var result = Substitute.For<IBookRepository>();
            result.GetBooks().ReturnsForAnyArgs(BookServiceFakeDataGenerator.GetFakeBooks());
            result.GetMemberDetails().ReturnsForAnyArgs(BookServiceFakeDataGenerator.GetFakeMemberData());
            return result;
        }
    }
}