namespace test.Math
{
    public class CartesianCoordinate
    {
        private double x;
        private double y;
        public CartesianCoordinate(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double CalculateDistanceFromOrigin(){
            return System.Math.Sqrt(x * x + y * y);
        }
    }
}