using System;

namespace test.VirtualMethods
{
    public class Mammal
    {
        public void Breath()
        {
            Console.WriteLine("Mammal.Breath");
        }

        virtual public void Sleep()
        {
            Console.WriteLine("Mammal.Sleep");
        }

        virtual public void Eat() 
        {
            Console.WriteLine("Mammal.Eat");
        }
    }
}