using MgtuBaumanIu3.Core;

namespace MgtuBaumanIu3.Merkelov.Task1;

public class Quest2 : BaseQuest
{
    public override void Start()
    {
        Io io = Io.Instance;
        int size = io.GetDigital<int>("Введите длину массивов");
        int[] arrayA = io.GetArray(size, "A");
        Console.WriteLine($"Вы ввели: {string.Join(" ", arrayA)}");
        int[] arrayB = io.GetArray(size, "B");
        Console.WriteLine($"Вы ввели: {string.Join(" ", arrayB)}");

        var result = arrayB
        .Select((valueB, index) => new
        {
            Index = index,
            Values = arrayA.Select(valueA => GetDifference(valueA, valueB))

        })
        .Select(item => new
        {
            item.Index,
            Indexes = item.Values.Select((value, index) => value == item.Values.Min() ? index : -1).Where(index => index is not -1).ToList()
        }).ToList();
        Console.WriteLine("Результат:");
        result.ForEach(item =>
        {
            string line = $"{arrayB[item.Index]}: {string.Join(", ", item.Indexes.Select(index => arrayA[index]))}";
            Console.WriteLine(line);
        });
    }

    private int GetDifference(int a, int b)
    {
        int difference = a - b;
        difference = difference > 0 ? difference : difference * -1;
        return difference;
    }
}