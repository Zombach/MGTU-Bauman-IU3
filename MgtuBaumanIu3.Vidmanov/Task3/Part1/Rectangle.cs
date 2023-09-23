using MgtuBaumanIu3.Vidmanov.Task3.Part1.Interfaces;

namespace MgtuBaumanIu3.Vidmanov.Task3.Part1;

public readonly struct Rectangle(Point topLeft, double width, double height)
    : IArea, IPerimeter, IIsPointOnObject, IView
{
    public Point TopLeft => topLeft;
    public double Width => width;
    public double Height => height;

    public double Area() => Width * Height;

    public double Perimeter() => 2 * (Width + Height);

    public bool IsPointOnObject(Point point)
    => point.X >= TopLeft.X && point.X <= TopLeft.X + Width
    && point.Y >= TopLeft.Y && point.Y <= TopLeft.Y + Height;
    
    public void View()
    {
        Console.WriteLine($"TopLeft: x={topLeft.X}, y={topLeft.Y}");
        Console.WriteLine($"Width: {width}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Площадь: {Area()}");
        Console.WriteLine($"Периметр: {Perimeter()} ");
    }
}