namespace MgtuBaumanIu3.Vidmanov.Task5.Part4;

public enum BerryColor
{
    Red,
    Blue,
    Black,
    Green
}

public class Berry(string name, double price, string form, BerryColor color, DateTime harvestDate)
    : Fruit(name, price, form)
{
    public BerryColor Color { get; set; } = color;
    public DateTime HarvestDate { get; set; } = harvestDate;
    public bool IsRootCrop { get; set; } = false;
}