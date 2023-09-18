using Task3.Part1.Interfaces;

namespace MgtuBaumanIu3.Vidmanov.Task3.Part1;

public struct Line : IView
{
    public Point Start { get; set; }
    public Point End { get; set; }
    public double Length => Start.Distance(End);

    public Line(Point start, Point end)
    {
        Start = start;
        End = end;
    }

    public void View() => Console.WriteLine($"Длинна = {Length}");

    public bool IsPointOnLine(Point point)
    => Math.Abs(Start.Distance(point) + End.Distance(point) - Length) < 0.001;
}