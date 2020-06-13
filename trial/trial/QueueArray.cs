using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trial
{
    public class QueueArray<T> : IEnumerable<T>
    {
        private T[] _queue;
        private int _head;
        private int _tail;
        public QueueArray()
        {
            const int DefaultCapacity = 4;
            _queue = new T[DefaultCapacity];

        }
        public QueueArray(int Capacity)
        {
            _queue = new T[Capacity];
        }

        public int Count => _tail - _head;
        public bool IsEmpty => Count == 0;

        public void Enqueue(T Item)
        {
            if (_queue.Length == _tail)
            {
                T[] LargerArray = new T[Count * 2];
                Array.Copy(_queue, LargerArray, Count);
                _queue = LargerArray;
            }
            _queue[_tail++] = Item;
        }
        public void Dequeue()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }
            _queue[_head++] = default(T);
            if (IsEmpty)
                _head = _tail = 0;
        }
        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            return _queue[_head];
        }

        public IEnumerator<T> GetEnumerator()
        {
          for(int i = _head; i <= _tail; i++)
            {
                yield return _queue[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
       
    }
}
