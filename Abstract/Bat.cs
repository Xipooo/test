using System;

namespace test.Abstract
{
    public class Bat : Mammal
    {
        public override void Eat()
        {
            Console.WriteLine("Bat.Eat");
        }

        public override void Sleep() {
            Console.WriteLine("Bat.Sleep");
        }   
    }
}