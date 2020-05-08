class LinkedStack:

    class _Node:
        __slots__ = '_element', '_next'

        def __init__(self, element, next):
            self._element = element
            self._next = next

    def __init__(self):
        self._head = None
        self._size = 0

    def __len__(self):
        return self._size

    def is_empty(self):
        return self._size == 0;

    def push(self, e):
        """Add element e to the top of the stack."""
        self._head = self._Node(e, self._head)
        self._size += 1

    def top(self):
        if self.is_empty():
            print('Stack is empty.')
            return
        return self._head._element

    def pop(self):
        if self.is_empty():
            print('Stack is empty.')
            return
        answer = self._head._element
        self._head = self._head._next
        self._size -= 1
        return answer


if __name__ == '__main__':
    myStack = LinkedStack()
    myStack.push(1)
    myStack.push(2)
    print(myStack.top())
    myStack.pop()
    print(myStack.top())
    print(myStack.__len__)
