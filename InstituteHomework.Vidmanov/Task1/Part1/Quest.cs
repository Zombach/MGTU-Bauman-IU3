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
        Optimized(x);
        Original(x);
    }

    private void Optimized(double x)
    {
        try
        {
            double result = (2 * Math.Pow(x, 3) + 6 * Math.Pow(x, 2) - 8 * x + 4) /
            (-4 * Math.Pow(x, 3) + 8 * Math.Pow(x, 2) - Math.Pow(x, 5) + 2 * Math.Pow(x, 4));
            Console.WriteLine(result);
        }
        catch { throw new Exception("Делить на ноль нельзя"); }
    }

    private void Original(double x)
    {
        double x2 = x * x;
        double x3 = x2 * x;
        double x4 = x3 * x;
        double x5 = x4 * x;
        double numerator = 2 * x3 + 6 * x2 - 8 * x + 4;
        double denominator = -4 * x3 + 8 * x2 - x5 + 2 * x4;
        if(denominator is 0) {throw new Exception("Делить на ноль нельзя"); }
        double result = numerator / denominator;
        Console.WriteLine(result);
    }
}