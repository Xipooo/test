namespace test
{
    public class Division
    {
        public double myDividend = 0.00;
        public double myDivisor = 1.00;

        public Division() {
            
        }
        public Division(double myDividend, double myDivisor)
        {
            this.myDividend = myDividend;
            this.myDivisor = myDivisor;
        }
        public double DivideDoubles(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                throw new System.AccessViolationException("Oi, you're a doofus!");
            }
            return dividend / divisor;
        }
    }
}