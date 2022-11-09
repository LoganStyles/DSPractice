// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Linkedlists!");

var lists = new MyLinkedLists();
lists.AddLast(10);
lists.AddLast(20);
lists.AddLast(30);
lists.AddLast(40);
lists.AddLast(50);
lists.AddLast(80);

lists.Display(lists);

// lists.Reverse();
// lists.Display(lists);

//kth node from the end
// Console.WriteLine(lists.GetKthNodeFromTheEnd(3));

//print the middle node(s)
// lists.PrintMiddle();

// delete the middle of the list
// lists.DeleteMiddle();
// lists.Display(lists);

// delete a value -- to make this work make Node class to public & _first public
// Console.WriteLine("---");
// var result = lists.DeleteValueRecursive(lists._first,10);
// lists.Display(result);

// --RECURSIVE
// var recursivelists = new MyRecursiveLinkedList();
// recursivelists.AddLast(10);
// recursivelists.AddLast(20);
// recursivelists.AddLast(30);
// recursivelists.AddLast(40);
// recursivelists.AddLast(50);
// recursivelists.AddLast(80);

// recursivelists.Display(recursivelists);

// Console.WriteLine(recursivelists.Contains(410));

// Console.WriteLine($"Sum is {recursivelists.Sum()}");
