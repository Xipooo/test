using System;

namespace test.Interfaces
{
    public class Human : IMammal
    {
        public void Breath() => Console.WriteLine("Human.Breath");
        public void Eat() => Console.WriteLine("Human.Eat");
        public void Sleep() => Console.WriteLine("Human.Sleep");
    }
}