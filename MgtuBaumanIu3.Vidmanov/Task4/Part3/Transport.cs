namespace MgtuBaumanIu3.Vidmanov.Task4.Part3;

public abstract class Transport(string name, double fuel, double mileage, double strength, string category)
{
    public string Name => name;

    public double Fuel { get; protected set; } = fuel;

    public double Mileage { get; protected set; } = mileage;
    public double Strength { get; protected set; } = strength;
    public string Category => category;

    public virtual void Move(double distance)
    {
        if (Strength is <= 0)
        {
            Console.WriteLine("Сломан, нужен ремонт");
            return;
        }
        // Реализация перемещения
        Console.WriteLine($"{Name} двигается на расстояние {distance} км");
        Fuel -= distance;
        Mileage += distance;
        ChangeState(5);
    }

    protected virtual void ChangeState(double wear) => Strength = Strength - wear < 0 ? 0 : Strength - wear;

    public void DisplayInfo()
    {
        Console.WriteLine($"Транспортное средство: {Name}");
        Console.WriteLine($"Остаток топлива: {Fuel} л");
        Console.WriteLine($"Пробег: {Mileage} км");
        Console.WriteLine($"Прочность: {Strength}%");
    }
}