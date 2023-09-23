using MgtuBaumanIu3.Core;

namespace MgtuBaumanIu3.Vidmanov.Task4.Part3;

/// <summary>
/// Творческое задание: Вы участвуете в разработке компьютерной игры. В качестве объектов
/// игрового мира выступают средства транспорта различных типов:
/// гужевая повозка
/// автомобиль
/// самолёт
/// катер
/// Требуется реализовать эти классы, затем протестировать их с помощью описанных
/// процедур перемещения, изменения состояния.
/// Все ТС могут совершать перемещения. Однако каждое перемещение приводит к
/// ухудшению качества ТС. У каждого типа ТС происходят в процессе перемещения свои
/// изменения. Изменения сказываются на дальнейшей работоспособности. Подробные
/// характеристики каждого типа ТС могут включать:
/// остаток топлива в топливном баке
/// запас хода категорию прав для управления износ и другие.
/// Сами перемещения можно выполнять непосредственно. Результат работы с объектами
/// классов вывести в виде таблицы.
/// </summary>
public class Quest : IQuest
{
    public void Start()
    {
        Transport horseCarriage = new HorseCarriage(100, 2000, 10);
        horseCarriage.DisplayInfo();
        horseCarriage.Move(10);
        horseCarriage.Move(12);
        horseCarriage.Move(12);
        horseCarriage.Move(22);
        horseCarriage.DisplayInfo();
        Transport car = new Car(40, 200, 20);
        car.DisplayInfo();
        car.Move(10);
        car.Move(12);
        car.Move(12);
        car.Move(22);
        car.DisplayInfo();
        Transport boat = new Boat(20, 500, 30);
        boat.DisplayInfo();
        boat.Move(10);
        boat.Move(10);
        boat.Move(12);
        boat.Move(22);
        boat.DisplayInfo();
        Transport airplane = new Airplane(90, 1000, 80);
        airplane.DisplayInfo();
        airplane.Move(10);
        airplane.Move(12);
        airplane.Move(22);
        airplane.DisplayInfo();
    }
}