using System;
using test.Finances;
using test.Math;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            EventSource es = new EventSource();
            es.Timeout += EventSource_Timeout;
            es.Timeout += EventSource_Timeout2;
            es.StartTimeout(5000);
            Console.WriteLine("Waiting for Timeout to complete...");
            Console.ReadLine();
        }

        private static void EventSource_Timeout(object sender, string e){
            Console.WriteLine(e);
        }

        private static void EventSource_Timeout2(object sender, string e){
            Console.WriteLine(e);
        }
    }
}
