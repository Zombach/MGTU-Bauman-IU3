namespace MgtuBaumanIu3.Vidmanov.Task1.Part2;

public class Triangle(Point pointA, Point pointB, Point pointC)
{
    public Vertex VertexA { get; set; } = new Vertex(pointA);
    public Vertex VertexB { get; set; } = new Vertex(pointB);
    public Vertex VertexC { get; set; } = new Vertex(pointC);

    private Median? _medianA;
    public Median MedianA => _medianA ??= new Median(VertexA, VertexB);

    private Median? _medianB;
    public Median MedianB => _medianB ??= new Median(VertexB, VertexA);

    private Median? _medianC;
    public Median MedianC => _medianC ??= new Median(VertexC, VertexA);

    private Point? _centerGravity;

    public Point CenterGravity => _centerGravity ??= new Point
    (
        (MedianA.Point.X + MedianB.Point.X + MedianC.Point.X) / 3,
        (MedianA.Point.Y + MedianB.Point.Y + MedianC.Point.Y) / 3
    );
}