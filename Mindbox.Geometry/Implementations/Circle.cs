namespace Mindbox.Geometry.Implementations;

public class Circle : IFigure
{
    public double Area { get; init; }
    public double Radius { get; init; }

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Радиус должен быть больше 0");
        }

        Radius = radius;
        Area = Math.PI * Math.Pow(Radius, 2);
    }
}
