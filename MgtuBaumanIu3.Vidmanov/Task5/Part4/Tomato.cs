namespace MgtuBaumanIu3.Vidmanov.Task5.Part4;

public enum TomatoColor
{
    Red,
    Yellow,
    Green
}

public class Tomato(string name, double price, string form, TomatoColor color)
    : Vegetables(name, price, form)
{
    public TomatoColor Color { get; set; } = color;
    public bool IsRootCrop { get; set; } = false;
}