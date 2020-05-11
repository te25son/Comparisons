using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class LinkedStack<T> : ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, ICollection
    {
        public LinkedStack()
        {
            _head = new Node<T>(default(T), _);  // T can be either a reference or value type so return default.
            _size = 0;
        }

        private Node _head { get; set; }

        private int _size { get; set; }

        public int Length()
        {
            return _size;
        }

        public bool IsEmpty()
        {
            return _size.Equals(0);
        }

        public void Push(T element)
        {
            _head = new Node(element, _head);
        }

        public class Node<T>
        {
            public Node(T element, T next)
            {
                _element = element;
                _next = next;
            }

            private T _element { get; }

            private T _next { get; }
        }
    }
}
