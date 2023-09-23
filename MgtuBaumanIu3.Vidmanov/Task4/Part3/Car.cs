using System.Xml.Linq;

namespace MgtuBaumanIu3.Vidmanov.Task4.Part3;

public class Car(double fuel, double mileage, int strength) : Transport("Машина", fuel, mileage, strength, "A")
{
    public override void Move(double distance)
    {
        if (Strength is 0)
        {
            Console.WriteLine("Сломан, нужен ремонт");
            return;
        }
        Console.WriteLine($"{Name} двигается на расстояние {distance} км");
        Fuel -= distance * 0.15;
        Mileage += distance;
        ChangeState(10);
    }
}