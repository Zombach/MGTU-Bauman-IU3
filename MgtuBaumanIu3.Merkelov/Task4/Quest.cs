using MgtuBaumanIu3.Core;

namespace MgtuBaumanIu3.Merkelov.Task4;

/// <summary>
/// Задание:  
/// 1. Для наборов чисел из строки «Добавить:» в варианте построить бинарное дерево.
/// Поочередно добавляя элементы в дерево в том порядке, в котором они даны.
/// При необходимости выполнять балансировку дерева.
/// 2. Удалить из дерева указанные в строке «Удалить» варианта элементы в том порядке,
/// в котором они даны. При необходимости выполнить балансировку дерева.
/// Пункт 2 выполняется после завершения пункта 1.
/// При добавлении необходимо выполнять балансировку после добавления каждого узла.
/// Сначала добавляем узел, затем балансируем. Аналогично для удаления.
/// Удаляем узел, а затем балансируем.
/// </summary>
public class Quest : BaseQuest
{
    public override void Start()
    {
        Io io = Io.Instance;
        int size = io.GetDigital<int>("Введите число вставляемых элементов:");
        
        if (size is <= 0)
        { throw new ArgumentException("Элементов должно быть больше 0"); }
        Tree<int> tree = new(io.GetDigital<int>("Введите число 1:"));
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
            tree.Remove(digital);
        }
        tree.Print();
    }
}