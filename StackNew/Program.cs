using System;
using System.Collections;
using System.Collections.Generic;

namespace StackNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack meanstack = new Stack();
            meanstack.Push(1);
            meanstack.Push(2);
            meanstack.Push(3);
            meanstack.Push(4.5);
            meanstack.Push("Hello world");
            foreach (var item in meanstack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("count is = " + meanstack.Count);
            meanstack.Pop();
            foreach (var item in meanstack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("count is = " + meanstack.Count);
            meanstack.Peek();
            foreach (var item in meanstack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("count is = " + meanstack.Count);
            meanstack.Clear();
            Console.WriteLine("count is = " + meanstack.Count);
            Console.Read();
        }
    }
}
