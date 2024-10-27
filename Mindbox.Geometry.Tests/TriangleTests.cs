using Mindbox.Geometry.Implementations;

namespace Mindbox.Geometry.Tests;

public class TriangleTests
{
    [Fact]
    public void Constructor_InvalidSides_ExceptionReturned()
    {
        double a = 1;
        double b = 2;
        double c = 1;

        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }

    [Fact]
    public void Constructor_CorrectSides_ExceptionReturned()
    {
        double a = 6;
        double b = 8;
        double c = 10;

        try
        {
            new Triangle(a, b, c);
        }
        catch
        {
            Assert.Fail();
        }
    }

    [Fact]
    public void Area_6and8and10_24Returned()
    {
        double a = 6;
        double b = 8;
        double c = 10;
        var triangle = new Triangle(a, b, c);

        double expected = 24;

        Assert.Equal(expected, triangle.Area);
    }

    [Fact]
    public void IsRightAngled_6and8and10_TrueReturned()
    {
        double a = 6;
        double b = 8;
        double c = 10;
        var triangle = new Triangle(a, b, c);

        bool expected = true;

        Assert.Equal(expected, triangle.IsRightAngled);
    }

    [Fact]
    public void IsRightAngled_1and1and1_FalseReturned()
    {
        double a = 1;
        double b = 1;
        double c = 1;
        var triangle = new Triangle(a, b, c);

        bool expected = false;

        Assert.Equal(expected, triangle.IsRightAngled);
    }
}
