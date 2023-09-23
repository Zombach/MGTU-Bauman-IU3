using MgtuBaumanIu3.Vidmanov.Task4.Part1.Interfaces;

namespace MgtuBaumanIu3.Vidmanov.Task4.Part1;

public class Point(double x, double y) : IView
{
    public double GetX() => x;

    public double GetY() => y;

    public double Distance(Point point)
    => Math.Sqrt(Math.Pow(x - point.GetX(), 2) - Math.Pow(y - point.GetY(), 2));

    public void View()
    {
        Console.WriteLine($"X={x}");
        Console.WriteLine($"Y={y}");
    }
}