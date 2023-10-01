namespace MgtuBaumanIu3.Vidmanov.Task5.Part4;

public class Apple(string name, double price, string form, string sort)
    : Fruit(name, price, form)
{
    public string Sort { get; set; } = sort;
    public bool IsRootCrop { get; set; } = false;
}