using InstituteHomework.Core;

namespace InstituteHomework.Merkelov.Task1;

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
        int a = io.GetDigital<int>("Введите сторону");
        int h = io.GetDigital<int>("Введите высоту");
        float s = (float)a * h / 2;
        Console.WriteLine($"Площадь треугольника: {s}");
    }
}