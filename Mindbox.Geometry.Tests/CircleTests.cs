using Mindbox.Geometry.Implementations;

namespace Mindbox.Geometry.Tests;

public class CircleTests
{

    [Fact]
    public void Constructor_NegativeRadius_ExceptionReturned()
    {
        double r = -1;
        Assert.Throws<ArgumentException>(() => new Circle(r));
    }

    [Fact]
    public void Constructor_ZeroRadius_ExceptionReturned()
    {
        double r = 0;

        Assert.Throws<ArgumentException>(() => new Circle(r));
    }

    [Fact]
    public void Constructor_PositiveRadius_CircleReturned()
    {
        double r = 1;

        try
        {
            new Circle(r);
        }
        catch
        {
            Assert.Fail();
        }

    }

    [Fact]
    public void Radius_3_3Returned()
    {
        double expectedR = 3;
        var circle = new Circle(expectedR);

        Assert.Equal(expectedR, circle.Radius);
    }

    [Fact]
    public void Area_Radius4_Pi16Returned()
    {
        double r = 4;
        var circle = new Circle(r);

        double expectedArea = Math.PI * Math.Pow(r, 2);

        Assert.Equal(expectedArea, circle.Area);
    }
}
