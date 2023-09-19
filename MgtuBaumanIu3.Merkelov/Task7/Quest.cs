using MgtuBaumanIu3.Core;

namespace MgtuBaumanIu3.Merkelov.Task7;

/// <summary>
/// Построить граф по таблице смежности.
/// Вычислить кратчайшее расстояние от узла B до всех вершин,
/// используя алгоритм Дейкстры.
/// </summary>
public class Quest : BaseQuest
{
    public override void Start()
    {
        throw new NotImplementedException("Не реализовано!");
        Dictionary<char, Dictionary<char, int>> adjacencyList = new()
        {
            {'A', new Dictionary<char, int> { {'B', 7 } } },
            {'B', new Dictionary<char, int> { {'A', 7 } } },
            {'C', new Dictionary<char, int> { {'B', 4 }, {'D', 1 } } },
            {'D', new Dictionary<char, int> { {'B', 2 }, {'C', 1 } } },
            {'E', new Dictionary<char, int> { {'B', 4 }, {'F', 2 }, {'G', 2 } } },
            {'F', new Dictionary<char, int> { {'E', 2 }, {'G', 2 }, {'A', 12 } } },
            {'G', new Dictionary<char, int> { {'E', 2 }, {'F', 2 }, {'H', 3 } } },
            {'H', new Dictionary<char, int> { {'G', 3 }, {'I', 2 }, {'J', 1 } } },
            {'I', new Dictionary<char, int> { {'H', 2 }, {'J', 1 } } },
            {'J', new Dictionary<char, int> { {'H', 1 }, {'J', 1 } } }
        }; 
        char startNode = 'B';
        Dictionary<char, int?> distances = Dijkstra(adjacencyList, startNode);

        foreach (var node in distances)
        {
            Console.WriteLine($"Shortest distance from {startNode} to {node.Key}: {node.Value}");
        }
    }
    public Dictionary<char, int?> Dijkstra(Dictionary<char, Dictionary<char, int>> graph, char startNode)
    {
        Dictionary<char, int?> distances = new()
        {
            [startNode] = 0
        };

        HashSet<char> visited = new();

        while (visited.Count < graph.Count)
        {
            char? currentNode = GetMinDistanceNode(distances, visited);
            if(currentNode is null) { continue; }

            visited.Add((char)currentNode);

            foreach (var neighbor in graph[(char)currentNode])
            {
                if(distances[(char)currentNode] is null) { continue; }
                int distance = (int)distances[(char)currentNode] + neighbor.Value;
                if (distance < distances[neighbor.Key])
                {
                    distances[neighbor.Key] = distance;
                }
            }
        }

        return distances;
    }

    public char? GetMinDistanceNode(Dictionary<char, int?> distances, HashSet<char> visited)
    {
        char? minNode = null;

        foreach (var node in distances.Keys)
        {
            if (!visited.Contains(node) && distances[node] is not null)
            {
                int? minDistance = distances[node];
                minNode = node;
            }
        }

        return minNode;
    }
}