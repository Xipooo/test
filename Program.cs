using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            System.String.Concat(new string[] {"Hello", " ", "World",});
            string myGreeting = "Hello world!";

            int myNumber = System.Int32.Parse("55");
            myNumber.ToString();

            string.Concat(new string[] {"Hello", " ", "world"});
            Console.WriteLine(myGreeting);
            int product = MultiplyTwoNumbers(4, 7);
            Console.WriteLine(product);
        }

        static int MultiplyTwoNumbers(int x, int y){
            return x * y;
        }
    }
}