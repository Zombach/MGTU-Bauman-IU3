using MgtuBaumanIu3.Vidmanov.Task4.Part1.Interfaces;

namespace MgtuBaumanIu3.Vidmanov.Task4.Part1;

public class Rectangle(Point topLeft, double width, double height)
    : IArea, IPerimeter, IIsPointOnObject, IView
{
    public Point TopLeft() => topLeft;

    public double Width() => width;

    public double Height() => height;

    public double Area() => width * height;

    public double Perimeter() => 2 * (width + height);

    public bool IsPointOnObject(Point point) =>
    point.GetX() >= topLeft.GetX() &&
    point.GetX() <= topLeft.GetX() + width &&
    point.GetY() >= topLeft.GetY() &&
    point.GetY() <= topLeft.GetY() + height;
    
    public void View()
    {
        Console.WriteLine($"TopLeft: x={topLeft.GetX()}, y={topLeft.GetY()}");
        Console.WriteLine($"Width: {width}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Площадь: {Area()}");
        Console.WriteLine($"Периметр: {Perimeter()} ");
    }
}