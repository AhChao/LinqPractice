using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    static class Program
    {
        static void Main(string[] args)
        {
            // delegate func
            Func<string, string, string> func1 = Hello;
            // anonymous function
            Func<string, string, string> func2 =
                delegate (string a, string b)
                {
                    var str =  "FUNC2 : Let's Study" + Environment.NewLine + a + " " + b;
                    Console.WriteLine(str);
                    return str;
                };
            // Lambda
            Func<string, string, string> func3 =
                (a, b) =>
                {
                    var str = "FUNC3 : Let's Study" + Environment.NewLine + a + " " + b;
                    Console.WriteLine(str);
                    return str;
                };

            // Use delegate func
            string helloStr = func2("Linq", @"https://docs.microsoft.com/zh-tw/dotnet/csharp/programming-guide/concepts/linq/");


            //Console.WriteLine(helloStr);

            var numList = new List<int>(){ 2,4,6,8,10};
            var ans = numList.MyWhere(Over5);
            Console.WriteLine(ans.Sum());

            Console.ReadKey();

        }

        static string Hello(string a, string b)
        {
            var str = "FUNC1 : Let's Study" + Environment.NewLine + a + " " + b;
            Console.WriteLine(str);
            return str;
        }

        private static bool Over5(int num)
        {
            return num > 5;
        }

        //extension method
        public static IEnumerable<TSource> MyWhere<TSource>(
            this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            foreach (TSource item in source)
            {
                if (predicate(item))
                    yield return item;
            }
        }
    }
}
