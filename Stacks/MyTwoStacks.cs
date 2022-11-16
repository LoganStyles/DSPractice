/// <summary>
/// Two stacks implemented in one array.
/// The solution makes use of two indexes.
/// </summary>
public class MyTwoStacks
{

    /// <summary>
    /// Storage variable for the stack
    /// </summary>
    private int[] _items;

    /// <summary>
    /// next position for the first stack
    /// </summary>
    private int _index1;

    /// <summary>
    /// next position for the second stack
    /// </summary>
    private int _index2;

    /// <summary>
    /// The stack's constructor. It takes an initial capacity & sets the default index for each stack.
    /// </summary>
    public MyTwoStacks(int size)
    {
        _items = new int[size];
        _index1 = 0;
        _index2 = -1;
    }

    /// <summary>
    /// inserts an integer at the next valid odd index (1,3,5,..) for the first stack
    /// </summary>
    /// <param name="item">Represents the item to insert </param>
    public void Push1(int item)
    {
        // determine index
        if (IsEmpty1())
            _index1 = 1;
        else
            _index1 = _index1 + 2;

        InsertAt(item, _index1);
    }

    /// <summary>
    /// inserts an integer at the next valid odd index (0,2,4,..) for the second stack
    /// </summary>
    /// <param name="item">Represents the item to insert </param>
    public void Push2(int item)
    {
        // determine index
        if (IsEmpty2())
            _index2 = 0;
        else
            _index2 = _index2 + 2;

        InsertAt(item, _index2);
    }

    /// <summary>
    /// fetches & removes the item at the top of the first stack
    /// </summary>
    /// <returns>The item at the top of the first stack</returns>
    public int Pop1()
    {
        if (IsEmpty1())
            throw new InvalidOperationException("First stack is empty");

        var itemAtTop = _items[_index1];
        _items[_index1] = 0;
        _index1 = _index1 - 2;
        return itemAtTop;
    }

    /// <summary>
    /// fetches & removes the item at the top of the second stack
    /// </summary>
    /// <returns>The item at the top of the second stack</returns>
    public int Pop2()
    {
        if (IsEmpty1())
            throw new InvalidOperationException("Second stack is empty");

        var itemAtTop = _items[_index2];
        _items[_index2] = 0;
        _index2 = _index2 - 2;
        return itemAtTop;
    }

    /// <summary>
    /// determines if the first stack is empty
    /// </summary>
    public bool IsEmpty1()
    {
        return _index1 == 0;
    }

    /// <summary>
    /// determines if the second stack is empty
    /// </summary>
    public bool IsEmpty2()
    {
        return _index2 < 0;
    }

    /// <summary>
    /// determines if the first stack is full
    /// </summary>
    public bool IsFull1()
    {
        //_index1 => 1,3,
        //_items.length => 5
        return _index1 + 2 >= _items.Length;
    }

    /// <summary>
    /// determines if the second stack is full
    /// </summary>
    public bool IsFull2()
    {
        //_index1 => 0,2,4
        //_items.length => 5
        return _index2 + 2 >= _items.Length;
    }

    /// <summary>
    /// inserts an item in a specific stack
    /// </summary>
    /// <param name="item">Represents the item to insert </param>
    /// <param name="index">Represents the stack index to insert at </param>
    private void InsertAt(int item, int index)
    {
        if (index >= _items.Length)
        {
            var newItems = new int[_items.Length * 2];
            for (var i = 0; i < _items.Length; i++)
            {
                newItems[i] = _items[i];
            }
            _items = newItems;
        }

        _items[index] = item;
    }

    /// <summary>
    /// displays all the items in both stacks
    /// </summary>
    public static void Display(MyTwoStacks stack)
    {
        if (stack._index1 == 0 && stack._index2 == 0)
            return;
        foreach (var item in stack._items)
            Console.WriteLine(item);
    }

}