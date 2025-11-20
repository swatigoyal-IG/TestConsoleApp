namespace ConsoleApp.ClassesDemo
{
    public class Square : Polygon
    {
        public Square(int width)
        {
            Width = width;
        }
        public override double Area()
        {
            return Width * Width;
        }
    }
}
