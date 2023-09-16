namespace InstituteHomework.Merkelov.Task4;

public class Tree<T> where T : notnull
{
    public Node<T>? Head { get; set; }

    public Tree(T data) => Head = new Node<T>(data);

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
        if(node is null) { return null; }
        int hash = key.GetHashCode();
        if (hash < node.Hash)
        {
            node.Left = Remove(node.Left, key);
        }
        else if(hash > node.Hash)
        {
            node.Right = Remove(node.Right, key);
        }
        else
        {
            if (node.Left is null) { return node.Right; }
            else if (node.Right is null) { return node.Left; }
            node.Data = MinValue(node.Right);

            // Удаляем узел с минимальным значением из правого поддерева
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

    public void Traversal()
    {
        if (Head is not null)
        {
            Console.WriteLine();
            Traversal(Head);
            return;
        }
        Console.WriteLine("Пустое дерево");
    }

    public void Traversal(Node<T>? node)
    {
        if (node is null) { return; }
        Traversal(node.Left);
        Console.Write($"{node.Data} ");
        Traversal(node.Right);
    }
}