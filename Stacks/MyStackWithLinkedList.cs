using System.Collections.Generic;

/* build a stack using a Linked list. The stack should implement the following:

- Push 
- Pop
- Peek
- IsEmpty  */
public class MyStackWithLinkedList
{

    /// <summary>
    /// Storage variables for the stack
    /// </summary>
    private LinkedList<int> _items;
    private int _count;

    /// <summary>
    /// The stack's constructor.
    /// </summary>
    public MyStackWithLinkedList()
    {
        _items = new();
        _count = 0;
    }

    /// <summary>
    /// inserts an integer to the end of the stack
    /// </summary>
    /// <param name="item">Represents the item to insert </param>
    public void Push(int item)
    {
        LinkedListNode<int> node = new(item);
        _items.AddLast(node);
        _count++;
    }

    /// <summary>
    /// fetches the item at the top of the stack
    /// </summary>
    /// <returns>The the item at the top of the stack</returns>
    public int Peek()
    {
        if (_count == 0)
            throw new InvalidOperationException("Stack is empty");

        return _items.ElementAt(_count - 1);
    }

    /// <summary>
    /// fetches & removes the item at the top of the stack
    /// </summary>
    /// <returns>The item at the top of the stack</returns>
    public int Pop()
    {
        if (_count == 0)
            throw new InvalidOperationException("Stack is empty");

        var itemAtTop = _items.ElementAt(_count - 1);
        _items.RemoveLast();

        return itemAtTop;
    }

    /// <summary>
    /// determines if the stack is empty
    /// </summary>
    public bool IsEmpty()
    {
        return _count == 0;
    }

    public static void Display(MyStackWithLinkedList stack)
    {
        if (stack._count == 0)
            return;
        foreach (var item in stack._items)
            Console.WriteLine(item);
    }
}