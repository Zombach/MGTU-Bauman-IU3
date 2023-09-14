using InstituteHomework.Core;

namespace InstituteHomework.Facade;

public class MerkelovFacade
{
    public static IQuest Task1Part1 => new Merkelov.Task1.Quest1();
    public static IQuest Task1Part2 => new Merkelov.Task1.Quest2();
    public static IQuest Task2Part1 => new Merkelov.Task2.Quest1();
    public static IQuest Task2Part2 => new Merkelov.Task2.Quest2();
    public static IQuest Task3 => new Merkelov.Task3.Quest();
    public static IQuest Task5 => new Merkelov.Task5.Quest();
    public static IQuest Task8 => new Merkelov.Task8.Quest();
}