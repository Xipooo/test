using System;
using test.SingletonPattern;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(POTUS.Instance.FirstName);
        }
    }
}
