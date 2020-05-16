using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class Node<T>
    {
        public Node(T element, Node<T> next)
        {
            Element = element;
            Next = next;
        }

        public T Element { get; set; }
        
        public Node<T> Next { get; set; }
    }

    public class LinkedStack<T>
    {
        public LinkedStack()
        {
            Head = new Node<T>(default, null);
            Size = 0;
        }

        public Node<T> Head;

        public int Size { get; set; }

        public int Length
        {
            get { return Size; }
        }

        public bool IsEmpty
        {
            get { return Size.Equals(0); }
        }

        public void Push(T element)
        {
            // Add element to top of stack.
            Head = new Node<T>(element, Head);
            Size += 1;
        }

        public T Top()
        {
            // Returns but does not remove the element at the top of the stack.
            if (this.IsEmpty)
            {
                throw new Exception("The list is empty!");
            }
            return Head.Element;
        }

        public T Pop()
        {
            // Remove and return the element from the top of the stack (LIFO).
            if (this.IsEmpty)
            {
                throw new Exception("The list is empty!");
            }
            var result = Head.Element;
            Head = Head.Next;
            Size -= 1;
            return result;
        }
    }
}
