public class MyLinkedLists
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


    public void AddFirst(int item)
    {
        var node = new Node(item);

        if (IsEmpty())
            _first = _last = node;
        else
        {
            node.Next = _first;
            _first = node;
        }

        _count++;
    }

    public void AddLast(int item)
    {
        var node = new Node(item);

        if (IsEmpty())
            _first = _last = node;
        else
        {
            _last.Next = node;
            _last = node;
        }

        _count++;
    }

    public void DeleteFirst()
    {
        if (IsEmpty())
            throw new IndexOutOfRangeException("No item to delete");

        //if only one node exists
        if (_first == _last)
            _first = _last = null;
        else
        {
            var secondNode = _first.Next;
            _first.Next = null;
            _first = secondNode;
        }

        _count--;

    }

    public void DeleteLast()
    {
        if (IsEmpty())
            throw new IndexOutOfRangeException("No item to delete");

        //if only one node exists
        if (_first == _last)
            _first = _last = null;
        else
        {
            var previous = GetPrevious(_last);
            _last = previous;
            _last.Next = null;
        }

        _count--;
    }

    public bool Contains(int item)
    {
        var current = _first;

        while (current != null){
            if (current.Val == item)
                return true;
            current = current.Next;
        }
        return false;
    }

    public int IndexOf(int item)
    {
        var index = 0;
        var current = _first;

        while (current != null){
            if (current.Val == item)
                return index;
            current = current.Next;
            index++;
        }

        return -1;
    }

    private bool IsEmpty()
    {
        return _first == null;
    }

    private Node GetPrevious(Node node)
    {

        var current = _first;
        while (current != null)
        {
            if (current.Next == node)
                return current;
            current = current.Next;
        }

        return null;
    }
}