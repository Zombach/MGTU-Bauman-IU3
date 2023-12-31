﻿using MgtuBaumanIu3.Core;

namespace MgtuBaumanIu3.Facade;

public class MerkelovFacade
{
    public IQuest Task1Part1 => new Merkelov.Task1.Quest1();
    public IQuest Task1Part2 => new Merkelov.Task1.Quest2();
    public IQuest Task2Part1 => new Merkelov.Task2.Quest1();
    public IQuest Task2Part2 => new Merkelov.Task2.Quest2();
    public IQuest Task3 => new Merkelov.Task3.Quest();
    public IQuest Task4 => new Merkelov.Task4.Quest();
    public IQuest Task5 => new Merkelov.Task5.Quest();
    public IQuest Task6 => new Merkelov.Task6.Quest();
    public IQuest Task7 => new Merkelov.Task7.Quest();
    public IQuest Task8 => new Merkelov.Task8.Quest();
}