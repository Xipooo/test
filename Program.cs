using System;
using System.IO;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Division div = new Division(4.56, 7.897);
            Console.WriteLine("Dividend: " + div.myDividend + " Divisor: " + div.myDivisor);
            Console.WriteLine();
        }
    }
}
