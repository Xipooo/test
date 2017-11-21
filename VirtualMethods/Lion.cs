using System;

namespace test.VirtualMethods
{
    public class Lion : Mammal
    {
        public override void Eat()
        {
            Console.WriteLine("Lion.Eat");
        }
    }
}