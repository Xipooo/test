using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an number between 5 and 20.");
            var myResponse = int.Parse(Console.ReadLine());
            var i = 1;
            while (i <= myResponse) {
                Console.WriteLine(i + " is " + (i % 2 == 0 ? "even": (i % 3 == 0 ? "multiple of 3" : "Odd")));
                i++;
            }
        }
    }
}