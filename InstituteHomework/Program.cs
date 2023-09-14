using InstituteHomework.Core;
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
    IQuest quest = number switch
    {
        1 => MerkelovFacade.Task1Part1,
        2 => MerkelovFacade.Task1Part2,
        3 => MerkelovFacade.Task2Part1,
        4 => MerkelovFacade.Task2Part2,
        5 => MerkelovFacade.Task3,
        6 => MerkelovFacade.Task5,
        7 => MerkelovFacade.Task8,
        _ => throw new Exception()
    };
    quest.Start();
}
else
{
    int number = io.GetDigital<int>("Выберете задание:");
    IQuest quest = number switch
    {
        1 => VidmanovFacade.Task1Part1,
        2 => VidmanovFacade.Task1Part2,
        _ => throw new Exception()
    };
    quest.Start();
}




