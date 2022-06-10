using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.LinkedLists
{
    internal class IterativeLinkedList
    {
        private class Node
        {

            public Node(int val)
            {
                Val = val;
            }

            public int Val { get; }
            public Node Next { get; set; }
        }

        private Node Head;

        //Time: O(n)
        //Space: O(1)
        public void Append(int input)
        {
            var node = new Node(input);
            if (Head == null)
            {

                Head = node;
                return;
            }

            var current = Head;
            while (current.Next != null)
                current = current.Next;

            current.Next = node;
        }

        //Time: O(n)
        //Space: O(1)
        public bool Contains(int target)
        {
            var current = Head;

            while (current != null)
            {
                if (current.Val == target)
                    return true;

                current = current.Next;
            }

            return false;
        }
        //Time: O(n)
        //Space: O(1)
        public int Sum()
        {
            int sum = 0;
            var current = Head;

            while (current != null)
            {
                sum+=current.Val;
                current = current.Next;
            }

            return sum;
        }

        //Time: O(n)
        //Space: O(1)
        public void Print()
        {
            var index = 1;

            var current = Head;
            while (current != null)
            {
                Console.WriteLine($"Node {index++}: {current.Val}");
                current = current.Next;
            }
        }

        /*
         * write a funt deleteVal(head,val) that accepts the head node of a linkedlist
         * and a value as an argument.
         * 
         * the funt should delete the node of the linked list that contains the given value.
         * 
         * The funt should return the head of the list.
         * 
         * assume that the linked list only contains unique values.
         * 
         */
    }
}
