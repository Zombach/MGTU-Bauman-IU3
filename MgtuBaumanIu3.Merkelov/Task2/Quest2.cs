﻿using MgtuBaumanIu3.Core;

namespace MgtuBaumanIu3.Merkelov.Task2;

/// <summary>
/// Реализовать алгоритм бинарного поиска через рекурсию.
/// </summary>
public class Quest2 : BaseQuest
{
    public override void Start()
    {
        Io io = Io.Instance;
        int size = io.GetDigital<int>("Введите длину массива");
        List<int> array = io.GetArray(size, "A").ToList();
        array.Sort();
        Console.WriteLine($"Вы ввели: {string.Join(" ", array)}");

        int value = io.GetDigital<int>("Укажите искомое значение");
        
        int result = BinarySearch(array, value, 0, array.Count - 1);

        Console.WriteLine("Результат:");
        Console.WriteLine(result != -1
        ? $"Элемент {value} найден в массиве по индексу {result}"
        : $"Элемент {value} не найден в массиве");
    }

    public int BinarySearch(List<int> array, int value, int left, int right)
    {
        if (left > right) return -1;
        int middle = left + (right - left) / 2;
        if (array[middle] == value) { return middle; }
        if (array[middle] < value) { return BinarySearch(array, value, middle + 1, right); }
        return BinarySearch(array, value, left, middle - 1);
    }
}