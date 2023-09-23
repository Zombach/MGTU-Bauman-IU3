using MgtuBaumanIu3.Vidmanov.Task3.Part1.Interfaces;

namespace MgtuBaumanIu3.Vidmanov.Task3.Part1;

public readonly struct Line(Point start, Point end) : IIsPointOnObject, IView
{
    public Point Start => start;
    public Point End => end;

    public double Length() => Start.Distance(End);

    public bool IsPointOnObject(Point point)
    => Math.Abs(Start.Distance(point) + End.Distance(point) - Length()) < 0.001;

    public void View()
    {
        Console.WriteLine($"Start: x={start.X}, y={start.Y}");
        Console.WriteLine($"Длинна = {Length}");
    }
}