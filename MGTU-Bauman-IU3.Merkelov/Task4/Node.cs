namespace InstituteHomework.Merkelov.Task4;

public class Node<T> where T : notnull
{
    public T? Data { get; set; }
    public int Hash => Data?.GetHashCode() ?? -1;
    public Node<T>? Right { get; set; }
    public Node<T>? Left { get; set; }
    
    public Node(T data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}