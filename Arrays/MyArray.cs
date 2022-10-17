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


    public void DisplayArray()
    {
        Console.WriteLine("Printing array items...");

        //for loop is more efficient here since array may not b filled completely
        for (int i = 0; i < _count; i++)
            Console.WriteLine(_items[i]);
    }
}