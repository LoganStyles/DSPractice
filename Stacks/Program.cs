// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");




// Stack<char> temp = new Stack<char>();
// foreach (char item in str)
// {

//     temp.Push(item);
// }
// --REVERSE A STRING--
string str = "abcd";
var reverser = new StringReverser();
// Console.WriteLine(reverser.Reverse(str));
// Console.WriteLine(reverser.Reverse(""));
// Console.WriteLine(reverser.Reverse(null));

// --REVERSE A STRING WITH A STACK--
Console.WriteLine(reverser.ReverseWithStack(str));
// Console.WriteLine(reverser.ReverseWithStack(""));
// Console.WriteLine(reverser.ReverseWithStack(null));