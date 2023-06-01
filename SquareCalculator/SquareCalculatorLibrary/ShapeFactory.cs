using SquareCalculatorLibrary.Shapes;

namespace SquareCalculatorLibrary
{
    public class ShapeFactory
    {
        public ShapeFactory() { }

        public Circle CreateCircle(double radius)
        {
            return new Circle(radius);
        }

        public Triangle CreateTriangle(double sideA, double sideB, double sideC)
        {
            return new Triangle(sideA, sideB, sideC);
        }
    }
}