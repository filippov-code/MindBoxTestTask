using Core;

namespace CoreTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Constructor_NegativeRadius_ExceptionReturned()
        {
            double r = -1;
            Assert.ThrowsException<ArgumentException>(() => new Circle(r));
        }

        [TestMethod]
        public void Constructor_ZeroRadius_ExceptionReturned()
        {
            double r = 0;

            Assert.ThrowsException<ArgumentException>(() => new Circle(r));
        }

        [TestMethod]
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

        [TestMethod]
        public void Radius_3_3Returned()
        {
            double expectedR = 3;
            Circle circle = new Circle(expectedR);

            Assert.AreEqual(expectedR, circle.Radius);
        }

        [TestMethod]
        public void Area_Radius4_Pi16Returned()
        {
            double r = 4;
            Circle circle = new Circle(r);

            double expectedArea = Math.PI * Math.Pow(r, 2);

            Assert.AreEqual(expectedArea, circle.Area);
        }
    }
}