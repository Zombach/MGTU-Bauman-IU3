using Task3.Part1.Interfaces;

namespace MgtuBaumanIu3.Vidmanov.Task3.Part1;

public struct Circle : IArea, IPerimeter, IView
{
    public Point Center { get; set; }
    public double Radius { get; set; }

    public Circle(Point center, double radius)
    {
        Center = center;
        Radius = radius;
    }

    public bool IsPointInside(Point point)
    => Math.Pow(point.X - Center.X, 2)
    + Math.Pow(point.Y - Center.Y, 2) <= Math.Pow(Radius, 2);

    public double Area() => Math.PI * Math.Pow(Radius, 2);
    public double Perimeter() => 2 * Math.PI * Radius;

    public void View()
    {
        Console.WriteLine($"Площадь: {Area()}");
        Console.WriteLine($"Периметр: {Perimeter()} ");
    }
}