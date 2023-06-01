using SquareCalculatorLibrary;

namespace SquareCalculatorLibraryTests
{
    public class TriangleCalculateSquareTests
    {
        private ShapeFactory factory = new ShapeFactory();

        [Fact]
        public void Triangle_CalculateSquare_ReturnsInvalidTriangleSides()
        {
            // Arrange
            var sideA = 1.0;
            var sideB = 2.0;
            var sideC = 3.0;
            var triangle = factory.CreateTriangle(sideA, sideB, sideC);

            // Act
            var sidesAreValid = triangle.AreTriangleSidesValid();

            // Assert
            Assert.False(sidesAreValid);
        }

        [Fact]
        public void Triangle_CalculateSquare_ReturnsValidTriangleSides()
        {
            // Arrange
            var sideA = 1.1;
            var sideB = 2.0;
            var sideC = 3.0;
            var triangle = factory.CreateTriangle(sideA, sideB, sideC);

            // Act
            var sidesAreValid = triangle.AreTriangleSidesValid();

            // Assert
            Assert.True(sidesAreValid);
        }

        [Fact]
        public void Triangle_CalculateSquare_ReturnsTriangleIsRightAngled()
        {
            // Arrange
            var sideA = 3.0;
            var sideB = 4.0;
            var sideC = 5.0;
            var triangle = factory.CreateTriangle(sideA, sideB, sideC);

            // Act
            var isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.True(isRightAngled);
        }

        [Fact]
        public void Triangle_CalculateSquare_ReturnsTriangleIsNotRightAngled()
        {
            // Arrange
            var sideA = 3.1;
            var sideB = 4.0;
            var sideC = 5.0;
            var triangle = factory.CreateTriangle(sideA, sideB, sideC);

            // Act
            var isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.False(isRightAngled);
        }

        [Fact]
        public void Triangle_CalculateSquare_ReturnsCorrectSquareValue()
        {
            // Arrange
            var sideA = 3.0;
            var sideB = 4.0;
            var sideC = 5.0;
            var triangle = factory.CreateTriangle(sideA, sideB, sideC);

            // Act
            var square = triangle.CalculateSquare();

            // Assert
            Assert.Equal(6, square, 0);
        }

        [Fact]
        public void Triangle_CalculateSquare_ReturnsIncorrectSquareValue()
        {
            // Arrange
            var sideA = 1.0;
            var sideB = 2.0;
            var sideC = 3.0;
            var triangle = factory.CreateTriangle(sideA, sideB, sideC);

            // Act
            var square = triangle.CalculateSquare();

            // Assert
            Assert.Equal(0, square);
        }
    }
}