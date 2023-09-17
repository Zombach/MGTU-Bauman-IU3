namespace InstituteHomework.Vidmanov.Task4.Part1;

public class Line
{
    public Point Start { get; set; }
    public Point End { get; set; }
    public double Length => Start.Distance(End);

    public Line(Point start, Point end)
    {
        Start = start;
        End = end;
    }

    public bool IsPointOnLine(Point point)
    => Math.Abs(Start.Distance(point) + End.Distance(point) - Length) < 0.001;
}