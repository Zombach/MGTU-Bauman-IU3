using InstituteHomework.Core;

namespace InstituteHomework.Vidmanov.Task1.Part1;

/// <summary>
/// Вариант №1
/// Вычислить Y при введённом значении X по приведённой формуле и по
/// оптимизированной Вами формуле:
/// Y = (2*(x^3) + 6*(x^2) - 8*x + 4)/(-4*(x^3)+8*(x^2)-(x^5)+2*(x^4))
/// </summary>
public class Quest : BaseQuest
{
    public override void Start()
    {
        Io io = Io.Instance;
        double x = io.GetDigital<double>("Укажите X");
        double yOriginal = (2 * Math.Pow(x, 3) + 6 * Math.Pow(x, 2) - 8 * x + 4) /
                           (-4 * Math.Pow(x, 3) + 8 * Math.Pow(x, 2) - Math.Pow(x, 5) + 2 * Math.Pow(x, 4));
        double numerator = 2 * (x - 1) * (x + 2) * (x + 1); // Числитель
        double denominator = -x * (x - 1) * (x + 1) * (x - 2); // Знаменатель
        double yOptimized = numerator / denominator;
    }
}