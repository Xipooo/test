using System;

namespace test.Interfaces
{
    public class Zebra : IMammal
    {
        public void Breath() => Console.WriteLine("Zebra.Breath");
        public void Eat() => Console.WriteLine("Zebra.Eat");
        public void Sleep() => Console.WriteLine("Zebra.Sleep");
    }
}