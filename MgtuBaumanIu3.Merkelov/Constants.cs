namespace MgtuBaumanIu3.Merkelov;

public class Constants
{
    private const string Task1Part1 = " 1) Задание 1:а\tПлощади треугольника.";
    
    private const string Task1Part2 = " 2) Задание 1:б\tМассивы. Ближайшие числа.";

    private const string Task2Part1 = " 3) Задание 2:а\tМассивы. Посчитать число инверсий.";

    private const string Task2Part2 = " 4) Задание 2:б\tРекурсивный бинарного поиск.";

    private const string Task3 = " 5) Задание 3:\tHash-Таблица.";

    private const string Task4 = " 6) Задание 4:\tБинарное дерево.";

    private const string Task5 = " 7) Задание 5:\tРасстояние Дамерау-Левенштейна.";

    private const string Task6 = " 8) Задание 6:\tКрасно-черное дерево.";

    private const string Task7 = " 9) Задание 7:\tГраф.";

    private const string Task8 = "10) Задание 8:\tПоиск номеров.";

    public void ViewTasks()
    {
        Console.WriteLine(Task1Part1);
        Console.WriteLine(Task1Part2);
        Console.WriteLine(Task2Part1);
        Console.WriteLine(Task2Part2);
        Console.WriteLine(Task3);
        Console.WriteLine(Task4);
        Console.WriteLine(Task5);
        Console.WriteLine(Task6);
        Console.WriteLine(Task7);
        Console.WriteLine(Task8);
    }
}