using System;

namespace test.SingletonPattern
{
    public sealed class POTUS
    {
        private POTUS() { Console.WriteLine("POTUS Instantiated"); }
        private static POTUS instance = new POTUS();

        public static POTUS Instance {
            get {
                return instance;
            }
        }
        public string FirstName = "Donald";
        public string LastName = "Trump";
    }
}