namespace SquareCalculatorLibrary.Shapes
{
    public class Triangle : ShapeAbstract
    {
        private double sideA { get; set; }
        private double sideB { get; set; }
        private double sideC { get; set; }
        private double[] triangleSides { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            triangleSides = new[] { sideA, sideB, sideC };
        }

        public override double CalculateSquare()
        {
            var perimetr = (sideA + sideB + sideC) / 2;
            var square = Math.Sqrt(perimetr * (perimetr - sideA) * (perimetr - sideB) * (perimetr - sideC));
            return square;
        }

        public bool AreTriangleSidesValid()
        {
            if (triangleSides.Any(x => x <= 0))
                return false;
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                return false;

            return true;
        }

        public bool IsRightAngled()
        {
            var hypotenuse = triangleSides.Max();
            var cathets = triangleSides.OrderByDescending(x => x).Skip(1).ToArray();

            if (Math.Pow(hypotenuse, 2) != Math.Pow(cathets[0], 2) + Math.Pow(cathets[1], 2))
                return false;

            return true;
        }
    }
}