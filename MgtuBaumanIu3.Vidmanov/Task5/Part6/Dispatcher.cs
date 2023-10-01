using MgtuBaumanIu3.Vidmanov.Task5.Part6.Interfaces;

namespace MgtuBaumanIu3.Vidmanov.Task5.Part6;

public class Dispatcher : IAdd
{
    private readonly List<string> _tasks = new List<string>();
    public void Add<T>(T value) => _tasks.Add(value as string);
    
    public void ExecuteTasks()
    {
        Console.WriteLine("Executing tasks:");
        foreach (var task in _tasks)
        {
            Console.WriteLine($"- {task}");
        }
    }
}