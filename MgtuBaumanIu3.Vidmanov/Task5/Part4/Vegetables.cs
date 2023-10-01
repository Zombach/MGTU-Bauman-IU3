namespace MgtuBaumanIu3.Vidmanov.Task5.Part4;

public class Vegetables(string name, double price, string form)
{
    protected string GrowingLocation = "Unknown";
    public string Name { get; set; } = name;
    public string Form { get; set; } = form;

    public void SetPrice(double newPrice) => price = newPrice;
    public double GetPrice() => price;
}