using GeometryLib;
using GeometryLib.Factories;
using GeometryLib.Shapes;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var cf = new CircleFactory(5.0);
        var circle = cf.GetShape();
        var tf = new TriangleFactory(3.0, 4.0, 5.0);
        var triangle = tf.GetShape();
        Console.WriteLine($"Площадь круга = {circle.GetArea()}");
        Console.WriteLine($"Площадь треугольника = {triangle.GetArea()}");
        Console.WriteLine($"Треугольник прямоугольный - {triangle.IsRectangle}");
    }
}