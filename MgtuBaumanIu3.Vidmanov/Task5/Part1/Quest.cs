using MgtuBaumanIu3.Core;

namespace MgtuBaumanIu3.Vidmanov.Task5.Part1;

public class Quest : BaseQuest
{
    public override void Start()
    {
        Point? point = new(1, 2);
        Console.WriteLine($"Количество Point: {Point.Count()}");
        point = new(1, 2);
        point = new(1, 2);
        point = new(1, 2);
        Console.WriteLine($"Количество Point: {Point.Count()}");
        point = null;

        Console.WriteLine($"Количество Point: {Point.Count()}");
        GC.Collect();
        point = new(2, 1);
        Console.WriteLine($"Количество Point: {Point.Count()}");
    }
}