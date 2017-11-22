using System;

namespace test.ExtensionMethods
{
    public static class MyExtensions
    {
        public static int WordCount(this string text){
            return text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}