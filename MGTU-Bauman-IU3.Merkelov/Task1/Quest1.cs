using MgtuBaumanIu3.Core;

namespace MgtuBaumanIu3.Merkelov.Task1;

public class Quest1 : BaseQuest
{
    /// <summary>
    /// Блок схема
    /// Запустить
    /// Ввести значение стороны a с клавиатуры
    /// Ввести значение высоты h с клавиатуры
    /// Вычислить площадь треугольника S по формуле: S = (a * h) / 2
    /// Вывести значение площади S на экран
    /// Завершить
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