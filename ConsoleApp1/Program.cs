using System;
using ConsoleApp1.DataStructures;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<string>();
            list.AddFirst("Hello");
            list.AddFirst("Joel");
            list.AddFirst("Name");
            list.AddLast("Last");
            list.PrintAllNodes();
            Console.WriteLine(list.Includes("Joel"));
            Console.WriteLine(list.Includes("Frank"));
            Console.ReadKey();
        }
    }
}
