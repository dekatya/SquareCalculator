using SquareCalculatorLibrary.Shapes;

namespace SquareCalculatorLibrary
{
    public class SquareCalculator
    {
        public SquareCalculator() { }

        public double Calculate(ShapeAbstract shape)
        {
            return shape.CalculateSquare();
        }
    }
}