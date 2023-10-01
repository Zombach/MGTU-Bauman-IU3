using MgtuBaumanIu3.Vidmanov.Task5.Part5.Interfaces;

namespace MgtuBaumanIu3.Vidmanov.Task5.Part5;

public class Fruit(string name, double price, string form) : IFruitVeget
{
    protected string GrowingLocation = "Unknown";
    public string Name => name;

    public double Price => price;

    public string Form { get; set; } = form;

    public virtual void SetName(string newName) => name = newName;

    public virtual void SetWhere(string where) => GrowingLocation = where;

    public virtual void SetPrice(double newPrice) => price = newPrice;
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Fruit Name: {Name}");
        Console.WriteLine($"Where It Grows: {GrowingLocation}");
        Console.WriteLine($"Price: {Price}");
    }
}