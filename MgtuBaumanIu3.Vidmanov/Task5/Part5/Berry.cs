using MgtuBaumanIu3.Vidmanov.Task5.Part5.Interfaces;

namespace MgtuBaumanIu3.Vidmanov.Task5.Part5;

public enum BerryColor
{
    Red,
    Blue,
    Black,
    Green
}

public class Berry(string name, double price, string form, BerryColor color, DateTime harvestDate)
    : Fruit(name, price, form), IBerry
{
    public BerryColor Color { get; set; } = color;
    public DateTime HarvestDate { get; set; } = harvestDate;
    public bool IsRootCrop { get; set; } = false;

    public override void DisplayInfo()
    {
        Console.WriteLine($"Berry Name: {Name}");
        Console.WriteLine($"Berry Color: {Color}");
        Console.WriteLine($"Berry Form: {Form}");
        Console.WriteLine($"Berry Price: {Price}");
        Console.WriteLine($"Is Berry a Root Crop? {IsRootCrop}");
    }

    public void SetColor(BerryColor berryColor) => color = berryColor;

    public BerryColor GetColor() => color;

    public void SetHarvestDate(DateTime date) => harvestDate = date;

    public DateTime GetHarvestDate() => harvestDate;
}