using ShapeLibrary.Figures;
using Xunit;

namespace ShapeLibrary.Tests
{
    public class TriangleRectangularTests
    {
        [Fact]
        public void IsTriangleRectangular_WithCorrectNumbers_ReturnsCorrectResult()
        {
            //Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            var triangle = new Triangle(sideA, sideB, sideC);

            //Act
            var isRectangular = triangle.IsTriangleRectangular();

            //Assert
            Assert.True(isRectangular);
        }

        [Fact]
        public void IsTriangleRectangular_WithIncorrectNumbers_ReturnsFalse()
        {
            //Arrange
            double sideA = 4;
            double sideB = 7;
            double sideC = 1;
            var triangle = new Triangle(sideA, sideB, sideC);

            //Act
            var isRectangular = triangle.IsTriangleRectangular();

            //Assert
            Assert.False(isRectangular);
        }
    }
}