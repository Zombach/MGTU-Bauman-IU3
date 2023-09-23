namespace MgtuBaumanIu3.Vidmanov.Task4.Part3;

public class Airplane(double fuel, double mileage, int strength) : Transport("Самолет", fuel, mileage, strength, "S")
{
    public override void Move(double distance)
    {
        if (Strength is 0)
        {
            Console.WriteLine("Сломан, нужен ремонт");
            return;
        }
        Console.WriteLine($"{Name} двигается на расстояние {distance} км");
        Fuel -= distance * 0.5;
        Mileage += distance;
        ChangeState(30);
    }
}