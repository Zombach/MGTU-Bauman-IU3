using MgtuBaumanIu3.Core;

namespace MgtuBaumanIu3.Vidmanov.Task5.Part3;

public class Quest : BaseQuest
{
    public override void Start()
    {
        Io io = Io.Instance;
        int n = io.GetDigital<int>("Укажите число:");
        Console.WriteLine($"Факториал {n} = {MathFunctions.Fact(n)}");

        double x = io.GetDigital<double>("Укажите число:");
        Console.WriteLine($"Обратное число {x} = {MathFunctions.Reciprocal(x)}");
        Console.WriteLine($"Дробная часть {x} = {MathFunctions.FracPart(x)}");

        int num = io.GetDigital<int>("Укажите число:");
        Console.WriteLine($"{num} четное? {MathFunctions.IsEven(num)}");
        Console.WriteLine($"{num} нечетное? {MathFunctions.IsOdd(num)}");

        double cubeRoot = io.GetDigital<double>("Укажите число:");
        Console.WriteLine($"Кубический корень из {cubeRoot} = {MathFunctions.Crt(cubeRoot)}");

        double degrees = io.GetDigital<double>("Укажите число:");
        Console.WriteLine($"{degrees} градусов = {MathFunctions.DegToRad(degrees)} радиан");

        double radians = Math.PI / io.GetDigital<int>("Укажите число:"); ;
        Console.WriteLine($"{radians} радиан = {MathFunctions.RadToDeg(radians)} градусов");

        int binaryNumber = io.GetDigital<int>("Укажите число:"); ;
        Console.WriteLine($"{binaryNumber} - степень двойки? {MathFunctions.BinaryDigit(binaryNumber)}");

        Console.ReadKey();
    }
}