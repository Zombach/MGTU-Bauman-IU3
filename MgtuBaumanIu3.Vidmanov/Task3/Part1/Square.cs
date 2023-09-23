using MgtuBaumanIu3.Vidmanov.Task3.Part1.Interfaces;

namespace MgtuBaumanIu3.Vidmanov.Task3.Part1;

public readonly struct Square(Point topLeft, double sideLength)
    : IArea, IPerimeter, IIsPointOnObject, IView
{
    public Point TopLeft => topLeft;
    public double SideLength => sideLength;

    public double Area() => Math.Pow(SideLength, 2);

    public double Perimeter() => 4 * SideLength;

    public bool IsPointOnObject(Point point)
    => point.X >= TopLeft.X && point.X <= TopLeft.X + SideLength
    && point.Y >= TopLeft.Y && point.Y <= TopLeft.Y + SideLength;

    public void View()
    {
        Console.WriteLine($"TopLeft: x={topLeft.X}, y={topLeft.Y}");
        Console.WriteLine($"SideLength: {sideLength}");
        Console.WriteLine($"Площадь: {Area()}");
        Console.WriteLine($"Периметр: {Perimeter()} ");
    }
}