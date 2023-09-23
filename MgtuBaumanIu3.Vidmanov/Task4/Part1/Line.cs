using MgtuBaumanIu3.Vidmanov.Task4.Part1.Interfaces;

namespace MgtuBaumanIu3.Vidmanov.Task4.Part1;

public class Line(Point start, Point end) : IIsPointOnObject, IView
{
    public Point Start() => start;

    public Point End() => end;

    public double Length() => start.Distance(end);

    public bool IsPointOnObject(Point point)
    => Math.Abs(start.Distance(point) + end.Distance(point) - Length()) < 0.001;

    public void View()
    {
        Console.WriteLine($"Start: x={start.GetX()}, y={start.GetY()}");
        Console.WriteLine($"Длинна = {Length}");
    }
}