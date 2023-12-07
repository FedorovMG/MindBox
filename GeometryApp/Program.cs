using GeometryLib;
using GeometryLib.Shapes;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Triangle triangle = new Triangle(3.0, 5.0, 15.0);
        System.Console.WriteLine($"Площадь фигуры - {triangle.GetArea()}");
        System.Console.WriteLine($"Прямоугольный треугольник - {triangle.IsRectangle}");
    }
}