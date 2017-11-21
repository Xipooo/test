using System;
using test.VirtualMethods;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Mammal();
            mammal.Breath();
            mammal.Eat();
            mammal.Sleep();
            Console.WriteLine("???\n");

            Mammal[] critters = {
                new Lion(), new Zebra(), new Bat(), new Lion()
            };

            foreach (Mammal critter in critters){
                critter.Breath();
                critter.Eat();
                critter.Sleep();
                Console.WriteLine();
            }
        }
    }
}
