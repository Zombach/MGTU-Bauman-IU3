﻿using MgtuBaumanIu3.Core;
using MgtuBaumanIu3.Enums;
using MgtuBaumanIu3.Facade;

Io io = Io.Instance;
Console.WriteLine("1 - Merkelov");
Console.WriteLine("2 - Vidmanov");
int digital = io.GetDigital<int>("Выберете профессора:");

ProfessorEnum professor = digital switch
{
    1 => ProfessorEnum.Merkelov,
    2 => ProfessorEnum.Vidmanov,
    _ => throw new Exception("")
};

Console.WriteLine(professor);

do
{
    if (professor is ProfessorEnum.Merkelov)
    {
        MerkelovFacade facade = new();
        MgtuBaumanIu3.Merkelov.Constants constants = new();
        constants.ViewTasks();
        int number = io.GetDigital<int>("Выберете задание:");
        IQuest quest = number switch
        {
            1 => facade.Task1Part1,
            2 => facade.Task1Part2,
            3 => facade.Task2Part1,
            4 => facade.Task2Part2,
            5 => facade.Task3,
            6 => facade.Task4,
            7 => facade.Task5,
            8 => facade.Task6,
            9 => facade.Task7,
            10 => facade.Task8,
            _ => throw new Exception()
        };
        quest.Start();
    }
    else
    {
        VidmanovFacade facade = new();
        MgtuBaumanIu3.Vidmanov.Constants constants = new();
        constants.ViewTasks();
        int number = io.GetDigital<int>("Выберете задание:");
        IQuest quest = number switch
        {
            1 => facade.Task1Part1,
            2 => facade.Task1Part2,
            3 => facade.Task2,
            4 => facade.Task3Part1,
            5 => facade.Task3Part2,
            6 => facade.Task4Part1,
            7 => facade.Task4Part2,
            8 => facade.Task4Part3,
            9 => facade.Task5Part1,
            10 => facade.Task5Part2,
            11 => facade.Task5Part3,
            12 => facade.Task5Part4,
            13 => facade.Task5Part5,
            14 => facade.Task5Part6,
            _ => throw new Exception()
        };
        quest.Start();
    }

    Console.WriteLine("Для завершения нажмите Escape!");
    Console.WriteLine("Для продолжения любую другую!");
    ConsoleKey key = Console.ReadKey(intercept: true).Key;
    if(key is ConsoleKey.Escape) { return; }
    
} while (true);