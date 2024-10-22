namespace Core.Implementations;

public class Triangle : IFigure
{
    private readonly double _area;

    public double Area => _area;
    public double A { get; init; }
    public double B { get; init; }
    public double C { get; init; }
    public bool IsRightAngled { get; init; }

    public Triangle(double a, double b, double c)
    {
        //  Свойство сторон треугольника:
        //  Сумма длин двух любых сторон треугольника больше длины оставшейся стороны
        if (a + b <= c || b + c <= a || c + a <= b)
        {
            throw new ArgumentException("Невозможно построить треугольник с такими сторонами");
        }

        A = a;
        B = b;
        C = c;

        //  Для проверки на прямоугольность используется теорема Пифагора:
        //  В прямоугольном треугольнике квадрат гипотенузы равен сумме квадратов катетов треугольника
        if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a))
        {
            IsRightAngled = true;
        }

        //  Для вычисления площади используется формула Герона:
        //  S = √(p·(p - a)·(p - b)·(p - c)), p = (a+b+c)/2
        double p = (A + B + C) / 2;
        _area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }
}
