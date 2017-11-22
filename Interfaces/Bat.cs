using System;

namespace test.Interfaces
{
    public class Bat : IMammal
    {
        public void Breath() => Console.WriteLine("Bat.Breath");
        public void Eat() => Console.WriteLine("Bat.Eat");
        public void Sleep() => Console.WriteLine("Bat.Sleep");
    }
}