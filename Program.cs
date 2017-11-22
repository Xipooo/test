using System;
using test.ExtensionMethods;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Veni Vidi Vici";
            int wordCount = text.WordCount();
        }
    }
}
