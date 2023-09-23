namespace MgtuBaumanIu3.Vidmanov.Task4.Part3;

public abstract class Transport(string type, int fuel, int range, string licenseCategory)
{
    public string Type => type;
    public int Fuel => fuel;
    public int Range => range;
    public string LicenseCategory => licenseCategory;

    private float _wear = 0;

    public void Move(int distance)
    {
        // Рассчитываем износ и уменьшаем топливо
        _wear += distance;
        fuel -= distance;

        // Обновляем остаток топлива и запас хода
        Console.WriteLine($"{type}: Перемещение на {distance} км.");
        Console.WriteLine($"Остаток топлива: {fuel} литров");
        Console.WriteLine($"Запас хода: {range - _wear} км.");
    }
}