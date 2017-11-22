namespace test.Overloading
{
    public class Rectangle
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public bool IsSquare => Height == Width;

        public Rectangle() : this(1, 1) { }
        public Rectangle(int size) : this(size, size) { }
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override string ToString() =>
            Width + "x" + Height + " " + GetSquareOrRectString(IsSquare);

        private string GetSquareOrRectString(bool isSquare) => isSquare ? "square" : "rectangle";
    }
}