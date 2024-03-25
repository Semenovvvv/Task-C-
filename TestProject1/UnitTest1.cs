using NUnit.Framework;
using System.IO;
using System;

namespace TaskTests
{

    [TestFixture]
    public class Tests
    {
        [Test]
        public void CalculateCircleArea_ValidRadius_ReturnsCorrectArea()
        {
            double radius = 5;
            double expectedArea = Math.PI * radius * radius;

            double actualArea = Task.Program.GeometryCalculator.CalculateCircleArea(radius);

            Assert.AreEqual(expectedArea, actualArea, 1e-6);
        }

        [Test]
        public void CalculateCircleArea_NegativeRadius_ThrowsArgumentException()
        {
            double radius = -5;

            Assert.Throws<ArgumentException>(() => Task.Program.GeometryCalculator.CalculateCircleArea(radius));
        }

        [Test]
        public void CalculateTriangleArea_ValidSides_ReturnsCorrectArea()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            double expectedArea = 6;

            double actualArea = Task.Program.GeometryCalculator.CalculateTriangleArea(side1, side2, side3);

            Assert.AreEqual(expectedArea, actualArea, 1e-6);
        }

        [Test]
        public void CalculateTriangleArea_NegativeSide_ThrowsArgumentException()
        {
            double side1 = 3;
            double side2 = -4;
            double side3 = 5;

            Assert.Throws<ArgumentException>(() => Task.Program.GeometryCalculator.CalculateTriangleArea(side1, side2, side3));
        }

        [Test]
        public void IsRightTriangle_RightTriangle_ReturnsTrue()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;

            bool isRightTriangle = Task.Program.GeometryCalculator.IsRightTriangle(side1, side2, side3);

            Assert.IsTrue(isRightTriangle);
        }

        [Test]
        public void IsRightTriangle_NotRightTriangle_ReturnsFalse()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 6;

            bool isRightTriangle = Task.Program.GeometryCalculator.IsRightTriangle(side1, side2, side3);

            Assert.IsFalse(isRightTriangle);
        }
    }
}