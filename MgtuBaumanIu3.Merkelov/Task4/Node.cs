namespace MgtuBaumanIu3.Merkelov.Task4;

public class Node<T>(T data) where T : notnull
{
    public T? Data { get; set; } = data;
    public int Hash => Data?.GetHashCode() ?? -1;
    public Node<T>? Right { get; set; } = null;
    public Node<T>? Left { get; set; } = null;

    public void Print(string indent, bool last)
    {
        Console.Write(indent);
        Console.Write(last ? "└─" : "├─");
        indent += last ? "  " : "| ";
        Console.WriteLine(Data);

        List<Node<T>> children = [];
        if (Left is not null) { children.Add(Left); }
        if (Right is not null) { children.Add(Right); }

        for (int i = 0; i < children.Count; i++)
        {
            children[i].Print(indent, i == children.Count - 1);
        }
    }
}