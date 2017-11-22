using System;
using System.Collections;
using System.Collections.Generic;
using test.Generics;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isEqual;

            isEqual = NonGenericCompareClass.Compare(3, 4);
            Console.WriteLine(isEqual);
            isEqual = NonGenericCompareClass.Compare("up", "up");
            Console.WriteLine(isEqual);

            isEqual = GenericCompareClass.Compare<int>(3, 4);
            Console.WriteLine(isEqual);
            isEqual = GenericCompareClass.Compare<string>("up", "up");
            Console.WriteLine(isEqual);
        }
    }
}
