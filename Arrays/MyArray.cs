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

    /// inserts an item at a certain index.
    ///
    /// This operation expands the array when if it is full.
    /// @param item the item to be inserted
    /// @note Big O time complexity => O(n)
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

    /// inserts an item at a certain index.
    ///
    /// This operation expands the array if it is full. it also shifts items if necessary
    /// @param item the item to be inserted
    /// @param index the position of the item to be inserted
    /// @note Big O time complexity => O(n)
    public void InsertAt(int item, int index)
    {

        if (index < 0 || index > _items.Length)
            throw new IndexOutOfRangeException("Invalid index provided");

        if (_count == _items.Length)
        {

            int[] newItems = new int[_count * 2];
            for (int i = 0; i < _items.Length; i++)
            {
                newItems[i] = _items[i];
            }
            _items = newItems;
        }

        //shift items to the right if required index is occupied
        if (index < _count)
        {
            var shiftIndex = index;
            var current = _items[shiftIndex];
            while (shiftIndex < _count)
            {
                var next = _items[shiftIndex + 1];
                _items[++shiftIndex] = current;
                current = next;
            }

        }
        _items[index] = item;
        _count++;

    }

    /// removes an item at a certain index.
    ///
    /// This operation shrinks the array - hence we only process n-1 items to avoid IndexOutOfRangeException.
    /// @param index the index to be removed
    /// @note Big O time complexity => O(n)
    public void RemoveAt(int index)
    {
        if (index < 0 || index >= _count)
            throw new IndexOutOfRangeException("Invalid index supplied");

        if (index == _count - 1)
        {
            --_count;
            return;
        }

        for (int i = index; i < _count - 1; i++)
        {
            _items[i] = _items[i + 1];
        }

        _count--;
    }
    /// searches for an item
    ///
    /// @param item - the item to be searched
    /// @note Big O time complexity => O(n)
    public int IndexOf(int item)
    {
        for (int index = 0; index < _count; index++)
        {
            if (_items[index] == item)
                return index;
        }

        return -1;
    }

    /// searches for the maximum item in an array.
    ///
    /// @note Big O time complexity => O(n) or theta n
    public int Max()
    {
        if (_count == 0)
            return -1;

        int maxItem = _items[0];

        for (int i = 0; i < _count; i++)
        {
            maxItem = (_items[i] > maxItem) ? _items[i] : maxItem;
        }

        return maxItem;
    }

    /// returns the common items between two arrays.
    ///
    /// .
    /// @param array1 - the first array
    /// @param array2 - the second array
    /// @returns array with common items
    /// @note Big O time complexity => O(n^2)
    /// @note Big O space complexity => O(n)
    public static int[] Intersect(int[] array1, int[] array2)
    {

        int size = 0;

        for (int i = 0; i < array1.Length; i++)
        {
            for (int j = 0; j < array2.Length; j++)
            {
                if (array1[i] == array2[j])
                {
                    size++;
                }
            }
        }

        int[] result = new int[size];
        int countOfResult = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            for (int j = 0; j < array2.Length; j++)
            {
                if (array1[i] == array2[j])
                {
                    result[countOfResult++] = array1[i];
                }
            }
        }

        return result;

    }


    /// returns the common items between two arrays.
    ///
    /// This operation uses a list to temporarily hold the common items of both arrays.
    /// @param array1 - the first array
    /// @param array2 - the second array
    /// @returns array with common items
    /// @note Big O time complexity => O(n^2)
    /// @note Big O space complexity => O(n)
    public static int[] IntersectUsingAList(int[] array1, int[] array2)
    {

        List<int> result = new List<int>();

        for (int i = 0; i < array1.Length; i++)
        {
            for (int j = 0; j < array2.Length; j++)
            {
                if (array1[i] == array2[j])
                {
                    result.Add(array1[i]);
                }
            }
        }

        return result.ToArray();

    }

    /// returns the common items between two arrays.
    ///
    /// This operation uses a set to temporarily hold the common items of both arrays.
    /// @param array1 - the first array
    /// @param array2 - the second array
    /// @returns array with common items
    /// @note Big O time complexity => O(n^2)
    /// @note Big O space complexity => O(1)
    public static int[] IntersectUsingASet(int[] array1, int[] array2)
    {

        HashSet<int> result = new HashSet<int>();

        for (int i = 0; i < array1.Length; i++)
        {
            for (int j = 0; j < array2.Length; j++)
            {
                if (array1[i] == array2[j])
                {
                    result.Add(array1[i]);
                }
            }
        }

        return result.ToArray();

    }

    /// reverses an array.
    ///
    /// This operation uses a set to temporarily hold the common items of both arrays.
    /// @param input - the input array
    /// @returns the reverse of the input array
    /// @note Big O time complexity => O(n)
    /// @note Big O space complexity => O(n)
    public static int[] Reverse(int[] input)
    {
        int[] result = new int[input.Length];
        int startIndex = 0;
        int endIndex = input.Length - 1;

        for (int i = endIndex; i >= 0; i--)
        {
            result[startIndex++] = input[i];
        }

        return result;
    }

    public void DisplayArray()
    {
        Console.WriteLine("Printing array items...");

        //for loop is more efficient here since array may not b filled completely
        for (int i = 0; i < _count; i++)
            Console.WriteLine(_items[i]);
    }
}