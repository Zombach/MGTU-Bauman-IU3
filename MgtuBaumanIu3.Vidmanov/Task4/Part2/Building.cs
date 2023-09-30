namespace MgtuBaumanIu3.Vidmanov.Task4.Part2;

/// <summary>
/// Разработать класс, инкапсулирующий информацию о зданиях, в том числе о домах,
/// складских помещениях, учреждениях. В этом классе (Building) будут храниться три
/// элемента информации о зданиях: количество этажей, общая площадь и количество
/// жильцов. Описание нового типа данных Building разместить в отдельном файле
/// Building.cs, который должен быть включен в проект. Основной код программы должен
/// использовать описанный в Building.cs класс:
/// создать 2 экземпляра (House, Office) нового класса
/// инициализовать значения полей обоих экземпляров
/// продемонстрировать состояние созданных объектов путем вывода содержимого их
/// полей создать признак, помогающий отличать объекты класса определенного вида
/// (например, отличительный признак офисного и жилого здания)
/// </summary>
public class Building(int floors, double area, int residents, TypeEnum type)
{
    public int Floors => floors;
    public double Area => area;
    public int Residents => residents;
    public TypeEnum Type => type;

    public void ViewInfo()
    {
        Console.WriteLine($"Тип здания: {type}");
        Console.WriteLine($"Количество этажей: {floors}");
        Console.WriteLine($"Общая площадь: {area} кв. м");
        Console.WriteLine($"Количество жильцов: {residents}");
    }
}