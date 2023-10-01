using MgtuBaumanIu3.Vidmanov.Task5.Part5.Interfaces;

namespace MgtuBaumanIu3.Vidmanov.Task5.Part5;

public enum TomatoColor
{
    Red,
    Yellow,
    Green
}

public class Tomato(string name, double price, string form, TomatoColor color)
    : Vegetables(name, price, form), ITomato
{
    public TomatoColor Color { get; set; } = color;
    public bool IsRootCrop { get; set; } = false;

    public override void DisplayInfo()
    {
        Console.WriteLine($"Tomato Name: {Name}");
        Console.WriteLine($"Tomato Color: {Color}");
        Console.WriteLine($"Tomato Form: {Form}");
        Console.WriteLine($"Tomato Price: {Price}");
        Console.WriteLine($"Is Tomato a Root Crop? {IsRootCrop}");
    }

    public void SetColor(TomatoColor tomatoColor) => color = tomatoColor;

    public TomatoColor GetColor() => color;
}