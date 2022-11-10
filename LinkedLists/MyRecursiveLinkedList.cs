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

    /* this method requires Node class & _first to be public */
    // public bool ContainsAlt(int target, Node node = null)
    // {
    //     if (node == null)
    //         return false;

    //     if (node.Val == target)
    //         return true;

    //     return ContainsAlt(target, node.Next);
    // }

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

    #region Reverse list

    /* 
        Implement functions to reverse a linked list iteratively & recursively

        Write a function ReverseList() that accepts the head of a linked list as an argument.

        The function should reverse the order of the nodes of the linked list in-place.

        The function should return the new head of the linked list
         */

/* this method requires Node class & _first to be public */
    // public Node ReverseListIterative(Node head)
    // {
    //     if (head == null)
    //         return null;

    //     // {10->20->30}
    //     Node previous = head;
    //     Node current = head.Next;

    //     while (current != null)
    //     {
    //         var next = current.Next;
    //         current.Next = previous;

    //         previous = current;
    //         current = next;
    //     }
    //     // {10-><-20->30}
    //     head.Next = null;
    //     // {10<-20->30}
    //     return previous;
    // }

/* this method requires Node class & _first to be public */
    // public Node ReverseListRecursive(Node head)
    // {
    //     if (head == null)
    //         return null;

    //     var current = head.Next;
    //     head.Next = null;

    //     return _ReverseListRecursive(current, head);
    // }

    private Node _ReverseListRecursive(Node current, Node previous)
    {

        if (current == null)
            return previous;

        var next = current.Next;
        current.Next = previous;

        return _ReverseListRecursive(next, current);
    }

    // public Node RecursiveListRecursiveAlt(Node current, Node previous = null)
    // {
    //     if (current == null)
    //         return previous;

    //     var next = current.Next;
    //     current.Next = previous;

    //     return RecursiveListRecursiveAlt(next, current);
    // }

    #endregion

    public void Display(MyRecursiveLinkedList list)
    {
        _Display(list._first);
    }

/* this method requires Node class & _first to be public */
    // public void Display(Node head)
    // {
    //     _Display(head);
    // }


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