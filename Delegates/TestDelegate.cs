using System;

namespace test.Delegates
{
    delegate int NumberChanger(int n);
    public class TestDelegate
    {
        static int num = 10;

        public static int AddNum(int p){
            num +=p;
            return num;
        }
        public static int MultNum(int q){
            num *= q;
            return num;
        }

        public static int getNum() => num;

        public static void DoStuff(){
            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);
            NumberChanger nc3 = new NumberChanger(AddNum);

            nc = nc1; //Behaves like Value Type
            nc1 += nc2;
            nc1 += nc3;

            Console.WriteLine(nc1(5));
        }
    }
}