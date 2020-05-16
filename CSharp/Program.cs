using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new LinkedStack<int>();
            stack.Push(2);  // Add 2 to the top of the stack.

            Console.WriteLine(stack.Top());  // Write the element at the top of the stack.
            Console.WriteLine(stack.Length);  // Write the length of the stack.
            Console.WriteLine(stack.Pop());  // Remove and write the element at the top of the stack.
            Console.WriteLine(stack.Length);  // Write the length of the stack.

            stack.Push(1);
            stack.Push(2);

            Console.WriteLine(stack.Head);
            Console.WriteLine(stack.Head.Next);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Head);
            Console.WriteLine(stack.Head.Next);

        }
    }
}
