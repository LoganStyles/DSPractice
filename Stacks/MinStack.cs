/* Design a stack that supports push, pop, and retrieving the minimum value in constant time.
For example, we populate our stack with [5,2,10,1] (from left to right).

stack.Min() // 1
stack.Pop()
stack.Min() // 2 
*/

using System.Collections;

public class MinStack
{

    private Stack<int> _stack;
    private int _minVal;
    private const int MULTIPLIER = 2;

    public MinStack()
    {
        _stack = new();
        _minVal = -1; //assuming only positive integers are allowed in the stack
    }

    public int Min()
    {
        return _minVal;
    }

    public void Push(int item)
    {
        if (IsEmpty())
        {
            _minVal = item;
            _stack.Push(item);
            return;
        }

        if (item < _minVal)
        {
            _stack.Push(MULTIPLIER * item - _minVal);
            _minVal = item;
        }
        else
        {
            _stack.Push(item);
        }
    }

    public int Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty");

        int itemAtTop = _stack.Peek();

        // if itemAtTop < _minVal then it means _minVal stores the actual value
        if (itemAtTop < _minVal)
            return _minVal;
        else
            return itemAtTop;
    }

    public int Pop()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty");

        int itemAtTop = _stack.Pop();
        int itemToPop;

        // if itemAtTop < _minVal then it means _minVal stores the actual value
        // since we are removing this value, we also take _minVal back to its previous value
        if (itemAtTop < _minVal)
        {
            itemToPop = _minVal;
            _minVal = MULTIPLIER * _minVal - itemAtTop;
        }
        else
            itemToPop = itemAtTop;

        return itemToPop;
    }

    public static void Display(MinStack stack)
    {
        if (stack.IsEmpty())
            return;
        foreach (var item in stack._stack)
            Console.WriteLine(item);
    }

    private bool IsEmpty()
    {
        return _stack.Count == 0;
    }

}