﻿namespace MgtuBaumanIu3.Vidmanov.Task4.Part1;

public class Square
{
    public Point TopLeft { get; set; }
    public double SideLength { get; set; }
    public double Area => Math.Pow(SideLength, 2);
    public double Perimeter => 4 * SideLength;

    public Square(Point topLeft, double sideLength)
    {
        TopLeft = topLeft;
        SideLength = sideLength;
    }

    public bool IsPointInside(Point point)
    => point.GetX() >= TopLeft.GetX() && point.GetX() <= TopLeft.GetX() + SideLength
    && point.GetY() >= TopLeft.GetY() && point.GetY() <= TopLeft.GetY() + SideLength;
}