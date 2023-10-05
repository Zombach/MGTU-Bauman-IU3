namespace MgtuBaumanIu3.Merkelov.Task7;

public class Dijkstra
{
    private int MinimumDistance(int[] distance, bool[] shortestPathTreeSet, int verticesCount)
    {
        int min = int.MaxValue;
        int minIndex = 0;

        for (int i = 0; i < verticesCount; i++)
        {
            if (shortestPathTreeSet[i] || distance[i] > min) { continue; }
            min = distance[i];
            minIndex = i;
        }

        return minIndex;
    }

    private void Print(int[] distance, int verticesCount)
    {
        Console.WriteLine("Вершина\tРасстояние от источника");

        for (int i = 0; i < verticesCount; ++i)
        {
            Console.WriteLine("{0}\t  {1}", i, distance[i]);
        }
    }

    public void DijkstraAlgo(int[,] graph, int source, int verticesCount)
    {
        int[] distance = new int[verticesCount];
        bool[] shortestPathTreeSet = new bool[verticesCount];

        for (int i = 0; i < verticesCount; i++)
        {
            distance[i] = int.MaxValue;
            shortestPathTreeSet[i] = false;
        }

        distance[source] = 0;

        for (int i = 0; i < verticesCount - 1; i++)
        {
            int u = MinimumDistance(distance, shortestPathTreeSet, verticesCount);
            shortestPathTreeSet[u] = true;

            for (int j = 0; j < verticesCount; ++j)
            {
                if
                (
                    !shortestPathTreeSet[j] &&
                    Convert.ToBoolean(graph[u, j]) &&
                    distance[u] != int.MaxValue &&
                    distance[u] + graph[u, j] < distance[j]
                )
                { distance[j] = distance[u] + graph[u, j]; }
            }
        }
        Print(distance, verticesCount);
    }
}