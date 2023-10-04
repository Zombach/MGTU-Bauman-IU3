using System.Drawing;

namespace MgtuBaumanIu3.Merkelov.Task6;

public class Tree(int data)
{
    private Node _head = new(data);

    public void Insert(int value)
    {
        Node newNode = new(value);

        Node? current = _head;
        Node? parent = null;
        while (current is not null)
        {
            parent = current;
            current = value < current.Value ? current.Left : current.Right;
        }

        newNode.Parent = parent;
        if (value < parent.Value) { parent.Left = newNode; }
        else { parent.Right = newNode; }

        FixTreeInsert(newNode);
    }

    public void Print()
    {
        Console.WriteLine();
        _head?.Print(string.Empty, true);
    }

    private void FixTreeInsert(Node node)
    {
        while (node.Parent != null && node != _head && node.Parent.NodeColor == Color.Red)
        {
            if (node.Parent == node.Parent.Parent?.Left)
            {
                Node? uncle = node.Parent.Parent.Right;

                if (uncle is not null && uncle.NodeColor == Color.Red)
                {
                    node.Parent.NodeColor = Color.Black;
                    uncle.NodeColor = Color.Black;
                    node.Parent.Parent.NodeColor = Color.Red;
                    node = node.Parent.Parent;
                }
                else
                {
                    if (node == node.Parent.Right)
                    {
                        node = node.Parent;
                        RotateLeft(node);
                    }

                    node.Parent.NodeColor = Color.Black;
                    if (node.Parent.Parent != null)
                    {
                        node.Parent.Parent.NodeColor = Color.Red;
                        RotateRight(node.Parent.Parent);
                    }
                }
            }
            else
            {
                Node? uncle = node.Parent.Parent?.Left;

                if (uncle != null && uncle.NodeColor == Color.Red)
                {
                    node.Parent.NodeColor = Color.Black;
                    uncle.NodeColor = Color.Black;
                    if (node.Parent.Parent is not null)
                    {
                        node.Parent.Parent.NodeColor = Color.Red;
                        node = node.Parent.Parent;
                    }
                }
                else
                {
                    if (node == node.Parent.Left)
                    {
                        node = node.Parent;
                        RotateRight(node);
                    }

                    if (node.Parent != null)
                    {
                        node.Parent.NodeColor = Color.Black;
                        if (node.Parent.Parent is not null)
                        {
                            node.Parent.Parent.NodeColor = Color.Red;
                            RotateLeft(node.Parent.Parent);
                        }
                    }
                }
            }
        }

        _head.NodeColor = Color.Black;
    }

    private void RotateLeft(Node node)
    {
        Node? rightChild = node.Right;
        node.Right = rightChild?.Left;

        if (rightChild?.Left is not null) { rightChild.Left.Parent = node; }

        if (rightChild is not null)
        {
            rightChild.Parent = node.Parent;
            if (node.Parent is null) { _head = rightChild; }
            else if (node == node.Parent.Left) { node.Parent.Left = rightChild; }
            else { node.Parent.Right = rightChild; }

            rightChild.Left = node;
            node.Parent = rightChild;
        }
    }

    private void RotateRight(Node node)
    {
        Node? leftChild = node.Left;
        node.Left = leftChild?.Right;

        if (leftChild?.Right is not null)
            leftChild.Right.Parent = node;

        if (leftChild is not null)
        {
            leftChild.Parent = node.Parent;
            if (node.Parent == null) { _head = leftChild; }
            else if (node == node.Parent.Left) { node.Parent.Left = leftChild; }
            else { node.Parent.Right = leftChild; }
        }
    }
}