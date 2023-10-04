using MgtuBaumanIu3.Core;
using MgtuBaumanIu3.Merkelov.Task4;

namespace MgtuBaumanIu3.Merkelov.Task6;

/// <summary>
/// 1. Для наборов чисел из строки «Добавить» в варианте построить красно-черное дерево.
/// Необходимо добавить элементы в дерево в том порядке, в котором они даны.
/// При необходимости выполнить балансировку дерева.
/// 2. Удалить из дерева указанные элементы из строки \"Удалить\" в варианте в том порядке,
/// в котором они даны. При необходимости выполнить балансировку дерева.
/// Пункт 2 выполняется после завершения пункта 1.
/// </summary>
public class Quest : BaseQuest
{
    public override void Start()
    { Io io = Io.Instance;
        int size = io.GetDigital<int>("Введите число вставляемых элементов:");

        if (size is <= 0)
        { throw new ArgumentException("Элементов должно быть больше 0"); }
        Tree tree = new(io.GetDigital<int>("Введите число 1:"));
        
        for (int i = 2; i <= size; i++)
        {
            int digital = io.GetDigital<int>($"Введите число {i}:");
            tree.Insert(digital);
        }
        tree.Print();

        int remove = io.GetDigital<int>("Введите число удаляемых элементов:");
        for (int i = 1; i <= remove; i++)
        {
            int digital = io.GetDigital<int>($"Введите число {i}:");
            //tree.Remove(digital);
        }
        tree.Print();
    }
}