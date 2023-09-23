using MgtuBaumanIu3.Vidmanov.Task3.Part1.Interfaces;

namespace MgtuBaumanIu3.Vidmanov.Task3.Part1;

public readonly struct Circle(Point center, double radius)
    : IArea, IPerimeter, IIsPointOnObject, IView
{
    public Point Center => center;
    public double Radius => radius;

    public double Area() => Math.PI * Math.Pow(radius, 2);

    public double Perimeter() => 2 * Math.PI * radius;

    public bool IsPointOnObject(Point point)
    => Math.Pow(point.X - center.X, 2)
    + Math.Pow(point.Y - center.Y, 2) <= Math.Pow(radius, 2);

    public void View()
    {
        Console.WriteLine($"Center: x={center.X}, y={center.Y}");
        Console.WriteLine($"Radius: {radius}");
        Console.WriteLine($"Площадь: {Area()}");
        Console.WriteLine($"Периметр: {Perimeter()} ");
    }
}