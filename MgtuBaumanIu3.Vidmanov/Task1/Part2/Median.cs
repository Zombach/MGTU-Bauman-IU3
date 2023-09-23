namespace MgtuBaumanIu3.Vidmanov.Task1.Part2;

public class Median(Vertex first, Vertex second)
{
    public Point Point { get; set; } = new
    (
        first.Point.X + ((float)2 / 3) * (second.Point.X - first.Point.X),
        first.Point.Y + ((float)2 / 3) * (second.Point.Y - first.Point.Y)
    );
}