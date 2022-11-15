public class Expressions
{

    /* Given a string, write code to determine if the string is a balanced expression
    samples
    "{a + b})()"
    "({a + b})()"
    "]({a + b})()"
    "(1+2"
    "{{[[]" */

    private readonly List<char> _leftItems = new List<char> { '(', '{', '[', '<' };
    private readonly List<char> _rightItems = new List<char> { ')', '}', ']', '>' };

    public bool IsBalanced(string input)
    {
        if (String.IsNullOrWhiteSpace(input))
            return true;

        var stack = new Stack<char>();

        foreach (var item in input)
        {
            if (_leftItems.Contains(item))
                stack.Push(item);

            if (_rightItems.Contains(item))
            {
                if (stack.Count == 0)
                    return false;

                var itemAtTop = stack.Pop();

                if (!_leftItems.IndexOf(itemAtTop).Equals(_rightItems.IndexOf(item)))
                    return false;
            }
        }

        return stack.Count == 0;
    }

    public string BracketMatcher(string str)
    {
        var items = new Stack<char>();
        var status = true;
        List<char> _leftBrackets = new List<char>() { '(' };
        List<char> _rightBrackets = new List<char>() { ')' };

        foreach (char item in str.ToCharArray())
        {
            if (_leftBrackets.Contains(item))
                items.Push(item);

            if (_rightBrackets.Contains(item))
            {
                if (items.Count == 0)
                    return "0";

                var itemOnTop = items.Pop();

                if (_leftBrackets.IndexOf(itemOnTop) != _rightBrackets.IndexOf(item))
                    status = false;
            }
        }

        if (items.Count == 0 && status)
            return "1";
        return "0";
    }
}