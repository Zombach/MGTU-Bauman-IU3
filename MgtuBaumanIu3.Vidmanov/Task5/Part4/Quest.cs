using MgtuBaumanIu3.Core;

namespace MgtuBaumanIu3.Vidmanov.Task5.Part4;

public class Quest : BaseQuest
{
    public override void Start()
    {
        Apple apple = new Apple("Red Apple", 1.99, "Round", "Fuji");
        Berry berry = new Berry("Blueberry", 3.49, "Round", BerryColor.Blue, DateTime.Now);

        Console.WriteLine("Apple Name: " + apple.Name);
        Console.WriteLine("Apple Sort: " + apple.Sort);
        Console.WriteLine("Apple Form: " + apple.Form);
        Console.WriteLine("Apple Price: " + apple.GetPrice());
        Console.WriteLine("Is Apple a Root Crop? " + apple.IsRootCrop);

        Console.WriteLine("\nBerry Name: " + berry.Name);
        Console.WriteLine("Berry Color: " + berry.Color);
        Console.WriteLine("Berry Form: " + berry.Form);
        Console.WriteLine("Berry Price: " + berry.GetPrice());
        Console.WriteLine("Is Berry a Root Crop? " + berry.IsRootCrop);

        Potatoes potatoes = new Potatoes("Red Potatoes", 2.49, "Round", "Russet");
        Tomato tomato = new Tomato("Cherry Tomato", 1.79, "Round", TomatoColor.Red);

        Console.WriteLine("Potatoes Name: " + potatoes.Name);
        Console.WriteLine("Potatoes Type: " + potatoes.Type);
        Console.WriteLine("Potatoes Form: " + potatoes.Form);
        Console.WriteLine("Potatoes Price: " + potatoes.GetPrice());
        Console.WriteLine("Is Potatoes a Root Crop? " + potatoes.IsRootCrop);

        Console.WriteLine("\nTomato Name: " + tomato.Name);
        Console.WriteLine("Tomato Color: " + tomato.Color);
        Console.WriteLine("Tomato Form: " + tomato.Form);
        Console.WriteLine("Tomato Price: " + tomato.GetPrice());
        Console.WriteLine("Is Tomato a Root Crop? " + tomato.IsRootCrop);
    }
}