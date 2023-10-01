using MgtuBaumanIu3.Vidmanov.Task5.Part6.Interfaces;

namespace MgtuBaumanIu3.Vidmanov.Task5.Part6;

public class Group(string name) : IAdd
{
    public string Name { get; set; } = name;
    public List<User> Users { get; set; } = new();


    public void Add<T>(T value) => Users.Add(value as User);

    public void RemoveUser(User user) => Users.Remove(user);

    public void DisplayGroupMembers()
    {
        Console.WriteLine($"Group: {Name}");
        foreach (var user in Users)
        {
            Console.WriteLine($"- {user.Username} ({user.Email})");
        }
    }
}
