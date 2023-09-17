namespace InstituteHomework.Vidmanov.Task4.Part1;

public class Rectangle
{
    public Point TopLeft { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    public double Area => Width * Height;
    public double Perimeter => 2 * (Width + Height);

    public Rectangle(Point topLeft, double width, double height)
    {
        TopLeft = topLeft;
        Width = width;
        Height = height;
    }

    public bool IsPointInside(Point point)
    => point.X >= TopLeft.X && point.X <= TopLeft.X + Width
    && point.Y >= TopLeft.Y && point.Y <= TopLeft.Y + Height;
}