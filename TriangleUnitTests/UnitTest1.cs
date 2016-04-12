using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geometry;

namespace TriangleUnitTests
{
    [TestClass]
    public class TriangleTests
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ZeroLengthTest()
        {
            Triangle triangle = new Triangle(0, 4, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativeLengthTest()
        {
            Triangle triangle = new Triangle(-3, 4, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void InvalidLengthsTest()
        {
            Triangle triangle = new Triangle(3, 4, 8);
        }

        [TestMethod]
        public void RightTriangleTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightTriangle());
        }

        [TestMethod]
        public void CorrertSquareTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double square = triangle.CalcSquare();
            Assert.AreEqual(square, 6, double.Epsilon, "Получившееся значение площади не совпадает с ожидаемым");
        }
    }
}
