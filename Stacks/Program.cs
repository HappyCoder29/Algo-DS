using System;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            int count = stack.Count();
            Console.WriteLine("Hello World!");
        }
    }
}
