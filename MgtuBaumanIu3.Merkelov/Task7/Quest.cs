using MgtuBaumanIu3.Core;

namespace MgtuBaumanIu3.Merkelov.Task7;

/// <summary>
/// Построить граф по таблице смежности.
/// Вычислить кратчайшее расстояние от узла B до всех вершин,
/// используя алгоритм Дейкстры.
/// </summary>
public class Quest : BaseQuest
{
    private readonly int[,] _graph =
    {
        {0, 7, 0, 0, 0, 0, 0, 0, 0, 0},
        {7, 0, 4, 2, 4, 0, 0, 0, 0, 0},
        {0, 4, 0, 1, 0, 0, 0, 0, 0, 0},
        {0, 2, 1, 0, 0, 0, 0, 0, 0, 0},
        {0, 4, 0, 0, 0, 2, 2, 0, 0, 0},
        {0, 0, 0, 0, 2, 0, 2, 12, 0, 0},
        {0, 0, 0, 0, 2, 2, 0, 3, 0, 0},
        {0, 0, 0, 0, 0, 12, 3, 0, 2, 1},
        {0, 0, 0, 0, 0, 0, 0, 2, 0, 1},
        {0, 0, 0, 0, 0, 0, 0, 1, 1, 0}
    };
    public override void Start()
    {
        Dijkstra.DijkstraAlgo(_graph, 1, 10);
        Console.ReadKey();
        //throw new NotImplementedException("Не реализовано!");

    }
}