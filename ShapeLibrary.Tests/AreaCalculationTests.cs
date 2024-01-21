using Xunit;

namespace ShapeLibrary.Tests
{
    public class AreaCalculationTests
    {
        [Fact]
        public void CircleAreaCalculation_WithCorrectNumber_ReturnsCorrectArea()
        {
            //Arrange
            double radius = 5.5;
            var circle = ShapeFactory.Create(radius);

            //Act
            var area = circle.CalculateArea();
            var correctValue = Math.PI * Math.Pow(radius, 2);

            //Assert
            Assert.Equal(correctValue, area);
        }

        [Fact]
        public void TriangleAreaCalculation_WithCorrectNumbers_ReturnsCorrectArea()
        {
            //Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            var triangle = ShapeFactory.Create(sideA, sideB, sideC);

            //Act
            var area = triangle.CalculateArea();
            var semiperimeter = (sideA + sideB + sideC) / 2;
            var correctValue = Math.Sqrt(semiperimeter * (semiperimeter - sideA) * (semiperimeter - sideB) * (semiperimeter - sideC));

            //Assert
            Assert.Equal(correctValue, area);
        }
    }
}