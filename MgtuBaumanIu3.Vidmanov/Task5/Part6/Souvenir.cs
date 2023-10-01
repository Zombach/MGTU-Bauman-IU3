using MgtuBaumanIu3.Vidmanov.Task5.Part6.Interfaces;

namespace MgtuBaumanIu3.Vidmanov.Task5.Part6;

public class Souvenir(string name) : IPrintable
{
    public string Name { get; set; } = name;

    public void Print() => Console.WriteLine($"Printing souvenir: {Name}");
}