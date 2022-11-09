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

        while (current != null)
        {
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

        while (current != null)
        {
            if (current.Val == item)
                return index;
            current = current.Next;
            index++;
        }

        return -1;
    }

    #region  Exercises
    public void Reverse()
    {
        if (IsEmpty())
            return;
        //10->20->30
        var previous = _first;//{10,->20}
        var current = _first.Next;//{20,->30}

        while (current != null)
        {
            var next = current.Next;//{30,->null},{null,null}
            current.Next = previous;//{20,->10}, {30, ->20}

            previous = current;//{10,->20}->{20,->10}, {20,->10}->{30, ->20}
            current = next;//{30,->null}-> {null,null}
        }

        _last = _first; //{10,->20}
        _last.Next = null;//{10,null}
        _first = previous;//{30, ->20}
    }

    public int GetKthNodeFromTheEnd(int k)
    {
        if (k <= 0)
            throw new ArgumentOutOfRangeException("K has an invalid value");

        if (IsEmpty())
            throw new InvalidOperationException("List is empty!");

        Node leadNode = _first;
        Node targetNode = _first;

        for (var i = 0; i < k - 1; i++)
        {
            leadNode = leadNode.Next;
            if (leadNode == null)
                throw new ArgumentOutOfRangeException("K has an invalid value");
        }

        while (leadNode.Next != null) //or while(leadNode != _last)
        {
            targetNode = targetNode.Next;
            leadNode = leadNode.Next;
        }

        return targetNode.Val;
    }

    public void PrintMiddle()
    {
        //[10,20,30]
        //[10,20,30,40]
        if (IsEmpty())
            throw new InvalidOperationException("List is empty!");

        Node leadNode = _first;
        Node targetNode = _first;

        while (leadNode != _last && leadNode.Next != _last)
        {
            targetNode = targetNode.Next;
            leadNode = leadNode.Next.Next;
        }

        if (leadNode.Next == _last)
            Console.WriteLine($"Middle Node is : {targetNode.Val} and {targetNode.Next.Val}");
        else
            Console.WriteLine($"Middle Node is {targetNode.Val}");
    }

    public bool HasLoop()
    {

        if (IsEmpty())
            throw new InvalidOperationException("List is empty!");

        Node leadNode = _first;
        Node targetNode = _first;

        while (leadNode != null)
        {
            targetNode = targetNode.Next;
            leadNode = leadNode.Next.Next;

            if (leadNode.Val == targetNode.Val || leadNode.Next.Equals(targetNode))
                return true;
        }

        return false;
    }

    #endregion

    public void Display(MyLinkedLists list)
    {
        var current = list._first;

        while (current != null)
        {
            Console.WriteLine(current.Val);
            current = current.Next;
        }
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