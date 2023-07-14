using SquareCalculatorLibrary;
using SquareCalculatorLibrary.Shapes;

var list = new List<ShapeAbstract>()
{
    new Triangle(3, 4, 5),
    new Triangle(3, 6, 5),
    new Circle(4),
    new Circle(5)
};

var squareCalculator = new SquareCalculator();
foreach (var shape in list)
{
    Console.WriteLine(squareCalculator.Calculate(shape));
}