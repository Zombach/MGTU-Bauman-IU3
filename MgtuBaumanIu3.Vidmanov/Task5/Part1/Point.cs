using MgtuBaumanIu3.Vidmanov.Task4.Part1.Interfaces;

namespace MgtuBaumanIu3.Vidmanov.Task5.Part1;

public class Point : IView, ICount
{
    private static int _count = 0;
    private readonly double _x;
    private readonly double _y;

    public Point(double x, double y)
    {
        _x = x;
        _y = y;
        _count++;
    }

    ~Point() => _count = 0;

    public static int Count() => _count;

    public double GetX() => _x;

    public double GetY() => _y;

    public double Distance(Task4.Part1.Point point)
        => Math.Sqrt(Math.Pow(_x - point.GetX(), 2) - Math.Pow(_y - point.GetY(), 2));

    public void View()
    {
        Console.WriteLine($"X={_x}");
        Console.WriteLine($"Y={_y}");
    }
}