using MgtuBaumanIu3.Vidmanov.Task3.Part1.Interfaces;

namespace MgtuBaumanIu3.Vidmanov.Task3.Part1;

public readonly struct Point(double x, double y) : IView
{
    public double X => x;
    public double Y => y;
    
    public double Distance(Point point)
    => Math.Sqrt(Math.Pow(X - point.X, 2) - Math.Pow(Y - point.Y, 2));

    public void View()
    {
        Console.WriteLine($"X={x}");
        Console.WriteLine($"Y={y}");
    }
}