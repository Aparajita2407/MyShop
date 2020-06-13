using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trial
{
    public class DoublyLinkedList<T>
    {
        public DoublyLinkedNode<T> Head { get; set; }
        public DoublyLinkedNode<T> Tail
        {
            get; set;

        }
        public int Count = 0;
        public bool IsEmpty => Count == 0;
        public void AddFirst(T value)
        {
            AddFirst(new DoublyLinkedNode<T>(value));
        }

        private void AddFirst(DoublyLinkedNode<T> doublyLinkedNode)
        {
            DoublyLinkedNode<T> temp = Head;
            Head = doublyLinkedNode;
            Head.Next = temp;
            if (IsEmpty)
            {
                Tail = Head;
            }
            else
            {
                temp.Previous = Head;
            }
            Count++;
        }
        public void AddLast(T value)
        {
            AddLast(new DoublyLinkedNode<T>(value));
        }

        private void AddLast(DoublyLinkedNode<T> doublyLinkedNode)
        {
            if (IsEmpty)
            {
                Head = Tail = doublyLinkedNode;
            }
            else
            {
                Tail.Next = doublyLinkedNode;
                doublyLinkedNode.Previous = Tail;
                Tail = doublyLinkedNode;
            }
            Count++;
        }
        public void RemoveFirst()
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            Head = Head.Next;
            Count--;
            if (IsEmpty)
            {
                Tail = null;
            }
            else
            {
                Head.Previous = null;
            }
        }
        public void RemoveLast()
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            if (Count == 1)
            {
                Head = Tail = null;
            }
            else
            {
                Tail.Previous.Next = null;
                Tail = Tail.Previous;
            }
            Count--;

        }
    }
}
