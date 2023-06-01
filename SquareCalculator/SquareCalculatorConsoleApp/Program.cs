using SquareCalculatorLibrary;

var factory = new ShapeFactory();
var shape = String.Empty;
var isCorrectShape = false;

while (!isCorrectShape)
{
    Console.WriteLine("Выберите фигуру: круг (к) или треугольник (т)");
    shape = Console.ReadLine();
    isCorrectShape = (shape == "к" || shape == "т") ? true : false;
}

if (shape == "к")
{
    Console.WriteLine("Укажите радиус круга");
    var radius = Console.ReadLine();
    if (Double.TryParse(radius, out var result))
    {
        var circle = factory.CreateCircle(result);
        if (!circle.IsRadiusValid())
            Console.WriteLine("Радиус круга невалиден");
        else
        {
            Console.WriteLine($"Площадь круга = {circle.CalculateSquare()}");
        }
    }
    else
    {
        Console.WriteLine("Радиус круга должен быть десятичным числом");
    }
}
else
{
    Console.WriteLine("Укажите стороны треугольника.\nСторона а:");
    var sideA = Console.ReadLine();
    Console.WriteLine("Сторона b:");
    var sideB = Console.ReadLine();
    Console.WriteLine("Сторона c:");
    var sideC = Console.ReadLine();

    if (Double.TryParse(sideA, out var resultA)
        && Double.TryParse(sideB, out var resultB)
        && Double.TryParse(sideC, out var resultC))
    {
        var triangle = factory.CreateTriangle(resultA, resultB, resultC);
        if (!triangle.AreTriangleSidesValid())
            Console.WriteLine("Стороны треугольника невалидны");
        else
        {
            Console.WriteLine($"Площадь треугольника = {triangle.CalculateSquare()}");
            Console.WriteLine($"Прямоугольный ли треугольник = {triangle.IsRightAngled()}");
        }
    }
    else
    {
        Console.WriteLine("Стороны треугольника должны быть десятичными числами");
    }
}