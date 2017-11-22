namespace test.Generics
{
    public class NonGenericCompareClass
    {
        static public bool Compare(string x, string y) => x.Equals(y);
        static public bool Compare(int x, int y) => x.Equals(y);
    }
}