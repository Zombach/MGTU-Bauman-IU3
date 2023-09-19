using Task3.Part1.Interfaces;

namespace MgtuBaumanIu3.Vidmanov.Task3.Part1;

public struct Square : IArea, IPerimeter, IView
{
    public Point TopLeft { get; set; }
    public double SideLength { get; set; }
    
    public Square(Point topLeft, double sideLength)
    {
        TopLeft = topLeft;
        SideLength = sideLength;
    }

    public bool IsPointInside(Point point)
    => point.X >= TopLeft.X && point.X <= TopLeft.X + SideLength
    && point.Y >= TopLeft.Y && point.Y <= TopLeft.Y + SideLength;

    public double Area() => Math.Pow(SideLength, 2);

    public double Perimeter() => 4 * SideLength;

    public void View()
    {
        Console.WriteLine($"Площадь: {Area()}");
        Console.WriteLine($"Периметр: {Perimeter()} ");
    }
}