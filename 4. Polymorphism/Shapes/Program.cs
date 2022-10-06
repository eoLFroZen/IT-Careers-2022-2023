using Shapes;

List<Shape> shapes = new List<Shape>();

Rectangle rectangle = new Rectangle(2, 3.3);
shapes.Add(rectangle);

Circle circle = new Circle(10);
shapes.Add(circle);

for (int i = 0; i < shapes.Count; i++)
{
    Console.WriteLine(shapes[i].Draw());
    Console.WriteLine("Area: " + shapes[i].CalculateArea());
    Console.WriteLine("Perimeter: " + shapes[i].CalculatePerimeter());
    Console.WriteLine();
}