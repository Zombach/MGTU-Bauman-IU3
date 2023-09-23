namespace MgtuBaumanIu3.Merkelov.Task6;

public class Tree
{
    private Node _head;
    private Node _null;

    public Tree()
    {
        _null = new Node()
        {
            Color = ColorEnum.Black,
            Left = null,
            Right = null
        };
        _head = _null;
    }

    public void Insert(int value)
    {
        Node node = new(value);
        Node? y = null;
        Node x = _head;

        while (x is not null)
        {
            y = x;
            if (value < x.Value)
            {
                x = x.Left;
            }
            else
            {
                x = x.Right;
            }
        }

        node.Parent = y;
        if (y == null)
        {
            _head = node;
        }
        else if (value < y.Value)
        {
            y.Left = node;
        }
        else
        {
            y.Right = node;
        }

        if (node.Parent == null)
        {
            node.Color = ColorEnum.Black;
            return;
        }

        if (node.Parent.Parent == null)
        {
            return;
        }

        FixInsert(node);
    }

    private void FixInsert(Node k)
    {
        Node u;
        while (k.Parent.Color == ColorEnum.Red)
        {
            if (k.Parent == k.Parent.Parent.Right)
            {
                u = k.Parent.Parent.Left; // uncle
                if (u.Color == ColorEnum.Red)
                {
                    u.Color = ColorEnum.Black;
                    k.Parent.Color = ColorEnum.Black;
                    k.Parent.Parent.Color = ColorEnum.Red;
                    k = k.Parent.Parent;
                }
                else
                {
                    if (k == k.Parent.Left)
                    {
                        k = k.Parent;
                        RotateRight(k);
                    }
                    k.Parent.Color = ColorEnum.Black;
                    k.Parent.Parent.Color = ColorEnum.Red;
                    RotateLeft(k.Parent.Parent);
                }
            }
            else
            {
                u = k.Parent.Parent.Right; // uncle

                if (u.Color == ColorEnum.Red)
                {
                    u.Color = ColorEnum.Black;
                    k.Parent.Color = ColorEnum.Black;
                    k.Parent.Parent.Color = ColorEnum.Red;
                    k = k.Parent.Parent;
                }
                else
                {
                    if (k == k.Parent.Right)
                    {
                        k = k.Parent;
                        RotateLeft(k);
                    }
                    k.Parent.Color = ColorEnum.Black;
                    k.Parent.Parent.Color = ColorEnum.Red;
                    RotateRight(k.Parent.Parent);
                }
            }
            if (k == _head)
            {
                break;
            }
        }
        _head.Color = ColorEnum.Black;
    }

    // Вспомогательный метод для поворота влево
    private void RotateLeft(Node x)
    {
        Node y = x.Right;
        x.Right = y.Left;
        if (y.Left != _null)
        {
            y.Left.Parent = x;
        }
        y.Parent = x.Parent;
        if (x.Parent == null)
        {
            _head = y;
        }
        else if (x == x.Parent.Left)
        {
            x.Parent.Left = y;
        }
        else
        {
            x.Parent.Right = y;
        }
        y.Left = x;
        x.Parent = y;
    }

    // Вспомогательный метод для поворота вправо
    private void RotateRight(Node x)
    {
        Node y = x.Left;
        x.Left = y.Right;
        if (y.Right != _null)
        {
            y.Right.Parent = x;
        }
        y.Parent = x.Parent;
        if (x.Parent == null)
        {
            _head = y;
        }
        else if (x == x.Parent.Right)
        {
            x.Parent.Right = y;
        }
        else
        {
            x.Parent.Left = y;
        }
        y.Right = x;
        x.Parent = y;
    }
}