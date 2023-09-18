namespace MgtuBaumanIu3.Vidmanov.Task3.Part2;

public struct ConveyerControl
{
    public void Conveyer(Action action)
    {
        string command = action switch
        {
            Action.Start => "Запуск",
            Action.Stop => "Остановка",
            Action.Forward => "Перемещение вперед",
            Action.Backward => "Перемещение назад",
            _ => "Неизвестная команда"
        };
        Console.WriteLine(command);
    }

    public enum Action
    {
        Unknown = default,
        Start = 1,
        Stop = 2,
        Forward = 3,
        Backward = 4
    }
}