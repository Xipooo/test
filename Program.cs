using System;
using System.Linq;
using System.Text;
using MyNamespace;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Foo.foo());
            MyClass myObject = new MyClass();
            Console.WriteLine(myObject.foo());
        }
    }
}
