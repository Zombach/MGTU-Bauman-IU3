using Task3.Part1.Interfaces;

namespace MgtuBaumanIu3.Vidmanov.Task3.Part1;

public struct Rectangle : IArea, IPerimeter, IView
{
    public Point TopLeft { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(Point topLeft, double width, double height)
    {
        TopLeft = topLeft;
        Width = width;
        Height = height;
    }

    public bool IsPointInside(Point point)
    => point.X >= TopLeft.X && point.X <= TopLeft.X + Width
    && point.Y >= TopLeft.Y && point.Y <= TopLeft.Y + Height;
    
    public double Area() => Width * Height;
    public double Perimeter() => 2 * (Width + Height);

    public void View()
    {
        Console.WriteLine($"Площадь: {Area()}");
        Console.WriteLine($"Периметр: {Perimeter()} ");
    }
}