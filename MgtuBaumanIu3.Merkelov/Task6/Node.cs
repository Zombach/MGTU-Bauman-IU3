namespace MgtuBaumanIu3.Merkelov.Task6;

public class Node(int? value = null)
{
    public ColorEnum Color { get; set; } = ColorEnum.Red;
    public Node? Parent { get; set; } = null;
    public Node? Left { get; set; } = null;
    public Node? Right { get; set; } = null;
    public int? Value { get; set; } = value;
}