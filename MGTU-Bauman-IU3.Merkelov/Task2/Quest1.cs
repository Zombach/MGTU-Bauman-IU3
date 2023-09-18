using MgtuBaumanIu3.Core;

namespace MgtuBaumanIu3.Merkelov.Task2;

public class Quest1 : BaseQuest
{
    public override void Start()
    {
        Io io = Io.Instance;
        int size = io.GetDigital<int>("Введите длину массива");
        int[] array = io.GetArray(size, "A");
        Console.WriteLine($"Вы ввели: {string.Join(" ", array)}");

        int inversion = 0;
        int length = array.Length - 1;

        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length - i; j++)
            {
                if (array[j] < array[j + 1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    inversion++;
                }
            }
        }
        Console.WriteLine("Результат:");
        Console.WriteLine($"Инверсий: {inversion}");
    }
}