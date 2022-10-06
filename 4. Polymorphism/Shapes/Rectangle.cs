namespace Shapes
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }

        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }

        public override string Draw()
        {
            return base.Draw() + $" a rectangle with width {Width} and height {Height}.";
        }
    }
}
