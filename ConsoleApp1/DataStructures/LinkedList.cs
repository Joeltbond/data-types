using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DataStructures
{

    class LinkedList
    {
        private class Node
        {
            public int data;
            public Node next;
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

        public void AddFirst(int data)
        {
            var temp = new Node
            {
                data = data,
                next = head
            };
            head = temp;
        }

        public void AddLast(int data)
        {
            if (head == null)
            {
                AddFirst(data);
            }
            else
            {
                Node toAdd = new Node
                {
                    data = data
                };
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;
            }
        }
    }
}
