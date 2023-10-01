using MgtuBaumanIu3.Core;
using MgtuBaumanIu3.Vidmanov.Task5.Part6.Interfaces;

namespace MgtuBaumanIu3.Vidmanov.Task5.Part6;

public class Quest : BaseQuest
{
    public override void Start()
    {
        // Для учета автомобилей
        Vehicle car1 = new Car("ABC123", "Toyota", "Camry");
        decimal parkingCost = car1.CalculateCost(3);
        Console.WriteLine($"Parking cost for car1: ${parkingCost}");

        // Для анкетирования
        Survey survey = new Survey();
        survey.AddAnswer("Name", "John");
        survey.AddAnswer("Age", "30");
        survey.DisplayResults();

        // Для диспетчера задач
        Dispatcher dispatcher = new();
        dispatcher.Add("Task 1: Clean the room");
        dispatcher.Add("Task 2: Buy groceries");
        dispatcher.ExecuteTasks();

        // Для печати фотографий и фотосувениров
        IPrintable photo = new Photo("Family vacation");
        IPrintable souvenir = new Souvenir("Keychain souvenir");
        photo.Print();
        souvenir.Print();

        Console.ReadLine();
    }
}