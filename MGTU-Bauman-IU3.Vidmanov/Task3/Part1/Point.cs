﻿namespace InstituteHomework.Vidmanov.Task3.Part1;

public struct Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double Distance(Point point)
    => Math.Sqrt(Math.Pow(X - point.X, 2) - Math.Pow(Y - point.Y, 2));
}