using MgtuBaumanIu3.Core;
using MgtuBaumanIu3.Vidmanov.Task5.Part5.Interfaces;

namespace MgtuBaumanIu3.Vidmanov.Task5.Part5;

public class Quest : BaseQuest
{
    public override void Start()
    {
        IFruitVeget fruitVeget1 = new Apple("Red Apple", 1.99, "Round", "Fuji");
        IFruitVeget fruitVeget2 = new Berry("Blueberry", 3.49, "Round", BerryColor.Blue, DateTime.Now);
        IFruitVeget fruitVeget3 = new Potatoes("Red Potatoes", 2.49, "Round", "Russet");
        IFruitVeget fruitVeget4 = new Tomato("Cherry Tomato", 1.79, "Round", TomatoColor.Red);

        fruitVeget1.DisplayInfo();
        Console.WriteLine();
        fruitVeget2.DisplayInfo();
        Console.WriteLine();
        fruitVeget3.DisplayInfo();
        Console.WriteLine();
        fruitVeget4.DisplayInfo();
    }
}