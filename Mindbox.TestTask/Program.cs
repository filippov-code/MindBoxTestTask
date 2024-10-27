using Mindbox.Geometry;
using Mindbox.Geometry.Implementations;

Console.WriteLine("===Triangle===");
var triangle = new Triangle(5, 6, 7);
Console.WriteLine($"Sides: {triangle.A}, {triangle.B}, {triangle.C}");
Console.WriteLine($"Area: {triangle.Area}");
Console.WriteLine($"IsRight: {triangle.IsRightAngled}");
triangle = new Triangle(6, 8, 10);
Console.WriteLine($"Sides: {triangle.A}, {triangle.B}, {triangle.C}");
Console.WriteLine($"Area: {triangle.Area}");
Console.WriteLine($"IsRight: {triangle.IsRightAngled}");

Console.WriteLine("===Circle===");
var circle = new Circle(1);
Console.WriteLine($"Radius: {circle.Radius}");
Console.WriteLine($"Area: {circle.Area}");
circle = new Circle(4);
Console.WriteLine($"Radius: {circle.Radius}");
Console.WriteLine($"Area: {circle.Area}");

Console.WriteLine("===Figure===");
IFigure figure = new Circle(2);
Console.WriteLine($"Circle Area: {figure.Area}");
figure = new Triangle(3, 4, 5);
Console.WriteLine($"Triangle Area: {figure.Area}");
