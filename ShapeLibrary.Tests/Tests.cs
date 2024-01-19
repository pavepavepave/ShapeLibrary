using ShapeLibrary.Figures;
using ShapeLibrary.Interfaces;
using Xunit;

namespace ShapeLibrary.Tests
{
    public class Tests
    {
        [Fact]
        public void CircleAreaCalculation_WithPositiveRadius_ReturnsCorrectArea()
        {
            //Arrange
            double radius = 5.5;
            var circle = ShapeFactory.Create(radius);

            //Act
            var area = circle.CalculateArea();

            //Assert
            Assert.Equal(Math.PI * Math.Pow(radius, 2), area);
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

            //Assert
            Assert.Equal(6, area);
        }

        [Fact]
        public void IsTriangleRectangular_WithCorrectNumbers_ReturnsCorrectResult()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRectangular = triangle.IsTriangleRectangular();

            // Assert
            Assert.True(isRectangular);
        }

        [Fact]
        public void ShapeFactory_Create_CreatesCorrectShape()
        {
            // Arrange
            double[] circleArgs = { 5 };
            double[] triangleArgs = { 3, 4, 5 };

            // Act
            var circle = ShapeFactory.Create(circleArgs);
            var triangle = ShapeFactory.Create(triangleArgs);

            // Assert
            Assert.IsType<Circle>(circle);
            Assert.IsType<Triangle>(triangle);
        }
    }
}