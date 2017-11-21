using System;
using test.Abstract;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal[] critters = {
                new Lion(), new Zebra(), new Bat(), new Lion()
            };

            foreach (Mammal critter in critters)
            {
                critter.Breath();
                critter.Eat();
                critter.Sleep();
                Console.WriteLine();
            }
        }
    }
}
