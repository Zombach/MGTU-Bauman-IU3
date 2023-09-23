using MgtuBaumanIu3.Core;

namespace MgtuBaumanIu3.Vidmanov.Task3.Part1;

/// <summary>
/// В задачах этого семинара все объекты необходимо создавать в виде типа данных struct,
/// принадлежащие типу-значению. Каждый новый тип данных struct должен использовать, при
/// возможности, свойства более простого типа данных struct. Например, структура Line должна
/// иметь 2 поля структуры Point. В методе Main() создать пример (демонстрация) использования
/// созданных структур.
///   •  Создать структуру Point, описывающей точку на плоскости, заданную декартовыми
///      координатами. Среди методов Point предусмотреть метод Distance, вычисляющий
///      расстояние до заданной точки.
///   •  Создать структуру Line, описывающей линию на плоскости. Среди методов
///      Line предусмотреть метод, определяющий принадлежность заданной точки линии.
///      Реализовать метод, вычисляющий и выводящий на экран длину созданной линии.
///   •  Создать структуру Square, описывающей квадрат на плоскости со сторонами,
///      параллельными осям координат. Среди методов Square предусмотреть метод,
///      определяющий принадлежность заданной точки квадрату. Реализовать метод,
///      вычисляющий и выводящий на экран площадь и периметр квадрата.
///   •  Создать структуру Circle, описывающей круг на плоскости. Среди методов
///      Circle предусмотреть метод, определяющий принадлежность заданной точки кругу.
///      Реализовать метод, вычисляющий и выводящий на экран площадь и периметр круга.
///   •  Создать структуру Rectangle, описывающей прямоугольник на плоскости со сторонами,
///      параллельными осям координат. Среди методов Rectangle предусмотреть метод,
///      определяющий принадлежность заданной точки прямоугольнику. Реализовать метод,
///      вычисляющий и выводящий на экран площадь и периметр прямоугольника.
///   •  Создать структуру Rhombus, описывающей ромб на плоскости с осями, параллельными
///      осям координат. Среди методов Rhombus предусмотреть метод, определяющий
///      принадлежность заданной точки ромбу. Реализовать метод, вычисляющий и выводящий
///      на экран площадь и периметр ромба.
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
        Console.WriteLine($"Точка ({testPoint.X}, {testPoint.Y}) принадлежит линии: {(isPointOnObject? "да": "нет")}");
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