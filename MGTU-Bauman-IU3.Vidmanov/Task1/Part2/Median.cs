namespace MgtuBaumanIu3.Vidmanov.Task1.Part2;

public class Median
{
    public float X { get; set; }
    public float Y { get; set; }

    public Median(Vertex vertex1, Vertex vertex2)
    {
        X = vertex1.X + ((float)2 / 3) * (vertex2.X - vertex1.X);
        Y = vertex1.Y + ((float)2 / 3) * (vertex2.Y - vertex1.Y);
    }
}