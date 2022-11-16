// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region --REVERSE A STRING--
// string str = "abcd";
// var reverser = new StringReverser();
// Console.WriteLine(reverser.Reverse(str));
// Console.WriteLine(reverser.Reverse(""));
// Console.WriteLine(reverser.Reverse(null));

// --REVERSE A STRING WITH A STACK--
// Console.WriteLine(reverser.ReverseWithStack(str));
// Console.WriteLine(reverser.ReverseWithStack(""));
// Console.WriteLine(reverser.ReverseWithStack(null));
#endregion

#region -- DETERMINE BALANCED EXPRESSION
// Expressions exp = new();
// Console.WriteLine("{0} is {1} balanced", "{a + b})()", exp.IsBalanced("{a + b})()") ? "" : "NOT");
// Console.WriteLine("{0} is {1} balanced", "({a + b})()", exp.IsBalanced("({a + b})()") ? "" : "NOT");
// Console.WriteLine("{0} is {1} balanced", "]({a + b})()", exp.IsBalanced("]({a + b})()") ? "" : "NOT");
// Console.WriteLine("{0} is {1} balanced", null, exp.IsBalanced(null) ? "" : "NOT");
// Console.WriteLine("{0} is {1} balanced", "", exp.IsBalanced("") ? "" : "NOT");
// Console.WriteLine("{0} is {1} balanced", "(1+2", exp.IsBalanced("(1+2") ? "" : "NOT");
// Console.WriteLine("{0} is {1} balanced", "{{[[]", exp.IsBalanced("{{[[]") ? "" : "NOT");
// Console.WriteLine("{0} is {1} balanced", ")1+2(", exp.IsBalanced(")1+2(") ? "" : "NOT");
#endregion

#region -- STACK using an array 
// MyStack stack = new(5);
// stack.Push(10);
// stack.Push(20);
// stack.Push(30);
// stack.Push(40);
// stack.Push(50);
// stack.Push(60);

// MyStack.Display(stack);

// peek
// Console.WriteLine($"Item at the top of the stack is {stack.Peek()}");

// pop
// Console.WriteLine($"Popped item is {stack.Pop()}");
// MyStack.Display(stack);

// is empty
// Console.WriteLine("Stack is {0} empty.",stack.IsEmpty() ? "": "NOT");
#endregion

#region -- Stack using a Linked List 
// MyStackWithLinkedList stack = new();
// stack.Push(10);
// stack.Push(20);
// stack.Push(30);
// stack.Push(40);
// stack.Push(50);
// stack.Push(60);

// MyStackWithLinkedList.Display(stack);

// peek
// Console.WriteLine($"Item at the top of the stack is {stack.Peek()}");

// pop
// Console.WriteLine($"Popped item is {stack.Pop()}");
// MyStackWithLinkedList.Display(stack);

// is empty
// Console.WriteLine("Stack is {0}empty.",stack.IsEmpty() ? "": "NOT ");
#endregion

#region -- My Two Stacks

MyTwoStacks stack = new(5);
stack.Push1(10);
stack.Push1(20);
// stack.Push1(30);
stack.Push2(40);
stack.Push2(50);
stack.Push2(60);

MyTwoStacks.Display(stack);

// is first stack empty?
// Console.WriteLine("First Stack is {0}empty.",stack.IsEmpty1() ? "": "NOT ");

// is first stack full?
// Console.WriteLine("First Stack is {0}full.",stack.IsFull1() ? "": "NOT ");

// is second stack empty?
// Console.WriteLine("Second Stack is {0}empty.",stack.IsEmpty2() ? "": "NOT ");

// is second stack full?
// Console.WriteLine("Second Stack is {0}full.",stack.IsFull2() ? "": "NOT ");

// pop the first stack
Console.WriteLine($"Popped item from first stack is {stack.Pop1()}");
MyTwoStacks.Display(stack);
Console.WriteLine("---");
stack.Push1(30);
MyTwoStacks.Display(stack);

// pop the second stack
Console.WriteLine($"Popped item from second stack is {stack.Pop2()}");
MyTwoStacks.Display(stack);
Console.WriteLine("---");
stack.Push2(100);
MyTwoStacks.Display(stack);

#endregion