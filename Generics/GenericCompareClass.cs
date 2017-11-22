namespace test.Generics {
    public class GenericCompareClass{
        static public bool Compare<T>(T x, T y) => x.Equals(y);
    }
}