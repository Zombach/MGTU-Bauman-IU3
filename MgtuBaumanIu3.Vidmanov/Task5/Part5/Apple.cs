using MgtuBaumanIu3.Vidmanov.Task5.Part5.Interfaces;

namespace MgtuBaumanIu3.Vidmanov.Task5.Part5;

public class Apple(string name, double price, string form, string sort)
    : Fruit(name, price, form), IApple
{
    public string Sort => sort;
    public bool IsRootCrop { get; set; } = false;

    public string GetSort() => sort;
    public void SetSort(string newSort) => sort = newSort;

    public override void DisplayInfo()
    {
        Console.WriteLine($"Apple Name: {Name}");
        Console.WriteLine($"Apple Sort: {Sort}");
        Console.WriteLine($"Apple Form: {Form}");
        Console.WriteLine($"Apple Price: {Price}");
        Console.WriteLine($"Is Apple a Root Crop? {IsRootCrop}");
    }
}