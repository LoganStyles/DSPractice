using System.Collections;
using System.Text;

public class StringReverser
{
    /// returns a reversed string.
    ///
    /// .
    /// @returns a reversed string
    /// @note Big O time complexity => O(n) or theta time complexity => O(n)
    public string Reverse(string input)
    {
        if (input == null)
            throw new ArgumentNullException("Null argument passed!");

        StringBuilder result = new();
        for (var i = input.Length - 1; i >= 0; i--)
        {
            result.Append(input[i]);
        }

        return result.ToString();
    }

    /// returns a reversed string using a stack and StringBuilder.
    ///
    /// .
    /// @returns a reversed string
    /// @note Big O time complexity => O(n) or theta time complexity => O(n)
    public string ReverseWithStack(string input)
    {
        if (input == null)
            throw new ArgumentNullException("Null argument passed!");

        Stack stack = new();
        foreach (var item in input)
        {
            stack.Push(item);
        }

        StringBuilder result = new();
        while (stack.Count > 0)
        {
            result.Append(stack.Pop());
        }

        return result.ToString();
    }
}
