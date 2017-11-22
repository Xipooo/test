using System;
using test.Overloading;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            Console.WriteLine(rect.ToString());

            rect = new Rectangle(10);
            Console.WriteLine(rect.ToString());

            rect = new Rectangle(20, 20);
            Console.WriteLine(rect.ToString());

            rect = new Rectangle(20, 30);
            Console.WriteLine(rect.ToString());
        }
    }
}
