public class MyArray
{

    private int[] _items;
    private int _count;

    public MyArray(int size)
    {
        _items = new int[size];
    }

    public int GetSize()
    {
        return _count;
    }

    public void Insert(int item)
    {

        if (_items.Length == _count)
        {
            //the array is full hence we double its size
            int[] newItems = new int[_count * 2];

            for (int i = 0; i < _count; i++)
            {
                newItems[i] = _items[i];
            }

            _items = newItems;
        }

        _items[_count++] = item;
    }
    /// removes an item at a certain index.
    ///
    /// This operation shrinks the array - hence we only process n-1 items to avoid IndexOutOfRangeException.
    ///@param index the index to be removed
    public void RemoveAt(int index)
    {
        if (index < 0 || index >= _count)
            throw new IndexOutOfRangeException("Invalid index supplied");

        if (index == _count - 1)
        {
            --_count;
            return;
        }

        for (int i = index; i < _count-1; i++)
        {
            _items[i] = _items[i + 1];
        }

        _count--;
    }


    public void DisplayArray()
    {
        Console.WriteLine("Printing array items...");

        //for loop is more efficient here since array may not b filled completely
        for (int i = 0; i < _count; i++)
            Console.WriteLine(_items[i]);
    }
}