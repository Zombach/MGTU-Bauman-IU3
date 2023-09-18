using MgtuBaumanIu3.Core;

namespace MgtuBaumanIu3.Merkelov.Task3;

/// <summary>
/// Заполнить хэш-таблицу для следующего набора данных.
/// После добавления всего набора данных выполнить удаление из хэш-таблицы следующие данные,
/// в том порядке, в котором они представлены.
/// </summary>
public class Quest : BaseQuest
{
    /*
    20
    15
    Водоросли
    280
    Картофель
    260
    Лук-порей
    59
    Манго
    291
    Орехи грецкие
    266
    Салями
    225
    Специи
    283
    Сыр сливочный
    152
    Творог
    215
    Тофу
    142
    Хек
    248
    Чай черный
    118
    Чернила каракатицы
    95
    Шампиньоны
    101
    Финик
    104
    4
    Орехи грецкие
    Водоросли
    Специи
    Манго
    */

    public override void Start()
    {
        Io io = Io.Instance;
        int size = io.GetDigital<int>("Введите длину таблицы");
        HashTable hashTable = new(size);
        int count = io.GetDigital<int>("Укажите количество вставляемых элементов");
        for (int i = 0; i < count; i++)
        {
            hashTable.Insert(io.GetPair());
        }
        count = io.GetDigital<int>("Укажите количество удаляемых элементов");
        hashTable.View("Таблица после заполнения");
        for (int i = 0; i < count; i++)
        {
            bool isRemove = hashTable.Remove(io.GetLine("Укажите ключ"));
            Console.WriteLine($"Элемент {(isRemove ? "удален" : "не найден")}");
        }
        hashTable.View("Таблица после удаления");
    }
}