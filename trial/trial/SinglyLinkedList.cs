using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trial
{
     public class SinglyLinkedList<T> : IEnumerable<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public bool IsEmpty => Count == 0;

        public int Count { get; set; }
        public void DetectLoop()
        {
            Node<T> Fast = Head;
            Node<T> Slow = Head;
            while (Slow != null && Fast != null && Fast.Next != null)
            {
                Slow = Slow.Next;
                Fast = Fast.Next.Next;
                if (Slow == Fast)
                {
                    Console.WriteLine("Found loop in the list");
                    Console.WriteLine("Calling function to remove it");

                    DetectAndRemoveLoop(Slow);

                }
            }
            Console.WriteLine("No loop in the list");
        }
        public T AccessDataAt(int index)
        {
            Count = 1;
            Node<T> Traverser = Head;
            while (Traverser!=null)
            {
                if (Count == index)
                    return Traverser.Value;
                Count++;
                Traverser = Traverser.Next;
            }
            return default(T);
        }

        private void DetectAndRemoveLoop(Node<T> slow)
        {
            Node<T> node1 = slow ;
            Node<T> node2 = slow;
            int k = 1; int i = 0;

            //Counting the number of elements in the loop
            while (node1.Next != node2)
            {
                node1 = node1.Next;
                k++;
            }


            //Assigning one node to head and the other to the point at the number of elements in loop in the list
            node1 = Head;
            Console.WriteLine("Node 1 has " + node1.Value);
            for (i = 0; i <= k; i++)
            {
                node2 = node2.Next;

            }
            Console.WriteLine("Node 2 has " + node2.Value);


            //moving both nodes one by one, where they meet, is the starting point of loop
            while (node2 != node1)
            {
                node2 = node2.Next;
                node1 = node1.Next;
            }

            //moving one pointer in loop till it reaches the ending loop
            while (node2.Next != node1) {
                node2 = node2.Next;
            }
            node2.Next = null;

            Console.WriteLine("Removed the loop Successfully");


        }

        public T PrintMiddle()
        {
             Node<T> Slow = Head;
                Node<T> Fast = Head;
                while (Fast != null && Fast.Next!=null)
                {
                    Slow = Slow.Next;
                    Fast = Fast.Next.Next;
                }
                return Slow.Value;
                //  Console.WriteLine("Middle value is of the list is: " + Slow.Value);
           
        }
        public void ReverseList(SinglyLinkedList<T> listBeforeReverse)
        {
            SinglyLinkedList<T> listAfterReverse = new SinglyLinkedList<T>();
            var current = listBeforeReverse.Head;
            while (current.Next != null)
            {
                listAfterReverse.AddFirst(current.Value);
               
            }
            listAfterReverse.GetEnumerator();
        }

        public void AddFirst(T value)
        {
            AddFirst(new Node<T>(value));
        }

        private void AddFirst(Node<T> node)
        {
          //  if (IsEmpty)
          //      throw new ArgumentNullException();
            Node<T> temp = Head;
            Head = node;
            Head.Next = temp;
            Count++;
            if (Count == 1)
            {
                Head = Tail =node;
            }
        }
        public void AddLast(T value)
        {
            AddLast(new Node<T>(value));
        }

        private void AddLast(Node<T> node)
        {
            if (IsEmpty)
            {
                Head = Tail = node;
            }
            Tail.Next = node;
            Tail = node;
            Count++;
        }
        public void RemoveFirst()
        {
            if (IsEmpty)
                throw new ArgumentNullException();

            Head = Head.Next;
            if (Count == 1)
            {
                Tail = null;
            }
            Count--;
        }
        public void RemoveLast()
        {
            if (IsEmpty)
                throw new ArgumentNullException();
            if (Count == 1)
            {
                Head = Tail = null;
            }
            else
            {
                var current = Head;
                while (current.Next != Tail)
                {
                    current = current.Next;
                }
                current.Next = null;
                Tail = current;
                
            }
            Count--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> i = Head;
            while(i!=null)
            {
                yield return i.Value;
                i = i.Next;

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
