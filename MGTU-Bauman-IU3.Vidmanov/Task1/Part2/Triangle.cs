namespace InstituteHomework.Vidmanov.Task1.Part2;

public class Triangle
{
    public Vertex VertexA { get; set; }
    public Median MedianA { get; set; }
    public Vertex VertexB { get; set; }
    public Median MedianB { get; set; }
    public Vertex VertexC { get; set; }
    public Median MedianC { get; set; }
    public float CenterGravityX => (MedianA.X + MedianB.X + MedianC.X) / 3;
    public float CenterGravityY => (MedianA.Y + MedianB.Y + MedianC.Y) / 3;

    public Triangle
    (
        float aX,
        float aY,
        float bX,
        float bY,
        float cX,
        float cY
    )
    {
        VertexA = new(aX, aY);
        VertexB = new(bX, bY);
        VertexC = new(cX, cY);
        MedianA = new(VertexA, VertexB);
        MedianB = new(VertexB, VertexA);
        MedianC = new(VertexC, VertexA);
    }
}