using InstituteHomework.Core;

namespace InstituteHomework.Facade;

public class VidmanovFacade
{
    public IQuest Task1Part1 => new Vidmanov.Task1.Part1.Quest();
    public IQuest Task1Part2 => new Vidmanov.Task1.Part2.Quest();
}