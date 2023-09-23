namespace MgtuBaumanIu3.Vidmanov.Task4.Part3;

public class Boat(double fuel, double mileage, int strength) : Transport("Катер", fuel, mileage, strength, "F")
{
    public override void Move(double distance)
    {
        if (Strength is 0)
        {
            Console.WriteLine("Сломан, нужен ремонт");
            return;
        }
        Console.WriteLine($"{Name} двигается на расстояние {distance} км");
        Fuel-= distance * 0.25;
        Mileage += distance;
        ChangeState(20);
    }
}