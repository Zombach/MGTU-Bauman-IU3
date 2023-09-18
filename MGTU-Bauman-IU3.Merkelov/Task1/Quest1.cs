using MgtuBaumanIu3.Core;

namespace MgtuBaumanIu3.Merkelov.Task1;

public class Quest1 : BaseQuest
{
    /// <summary>
    /// Задание 1.
    /// Разработать блок-схему алгоритма и программу для вычисления
    /// площади треугольника S по заданным с клавиатуры значениям
    /// стороны a и высоты h, проведенной к этой стороне.
    /// Значение площади вывести на экран.
    /// </summary>
    public override void Start()
    {
        Io io = Io.Instance;
        double a = io.GetDigital<double>("Введите сторону");
        double h = io.GetDigital<double>("Введите высоту");
        double s = a * h / 2;
        Console.WriteLine($"Площадь треугольника: {s}");
    }
}