namespace MgtuBaumanIu3.Merkelov.Task6;

public class Node
{
    public ColorEnum Color { get; set; }
    public Node? Parent { get; set; }
    public Node? Left { get; set; }
    public Node? Right { get; set; }
    public int? Value { get; set; }
    
    public Node(int? value = null, Node? parent = null, Node? left = null, Node? right = null, ColorEnum color = ColorEnum.Red)
    {
        Color = color;
        Parent = parent;
        Left = left;
        Right = right;
        Value = value;
    }
}