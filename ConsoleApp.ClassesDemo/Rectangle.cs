namespace ConsoleApp.ClassesDemo
{
    public class Rectangle : Polygon,I2DShape
    {
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public int Height { get; set; }
        public override double Area()
        {
            return Width * Height;
        }
        public double Perimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
