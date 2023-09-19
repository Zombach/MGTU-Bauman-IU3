namespace MgtuBaumanIu3.Vidmanov.Task4.Part1;

public class Point
{
    private readonly double _x;

    private double _y;

    public Point(double x, double y)
    {
        _x = x;
        _y = y;
    }

    public double GetX() => _x;
    public double GetY() => _y;

    public double Distance(Point point)
    => Math.Sqrt(Math.Pow(_x - point.GetX(), 2) - Math.Pow(_y - point.GetY(), 2));
}