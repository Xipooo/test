using System;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Five Lettered Names:");

            string[] names = {
                "John", "Sally", "Bob", "Sebastian", "Frank", "Norma", "William", "Jane"
            };

            Console.WriteLine("\nLINQ query operator syntax using keywords");

            var query1 = from name in names
                         where name.Length == 5
                         orderby name
                         select name.ToUpper();

            foreach (string name in query1)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nLINQ extension method syntax using lambdas");
            var query2 = names
                            .Where(name => name.Length == 5)
                            .OrderBy(name => name)
                            .Select(name => name.ToUpper());

            foreach (string name in query2)
            {
                Console.WriteLine(name);
            }
        }
    }
}
