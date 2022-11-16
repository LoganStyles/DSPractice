/* build a stack using an integer array. The stack should implement the following:

- Push 
- Pop
- Peek
- IsEmpty  */
public class MyStack
{

    private int[] _items;
    private int _count;

    public MyStack(int size)
    {
        _items = new int[size];
        _count = 0;
    }

    /// <summary>
    /// inserts an integer at the end of the stack
    /// </summary>
    /// <param name="item">Represents the item to insert </param>
    public void Push(int item)
    {
        /* add item into the array
        increase the count
        check if array is full then increase capacity */
        if (_items.Length == _count)
        {
            int[] newItems = new int[_count * 2];
            for (var i = 0; i < _items.Length; i++)
            {
                newItems[i] = _items[i];
            }
            _items = newItems;
        }
        _items[_count++] = item;
    }

    /// <summary>
    /// fetches the item at the top of the stack
    /// </summary>
    /// <returns>The the item at the top of the stack</returns>
    public int Peek()
    {
        /* fetch the item at the last valid index
         */
        if (_count == 0)
            throw new InvalidOperationException("Stack is empty");
        return _items[_count - 1];
    }

    /// <summary>
    /// fetches & removes the item at the top of the stack
    /// </summary>
    /// <returns>The item at the top of the stack</returns>
    public int Pop()
    {
        /* fetch the item at the last valid index
        then remove it from the array */
        if (_count == 0)
            throw new InvalidOperationException("Stack is empty");

        var itemAtTop = _items[_count - 1];
        _items[--_count] = 0;
        return itemAtTop;
    }

    /// <summary>
    /// determines if the stack is empty
    /// </summary>
    public bool IsEmpty()
    {
        return _count == 0;
    }

    public static void Display(MyStack stack)
    {
        if (stack._count == 0)
            return;
        foreach (var item in stack._items)
            Console.WriteLine(item);
    }

}