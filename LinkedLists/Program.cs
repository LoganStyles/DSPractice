// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Linkedlists!");

var lists = new MyLinkedLists();
lists.AddLast(10);
lists.AddLast(20);
lists.AddLast(30);
lists.AddLast(40);
lists.AddLast(50);
lists.AddLast(80);

// lists.Display(lists);

// lists.Reverse();
// lists.Display(lists);

//kth node from the end
// Console.WriteLine(lists.GetKthNodeFromTheEnd(3));

//print the middle node(s)
lists.PrintMiddle();
