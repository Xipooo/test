using System;

namespace test.Interfaces
{
    public class MountainLion : ILion
    {
        public void Breath() => Console.WriteLine("MountainLion.Breath");
        public void Eat() => Console.WriteLine("Mountain.Eat");
        public void Sleep() => Console.WriteLine("Mountain.Sleep");
        public void Roar() => Console.WriteLine("MountainLion.Roar");
    }
}