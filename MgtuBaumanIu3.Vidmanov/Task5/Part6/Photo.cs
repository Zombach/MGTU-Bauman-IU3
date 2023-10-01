using MgtuBaumanIu3.Vidmanov.Task5.Part6.Interfaces;

namespace MgtuBaumanIu3.Vidmanov.Task5.Part6;

public class Photo(string title) : IPrintable
{
    public string Title { get; set; } = title;

    public void Print() => Console.WriteLine($"Printing photo: {Title}");
}