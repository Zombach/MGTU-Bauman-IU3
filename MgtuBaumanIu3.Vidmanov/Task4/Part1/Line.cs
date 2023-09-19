namespace MgtuBaumanIu3.Vidmanov.Task4.Part1;

public class Line
{
    private readonly Point _start;
    private readonly Point _end;

    public double Length => _start.Distance(_end);

    public Line(Point start, Point end)
    {
        _start = start;
        _end = end;
    }

    public Point Start() => _start;
    public Point End() => _end;

    public bool IsPointOnLine(Point point)
    => Math.Abs(_start.Distance(point) + _end.Distance(point) - Length) < 0.001;
}