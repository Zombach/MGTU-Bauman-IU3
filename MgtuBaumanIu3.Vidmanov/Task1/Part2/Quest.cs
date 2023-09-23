using MgtuBaumanIu3.Core;

namespace MgtuBaumanIu3.Vidmanov.Task1.Part2;

/// <summary>
/// Вариант №3. Найти координаты центра тяжести треугольника на плоскости, то есть
/// координаты точки, лежащей на медиане и отстоящей на 2/3 ее длины от вершины, из
/// которой медиана проведена. Для проверки результата выполнить вычисления для всех
/// трех медиан. Проверить работу программы также для равнобедренного прямоугольного
/// треугольника с координатами вершин (0; 0), (3; 0), (0; 3), где решение очевидно.
/// </summary>
public class Quest : BaseQuest
{
    public override void Start()
    {
        Point pointA = GetPoint('A');
        Point pointB = GetPoint('B');
        Point pointC = GetPoint('C');

        Triangle triangle = new(pointA, pointB, pointC);
        ViewMedian(triangle.MedianA);
        ViewMedian(triangle.MedianB);
        ViewMedian(triangle.MedianC);
        CenterGravity(triangle.CenterGravity);
    }

    private Point GetPoint(char name)
    {
        Io io = Io.Instance;
        Console.WriteLine($"Укажите точку {name}");
        float x = io.GetDigital<float>("Укажите X");
        float y = io.GetDigital<float>("Укажите Y");
        return new(x, y);
    }

    public void ViewMedian(Median median) => Console.WriteLine($"Медиана А: x={median.Point.X}, y={median.Point.Y}");
    public void CenterGravity(Point center) => Console.WriteLine($"Центр: x={center.X}, y={center.Y}");
}