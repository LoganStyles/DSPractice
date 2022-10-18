﻿// See https://aka.ms/new-console-template for more information
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
// numbers.RemoveAt(2);
// numbers.RemoveAt(4);
// numbers.RemoveAt(10);//will throw an exception
// numbers.DisplayArray();
#endregion

#region Search
// int searchItem = 70;
// Console.WriteLine($"Index of {searchItem} is {numbers.IndexOf(searchItem)}");
#endregion

#region Find the maximum item in the array

// Console.WriteLine(String.Format("The largest item is {0}", numbers.Max()));
#endregion

#region Find the common items in two arrays

int[] array1 = { 10, 11, 11, 22, 30, 40 };
int[] array2 = { 10, 16, 11, 12, 30, 50, 56 };

var result = numbers.Intersect(array1, array2);
Console.Write("The common items are - ");
for (int i = 0; i < result.Length; i++)
{
    Console.Write($"{result[i]} ");
}
#endregion

#endregion