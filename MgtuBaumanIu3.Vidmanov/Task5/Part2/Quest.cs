using MgtuBaumanIu3.Core;

namespace MgtuBaumanIu3.Vidmanov.Task5.Part2;

public class Quest : BaseQuest
{
    public override void Start()
    {
        DateTime dateOpen = new(2023, 10, 1);
        string fio = "Иванов Иван Иванович";
        double depositSum = 10000;

        Deposit deposit = new(dateOpen, fio, depositSum);

        // Вывод информации о вкладе
        deposit.DisplayInfo();

        // Расчет суммы вклада по истечению заданного количества дней
        int days = 90;
        double finalAmount = deposit.CalculateInterest(days);
        Console.WriteLine($"Сумма вклада через {days} дней: {finalAmount} руб.");

        Console.ReadKey();
    }
}