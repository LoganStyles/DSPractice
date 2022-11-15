// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// --REVERSE A STRING--
// string str = "abcd";
// var reverser = new StringReverser();
// Console.WriteLine(reverser.Reverse(str));
// Console.WriteLine(reverser.Reverse(""));
// Console.WriteLine(reverser.Reverse(null));

// --REVERSE A STRING WITH A STACK--
// Console.WriteLine(reverser.ReverseWithStack(str));
// Console.WriteLine(reverser.ReverseWithStack(""));
// Console.WriteLine(reverser.ReverseWithStack(null));

// -- DETERMINE BALANCED EXPRESSION
// Expressions exp = new();
// Console.WriteLine("{0} is {1} balanced", "{a + b})()", exp.IsBalanced("{a + b})()") ? "" : "NOT");
// Console.WriteLine("{0} is {1} balanced", "({a + b})()", exp.IsBalanced("({a + b})()") ? "" : "NOT");
// Console.WriteLine("{0} is {1} balanced", "]({a + b})()", exp.IsBalanced("]({a + b})()") ? "" : "NOT");
// Console.WriteLine("{0} is {1} balanced", null, exp.IsBalanced(null) ? "" : "NOT");
// Console.WriteLine("{0} is {1} balanced", "", exp.IsBalanced("") ? "" : "NOT");
// Console.WriteLine("{0} is {1} balanced", "(1+2", exp.IsBalanced("(1+2") ? "" : "NOT");
// Console.WriteLine("{0} is {1} balanced", "{{[[]", exp.IsBalanced("{{[[]") ? "" : "NOT");
// Console.WriteLine("{0} is {1} balanced", ")1+2(", exp.IsBalanced(")1+2(") ? "" : "NOT");

// -- MYSTACK 
MyStack stack = new(5);
stack.Push(10);
stack.Push(20);
stack.Push(30);
stack.Push(40);
stack.Push(50);
stack.Push(60);

MyStack.Display(stack);

// peek
Console.WriteLine($"Item at the top of the stack is {stack.Peek()}");

// pop
Console.WriteLine($"Popped item is {stack.Pop()}");
MyStack.Display(stack);

// is empty
Console.WriteLine("Stack is {0} empty.",stack.IsEmpty() ? "": "NOT");