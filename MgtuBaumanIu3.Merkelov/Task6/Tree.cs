namespace MgtuBaumanIu3.Merkelov.Task6;

public class Tree
{
    private readonly Node _sentinel;
    public Node Head { get; set; }

    public Tree()
    {
        _sentinel = new Node(color: ColorEnum.Black);
        Head = _sentinel;
    }

    public void Insert(int value)
    {
        Node newNode = new()
        {
            Value = value,
            Left = _sentinel,
            Right = _sentinel,
            Color = ColorEnum.Red
        };
        Node? parent = null;
        Node current = Head;

        while (current != _sentinel)
        {
            parent = current;
            if (value < current.Value)
                current = current.Left;
            else
                current = current.Right;
        }
    }
}