using MgtuBaumanIu3.Core;

namespace MgtuBaumanIu3.Merkelov.Task4;

public class Quest : BaseQuest
{
    public override void Start()
    {
        Tree<int> tree = new(27);
        tree.Insert(34);
        tree.Insert(17);
        tree.Insert(20);
        tree.Insert(10);
        tree.Insert(5);
        tree.Insert(15);
        tree.Insert(11);
        tree.Insert(14);
        tree.Insert(12);
        tree.Insert(16);
        tree.Insert(40);
        tree.Insert(33);
        tree.Insert(37);
        tree.Traversal();
        tree.Remove(33);
        tree.Remove(15);
        tree.Remove(14);
        tree.Traversal();
    }
}