using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    //FIFO ENQUEUE DEQUEUE PEEK
    public class ArrayQueue<T> : IEnumerable<T>
    {
        private T[] _queue;
        private int _head;
        private int _tail;
        public int Count => _tail - _head;
        public ArrayQueue()
        {
            const int defaultCapacity = 4;
            _queue = new T[defaultCapacity];
        }
        public ArrayQueue(int capacity)
        {
            _queue = new T[capacity];
        }

        public void Enqueue(T item)
        {
            if(_queue.Length == _tail)
            {
                T[] largerArray = new T[Count * 2];
                Array.Copy(_queue,largerArray,Count);
                _queue = largerArray;
            }

            _queue[_tail++] = item;
        }

        public T Peek()
        {
            if (Count == 0)
                throw new NotImplementedException();

            return _queue[_head];
        }
        public void Dequeue()
        {
            if (Count == 0)
                throw new NotImplementedException();

            _queue[_head++] = default(T);

            if (Count == 0)
                _head = _tail = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = _head; i< _tail; i++)
            {
                yield return _queue[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void PrintQueue()
        {
            int i = _queue.Length - 1;
            int index = 0;
            while (i != 0)
            {
                if (Convert.ToInt32(_queue[index]) > 0)
                    Console.WriteLine(_queue[index]);

                index++;
                i--;
            }
        }
    }

    public class CircularQueue<T> : IEnumerable<T>
    {
        private T[] _queue;
        private int _head;
        private int _tail;
        public int Count => _head <= _tail ? _tail - _head : _tail - _head + _queue.Length;
        public CircularQueue()
        {
            const int defaultCapacity = 4;
            _queue = new T[defaultCapacity];
        }
        public CircularQueue(int capacity)
        {
            _queue = new T[capacity];
        }

        public void Enqueue(T item)
        {
            if( Count ==  _queue.Length -1)
            {
                int countPriorResize = Count;
                T[] newArray = new T[2 * _queue.Length];
                Array.Copy(_queue,_head,newArray,0,_queue.Length - _head);
                Array.Copy(_queue,0, newArray,_queue.Length - _head,_tail);

                _queue = newArray;

                _head = 0;
                _tail = countPriorResize;
            }

            _queue[_tail] = item;
            if(_tail< _queue.Length - 1)
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
            if (Count == 0)
                throw new InvalidOperationException();

            _queue[_head++] = default(T);
            if (Count == 0)
                _head = _tail = 0;
            else if(Count == _queue.Length)
            {
                _head = 0;
            }
        }

        public T Peek()
        {
            if (Count == 0)
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

        public void PrintQueue()
        {
            int i = _queue.Length - 1;
            int index = 0;
            while (i != 0)
            {
                if (Convert.ToInt32(_queue[index]) > 0)
                    Console.WriteLine(_queue[index]);

                index++;
                i--;
            }
        }
    }

    public class LinkedListQueue<T> : IEnumerable<T>
    {
        private readonly SinglyLinkedList<T> singlyLinkedList = new SinglyLinkedList<T>();

        public void Enqueue(T item)
        {
            singlyLinkedList.AddLast(item);
        }

        public void Dequeue()
        {
            if (singlyLinkedList.Count == 0)
                throw new InvalidOperationException();

            singlyLinkedList.RemoveFirst();
        }

        public T Peek()
        {
            if (singlyLinkedList.Count == 0)
                throw new InvalidOperationException();
            return singlyLinkedList.Head.Value;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void PrintQueue()
        {
            singlyLinkedList.PrintLinkedList();
        }
    }
}
