using InstituteHomework.Core;

namespace InstituteHomework.Facade;

public class MerkelovFacade
{
    public IQuest Task1Part1 => new Merkelov.Task1.Quest1();
    public IQuest Task1Part2 => new Merkelov.Task1.Quest2();
    public IQuest Task2Part1 => new Merkelov.Task2.Quest1();
    public IQuest Task2Part2 => new Merkelov.Task2.Quest2();
    public IQuest Task3 => new Merkelov.Task3.Quest();
    public IQuest Task4 => new Merkelov.Task4.Quest();
    public IQuest Task5 => new Merkelov.Task5.Quest();
    public IQuest Task8 => new Merkelov.Task8.Quest();
}