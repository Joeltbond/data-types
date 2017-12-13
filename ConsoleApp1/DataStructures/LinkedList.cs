using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DataStructures
{

    class LinkedList<T>
    {
        private class Node
        {
            public Node next;
            public T data;
        }

        private Node head;

        public void PrintAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void AddFirst(T data)
        {
            var temp = new Node
            {
                data = data,
                next = head
            };
            head = temp;
        }

        public void AddLast(T data)
        {
            if (head == null)
            {
                AddFirst(data);
            }
            else
            {
                var toAdd = new Node
                {
                    data = data
                };
                var current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;
            }
        }

        public bool Includes(T data)
        {
            var current = head;
            while (current != null && !current.data.Equals(data))
            {
                current = current.next;
            }

            return current != null;
        }
    }
}
