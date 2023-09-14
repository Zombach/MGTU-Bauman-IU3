﻿using InstituteHomework.Core;
using InstituteHomework.Enums;
using InstituteHomework.Facade;

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


if (professor is ProfessorEnum.Merkelov)
{
    int number = io.GetDigital<int>("Выберете задание:");
    MerkelovFacade facade = new();
    IQuest quest = number switch
    {
        1 => facade.Task1Part1,
        2 => facade.Task1Part2,
        3 => facade.Task2Part1,
        4 => facade.Task2Part2,
        5 => facade.Task3,
        6 => facade.Task5,
        7 => facade.Task8,
        _ => throw new Exception()
    };
    quest.Start();
}
else
{
    int number = io.GetDigital<int>("Выберете задание:");
    VidmanovFacade facade = new();
    IQuest quest = number switch
    {
        1 => facade.Task1Part1,
        2 => facade.Task1Part2,
        _ => throw new Exception()
    };
    quest.Start();
}




