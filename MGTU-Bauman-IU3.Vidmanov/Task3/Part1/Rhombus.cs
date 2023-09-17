using Task3.Part1.Interfaces;

namespace InstituteHomework.Vidmanov.Task3.Part1;

public struct Rhombus : IArea, IPerimeter, IView
{
    public Point Top { get; set; }
    public double Diagonal1 { get; set; }
    public double Diagonal2 { get; set; }

    public Rhombus(Point top, double diagonal1, double diagonal2)
    {
        Top = top;
        Diagonal1 = diagonal1;
        Diagonal2 = diagonal2;
    }

    public bool IsPointInside(Point point)
    {
        double halfDiagonal1 = Diagonal1 / 2;
        double halfDiagonal2 = Diagonal2 / 2;
        double centerX = Top.X + halfDiagonal1;
        double centerY = Top.Y + halfDiagonal2;

        double dx = Math.Abs(point.X - centerX);
        double dy = Math.Abs(point.Y - centerY);

        return dx / halfDiagonal1 + dy / halfDiagonal2 <= 1;
    }

    public double Area() => Diagonal1 * Diagonal2 / 2;
    public double Perimeter() => 4 * Math.Sqrt((Math.Pow(Diagonal1, 2) + Math.Pow(Diagonal2, 2)) / 4);

    public void View()
    {
        Console.WriteLine($"Площадь: {Area()}");
        Console.WriteLine($"Периметр: {Perimeter()} ");
    }
}