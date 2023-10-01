using MgtuBaumanIu3.Vidmanov.Task5.Part5.Interfaces;

namespace MgtuBaumanIu3.Vidmanov.Task5.Part5;

public class Potatoes(string name, double price, string form, string type)
    : Vegetables(name, price, form), IPotato
{
    public string Type { get; set; } = type;
    public bool IsRootCrop { get; set; } = false;

    public override void DisplayInfo()
    {
        Console.WriteLine($"Potatoes Name: {Name}");
        Console.WriteLine($"Potatoes Type: {Type}");
        Console.WriteLine($"Potatoes Form: {Form}");
        Console.WriteLine($"Potatoes Price: {Price}");
        Console.WriteLine($"Is Potatoes a Root Crop? {IsRootCrop}");
    }

    public void SetType(string newType) => type = newType;

    public new string GetType() => type;
}