﻿using MgtuBaumanIu3.Vidmanov.Task3.Part1.Interfaces;

namespace MgtuBaumanIu3.Vidmanov.Task3.Part1;

public readonly struct Rhombus(Point top, double diagonal1, double diagonal2)
    : IArea, IPerimeter, IIsPointOnObject, IView
{
    public Point Top => top;
    public double Diagonal1 => diagonal1;
    public double Diagonal2 => diagonal2;

    public double Area() => Diagonal1 * Diagonal2 / 2;

    public double Perimeter() => 4 * Math.Sqrt((Math.Pow(Diagonal1, 2) + Math.Pow(Diagonal2, 2)) / 4);

    public bool IsPointOnObject(Point point)
    {
        double halfDiagonal1 = Diagonal1 / 2;
        double halfDiagonal2 = Diagonal2 / 2;
        double centerX = Top.X + halfDiagonal1;
        double centerY = Top.Y + halfDiagonal2;
        double dx = Math.Abs(point.X - centerX);
        double dy = Math.Abs(point.Y - centerY);
        return dx / halfDiagonal1 + dy / halfDiagonal2 <= 1;
    }

    public void View()
    {
        Console.WriteLine($"Top: x={top.X}, y={top.Y}");
        Console.WriteLine($"Диагональ 1: {diagonal1}");
        Console.WriteLine($"Диагональ 2: {diagonal2}");
        Console.WriteLine($"Площадь: {Area()}");
        Console.WriteLine($"Периметр: {Perimeter()} ");
    }
}