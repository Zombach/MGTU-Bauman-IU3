namespace MgtuBaumanIu3.Vidmanov.Task5.Part2;

public class Deposit(DateTime dateOpen, string fullName, double depositSum) : IDeposit
{
    private static readonly double Rate;
    private static readonly string BankName;
    private static readonly int DepositTerm;

    static Deposit()
    {
        Rate = 0.05;
        BankName = "Некий Банк";
        DepositTerm = 365;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Информация о вкладе:");
        Console.WriteLine($"Название банка: {BankName}");
        Console.WriteLine($"Дата открытия вклада: {dateOpen}");
        Console.WriteLine($"Срок вклада: {DepositTerm} дней");
        Console.WriteLine($"ФИО держателя вклада: {fullName}");
        Console.WriteLine($"Сумма вклада: {depositSum} руб.");
        Console.WriteLine($"Текущая ставка: {Rate * 100}%");
    }

    public double CalculateInterest(int days)
    {
        double percent = Rate * days / 365;
        double interest = depositSum * percent;
        return depositSum + interest;
    }
}