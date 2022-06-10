// See https://aka.ms/new-console-template for more information
using DSPractice.LinkedLists;

Console.WriteLine("Hello, Data structures!");

#region LinkedLists

#region Iterative LinkedList
//var myLinkedList = new IterativeLinkedList();
//myLinkedList.Append(1);
//myLinkedList.Append(2);
//myLinkedList.Append(3);
//myLinkedList.Append(4);

//myLinkedList.Print();

//var status = false;
//status = myLinkedList.Contains(4);
//Console.WriteLine($"List contains 4? {status}");
//status = myLinkedList.Contains(8);
//Console.WriteLine($"List contains 8? {status}");

//Console.WriteLine($"Sum: {myLinkedList.Sum()}");

#endregion

#region Recursive LinkedList
var recursiveLinkedList = new RecursiveLinkedList();
recursiveLinkedList.Append(1);
recursiveLinkedList.Append(2);
recursiveLinkedList.Append(3);
recursiveLinkedList.Append(4);

recursiveLinkedList.Print();

var status = false;
status = recursiveLinkedList.Contains(4);
Console.WriteLine($"List contains 4? {status}");
status = recursiveLinkedList.Contains(8);
Console.WriteLine($"List contains 8? {status}");

Console.WriteLine($"Sum: {recursiveLinkedList.Sum()}");

#endregion

#endregion


Console.ReadLine();
