using System;

namespace test.Interfaces
{
    public class SnoopLion : IMammal
    {
        public void Breath() => Console.WriteLine("Yeah yeah Breath");
        public void Eat() => Console.WriteLine("Yeah yeah Eat");
        public void Sleep() => Console.WriteLine("Yeah yeah Sleep");
    }
}