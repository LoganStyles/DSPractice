// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region MyArray
/**
* Exercise to create an array class
*/
MyArray numbers = new MyArray(6);
#region Insert items
numbers.Insert(10);
numbers.Insert(20);
numbers.Insert(30);
numbers.Insert(40);
numbers.Insert(50);
numbers.Insert(60);

numbers.DisplayArray();
#endregion

#region Remove items
numbers.RemoveAt(2);
numbers.RemoveAt(4);
// numbers.RemoveAt(10);//will throw an exception
numbers.DisplayArray();
#endregion

#endregion