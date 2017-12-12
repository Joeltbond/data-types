using System;
using ConsoleApp1.DataStructures;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList();
            list.AddFirst(10);
            list.AddFirst(30);
            list.AddFirst(70);
            list.AddLast(99);
            list.PrintAllNodes();
            Console.ReadKey();
        }
    }
}
