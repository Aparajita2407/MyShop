using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trial
{
    class LinkedStack<T>
    {
        private readonly SinglyLinkedList<T> singlyLinkedList = new SinglyLinkedList<T>();
        public int Count => singlyLinkedList.Count;
        public bool IsEmpty => Count == 0;
        public void Push(T item)
        {
            singlyLinkedList.AddFirst(item);
        }
        public void Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            singlyLinkedList.RemoveFirst();
        }
        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            return singlyLinkedList.Head.Value;

        }
    }
}
