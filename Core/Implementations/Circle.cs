namespace Core.Implementations;

public class Circle : IFigure
{
    private readonly double _area;

    public double Area => _area;
    public double Radius { get; init; }

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Радиус должен быть больше 0");
        }

        Radius = radius;
        _area = Math.PI * Math.Pow(Radius, 2);
    }
}
