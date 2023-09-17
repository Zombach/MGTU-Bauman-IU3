namespace InstituteHomework.Vidmanov.Task4.Part1;

public class Circle
{
    public Point Center { get; set; }
    public double Radius { get; set; }
    public double Area => Math.PI * Math.Pow(Radius, 2);
    public double Perimeter => 2 * Math.PI * Radius;

    public Circle(Point center, double radius)
    {
        Center = center;
        Radius = radius;
    }

    public bool IsPointInside(Point point)
    => Math.Pow(point.X - Center.X, 2)
    + Math.Pow(point.Y - Center.Y, 2) <= Math.Pow(Radius, 2);
}