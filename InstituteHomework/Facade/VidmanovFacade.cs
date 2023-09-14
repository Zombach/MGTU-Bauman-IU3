using InstituteHomework.Core;

namespace InstituteHomework.Facade;

public class VidmanovFacade
{
    public static IQuest Task1Part1 => new Vidmanov.Task1.Part1.Quest();
    public static IQuest Task1Part2 => new Vidmanov.Task1.Part2.Quest();
}