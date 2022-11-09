public class MyRecursiveLinkedList
{

    private class Node
    {
        public int Val { get; set; }
        public Node Next { get; set; }

        public Node(int val)
        {
            Val = val;
        }
    }

    private Node _first;
    private Node _last;
    private int _count;

    public void AddLast(int item)
    {
        var node = new Node(item);

        if (IsEmpty())
        {
            _first = _last = node;
        }
        else
        {
            _AddLast(_first, node);
        }

    }

    private void _AddLast(Node node, Node newNode)
    {
        if (node.Equals(_last)) // or if(node.Next.Equals(null))
        {
            node.Next = newNode;
            _count++;
            _last = newNode;
            return;
        }

        _AddLast(node.Next, newNode);
    }

    public bool Contains(int item)
    {

        if (IsEmpty())
            return false;
        else
        {
            return _Contains(_first, item);
        }
    }

    private bool _Contains(Node node, int item)
    {
        if (node == null)
            return false;

        if (node.Val == item)
            return true;

        return _Contains(node.Next, item);
    }

    public int Sum()
    {
        return _first.Val + _Sum(_first.Next);
    }

    private int _Sum(Node node)
    {
        if (node == null)
            return 0;

        return node.Val + _Sum(node.Next);
    }

    public void Display(MyRecursiveLinkedList list)
    {
        _Display(list._first);
    }

    private void _Display(Node node)
    {
        if (node == null)
            return;

        Console.WriteLine(node.Val);

        _Display(node.Next);
    }

    private bool IsEmpty()
    {
        return _first == null;
    }
}