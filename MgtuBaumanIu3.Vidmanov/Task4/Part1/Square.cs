using MgtuBaumanIu3.Vidmanov.Task4.Part1.Interfaces;

namespace MgtuBaumanIu3.Vidmanov.Task4.Part1;

public class Square(Point topLeft, double sideLength)
    : IArea, IPerimeter, IIsPointOnObject, IView
{
    public Point TopLeft() => topLeft;

    public double SideLength() => sideLength;

    public double Area() => Math.Pow(sideLength, 2);

    public double Perimeter() => 4 * sideLength;

    public bool IsPointOnObject(Point point)
    => point.GetX() >= topLeft.GetX() && point.GetX() <= topLeft.GetX() + sideLength
    && point.GetY() >= topLeft.GetY() && point.GetY() <= topLeft.GetY() + sideLength;
    
    public void View()
    {
        Console.WriteLine($"TopLeft: x={topLeft.GetX()}, y={topLeft.GetY()}");
        Console.WriteLine($"SideLength: {sideLength}");
        Console.WriteLine($"Площадь: {Area()}");
        Console.WriteLine($"Периметр: {Perimeter()} ");
    }
}