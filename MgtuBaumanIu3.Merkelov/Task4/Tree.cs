namespace MgtuBaumanIu3.Merkelov.Task4;

public class Tree<T>(T first) where T : notnull
{
    public Node<T>? Head { get; set; } = new(first);

    public void Insert(T data) => Head = Insert(Head, data);

    private Node<T> Insert(Node<T>? node, T data)
    {
        if (node is null)
        {
            node = new Node<T>(data);
            return node;
        }

        int hash = data.GetHashCode();
        if (hash < node.Hash)
        {
            node.Left = Insert(node.Left, data);
        }
        else if (hash > node.Hash)
        {
            node.Right = Insert(node.Right, data);
        }

        return node;
    }

    public void Remove(T key) => Head = Remove(Head, key);

    public Node<T>? Remove(Node<T>? node, T key)
    {
        if (node is null) { return null; }
        int hash = key.GetHashCode();
        if (hash < node.Hash)
        {
            node.Left = Remove(node.Left, key);
        }
        else if (hash > node.Hash)
        {
            node.Right = Remove(node.Right, key);
        }
        else
        {
            if (node.Left is null) { return node.Right; }
            else if (node.Right is null) { return node.Left; }
            node.Data = MinValue(node.Right);
            node.Right = Remove(node.Right, node.Data);
        }

        return node;
    }

    private T MinValue(Node<T> node)
    {
        T value = node.Data;
        while (node.Left is not null)
        {
            value = node.Left.Data;
            node = node.Left;
        }
        return value;
    }

    public void Print()
    {
        Console.WriteLine();
        Head?.Print(string.Empty, true);
    }
}