using Core;

namespace CoreTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Constructor_InvalidSides_ExceptionReturned()
        {
            double a = 1;
            double b = 2;
            double c = 1;

            Assert.ThrowsException<ArgumentException>(() => new Triangle(a, b, c));
        }

        [TestMethod]
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

        [TestMethod]
        public void Area_6and8and10_24Returned()
        {
            double a = 6;
            double b = 8;
            double c = 10;
            Triangle triangle = new Triangle(a, b, c);

            double expected = 24;

            Assert.AreEqual(expected, triangle.Area);
        }

        [TestMethod]
        public void IsRightAngled_6and8and10_TrueReturned()
        {
            double a = 6;
            double b = 8;
            double c = 10;
            Triangle triangle = new Triangle(a, b, c);

            bool expected = true;

            Assert.AreEqual(expected, triangle.IsRightAngled);
        }

        [TestMethod]
        public void IsRightAngled_1and1and1_FalseReturned()
        {
            double a = 1;
            double b = 1;
            double c = 1;
            Triangle triangle = new Triangle(a, b, c);

            bool expected = false;

            Assert.AreEqual(expected, triangle.IsRightAngled);
        }
    }
}
