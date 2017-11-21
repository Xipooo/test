using System;

namespace test.Abstract
{
    public abstract class Mammal
    {
        public void Breath() => Console.WriteLine("Mammal.Breath");
        public virtual void Sleep() => Console.WriteLine("Mammal.Sleep");
        public abstract void Eat();
    }
}
