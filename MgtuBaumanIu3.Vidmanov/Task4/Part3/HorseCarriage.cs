using System.Xml.Linq;

namespace MgtuBaumanIu3.Vidmanov.Task4.Part3;

public class HorseCarriage(double fuel, double mileage, int wearAndTear) : Transport("Гужевая повозка", fuel, mileage, wearAndTear, "нет")
{
    public override void Move(double distance)
    {
        if (Strength is >= 50)
        {
            Console.WriteLine("Сломан, нужен ремонт");
            return;
        }
        Console.WriteLine($"{Name} двигается на расстояние {distance} км");
        Fuel -= distance * 0.1;
        Mileage += distance;
        ChangeState(5);
    }
}