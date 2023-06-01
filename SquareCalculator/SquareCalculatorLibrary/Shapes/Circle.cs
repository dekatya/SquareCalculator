namespace SquareCalculatorLibrary.Shapes
{
    public class Circle : ShapeAbstract
    {
        private double radius { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateSquare()
        {
            return Math.Pow(radius, 2) * Math.PI;
        }

        public bool IsRadiusValid()
        {
            if (radius <= 0)
                return false;

            return true;
        }
    }
}