namespace ConsoleApp.ClassesDemo
{
    public class Cuboid: Polygon, I2DShape, I3DShape
    {
        public double Length { get; set; }
        public double Height { get; set; }
        public Cuboid(double width, double height, double length)
        {
            Width = (int)width;
            Height = (int)height;
            Length = (int)length;
        }
        public override double Area()
        {
            return Width * Height * Length;
        }
        public double Perimeter()
        {
            return 4 * (Width + Height + Length);
        }
        public double Volume()
        {
            return Width * Height * Length;
        }
    }
}
