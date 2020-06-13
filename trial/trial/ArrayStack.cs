using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trial
{
    class ArrayStack<T> : IEnumerable<T>
    {
        private T[] Items;
        public int Count { get; set; }
        public bool IsEmpty => Count == 0;
        public ArrayStack()
        {
            const int DefaultCapacity = 4;
            Items = new T[DefaultCapacity];
        }
        public ArrayStack(int Capacity)
        {
            Items = new T[Capacity];
        }
        public void Push(T Item)
        {
            if (Items.Length == Count)
            {
                T[] LargerArray = new T[Count * 2];
                Array.Copy(Items, 0, LargerArray, 0, Count);
                Items = LargerArray;
            }
            Items[Count++] = Item;
        }
        public void Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            Items[--Count] = default(T);
        }
        public T Peek()
        {
            return Items[Count - 1];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i= Count-1; i>=0; i--)
            {
                yield return Items[i];

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
