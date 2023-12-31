﻿using MgtuBaumanIu3.Core;

namespace MgtuBaumanIu3.Vidmanov.Task2;

/// <summary>
/// 3.Работа с базовыми типами
/// Часть 1:
/// Работа с базовыми типами и обработкой исключений
/// Создать консольное приложение C# для расчета будущей стоимости капиталовложений,
/// которые имеют фиксированную ставку для прибыли на инвестиционный капитал.
/// Условия:
///   •  Использовать для переменных тип «decimal»
///   •  Пользователь вводит первоначальную стоимость вклада
///   •  Организовать проверки на минимальный остаток – $5000. Вывести
///      предупреждение при вводе суммы меньше минимального остатка.
///   •  Процентная ставка на прибыль (норма прибыли) – 8% годовых
///   •  Срок инвестиции – 10 лет
///   •  Организовать поясняющий вывод исходных данных, а также будущую стоимость
///      капиталовложения (с точностью до 3-х знаков после запятой). Выводить остаток
///      вклада и приращение остатка каждый год в течение срока вклада.
///   •  Использовать итерационные управляющие инструкции для оптимизации расчетов
///   •  Капитализация 1 раз в год
/// Норма прибыли – это процентная ставка в долях для заданного периода. Определяет
/// приращение капиталовложений в заданном периоде (для текущего задания норма
/// прибыли = 0.08 годовых).
///                             ∆ = S * p,
/// Где ∆ - приращение капиталовложений в периоде, S - остаток вклада, p - норма прибыли в периоде.
///
/// Часть 2:
/// Через 10 лет, после окончания срока вклада, вы вложили приобретенный капитал в
/// публичные акции «Сбербанк» на 1 год.
/// Стоимость акции меняется со временем. Норма прибыли капиталовложений изменяется
/// согласно функции: z = 0.1 + 0.02 * x^2 + 0.5 * sin(2*x) + cos(3*x)
/// Где z – процентная ставка на 1 месяц (z/100 = норма прибыли в долях единицы),
/// x – индекс месяца (x изменяется от 1 до 12 с шагом = 1).
/// Условия:
///   •  Доработать программу из части 1 согласно заданию части 2
///   •  Выводить в процессе расчета остаток капитала в долларах и норму прибыли в
///      процентах каждый месяц
///   •  Использовать итерационные управляющие инструкции для оптимизации расчетов
///   •  Капитализация 1 раз в месяц
///   •  Вычислить и вывести на экран процент и сумму приращения капиталовложений за
///      весь период инвестиций (12 месяцев)
///
/// Часть 3:
/// Организовать вывод на экран предполагаемого остатка капитала в долларах через
/// заданное пользователем количество месяцев.
/// Условия:
///   •  Доработать программу из части 2 согласно заданию части 3
///   •  Закон изменения нормы прибыли аналогичен тому, что был задан в части 2
///      текущего задания
///   •  Вводимое пользователем количество месяцев: от 13 до 48
///   •  Капитализация 1 раз в месяц
///   •  На экран выводит остаток в долларах, норму прибыли в процентах, индекс
///      заданного пользователем месяца
/// Для созданной программы, реализовать блоки обработки исключений, где это возможно.
/// Обработать, как минимум, три различных исключения. При этом использовать доступные
/// классы исключений, объявленные в System. Либо реализовать собственные.
/// </summary>
public class Quest : BaseQuest
{
    public override void Start()
    {
        decimal capital = Part1();
        capital = Part2(capital, 12);
        Part3(capital);
    }

    private decimal Part1()
    {
        Console.WriteLine("Разделитель для \"decimal\", используйте \",\"");

        decimal capital = Io.Instance.GetDigital<decimal>("Укажите капитал");
        CheckExceptions(capital);
        if (capital < 5000)
        { Console.WriteLine("Предупреждение: Выбранный вами капитал меньше минимального остатка"); }


        int year = Io.Instance.GetDigital<int>("Укажите длительность вклада, в годах");
        decimal rate = Io.Instance.GetDigital<decimal>("Укажите ставку вклада");

        Console.WriteLine();
        Console.WriteLine($"Ваш капитал составляет: {capital}");
        Console.WriteLine($"Срок инвестиции – {year}");
        Console.WriteLine($"Процентная ставка на прибыль (норма прибыли) – {rate}% годовых");

        List<string> info = new();
        try
        {
            for (int i = 1; i <= year; i++)
            {
                decimal remainder = capital * rate;
                capital += remainder;
                info.Add($"В {i} год");
                info.Add($"Остаток {capital:0.000}");
                info.Add($"Прибыль {remainder:0.000}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new OverflowException("Значение было либо слишком большим, либо слишком маленьким для десятичной дроби");
        }

        Console.WriteLine($"Итоговый остаток будет = {capital:0.000}\r\n");
        info.ForEach(Console.WriteLine);
        return capital;
    }

    private decimal Part2(decimal capital, int monthCount)
    {
        Console.WriteLine();
        Console.WriteLine($"Ваш капитал: {capital:0.000}");

        Console.WriteLine($"Выбрано месяцев {monthCount:0.000}");
        decimal current = capital;
        for (int month = 1; month <= monthCount; month++)
        {
            decimal interestRate = GetInterestRate(month);
            current += current * (interestRate / 100);
            Console.WriteLine($"Остаток капитала: {current:0.000} $");
            Console.WriteLine($"Норма прибыли: {interestRate:0.000} %");
        }

        Console.WriteLine();
        Console.WriteLine($"Приращения капиталовложений за {monthCount}");
        Console.WriteLine("Общая сумма:");
        Console.WriteLine($"{(current - capital):0.000} $");
        Console.WriteLine($"{(((current - capital) / capital) * 100):0.000} %");
        return current;
    }
    private void Part3(decimal capital)
    {
        int monthCount = Io.Instance.GetDigital<int>("Укажите длительность вклада, в месяцах 13 - 48");
        if(monthCount is < 13 or > 48) { throw new ArgumentOutOfRangeException($"Не верный диапазон"); }
        Part2(capital, monthCount);
    }

    private decimal GetInterestRate(int month)
    {
        decimal sin = (decimal)Math.Sin(2 * month);
        decimal cos = (decimal)Math.Cos(3 * month);
        return 0.1M + 0.02M * month * month + 0.5M * sin + cos;
    }

    private bool CheckExceptions(decimal capital) => capital switch
    {
        0 => throw new DivideByZeroException("Нельзя делить на 0"),
        < 0 => throw new Exception("Капитал не может быть отрицательным"),
        _ => true
    };
}