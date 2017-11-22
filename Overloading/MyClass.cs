namespace test.Overloading
{
    public class MyClass
    {
        public int GetLength(string text){
            return text.Length;
        }
        public int GetLength(int integer){
            return integer.ToString().Length;
            //string intAsString = integer.ToString();
            //int length = intAsString.Length;
            //return length;
        }
        public int GetLength(int[] integerArray){
            return integerArray.Length;
        }
    }
}