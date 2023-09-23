using MgtuBaumanIu3.Core;

namespace MgtuBaumanIu3.Vidmanov.Task4.Part1;

/// <summary>
///Изменить программу, которая была создана в предыдущем задании, следующим образом:
///Вместо структур использовать классы для объектов Point, Line, Square, Circle,
/// Rectangle, Rhomb(реализовать без использования наследования)
/// Члены-переменные всех классов должны быть закрытыми
/// Доступ к закрытым членам-переменным организовать при помощи открытых
/// членов-методов Для объектов Square, Circle, Rectangle, Rhomb создать методы вычисления
/// периметра и площади
/// </summary>
public class Quest : BaseQuest
{
    public override void Start()
    {
        Point pointA = new(1, 2);
        pointA.View();
        Point pointB = new(4, 6);
        Point testPoint = new(2, 4);

        Line line = new(pointA, pointB);
        bool isPointOnObject = line.IsPointOnObject(testPoint);
        Console.WriteLine($"Точка ({testPoint.GetX()}, {testPoint.GetY()}) принадлежит линии: {(isPointOnObject ? "да" : "нет")}");
        line.View();

        Square square = new(new Point(1, 1), 3);
        double squareArea = square.Area();
        double squarePerimeter = square.Perimeter();
        Console.WriteLine($"Площадь квадрата: {squareArea}, Периметр квадрата: {squarePerimeter}");
        bool isPointInsideSquare = square.IsPointOnObject(new Point(2, 2));
        Console.WriteLine($"Точка (2, 2) принадлежит квадрату: {isPointInsideSquare}");
        square.View();

        Circle circle = new Circle(new Point(0, 0), 5);
        double circleArea = circle.Area();
        double circlePerimeter = circle.Perimeter();
        Console.WriteLine($"Площадь круга: {circleArea}, Периметр круга: {circlePerimeter}");
        bool isPointInsideCircle = circle.IsPointOnObject(new Point(3, 3));
        Console.WriteLine($"Точка (3, 3) принадлежит кругу: {isPointInsideCircle}");
        circle.View();

        Rectangle rectangle = new Rectangle(new Point(1, 1), 4, 2);
        double rectangleArea = rectangle.Area();
        double rectanglePerimeter = rectangle.Perimeter();
        Console.WriteLine($"Площадь прямоугольника: {rectangleArea}, Периметр прямоугольника: {rectanglePerimeter}");
        bool isPointInsideRectangle = rectangle.IsPointOnObject(new Point(3, 2));
        Console.WriteLine($"Точка (3, 2) принадлежит прямоугольнику: {isPointInsideRectangle}");
        rectangle.View();

        Rhombus rhombus = new(new Point(1, 1), 4, 2);
        double rhombusArea = rhombus.Area();
        double rhombusPerimeter = rhombus.Perimeter();
        Console.WriteLine($"Площадь ромба: {rhombusArea}, Периметр ромба: {rhombusPerimeter}");
        bool isPointInsideRhombus = rhombus.IsPointOnObject(new Point(3, 2));
        Console.WriteLine($"Точка (3, 2) принадлежит ромбу: {isPointInsideRhombus}");
        rhombus.View();
    }
}