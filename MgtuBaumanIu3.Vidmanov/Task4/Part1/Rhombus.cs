using MgtuBaumanIu3.Vidmanov.Task4.Part1.Interfaces;

namespace MgtuBaumanIu3.Vidmanov.Task4.Part1;

public class Rhombus(Point top, double diagonal1, double diagonal2)
    : IArea, IPerimeter, IIsPointOnObject, IView
{
    public Point Top() => top;

    public double Diagonal1() => diagonal1;

    public double Diagonal2() => diagonal2;

    public double Area() => diagonal1 * diagonal2 / 2;

    public double Perimeter() =>
    4 * Math.Sqrt((Math.Pow(diagonal1, 2) + Math.Pow(diagonal2, 2)) / 4);

    public bool IsPointOnObject(Point point)
    {
        double halfDiagonal1 = diagonal1 / 2;
        double halfDiagonal2 = diagonal2 / 2;
        double centerX = top.GetX() + halfDiagonal1;
        double centerY = top.GetY() + halfDiagonal2;
        double dx = Math.Abs(point.GetX() - centerX);
        double dy = Math.Abs(point.GetY() - centerY);
        return dx / halfDiagonal1 + dy / halfDiagonal2 <= 1;
    }

    public void View()
    {
        Console.WriteLine($"Top: x={top.GetX()}, y={top.GetY()}");
        Console.WriteLine($"Диагональ 1: {diagonal1}");
        Console.WriteLine($"Диагональ 2: {diagonal2}");
        Console.WriteLine($"Площадь: {Area()}");
        Console.WriteLine($"Периметр: {Perimeter()} ");
    }
}