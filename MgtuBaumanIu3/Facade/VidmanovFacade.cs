using MgtuBaumanIu3.Core;

namespace MgtuBaumanIu3.Facade;

public class VidmanovFacade
{
    public IQuest Task1Part1 => new Vidmanov.Task1.Part1.Quest();
    public IQuest Task1Part2 => new Vidmanov.Task1.Part2.Quest();
    public IQuest Task2Part1 => new Vidmanov.Task2.Quest();
    public IQuest Task3Part1 => new Vidmanov.Task3.Part1.Quest();
    public IQuest Task3Part2 => new Vidmanov.Task3.Part2.Quest();
}