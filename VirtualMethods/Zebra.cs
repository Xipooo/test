using System;

namespace test.VirtualMethods
{
    public class Zebra : Mammal
    {
        override public void Eat()
        {
            Console.WriteLine("Zebra.Eat");
        }
    }
}
