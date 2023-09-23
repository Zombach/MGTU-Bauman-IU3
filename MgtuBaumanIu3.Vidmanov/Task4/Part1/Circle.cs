using MgtuBaumanIu3.Vidmanov.Task4.Part1.Interfaces;

namespace MgtuBaumanIu3.Vidmanov.Task4.Part1;

public class Circle(Point center, double radius)
    : IArea, IPerimeter, IIsPointOnObject, IView
{
    public Point Center() => center;
    
    public double Radius() => radius;
    
    public double Area() => Math.PI * Math.Pow(radius, 2);
    
    public double Perimeter() => 2 * Math.PI * radius;

    public bool IsPointOnObject(Point point)
    => Math.Pow(point.GetX() - center.GetX(), 2)
    + Math.Pow(point.GetY() - center.GetY(), 2) <= Math.Pow(radius, 2);

    public void View()
    {
        Console.WriteLine($"Center: x={center.GetX()}, y={center.GetY()}");
        Console.WriteLine($"Radius: {radius}");
        Console.WriteLine($"Площадь: {Area()}");
        Console.WriteLine($"Периметр: {Perimeter()} ");
    }
}