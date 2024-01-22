using ShapeLibrary.Figures;
using Xunit;

namespace ShapeLibrary.Tests
{
    public class ShapeFactoryTests
    {

        [Fact]
        public void ShapeFactory_CreateCircleWithCorrectNumber_CreatesCorrectCircle()
        {
            //Arrange
            double[] circleArgs = { 5 };

            //Act
            var circle = ShapeFactory.Create(circleArgs);

            //Assert
            Assert.IsType<Circle>(circle);
        }

        [Fact]
        public void ShapeFactory_CreateCircleWithIncorrectNumber_ThrowsException()
        {
            //Arrange
            double[] circleArgs = { 0 };

            //Act and Assert
            Assert.Throws<Exception>(() => new Circle(circleArgs[0]));
        }

        [Fact]
        public void ShapeFactory_CreateCircleWithCorrectNumbers_CreatesCorrectTriangle()
        {
            //Arrange
            double[] triangleArgs = { 3, 4, 5 };

            //Act
            var triangle = ShapeFactory.Create(triangleArgs);

            //Assert
            Assert.IsType<Triangle>(triangle);
        }

        [Fact]
        public void ShapeFactory_CreateTriangleWithIncorrectNumbers_ThrowsException()
        {
            //Arrange
            double[] triangleArgs = { 0, -1, -3 };

            //Act and Assert
            Assert.Throws<Exception>(() => new Triangle(triangleArgs[0], triangleArgs[1], triangleArgs[2]));
        }
    }
}
