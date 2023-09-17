using InstituteHomework.Core;

namespace InstituteHomework.Vidmanov.Task3.Part2;

/// <summary>
/// Написать программу управления конвейерной лентой на фабрике:
///    •  Создать структуру ConveyerControl.
///    •  Один из членов структуры - перечисление action, в котором определены принимаемые
///       команды управления лентой - старт, стоп, вперед, назад.
///    •  Еще один член структуры - метод conveyer(), принимающий единственный параметр типа
///       action. Метод conveyer() при помощи инструкции switch определяет соответствующую команду
///       и выводит в консоль состояние конвейерной ленты -
///       "Запуск", "Остановка", "Перемещение вперед", "Перемещение назад".
///    •  Все члены структуры имеют спецификатор доступа - public. В методе Main() создать
///       пример (демонстрация) использования структуры ConveyerControl.
///    •  Реализовать управление конвейерной лентой при помощи стрелок на клавиатуре:
///       "Left" - "Остановка", "Right" - "Запуск", "Up" - "Перемещение вперёд", "Down" -
///       "Перемещение назад". При нажатии клавиш ← → ↑ ↓ на экран должны выводиться
///       соответствующие информационные сообщения о состоянии конвейерной ленты.
/// </summary>
public class Quest : BaseQuest
{
    public override void Start()
    {
        ConveyerControl control = new();
        Console.WriteLine("Управление конвейерной лентой:");
        Console.WriteLine("Left - Остановка, Right - Запуск, Up - Перемещение вперед, Down - Перемещение назад");

        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(intercept: true).Key;
                ConveyerControl.Action action = key switch
                {
                    ConsoleKey.LeftArrow => ConveyerControl.Action.Stop,
                    ConsoleKey.RightArrow => ConveyerControl.Action.Start,
                    ConsoleKey.UpArrow => ConveyerControl.Action.Forward,
                    ConsoleKey.DownArrow => ConveyerControl.Action.Backward,
                    _ => ConveyerControl.Action.Unknown
                };

                control.Conveyer(action);
                if (action is not ConveyerControl.Action.Unknown) { continue; }
                Console.WriteLine("Завершение программы");
                return;
            }
        }
    }
}