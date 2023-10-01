namespace MgtuBaumanIu3.Vidmanov.Task5.Part4;

public class Potatoes(string name, double price, string form, string type)
    : Vegetables(name, price, form)
{
    public string Type { get; set; } = type;
    public bool IsRootCrop { get; set; } = false;
}