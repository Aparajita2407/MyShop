using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trial
{
    public class CircularQueue<T> : IEnumerable<T>
    {
        private T[] _queue;
        private int _head;
        private int _tail;
        public int Count => _head < _tail ? _tail - _head : _tail - _head + _queue.Length;
        public bool IsEmpty => Count==0;

        public CircularQueue()
        {
            const int DefaultCapacity = 4;
            _queue = new T[DefaultCapacity];
        }
        public CircularQueue(int Capacity)
        {
            _queue = new T[Capacity];
        }
        public void Enqueue(T Item)
        {
            if (Count == _queue.Length - 1) // case where array is like 7,blank,1,3--> elements=3 --> 4-1=3
            {
                int CountPriorResize = Count; 
                T[] NewArray = new T[_queue.Length * 2];
                Array.Copy(_queue, _head, NewArray, 0, _queue.Length - _head);
                Array.Copy(_queue, 0, NewArray, _queue.Length - _head, _tail);

                _queue = NewArray;
                _head = 0;
                _tail = CountPriorResize;

            }
            _queue[_tail] = Item;
            if (_tail < _queue.Length - 1)
            {
                _tail++;
            }
            else
            {
                _tail = 0;
            }

        }
        public void Dequeue()
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            _queue[_head++] = default(T);
            if (IsEmpty)
            {
                _head = _tail = 0;
            }
            else if (_head == _queue.Length)
            {
                _head = 0;
            }
        }
        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            return _queue[_head];

        }
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
