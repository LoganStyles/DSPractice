using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice.LinkedLists
{
    internal class RecursiveLinkedList
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
        //Space: O(n)
        public void Append(int input)
        {
            if (Head == null)
            {
                Head = new Node(input);
                return;
            }

            _Append(input, Head);
        }

        private void _Append(int input, Node current)
        {
            if (current.Next == null)
            {

                current.Next = new Node(input);
                return;
            }

            _Append(input, current.Next);
        }

        //Time: O(n)
        //Space: O(n)
        public bool Contains(int target)
        {
            return _Contains(Head, target);
        }

        private bool _Contains(Node current, int target)
        {
            if (current == null)
                return false;

            if (current.Val == target)
                return true;

            return _Contains(current.Next, target);
        }

        //Time: O(n)
        //Space: O(n)
        public int Sum()
        {
            //return _Sum(Head, 0);
            return _Sum2(Head);//alternative
        }

        private int _Sum(Node current, int sum)
        {
            if (current == null)
                return sum;

            return _Sum(current.Next, sum += current.Val);
        }

        private int _Sum2(Node current)
        {
            if (current == null)
                return 0;

            return current.Val + _Sum2(current.Next);
        }

        //Time: O(n)
        //Space: O(n)
        public void Print()
        {
            _Print(Head, 1);
        }

        private void _Print(Node current, int index)
        {
            if (current == null)
            {
                Console.WriteLine();
                return;
            }

            Console.WriteLine($"Node value {index}: {current.Val}");
            _Print(current.Next, index + 1);
        }
    }
}
