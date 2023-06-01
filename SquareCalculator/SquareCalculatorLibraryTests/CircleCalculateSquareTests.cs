using SquareCalculatorLibrary;

namespace SquareCalculatorLibraryTests
{
    public class CircleCalculateSquareTests
    {
        private ShapeFactory factory = new ShapeFactory();

        [Fact]
        public void Circle_CalculateSquare_ReturnsInvalidRadius()
        {
            // Arrange
            var radius = -10.0;
            var circle = factory.CreateCircle(radius);

            // Act
            var isValidRadius = circle.IsRadiusValid();

            // Assert
            Assert.False(isValidRadius);
        }

        [Fact]
        public void Circle_CalculateSquare_ReturnsValidRadius()
        {
            // Arrange
            var radius = 10.0;
            var circle = factory.CreateCircle(radius);

            // Act
            var isValidRadius = circle.IsRadiusValid();

            // Assert
            Assert.True(isValidRadius);
        }

        [Fact]
        public void Circle_CalculateSquare_ReturnsCorrectSquareValue()
        {
            // Arrange
            var radius = 10.0;
            var circle = factory.CreateCircle(radius);

            // Act
            var square = circle.CalculateSquare();

            // Assert
            Assert.Equal(314.15926535897931, square, 10);
        }
    }
}